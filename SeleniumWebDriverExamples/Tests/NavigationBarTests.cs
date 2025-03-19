namespace SeleniumWebDriverExamples.Tests
{
    internal sealed class NavigationBarTests : BaseTests
    {
        [Test]
        public void WhenUserOpensCommoditiesListThenAllCommodiitesAreShown()
        {
            RunTest(sp =>
            {
                var mainPage = sp.GetTestParticipant();
                var commmoditiesPopover = mainPage.NavBarPageObjectModel.ClickCommodities();
                Assert.That(() => commmoditiesPopover.WaitForAllCommodiites(), Throws.Nothing);
            });
        }

        [Test]
        public void SearchingForArticleShowsArticle()
        {
            RunTest(sp =>
            {
                var mainPage = sp.GetTestParticipant();
                var searchResultsPopover = mainPage.NavBarPageObjectModel.SearchBarPageObjectModel.Search("Oil");
                Assert.That(() => searchResultsPopover.WaitForResults(), Throws.Nothing);
            });
        }
    }
}
