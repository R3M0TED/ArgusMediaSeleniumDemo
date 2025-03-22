using OpenQA.Selenium;
using SeleniumWebDriverExamples.PageObjectModels.NavigationBar;
using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels
{
    internal class MainPageObjectModel : BasePageObjectModel
    {
        public NavBarPageObjectModel NavBarPageObjectModel { get; set; }
        public CookiesPopupPageObjectModel CookiesPopupPageObjectModel { get; set; }

        public MainPageObjectModel(TestParticipant testParticipant)
            : base(testParticipant)
        {
            NavBarPageObjectModel = new NavBarPageObjectModel(TestParticipant);
            CookiesPopupPageObjectModel = new CookiesPopupPageObjectModel(TestParticipant);
        }
    }
}
