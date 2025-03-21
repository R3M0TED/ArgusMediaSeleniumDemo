using OpenQA.Selenium;
using SeleniumWebDriverExamples.PageObjectModels.NavigationBar;
using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels
{
    internal class MainPageObjectModel : BasePageObjectModel
    {
        private const string _acceptCookiesButton = "//button[@id='onetrust-accept-btn-handler']";


        public NavBarPageObjectModel NavBarPageObjectModel { get; set; }
        public CookiesPopupPageObjectModel CookiesPopupPageObjectModel { get; set; }

        public MainPageObjectModel(TestParticipant testParticipant)
            : base(testParticipant)
        {
            this.NavBarPageObjectModel = new NavBarPageObjectModel(this.TestParticipant);
            this.CookiesPopupPageObjectModel = new CookiesPopupPageObjectModel(this.TestParticipant);
        }
    }
}
