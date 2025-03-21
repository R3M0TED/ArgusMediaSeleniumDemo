using SeleniumWebDriverExamples.PageObjectModels;

namespace SeleniumWebDriverExamples.Runtime
{
    internal interface ITestStateProvider
    {
        public MainPageObjectModel CreateTestParticipant();

        public IList<TestParticipant> GetActiveParticipants();
    }
}
