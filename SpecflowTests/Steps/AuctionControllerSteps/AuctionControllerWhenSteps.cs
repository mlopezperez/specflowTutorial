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
            var controller = ScenarioContext.Current.Get<AuctionController>();
            var auctions = controller.Get();
            ScenarioContext.Current.Set<IEnumerable<Auction>>(auctions);
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
