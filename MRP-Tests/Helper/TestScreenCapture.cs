using MRPTests.Config;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRPTests.Helper
{
    public static class TestScreenCapture
    {
        /// <summary>
        /// Do not use! - Set in the background by the framework.
        /// </summary>
        public static string ScreenshotPath { get; set; }
        /// <summary>
        /// Set inside the Test to specify the name of the test to be put into the filename.
        /// Typically set towards the top of the test method so Capture screen methods know how
        /// to name the files.
        /// </summary>
        public static string TestName { get; set; } = "Test";
        /// <summary>
        /// Do not use! - Set in the background by the framework, do not use!
        /// </summary>
        public static string BrowserName { get; set; }
        /// <summary>
        /// Do not use! - Set in the background by the framework, do not use!
        /// </summary>
        public static Boolean AddTimestamp { get; set; } = true;
        /// <summary>
        /// Do not use! - Set in the background by the framework, do not use!
        /// </summary>
        public static int TestNumber { get; set; } = 0;
        /// <summary>
        /// Do not use! - Set in the background by the framework, do not use!
        /// </summary>
        public static Boolean AddTestNumber { get; set; } = true;

        /// <summary>
        /// Set in the background by the framework, do not use!
        /// </summary>
        private static int LastTestNumber
        {
            get
            {
                if (TestNumber > 0)
                    return TestNumber;

                try
                {
                    var files = System.IO.Directory.GetFiles(ScreenshotPath, "Test_*");
                    if (files != null)
                    {
                        foreach(var filename in files)
                        {
                            try
                            {
                                string[] sections = filename.Split('_');
                                if (sections.Length >= 2)
                                {
                                    int num = Convert.ToInt32(sections[1]);
                                    if (num >= TestNumber)
                                        TestNumber = num + 1;
                                }
                            }
                            catch { }
                        }
                    }
                }
                catch { }

                return TestNumber;
            }
        }

        /// <summary>
        /// Capture screen to file
        /// </summary>
        /// <param name="capturefilename"></param>
        /// <param name="driver"></param>
        public static string CaptureToFile(string capturefilename, IWebDriver driver)
        {
            string filename = "Test_";

            if (string.IsNullOrEmpty(ScreenshotPath) == true)
                ScreenshotPath = config.ScreenCapturePath;

            if (AddTestNumber)
            {
                filename += LastTestNumber.ToString() + "_";
                TestNumber = LastTestNumber + 1;
            }

            if (string.IsNullOrEmpty(BrowserName) == false)
                filename += BrowserName + "-";

            if (string.IsNullOrEmpty(TestName) == false)
                filename += TestName + "-";

            filename += capturefilename + "_";

            if (AddTimestamp)
                filename += DateTime.Now.ToString("yyyy-MM-dd_HH24mmss");

            string fullFilename = System.IO.Path.Combine(ScreenshotPath, filename + ".png");
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            //Use it as you want now
            string screenshot = ss.AsBase64EncodedString;
            byte[] screenshotAsByteArray = ss.AsByteArray;
            ss.SaveAsFile(fullFilename, ScreenshotImageFormat.Png); //use any of the built in image formating
            return fullFilename;
        }
    }
}
