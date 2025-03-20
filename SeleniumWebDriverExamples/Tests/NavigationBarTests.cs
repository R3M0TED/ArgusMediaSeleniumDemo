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
                Assert.That(() => commmoditiesPopover.WaitForAllCommodities(), Throws.Nothing);
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

        [Test]
        public void SearchingForArticlseShowsArticle()
        {
            RunTest(sp =>
            {
                var mainPage = sp.GetTestParticipant();
                var searchResultsPopover = mainPage.NavBarPageObjectModel.SearchBarPageObjectModel.Search("Oil");
                Assert.That(() => searchResultsPopover.WaitForResults(), Throws.Nothing);
            });
        }

        [Test]
        public void SearchingForArticleSshowsArticle()
        {
            RunTest(sp =>
            {
                var mainPage = sp.GetTestParticipant();
                var searchResultsPopover = mainPage.NavBarPageObjectModel.SearchBarPageObjectModel.Search("Oil");
                Assert.That(() => searchResultsPopover.WaitForResults(), Throws.Nothing);
            });
        }

        [Test]
        public void SearchingForArticleShodwsArticle()
        {
            RunTest(sp =>
            {
                var mainPage = sp.GetTestParticipant();
                var searchResultsPopover = mainPage.NavBarPageObjectModel.SearchBarPageObjectModel.Search("Oil");
                Assert.That(() => searchResultsPopover.WaitForResults(), Throws.Nothing);
            });
        }

        [Test]
        public void SearchingForArticleShowsAfrticle()
        {
            RunTest(sp =>
            {
                var mainPage = sp.GetTestParticipant();
                var searchResultsPopover = mainPage.NavBarPageObjectModel.SearchBarPageObjectModel.Search("Oil");
                Assert.That(() => searchResultsPopover.WaitForResults(), Throws.Nothing);
            });
        }

        [Test]
        public void SearchingFaorArticleShowsArticle()
        {
            RunTest(sp =>
            {
                var mainPage = sp.GetTestParticipant();
                var searchResultsPopover = mainPage.NavBarPageObjectModel.SearchBarPageObjectModel.Search("Oil");
                Assert.That(() => searchResultsPopover.WaitForResults(), Throws.Nothing);
            });
        }

        [Test]
        public void SearchingForArticaleShowsArticle()
        {
            RunTest(sp =>
            {
                var mainPage = sp.GetTestParticipant();
                var searchResultsPopover = mainPage.NavBarPageObjectModel.SearchBarPageObjectModel.Search("Oil");
                Assert.That(() => searchResultsPopover.WaitForResults(), Throws.Nothing);
            });
        }

        [Test]
        public void SearchingForArtiscleShowsArticle()
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
