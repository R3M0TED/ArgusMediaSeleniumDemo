using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels
{
    internal class BasePageObjectModel
    {
        protected TestParticipant TestParticipant {  get; set; }

        public BasePageObjectModel(TestParticipant testParticipant)
        { 
            this.TestParticipant = testParticipant;
        }

        protected void TypeIntoElement(string content, string xPath, int timeout = 6)
        {
            var element = ClickElement(xPath);
            element.SendKeys(content);
        }

        protected IWebElement ClickElement(string xPath, int timeout = 6)
        {
            var element = WaitForElementToBeDisplayed(xPath);
            Wait(timeout).Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();

            return element;
        }

        protected IWebElement WaitForElementToBeDisplayed(string xPath, int timeout = 6)
        {
            var element = Wait(timeout).Until(d => d.FindElement(By.XPath(xPath)));
            Wait(timeout).Until(d => element.Displayed);

            return element;
        }

        private WebDriverWait Wait(int timeout)
        {
            return new WebDriverWait(this.TestParticipant.Driver, TimeSpan.FromSeconds(timeout));
        }
    }
}
