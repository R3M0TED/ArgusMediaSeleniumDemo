using SeleniumWebDriverExamples.PageObjectModels;

namespace SeleniumWebDriverExamples.Runtime
{
    sealed class TestStateProvider : ITestStateProvider, IDisposable
    {
        private IList<TestParticipant> _activeParticipants;

        private TestConfiguration _testConfiguration;

        public TestStateProvider(TestConfiguration testConfiguration)
        {
            _activeParticipants = new List<TestParticipant>();
            this._testConfiguration = testConfiguration;
        }

        public MainPageObjectModel CreateTestParticipant()
        {
            var participant = TestParticipantFactory.CreateTestParticipant(_testConfiguration, _activeParticipants.Count);
            _activeParticipants.Add(participant);

            GoToUrl(participant);
            var mainPageObjectModel = new MainPageObjectModel(participant);
            mainPageObjectModel.CookiesPopupPageObjectModel.ClickAcceptCookies();

            return mainPageObjectModel;
        }

        public IList<TestParticipant> GetActiveParticipants()
        {
            return this._activeParticipants;
        }

        public void Dispose()
        {
            foreach (var participant in _activeParticipants)
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
