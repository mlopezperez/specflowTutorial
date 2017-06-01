using System.Collections.Generic;
using AuctionApi.Models;

namespace AuctionApi.Repositories
{
    internal interface IAuctionRepository
    {
        IEnumerable<Auction> GetAllAuctions();

        Auction GetAuction(int id);

        void Add(Auction auction);
    }
}