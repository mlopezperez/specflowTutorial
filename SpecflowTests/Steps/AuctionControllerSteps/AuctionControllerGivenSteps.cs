using AuctionApi.Models;
using SpecflowTests.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowTests.Steps.AuctionControllerSteps
{
    [Binding]
    public class AuctionControllerGivenSteps
    {
        private readonly AuctionControllerContext _context;

        public AuctionControllerGivenSteps(AuctionControllerContext context)
        {
            _context = context;
        }

        [Given(@"A list of auctions stored in database")]
        public void GivenAListOfAuctionsStoredInDatabase(Table table)
        {
            var auctions = table.CreateSet<Auction>();
            foreach (var auction in auctions)
            {
                _context.Auctions.Add(auction);
            }
        }


        [Given(@"A list of (.*) auctions stored in database")]
        public void GivenAListOfAuctionsStoredInDatabase(int numberOfAuctions)
        {
            for (int i = 0; i < numberOfAuctions; i++)
            {
                var auctions = GenerateAuction(i);
                _context.Auctions.Add(auctions);
            }
        }

        [Given(@"A an auction with (.*) and ""(.*)""")]
        public void GivenAAnAuctionWithAnd(int id, DateTime startDate)
        {
            var auction = new Auction
            {
                Id = id,
                StartDateTime = startDate
            };
            
            ScenarioContext.Current.Set(auction);
        }


        private static Auction GenerateAuction(int id)
        {
            return new Auction()
            {
                Id = id,
                StartDateTime = DateTime.Now
            };
        }
    }
}
