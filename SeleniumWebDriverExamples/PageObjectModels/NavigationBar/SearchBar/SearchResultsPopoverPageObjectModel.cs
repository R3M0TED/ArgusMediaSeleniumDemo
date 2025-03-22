using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels.NavigationBar.SearchBar
{
    internal class SearchResultsPopoverPageObjectModel : BasePageObjectModel
    {
        private const string _searchResult = "//a[contains(@class, 'qa-searchpredict-item')]";

        public SearchResultsPopoverPageObjectModel(TestParticipant testParticipant)
            : base(testParticipant)
        {
        }

        public void WaitForSearchResults()
        {
            WaitForElementToBeDisplayed(_searchResult);
        }
    }
}
