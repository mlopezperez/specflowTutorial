using AuctionApi.Models;
using SpecflowTests.Context;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecflowTests.Steps.AuctionControllerSteps
{
    [Binding]
    public class AuctionControllerWhenSteps
    {
        private readonly AuctionControllerContext _context;

        public AuctionControllerWhenSteps(AuctionControllerContext context)
        {
            _context = context;
        }

        [When(@"I retrieve all actions from controller")]
        public void WhenIRetrieveAllActionsFromController()
        {
            var auctions = _context.Controller.Get();
            ScenarioContext.Current.Set<IEnumerable<Auction>>(auctions);
        }
        
        [When(@"I save it")]
        public void WhenISaveIt()
        {
            var auction = ScenarioContext.Current.Get<Auction>();
            
            _context.Controller.Save(auction);
        }
    }
}
