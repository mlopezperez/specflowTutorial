using System;

namespace AuctionApi.Models
{
    public class Lot
    {
        public int Id { get; set; }
        public DateTime EndDateTime { get; set; }
        public decimal Price { get; set; }
    }
}