using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels.NavigationBar.SearchBar
{
    internal class SearchBarPageObjectModel : BasePageObjectModel
    {
        private const string _searchBox = "//button[.//span[text()='Search']]";
        private const string _inputBox = "//input[contains(@class, 'HeaderSitecoreSearchInput_input__4Uojz')]";

        public SearchBarPageObjectModel(TestParticipant testParticipant)
            : base(testParticipant)
        {
        }

        public SearchResultsPopoverPageObjectModel Search(string content)
        {
            ClickElement(_searchBox);
            TypeIntoElement(content, _inputBox);

            return new SearchResultsPopoverPageObjectModel(this.TestParticipant);
        }
    }
}
