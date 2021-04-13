using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BBY_Automation.Pages
{
    public class Homepage
    {
        public IWebDriver driver;
        IWebElement element = null;
        public static IJavaScriptExecutor je;

        public Homepage (IWebDriver driver)
        {
            this.driver = driver;
        }
        #region Dashboard Page Locators Path
        //Lively Flip Section
        //Learn More button on the Lively Flip
        String LivelyFlipLearnMore = "(//div[@data-product-category='Phone'])[2]/*[@href='/phones/lively-flip-cell-phone-for-seniors'][2]";
        //Logo
        String Logo = "(//a[@href='/'])[1]";
        //Support Section
        //Support Section Learn More Button
        String SupportLearnMoreButton = "//*[@id='Contentplaceholder1_C030_Col00']/*[@href='/support'] | /*[text()='Learn More ']";
        #endregion
       
        public void ScrollToLivelyFlip()
        {
            //Scroll to Lively Flip Section
            element = driver.FindElement(By.XPath(LivelyFlipLearnMore));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
            this.Sleep(2000);
        }
        public void ClickOnLivelyFlipLearnMoreButton()
        {
            //Click on the Learn More under Lively Flip
           driver.FindElement(By.XPath(LivelyFlipLearnMore)).Click();
           this.Sleep(2000);
        }
        public void ClickOnLogo()
        {
            //Click on the Logo
            driver.FindElement(By.XPath(Logo)).Click();
            this.Sleep(2000);
        }
        public void ScrollToSupportSection()
        {
            //Scroll To Support Section
            element = driver.FindElement(By.XPath(SupportLearnMoreButton));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }
        public void ClickOnSupportSectionLearnMoreButton()
        {
            //Click on the Learn More button under support section
            driver.FindElement(By.XPath(SupportLearnMoreButton)).Click();
        }
        public bool AssertLearnMoreUnderSupportSection()
        {
            //Verify Learn More button is displayed under support section
            bool str = driver.FindElement(By.XPath(SupportLearnMoreButton)).Displayed;
            return str;
        }
        public void Sleep(int sleep)
        {
            Thread.Sleep(sleep);
        }
    }
}
