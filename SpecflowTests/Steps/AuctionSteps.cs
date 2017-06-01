using TechTalk.SpecFlow;

namespace SpecflowTests.Steps
{
    public class AuctionSteps
    {
        [Given(@"A list of (.*) auctions stored in database")]
        public void GivenAListOfAuctionsStoredInDatabase(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I retrieve all actions")]
        public void WhenIRetrieveAllActions()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the returned result must have (.*) elements")]
        public void ThenTheReturnedResultMustHaveElements(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
