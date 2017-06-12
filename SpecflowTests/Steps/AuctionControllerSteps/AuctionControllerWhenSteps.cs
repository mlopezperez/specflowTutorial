using AuctionApi.Controllers;
using AuctionApi.Models;
using AuctionApi.Repositories;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecflowTests.Steps.AuctionControllerSteps
{
    [Binding]
    public class AuctionControllerWhenSteps
    {
        [When(@"I retrieve all actions from controller")]
        public void WhenIRetrieveAllActionsFromController()
        {
            var repo = ScenarioContext.Current.Get<IAuctionRepository>();
            var controller = new AuctionController(repo);
            var auctions = controller.Get();
            ScenarioContext.Current.Set<IEnumerable<Auction>>(auctions);
        }


        [When(@"I retrieve the auction with the (.*)")]
        public void WhenIRetrieveTheAuctionWithThe(int id)
        {
            var repo = ScenarioContext.Current.Get<IAuctionRepository>();
            var controller = new AuctionController(repo);
            var auction = controller.Get(id);

            ScenarioContext.Current.Set(auction);
        }

        [When(@"I save it")]
        public void WhenISaveIt()
        {
            var auction = ScenarioContext.Current.Get<Auction>();
            IAuctionRepository repo = new AuctionRepository();

            var controller = new AuctionController(repo);
            controller.Save(auction);

            ScenarioContext.Current.Set(repo);
        }
    }
}
