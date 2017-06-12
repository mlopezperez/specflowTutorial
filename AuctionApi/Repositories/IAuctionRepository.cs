using System.Collections.Generic;
using AuctionApi.Models;

namespace AuctionApi.Repositories
{
    public interface IAuctionRepository
    {
        IEnumerable<Auction> GetAllAuctions();

        Auction GetAuction(int id);

        void Add(Auction auction);
    }
}