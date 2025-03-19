namespace SeleniumWebDriverExamples.Tests
{
    internal sealed class CommoditiesPopupTests : BaseTests
    {
        [Test]
        public void WhenUserClicksCommoditiesOverViewThenTheyAreRedirectedCorrectly()
        {
            RunTest(sp =>
            {
                var mainPage = sp.GetTestParticipant();
                var commmoditiesPopUp = mainPage.NavBarPageObjectModel.ClickCommodities();
                var commoditiesOverviewPage = commmoditiesPopUp.ClickCommoditiesOverviewButton();
                Assert.That(() => commoditiesOverviewPage.WaitForPageHeading(), Throws.Nothing);
            });
        }

        [Test]
        public void WhenUserClicksCrudeOilThenTheyAreRedirectedCorrectly()
        {
            RunTest(sp =>
            {
                var mainPage = sp.GetTestParticipant();
                var commmoditiesPopUp = mainPage.NavBarPageObjectModel.ClickCommodities();
                var crudeOilPage = commmoditiesPopUp.ClickCommoditiesOverviewButton();
                Assert.That(() => crudeOilPage.WaitForPageHeading(), Throws.Nothing);
            });
        }
    }
}
