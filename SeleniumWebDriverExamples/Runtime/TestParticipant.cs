using OpenQA.Selenium;

namespace SeleniumWebDriverExamples.Runtime
{
    public class TestParticipant
    {
        public readonly IWebDriver Driver;

        public readonly int Id;

        public TestParticipant(IWebDriver driver, int id)
        {
            this.Driver = driver;
            this.Id = id;
        }
    }

}
