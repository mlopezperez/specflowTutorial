using AuctionApi.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace AuctionApi.Controllers
{
    public class AuctionController : ApiController
    {
        public IEnumerable<Auction> Get()
        {
            return new List<Auction>();
        }

        public Auction Get(int auctionId)
        {
            return new Auction();
        }
    }
}
