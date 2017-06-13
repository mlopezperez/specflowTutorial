using AuctionApi.Models;
using System.Collections.Generic;
using AuctionApi.Controllers;

namespace SpecflowTests.Context
{
    public class AuctionControllerContext
    {
        public IList<Auction> Auctions { get; set; }
        public AuctionController Controller { get; set; }
    }
}
