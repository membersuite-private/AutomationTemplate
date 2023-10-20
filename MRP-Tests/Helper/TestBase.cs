using MRPTests.Config;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MRPTests.Helper
{
    public class TestBase
    {
        public string TestId { get; set; }
        public string TestName { get; set; }
        public string StepName { get; set; }
        public string BrowserName { get; set; }
        protected static IWebDriver driver;

        public TestBase()
        {
        }

        public void BrowserSetup(String BrowserN)
        {
            BrowserName = BrowserN;
            StackTrace st = new StackTrace(true);
            string testName = st.GetFrame(1).GetMethod().Name;
            for(int ctr = 0;ctr < st.FrameCount;ctr++)
            {
                var frame = st.GetFrame(ctr);
                if (frame.GetMethod().Name == "InvokeMethod")
                {
                    testName = st.GetFrame(ctr - 1).GetMethod().Name;
                    ctr = st.FrameCount;
                }
            }
            if (string.IsNullOrEmpty(TestName) == true)
            {
                TestName = testName;
                StartTest(testName);
            }

            TestScreenCapture.BrowserName = BrowserN;

            if (BrowserN.Equals("Chrome"))
            {

                ChromeOptions options = new ChromeOptions();
                options.AddArgument(@"user_data_dir=C:\\Users\\Shoaib\\AppData\\Local\\Google\\Chrome\User");
                driver = new ChromeDriver(options);
            }

            else if (BrowserN.Equals("Firefox"))
            {
                driver = new FirefoxDriver();
            }
            else if (BrowserN.Equals("Edge"))
            {
                EdgeOptions edgeOptions = new EdgeOptions();
                edgeOptions.UseChromium = true;
                driver = new EdgeDriver(edgeOptions);
            }
            else if (BrowserN.Equals("Safari"))
            {
                driver = new SafariDriver();
            }

            driver.Manage().Window.Maximize();
        }

        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browser = config.BrowserToRunWith.Split(',');
            foreach (String b in browser)
            {

                yield return b;
            }
        }


        public static IWebElement WaitUntilElementExists(By elementLocator, int timeout = 40)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(elementLocator));
                if (element != null)
                    ScrollIntoView(element);
                return element;
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "was not found in current context page.");
                throw;
            }
        }



        public static IList<IWebElement> WaitUntilElementCellElements(By elementLocator, int timeout = 4)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }

        public static IWebElement WaitUntilElementVisible(By elementLocator, int timeout = 25, Boolean scrollIntoView = true)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(elementLocator));
                if ((element != null) && (scrollIntoView))
                    ScrollIntoView(element);
                return element;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found.");
                throw;
            }
        }

        public static IWebElement WaitUntilElementClickable(By elementLocator, int timeout = 0)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(elementLocator));
                if (element != null)
                    ScrollIntoView(element);
                return element;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }

        public static ReadOnlyCollection<IWebElement> GetElements(IWebElement parentElement, params By[] elementLocators)
        {
            try
            {
                ReadOnlyCollection<IWebElement> elements = null;
                if (parentElement == null)
                    elements = driver.FindElements(elementLocators.First());
                else
                    elements = parentElement.FindElements(elementLocators.First());
                if (elements != null)
                {
                    if (elementLocators.Length == 1)
                        return elements;

                    var childElementLocators = elementLocators.Skip(1);
                    foreach (var element in elements)
                    {
                        var rtn = GetElements(element, childElementLocators.ToArray());
                        if (rtn != null)
                            return rtn;
                    }
                }
            }
            catch { }

            return null;
        }

        public static IWebElement GetParentElement(IWebElement element)
        {
            if (element != null)
                return element.FindElement(By.XPath("./parent::*"));

            return null;
        }

        public static IWebElement GetElementWithText(IWebElement parentElement, By findBy, string containsTxt/*, Boolean ignoreCase = true*/)
        {
            try
            {
                ReadOnlyCollection<IWebElement> elements = null;
                if (parentElement == null)
                    elements = driver.FindElements(findBy);
                else
                    elements = parentElement.FindElements(findBy);
                if (elements != null)
                {
                    foreach (var element in elements)
                        if (element.Text.Contains(containsTxt))
                            return element;
                }
            }
            catch { }

            return null;
        }

        public static List<IWebElement> GetElementsWithText(IWebElement parentElement, By findBy, string containsTxt)
        {
            List<IWebElement> rval = new List<IWebElement>();

            try
            {
                ReadOnlyCollection<IWebElement> elements = null;
                if (parentElement == null)
                    elements = driver.FindElements(findBy);
                else
                    elements = parentElement.FindElements(findBy);
                if (elements != null)
                {
                    foreach (var element in elements)
                        if (element.Text.Contains(containsTxt))
                            rval.Add(element);
                }
            }
            catch { }

            return rval;
        }

        public static IWebElement GetElement(IWebElement parentElement = null, params By[] elementLocators)
        {
            try
            {
                ReadOnlyCollection<IWebElement> elements = null;
                if (parentElement == null)
                    elements = driver.FindElements(elementLocators.First());
                else
                    elements = parentElement.FindElements(elementLocators.First());
                if (elements != null)
                {
                    if ((elements.Count == 1) && (elementLocators.Length == 1))
                        return elements.First();

                    var childElementLocators = elementLocators.Skip(1);

                    foreach (var element in elements)
                    {
                        string html = element.GetAttribute("outerHTML");
                        string attr = element.GetAttribute("style");
                        var rtn = GetElement(element, childElementLocators.ToArray());
                        if (rtn != null)
                            return rtn;
                    }
                }
            }
            catch { }

            return null;
        }


        public Boolean ElementExist(By by)
        {

            try
            {
                driver.FindElement(by);

                return true;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static bool IsElementDisplayed(By element)
        {
            if (driver.FindElements(element).Count > 0)
            {
                if (driver.FindElement(element).Displayed)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        public static void ScrollView(int pos)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0," + pos.ToString() + ")", "");
        }

        public static void ScrollIntoView(IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(" + element.Location.X + "," + element.Location.Y + "- 100);");
        }

        public static void ScrollToTop()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body);");
        }

        public static string CaptureScreen(string name)
        {
            return TestScreenCapture.CaptureToFile(name, driver);
        }


        public void StartTest(string testName, string browserName = null)
        {
            if (string.IsNullOrEmpty(TestName) == true)
                TestName = testName;
            if ((string.IsNullOrEmpty(BrowserName) == true) && (string.IsNullOrEmpty(browserName) == false))
                BrowserName = browserName;
            TestScreenCapture.BrowserName = BrowserName;
            TestScreenCapture.TestName = TestName;
        }

        public void SetStepName(string stepName)
        {
            StepName = stepName;
        }

        public void TestError(Exception ex)
        {
        }

        public void FinishTest()
        {
        }

        public static int DelayPrompt
        {
            get { return Convert.ToInt32(IsProduction ? config.ProdDelayPrompt : IsGreen ? config.GreenDelayPrompt : config.BlueDelayPrompt); }
        }

        public static int DelayScreenChange
        {
            get { return Convert.ToInt32(IsProduction ? config.ProdDelayScreenChange : IsGreen ? config.GreenDelayScreenChange : config.BlueDelayScreenChange); }
        }

        public static int DelayWaitOnSelection
        {
            get { return Convert.ToInt32(IsProduction ? config.ProdDelayWaitOnSelection : IsGreen ? config.GreenDelayWaitOnSelection : config.BlueDelayWaitOnSelection); }
        }

        public static int DelayWaitOnMyAccount
        {
            get { return Convert.ToInt32(IsProduction ? config.ProdDelayWaitOnMyAccount : IsGreen ? config.GreenDelayWaitOnMyAccount : config.BlueDelayWaitOnMyAccount); }
        }

        public static string MrpUrl
        {
            get
            {
                return IsProduction ? config.ProdUrl : IsGreen ? config.GreenUrl : config.BlueUrl;
            }
        }

        public static string MrpUsername
        {
            get
            {
                return IsProduction ? config.ProdUsername : IsGreen ? config.GreenUsername : config.BlueUsername;
            }
        }

        public static string MrpPassword
        {
            get
            {
                return IsProduction ? config.ProdPassword : IsGreen ? config.GreenPassword : config.BluePassword;
            }
        }

        public static string MrpLoginPageTitle
        {
            get
            {
                return IsProduction ? config.ProdLoginPageTitle : IsGreen ? config.GreenLoginPageTitle : config.BlueLoginPageTitle;
            }
        }

        public static Boolean IsProduction
        {
            get
            {
                return config.RunEnvironment.ToLower() == "prod";
            }
        }

        public static Boolean IsGreen
        {
            get
            {
                return config.RunEnvironment.ToLower() == "green";
            }
        }

        public static Boolean IsBlue
        {
            get
            {
                return config.RunEnvironment.ToLower() == "blue";
            }
        }


        [TearDown]
        public void cleanUp()
        {
            FinishTest();
            driver.Quit();
        }
    }
}
