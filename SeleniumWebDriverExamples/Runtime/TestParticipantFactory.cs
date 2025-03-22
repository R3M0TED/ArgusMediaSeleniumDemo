namespace SeleniumWebDriverExamples.Runtime
{
    internal class TestParticipantFactory
    {
        public static TestParticipant CreateTestParticipant(TestConfiguration testConfiguration, int id)
        {
            return new TestParticipant(WebDriverFactory.CreateWebDriver(testConfiguration), id);
        }
    }
}
