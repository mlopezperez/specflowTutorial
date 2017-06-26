using System.Collections.Generic;
using AuctionApi.Controllers;
using AuctionApi.Models;
using AuctionApi.Repositories;
using SpecflowTests.Context;
using TechTalk.SpecFlow;

namespace SpecflowTests.Steps.AuctionControllerSteps
{
    [Binding]
    public class Hooks
    {
        private readonly AuctionControllerContext _context;

        public Hooks(AuctionControllerContext context)
        {
            _context = context;
        }

        [BeforeScenario("controllerTest")]        
        public void BeforeScenario()
        {
            _context.Auctions = new List<Auction>();
            IAuctionRepository repo = new AuctionRepository(_context.Auctions);
            _context.Controller = new AuctionController(repo);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _context.Auctions.Clear();
        }
    }
}
