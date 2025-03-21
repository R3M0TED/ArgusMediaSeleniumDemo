using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels
{
    internal class BasePageObjectModel
    {
        private const int DefaultTimeout = 20; 

        protected TestParticipant TestParticipant { get; set; }

        public BasePageObjectModel(TestParticipant testParticipant)
        {
            this.TestParticipant = testParticipant;
        }

        protected void TypeIntoElement(string content, string xPath, int timeout = DefaultTimeout)
        {
            var element = WaitForElementToBeClickable(xPath, timeout);
            element.SendKeys(content);
        }

        protected IWebElement ClickElement(string xPath, int timeout = DefaultTimeout)
        {
            var element = WaitForElementToBeClickable(xPath, timeout);
            element.Click();
            return element;
        }

        protected IWebElement WaitForElementToBeClickable(string xPath, int timeout = DefaultTimeout)
        {
            return Wait(timeout).Until(ExpectedConditions.ElementToBeClickable(By.XPath(xPath)));
        }

        protected IWebElement WaitForElementToBeDisplayed(string xPath, int timeout = DefaultTimeout)
        {
            return Wait(timeout).Until(d => d.FindElement(By.XPath(xPath)));
        }

        protected void WaitForElementToBeInvisible(string xPath, int timeout = DefaultTimeout)
        {
            Wait(timeout).Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(xPath)));
        }

        private WebDriverWait Wait(int timeout)
        {
            return new WebDriverWait(this.TestParticipant.Driver, TimeSpan.FromSeconds(timeout));
        }
    }
}
