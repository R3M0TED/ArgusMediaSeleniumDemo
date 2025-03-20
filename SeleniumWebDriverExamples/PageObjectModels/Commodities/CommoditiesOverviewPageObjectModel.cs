using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels.Commodities
{
    internal class CommoditiesOverviewPageObjectModel : BasePageObjectModel
    {
        private const string _commoditiesHeading = "//h1[@class='qa-banner-title' and text()='Commodities']";

        public CommoditiesOverviewPageObjectModel(TestParticipant testParticipant)
            : base(testParticipant)
        {
        }

        public void WaitForPageHeading()
        {
            WaitForElementToBeDisplayed(_commoditiesHeading);
        }
    }
}
