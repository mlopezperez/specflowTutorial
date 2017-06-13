using System.Collections.Generic;
using System.Linq;
using AuctionApi.Models;

namespace AuctionApi.Repositories
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly IList<Auction> _storage;

        public AuctionRepository(IList<Auction> storage)
        {
            _storage = storage;
        }


        public IEnumerable<Auction> GetAllAuctions()
        {
            return _storage;
        }

        public Auction GetAuction(int id)
        {
            return _storage.SingleOrDefault(i => i.Id == id);
        }

        public void Add(Auction auction)
        {
            _storage.Add(auction);
        }
    }
}