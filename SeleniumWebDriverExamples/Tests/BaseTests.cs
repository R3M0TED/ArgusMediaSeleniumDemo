using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.Tests
{
    internal class BaseTests
    {
        public static void RunTest(Action<ITestStateProvider> testLogic)
        {
            var testStateProvider = new TestStateProvider();
            try
            {
                testLogic(testStateProvider);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            finally
            {
                testStateProvider.Dispose();
            }
        }
    }
}
