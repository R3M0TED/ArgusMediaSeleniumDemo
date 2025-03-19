using SeleniumWebDriverExamples.PageObjectModels.NavigationBar;
using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels
{
    sealed class MainPageObjectModel : BasePageObjectModel
    {
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
