using System;
using AuctionApi.Models;
using System.Collections.Generic;
using System.Web.Http;
using AuctionApi.Repositories;

namespace AuctionApi.Controllers
{
    public class AuctionController : ApiController
    {
        private readonly IAuctionRepository _auctionRepository;

        public AuctionController(IAuctionRepository auctionRepository)
        {
            _auctionRepository = auctionRepository;
        }

        public IEnumerable<Auction> Get()
        {
            return _auctionRepository.GetAllAuctions();
        }

        public Auction Get(int auctionId)
        {
            return _auctionRepository.GetAuction(auctionId);
        }

        [HttpPost]
        public void Save(Auction auction)
        {
            if (auction == null)
            {
                throw new ArgumentNullException(nameof(auction), "auction");
            }

            auction.EndDateTime = auction.StartDateTime.AddDays(1);
            _auctionRepository.Add(auction);
        }
    }
}
