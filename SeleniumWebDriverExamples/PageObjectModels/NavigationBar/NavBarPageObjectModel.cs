using SeleniumWebDriverExamples.PageObjectModels.NavigationBar.SearchBar;
using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels.NavigationBar
{
    internal class NavBarPageObjectModel : BasePageObjectModel
    {
        private const string _commoditiesButton = "//button[@class='cta MainNavigation_primaryLink__tYxec' and normalize-space(text())='Commodities']";
        public SearchBarPageObjectModel SearchBarPageObjectModel { get; set; }

        public NavBarPageObjectModel(TestParticipant testParticipant)
            : base(testParticipant)
        {
            this.SearchBarPageObjectModel = new SearchBarPageObjectModel(this.TestParticipant);
        }

        public CommoditiesPopoverPageObjectModel ClickCommodities()
        {
            ClickElement(_commoditiesButton);

            return new CommoditiesPopoverPageObjectModel(this.TestParticipant);
        }
    }
}
