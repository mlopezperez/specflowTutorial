using AuctionApi.Models;
using System.Collections.Generic;
using System.Web.Http;
using AuctionApi.Repositories;

namespace AuctionApi.Controllers
{
    public class AuctionController : ApiController
    {
        private readonly IAuctionRepository _auctionRepository = new AuctionRepository();

        public IEnumerable<Auction> Get()
        {
            return _auctionRepository.GetAllAuctions();
        }

        public Auction Get(int auctionId)
        {
            return _auctionRepository.GetAuction(auctionId);
        }
    }
}
