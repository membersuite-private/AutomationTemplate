using MRPTests.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRPTests.Helper
{
    public static class Logging
    {
        public static string LoggingPath { get; set; } 

        public static void DumpPage(string testName, string htmlTxt)
        {
            if (string.IsNullOrEmpty(LoggingPath) == true)
                LoggingPath = config.LoggingPath;

            string filename = System.IO.Path.Combine(LoggingPath, testName + "-" + DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".html");
            System.IO.File.WriteAllText(filename, htmlTxt);
        }
    }
}
