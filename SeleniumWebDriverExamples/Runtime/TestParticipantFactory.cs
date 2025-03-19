namespace SeleniumWebDriverExamples.Runtime
{
    internal class TestParticipantFactory
    {
        public static TestParticipant CreateTestParticipant(TestConfiguration testConfiguration)
        {
            return new TestParticipant(WebDriverFactory.CreateWebDriver(testConfiguration));
        }
    }
}
