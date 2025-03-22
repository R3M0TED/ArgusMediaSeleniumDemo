using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.Tests
{
    [SetUpFixture]
    public class TestSetupFixture
    {
        public static TestConfiguration Configuration { get; private set; } = new TestConfiguration();

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            if (Configuration.SaveFailureScreenshots)
            {
                Configuration.ScreenshotPath = ScreenshotUtilities.GetScreenshotFolderPath();
            }
        }
    }
}
