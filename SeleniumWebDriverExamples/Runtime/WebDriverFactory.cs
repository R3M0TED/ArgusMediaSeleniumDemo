using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumWebDriverExamples.Runtime
{
    internal class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(TestConfiguration testConfiguration)
        {
            var driver = testConfiguration.BrowserType.ToLower() switch
            {
                "chrome" => CreateChromeDriver(testConfiguration),
                "firefox" => CreateFirefoxDriver(testConfiguration),
                "edge" => CreateEdgeDriver(testConfiguration),
                _ => throw new ArgumentException("Unsupported browser")
            };

            driver.Manage().Window.Maximize();

            return driver;
        }

        private static IEnumerable<string> GetBrowserOptions(TestConfiguration testConfiguration)
        {
            var options = new List<string>();

            if (testConfiguration.Headless)
            {
                options.Add("--headless=new");
                options.Add("-headless");
            }

            return options;
        }

        private static IWebDriver CreateChromeDriver(TestConfiguration testConfiguration)
        {
            var options = new ChromeOptions();
            options.AddArguments(GetBrowserOptions(testConfiguration));
            return new ChromeDriver(options);
        }

        private static IWebDriver CreateFirefoxDriver(TestConfiguration testConfiguration)
        {
            var options = new FirefoxOptions();
            options.AddArguments(GetBrowserOptions(testConfiguration));
            return new FirefoxDriver(options);
        }

        private static IWebDriver CreateEdgeDriver(TestConfiguration testConfiguration)
        {
            var options = new EdgeOptions();
            options.AddArguments(GetBrowserOptions(testConfiguration));
            return new EdgeDriver(options);
        }
    }
}
