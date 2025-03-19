using SeleniumWebDriverExamples.PageObjectModels;
using SeleniumWebDriverExamples.Tests;

namespace SeleniumWebDriverExamples.Runtime
{
    sealed class TestStateProvider : ITestStateProvider, IDisposable
    {
        IList<TestParticipant> activeParticipants;
        public TestStateProvider()
        {
            activeParticipants = new List<TestParticipant>();
        }

        public MainPageObjectModel GetTestParticipant()
        {
            var participant = TestParticipantFactory.CreateTestParticipant(TestSetupFixture.Configuration!);
            activeParticipants.Add(participant);

            GoToUrl(participant);
            var mainPageObjectModel = new MainPageObjectModel(participant);
            mainPageObjectModel.CookiesPopupPageObjectModel.ClickAcceptCookies();

            return mainPageObjectModel;
        }

        public void Dispose()
        {
            foreach (var participant in activeParticipants)
            {
                participant.Driver.Quit();
                participant.Driver.Dispose();
            }
        }

        private void GoToUrl(TestParticipant participant)
        {
            participant.Driver.Navigate().GoToUrl("https://www.argusmedia.com/en");
        }
    }
}
