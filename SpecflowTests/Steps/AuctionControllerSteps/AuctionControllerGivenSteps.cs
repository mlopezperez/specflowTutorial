using System;
using AuctionApi.Models;
using AuctionApi.Repositories;
using TechTalk.SpecFlow;

namespace SpecflowTests.Steps.AuctionControllerSteps
{
    [Binding]
    public class AuctionControllerGivenSteps
    {
        [Given(@"A list of (.*) auctions stored in database")]
        public void GivenAListOfAuctionsStoredInDatabase(int numberOfAuctions)
        {
            var repo = ScenarioContext.Current.Get<IAuctionRepository>();
            for (int i = 0; i < numberOfAuctions; i++)
            {
                var auctions = GenerateAuction(i);
                repo.Add(auctions);
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
