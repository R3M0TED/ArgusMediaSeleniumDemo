namespace SeleniumWebDriverExamples.Tests
{
    internal sealed class MultipleUsersDemoTests : BaseTests
    {
        [Test]
        public void WhenMultipleUsersDoSomethingThenThisHappens()
        {
            RunTest(sp =>
            {
                var subjectMainPage = sp.CreateTestParticipant();
                var witnessMainPage = sp.CreateTestParticipant();

                var subjectCommmoditiesPopover = subjectMainPage.NavBarPageObjectModel.ClickCommodities();
                var witnessCommmoditiesPopover = witnessMainPage.NavBarPageObjectModel.ClickCommodities();

                Assert.That(() => subjectCommmoditiesPopover.WaitForAllCommodities(), Throws.Nothing);
                Assert.That(() => witnessCommmoditiesPopover.WaitForAllCommodities(), Throws.Nothing);

            });
        }
    }
}
