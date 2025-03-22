namespace SeleniumWebDriverExamples.Tests
{
    internal sealed class CommoditiesPopupTests : BaseTests
    {
        [Test]
        public void WhenUserClicksCommoditiesOverViewThenTheyAreRedirectedCorrectly()
        {
            RunTest(sp =>
            {
                var mainPage = sp.CreateTestParticipant();
                var commmoditiesPopUp = mainPage.NavBarPageObjectModel.ClickCommodities();
                var commoditiesOverviewPage = commmoditiesPopUp.ClickCommoditiesOverviewButton();
                Assert.That(() => commoditiesOverviewPage.WaitForPageHeadingToBeDisplayed(), Throws.Nothing);
            });
        }

        [Test]
        public void WhenUserClicksCrudeOilThenTheyAreRedirectedCorrectly()
        {
            RunTest(sp =>
            {
                var mainPage = sp.CreateTestParticipant();
                var commmoditiesPopUp = mainPage.NavBarPageObjectModel.ClickCommodities();
                var crudeOilPage = commmoditiesPopUp.ClickCommoditiesOverviewButton();
                Assert.That(() => crudeOilPage.WaitForPageHeadingToBeDisplayed(), Throws.Nothing);
            });
        }
    }
}
