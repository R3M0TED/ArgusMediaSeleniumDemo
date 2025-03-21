namespace SeleniumWebDriverExamples.Tests
{
    internal sealed class NavigationBarTests : BaseTests
    {
        [Test]
        public void WhenUserOpensCommoditiesListThenAllCommodiitesAreShown()
        {
            RunTest(sp =>
            {
                var mainPage = sp.CreateTestParticipant();
                var commmoditiesPopover = mainPage.NavBarPageObjectModel.ClickCommodities();
                Assert.That(() => commmoditiesPopover.WaitForAllCommodities(), Throws.Nothing);
            });
        }

        [Test]
        public void SearchingForArticleShowsArticle()
        {
            RunTest(sp =>
            {
                var mainPage = sp.CreateTestParticipant();
                var searchResultsPopover = mainPage.NavBarPageObjectModel.SearchBarPageObjectModel.Search("Oil");
                Assert.That(() => searchResultsPopover.WaitForResults(), Throws.Nothing);
            });
        }
    }
}
