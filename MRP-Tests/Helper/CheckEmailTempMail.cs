using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Net.Http;
using Newtonsoft.Json;

namespace MRPTests.Helper
{
    public class CheckEmailTempMail
    {
        protected IWebDriver driver;
        public string EmailAddress { get; set; }

        public CheckEmailTempMail()
        {
            ChromeOptions options = new ChromeOptions();
            driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("https://temp-mail.org/en/");
            driver.Manage().Cookies.DeleteAllCookies();
            Thread.Sleep(5000);

            var emailAddrBox = driver.FindElement(By.CssSelector("#mail"));
            EmailAddress = emailAddrBox.GetAttribute("value");
        }

        public void ScrollIntoView(IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(" + element.Location.X + "," + element.Location.Y + "- 100);");
        }

        public void BrowserToFront()
        {
            //driver.Manage().Window.FullScreen();
            try
            {
                driver.SwitchTo().Window(driver.Title).Manage().Window.Maximize();
            }
            catch { }
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        private const string verificationCodePrefix = "verification code is";
        public string GetVerificationCode
        {
            get
            {
                try
                {
                    string emailHash = CreateMD5(EmailAddress);
                    var client = new HttpClient();

                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri("https://privatix-temp-mail-v1.p.rapidapi.com/request/mail/id/" + emailHash.ToLower() + "/"),
                        Headers =
                        {
                            { "x-rapidapi-key", "0e0d144e9dmsh54a8ca37fbcac89p12c8bcjsn5ac55bdfe202" },
                            { "x-rapidapi-host", "privatix-temp-mail-v1.p.rapidapi.com" },
                        },
                    };
                    var respTask = client.SendAsync(request);
                    respTask.Wait();
                    var response = respTask.Result;
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var readTask = response.Content.ReadAsStringAsync();
                        readTask.Wait();
                        var body = readTask.Result;
                        if ((string.IsNullOrEmpty(body) == false) && (!body.Contains("no emails yet")))
                        {
                            List<TempMail_Email> tempMail_Emails = new List<TempMail_Email>();
                            if (body.StartsWith("["))
                                tempMail_Emails = JsonConvert.DeserializeObject<List<TempMail_Email>>(body);
                            else
                            {
                                Root emails = JsonConvert.DeserializeObject<Root>(body);
                                tempMail_Emails = emails.Emails;
                            }
                            if (tempMail_Emails.Count > 0)
                            {
                                foreach(var email in tempMail_Emails)
                                {
                                    if (email.mail_html.Contains(verificationCodePrefix))
                                    {
                                        var vCode = email.mail_html.Substring(email.mail_html.IndexOf(verificationCodePrefix) + verificationCodePrefix.Length);
                                        if (string.IsNullOrEmpty(vCode) == false)
                                        {
                                            if (vCode.Contains("."))
                                            {
                                                vCode = vCode.Substring(0, vCode.IndexOf('.'));
                                                return vCode.Trim();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
#if OLD
                    var inboxElements = driver.FindElements(By.CssSelector("div.inbox-dataList li"));
                    if ((inboxElements != null) && (inboxElements.Count > 0))
                    { 
                        foreach(var inboxElement in inboxElements)
                        {
                            var subjects = inboxElement.FindElements(By.CssSelector("a.title-subject"));
                            if ((subjects != null) && (subjects.Count > 0))
                            {
                                foreach(var subject in subjects)
                                {
                                    string href = subject.GetAttribute("href");
                                    if ((string.IsNullOrEmpty(href) == false) && (!href.Contains("javascript")))
                                    {
                                        ScrollIntoView(subject);
                                        subject.Click();
                                        Thread.Sleep(1000);

                                        var wordSections = driver.FindElements(By.CssSelector("div.inbox-data-content-intro"));
                                        if ((wordSections != null) && (wordSections.Count > 0))
                                        {
                                            foreach (var p in wordSections)
                                            {
                                                ScrollIntoView(p);
                                                if (p.Text.Contains(verificationCodePrefix))
                                                {
                                                    var vCode = p.Text.Substring(p.Text.IndexOf(verificationCodePrefix) + verificationCodePrefix.Length);
                                                    if (string.IsNullOrEmpty(vCode) == false)
                                                    {
                                                        if (vCode.Contains("."))
                                                        {
                                                            vCode = vCode.Substring(0, vCode.IndexOf('.'));
                                                            return vCode.Trim();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
#endif
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Ex:" + ex.Message);
                }

                return "";
            }            
        }

        public void CleanUp()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Id
    {
        public string oid { get; set; }
    }

    public class CreatedAt
    {
        public long milliseconds { get; set; }
    }

    public class MailAttachments
    {
        public List<object> attachment { get; set; }
    }

    public class TempMail_Email
    {
        public Id _id { get; set; }
        public CreatedAt createdAt { get; set; }
        public string mail_id { get; set; }
        public string mail_address_id { get; set; }
        public string mail_from { get; set; }
        public string mail_subject { get; set; }
        public string mail_preview { get; set; }
        public string mail_text_only { get; set; }
        public object mail_text { get; set; }
        public string mail_html { get; set; }
        public double mail_timestamp { get; set; }
        public int mail_attachments_count { get; set; }
        public MailAttachments mail_attachments { get; set; }
    }

    public class Root
    {
        public List<TempMail_Email> Emails { get; set; }
    }
}
