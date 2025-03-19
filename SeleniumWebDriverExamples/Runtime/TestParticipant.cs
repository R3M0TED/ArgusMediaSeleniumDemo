using OpenQA.Selenium;

namespace SeleniumWebDriverExamples.Runtime
{
    public class TestParticipant
    {
        public readonly IWebDriver Driver;

        public TestParticipant(IWebDriver driver)
        {
            Driver = driver;
        }
    }

}
