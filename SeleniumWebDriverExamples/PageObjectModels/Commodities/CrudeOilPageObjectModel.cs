using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels.Commodities
{
    internal class CrudeOilPageObjectModel : BasePageObjectModel
    {
        private const string _crudeOilHeading = "//h1[@class='qa-banner-title' and text()='Crude Oil']";

        public CrudeOilPageObjectModel(TestParticipant testParticipant)
            : base(testParticipant)
        {
        }

        public void WaitForPageHeadingToBeDisplayed()
        {
            WaitForElementToBeDisplayed(_crudeOilHeading);
        }
    }
}
