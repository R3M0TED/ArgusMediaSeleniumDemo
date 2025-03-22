using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.Tests
{
    abstract internal class BaseTests
    {
        public static void RunTest(Action<ITestStateProvider> testLogic)
        {
            var testConfiguration = TestSetupFixture.Configuration;
            var testStateProvider = new TestStateProvider(testConfiguration);
            try
            {
                testLogic(testStateProvider);
            }
            catch
            {
                if (testConfiguration.SaveFailureScreenshots)
                {
                    ScreenshotUtilities.TakeFailureScreenshots(testStateProvider.GetActiveParticipants(), testConfiguration.ScreenshotPath);
                }

                throw;
            }
            finally
            {
                testStateProvider.Dispose();
            }
        }
    }
}
