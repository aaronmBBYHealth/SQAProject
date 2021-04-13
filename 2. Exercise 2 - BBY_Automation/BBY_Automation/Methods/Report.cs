using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BBY_Automation
{
    public class Report
    {
        public IWebDriver driver;
        public ExtentReports initReport()
        {
            ExtentReports _extent;
            string dir = "";
            var fileName = "";
            var sourcePath = "";
            try
            {
                dir = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
                if (!Directory.Exists(dir + "\\Reports"))
                {
                    Directory.CreateDirectory(dir + "\\Reports");
                }
                if (!Directory.Exists(dir + "\\Reports"))
                {
                    Directory.CreateDirectory(dir + "\\Reports");
                }
                fileName = "HTMLReport" + ".html";
                sourcePath = dir + "\\Reports\\" + fileName;
            }
            catch (Exception e)
            {
                throw (e);
            }
            finally
            {
                ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(sourcePath);
                _extent = new ExtentReports();
                _extent.AttachReporter(htmlReporter);
            }
            return _extent;
        }
    }
}
