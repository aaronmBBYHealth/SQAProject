using AventStack.ExtentReports;
using BBY_Automation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Reflection;

namespace BBY_Automation
{
    class MainClass
    {
        public IWebDriver driver;
        public static ExtentReports _extent;
        public static ExtentTest _test;
        public static Status _logStatus;
        public Report report;

        static void Main(string[] args)
        {
            MainClass obj = new MainClass();
            try
            {
                obj.BeforeClass();
                obj.TC_1_LivelyFlipLearnMoreButton();
                obj.TC_2_BottomLearnMoreButton();
            }
            catch
            {
                obj.AfterClass();
            }
            obj.AfterClass();
        }

        [OneTimeSetUp]
        public void BeforeClass()
        {
            //Load browser
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("-incognito");
            option.AddArguments("--disable-notifications");
            driver = new ChromeDriver(option);
            //Enter URL and Maximize the screen
            driver.Navigate().GoToUrl("https://www.greatcall.com/");
            driver.Manage().Window.Maximize();
            this.initialReport();
        }        
        public virtual void initialReport()
        {
            report = new Report();
            _extent = report.initReport();
        }
        public void TC_1_LivelyFlipLearnMoreButton()
        {
            _test = _extent.CreateTest(MethodBase.GetCurrentMethod().Name);
            Homepage home = new Homepage(driver);
            try
            {
                String Actual = "Senior Cell Phones, Medical Alert Systems & Safety for Seniors";
                String Expected = driver.Title;
                if (Actual == Expected)
                {
                    _test.Log(Status.Info, "Assertion Passed: Navigated to the Greatcall");
                }
                else
                {
                    _test.Log(Status.Info, "Assertion Failed: Not navigated to Greatcall");
                }
                home.ScrollToLivelyFlip();  //Step-1 Scroll To Lively Flip
                _test.Log(Status.Pass, "Test Step 1: Scroll to Lively Flip section");
                home.ClickOnLivelyFlipLearnMoreButton();   //Step-2 Click on the Learn More button under Lively Flip
                _test.Log(Status.Pass, "Test Step 2: Click on the Learn More button under Lively Flip");
                string actual1 = driver.Url;
                string expected1 = "https://www.greatcall.com/phones/lively-flip-cell-phone-for-seniors";
                if (actual1 == expected1)
                {
                    _test.Log(Status.Info, "Assertion Passed: Lively Flip phone page is displayed");
                }
                else
                {
                    _test.Log(Status.Info, "Assertion Failed: Lively Flip phone page is not displayed");
                }
                home.ClickOnLogo(); //Step-3 Click on the Logo
                _test.Log(Status.Pass, "Test Step 3: Click on the Logo");
               string url = driver.Url;
                if (url == "https://www.greatcall.com/")
                {
                    _test.Log(Status.Info, "Assertion Passed: Homepage is displayed");
                }
                else
                {
                    _test.Log(Status.Info, "Assertion Failed: Homepage is not displayed");
                }
            }
            catch (Exception cleanup)
            {
                _test.Log(Status.Error, cleanup.Message);
                _test.Log(Status.Error, "Cleanup");
                home.ClickOnLogo(); //Click on the Logo
            }
        }
        public void TC_2_BottomLearnMoreButton()
        {
            _test = _extent.CreateTest(MethodBase.GetCurrentMethod().Name);
            Homepage home = new Homepage(driver);
            try
            {
                home.ScrollToSupportSection();  //Step-1 Scroll To Support Section
                _test.Log(Status.Pass, "Test Step 1: Scroll to Support Section");
                try
                {
                    bool text = home.AssertLearnMoreUnderSupportSection();
                    if (text == true)
                    {
                        _test.Log(Status.Info, "Assertion Passed: Learn More Button is available under Support Section");
                    }
                    else
                    {
                        _test.Log(Status.Info, "Assertion Failed: Learn More Button is available under Support Section");
                    }
                }
                catch { }
                home.ClickOnSupportSectionLearnMoreButton();   //Step-2 Click on the Learn More button under Support section
                _test.Log(Status.Pass, "Test Step 2: Click on the Learn More button under Lively Flip");
                String Actual = driver.Url;
                String Expected = "https://www.greatcall.com/support";
                if (Actual == Expected)
                {
                    _test.Log(Status.Info, "Assertion Passed: Support page is displayed");
                }
                else
                {
                    _test.Log(Status.Info, "Assertion Failed: Support page is not displayed");
                }
                home.ClickOnLogo(); //Step-3 Click on the Logo
                _test.Log(Status.Pass, "Test Step 3: Click on the Logo");
                string url = driver.Url;
                if (url == "https://www.greatcall.com/")
                {
                    _test.Log(Status.Info, "Assertion Passed: Homepage is displayed");
                }
                else
                {
                    _test.Log(Status.Info, "Assertion Failed: Homepage is not displayed");
                }
            }
            catch (Exception cleanup)
            {
                _test.Log(Status.Error, cleanup.Message);
                _test.Log(Status.Error, "Cleanup");
                home.ClickOnLogo(); //Click on the Logo
            }
        }
        public void AfterClass()
        {
            _extent.Flush();
            driver.Quit();
        }
    }
}
