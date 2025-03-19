using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels
{
    internal class CookiesPopupPageObjectModel : BasePageObjectModel
    {
        private const string _acceptCookiesButton = "//button[@id='onetrust-accept-btn-handler']";

        public CookiesPopupPageObjectModel(TestParticipant testParticipant)
            : base(testParticipant)
        {
        }

        public void ClickAcceptCookies()
        {
            ClickElement(_acceptCookiesButton);
        }
    }
}
