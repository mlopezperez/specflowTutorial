using System.Collections.Generic;
using System.Linq;
using AuctionApi.Models;

namespace AuctionApi.Repositories
{
    public class AuctionRepository : IAuctionRepository
    {
        private IList<Auction> auctions = new List<Auction>();

        public IEnumerable<Auction> GetAllAuctions()
        {
            return auctions;
        }

        public Auction GetAuction(int id)
        {
            return auctions.SingleOrDefault(i => i.Id == id);
        }

        public void Add(Auction auction)
        {
            auctions.Add(auction);
        }
    }
}