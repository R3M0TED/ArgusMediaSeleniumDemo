using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels
{
    internal class CookiesPopupPageObjectModel : BasePageObjectModel
    {
        private const string _acceptCookiesButton = "//button[@id='onetrust-accept-btn-handler']";
        private const string _cookiesPopupOverlay = "//div[@class='onetrust-pc-dark-filter ot-fade-in' and contains(@style, 'z-index:2147483645')]";

        public CookiesPopupPageObjectModel(TestParticipant testParticipant)
            : base(testParticipant)
        {
        }

        public void ClickAcceptCookies()
        {
            ClickElement(_acceptCookiesButton);
            WaitForElementToBeInvisible(_cookiesPopupOverlay);
        }
    }
}
