using System;
using System.Collections.Generic;

namespace AuctionApi.Models
{
    public class Auction
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public IEnumerable<Lot> Lots { get; set; }
    }
}