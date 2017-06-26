using AuctionApi.Models;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecflowWorkshop
{
    [Binding]
    class Hooks
    {
        private readonly RetrieveAuctionContext _context;

        public Hooks(RetrieveAuctionContext context)
        {
            _context = context;
        }

        [BeforeScenario]
        public void InitializeScenario()
        {
            _context.Storage = new List<Auction>();
        }

        [AfterScenario()]
        public void Cleanup()
        {
            _context.Storage.Clear();
        }
    }
}
