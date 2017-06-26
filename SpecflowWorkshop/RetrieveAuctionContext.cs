using AuctionApi.Models;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecflowWorkshop
{
    public class RetrieveAuctionContext
    {
        public DBContext Storage { get; set; }

        public IList<Auction> Results { get; set; }

        public Auction Result { get; set; }
    }
}
