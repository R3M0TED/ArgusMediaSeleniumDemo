namespace SeleniumWebDriverExamples.Tests
{
    [SetUpFixture]
    public class TestSetupFixture
    {
        public static TestConfiguration? Configuration { get; private set; }

        [OneTimeSetUp]
        public static void GlobalSetup()
        {
            Configuration = new TestConfiguration();
        }
    }
}
