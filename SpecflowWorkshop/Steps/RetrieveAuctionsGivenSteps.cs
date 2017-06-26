using AuctionApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowWorkshop.Steps
{
    [Binding]
    class RetrieveAuctionsGivenSteps
    {
        private readonly RetrieveAuctionContext _context;
        
        public RetrieveAuctionsGivenSteps(RetrieveAuctionContext context)
        {
            _context = context;
        }

        [Given(@"A list of (.*) auctions stored in database")]
        public void GivenAListOfAuctionsStoredInDatabase(int numberOfAuctions)
        {
            CreateAuctions(_context.Storage, numberOfAuctions);
        }

        [Given(@"An auctions with id (.*) and start time ""(.*)"" and end time ""(.*)""")]
        public void GivenAnAuctionsWithIdAndStartTimeAndEndTime(int id, DateTime starTime, DateTime endTime)
        {
            var auction = new Auction()
            {
                Id = id,
                StartDateTime = starTime,
                EndDateTime = endTime
            };
            _context.Storage.Add(auction);
        }

        [Given(@"An stored auction")]
        public void GivenAnAuctionsWithAndAnd(Table table)
        {
            IList<Auction> auctions = table.CreateSet<Auction>().ToList();
            foreach (var item in auctions)
            {
                _context.Storage.Add(item);
            }
        }
        
        private void CreateAuctions(IList<Auction> storage, int numberOfAuctions)
        {
            for (int i = 0; i < numberOfAuctions; i++)
            {
                var auction = new Auction()
                {
                    Id = i,
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now.AddDays(1)
                };
                storage.Add(auction);
            }
        }
    }
}

