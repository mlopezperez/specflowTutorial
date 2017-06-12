using System;
using System.Collections.Generic;
using AuctionApi.Models;
using AuctionApi.Repositories;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecflowTests.Steps
{
    [Binding]
    public class AuctionSteps 
    {
        [Given(@"A list of (.*) auctions stored in database")]
        public void GivenAListOfAuctionsStoredInDatabase(int numberOfAuctions)
        {
            IAuctionRepository repo = new AuctionRepository();
            for (int i = 0; i < numberOfAuctions; i++)
            {
                var auctions = GenerateAuction(i);
                repo.Add(auctions);
            }
            ScenarioContext.Current.Set(repo);
        }

        private static Auction GenerateAuction(int id)
        {
            return new Auction()
            {
                Id = id,
                EndDateTime = DateTime.Now,
                StartDateTime = DateTime.Now.AddDays(-1)
            };
        }

        [When(@"I retrieve all actions")]
        public void WhenIRetrieveAllActions()
        {
            var repo = ScenarioContext.Current.Get<IAuctionRepository>();
            var auctions = repo.GetAllAuctions();
            ScenarioContext.Current.Set<IEnumerable<Auction>>(auctions);
        }

        [Then(@"the returned result must have (.*) elements")]
        public void ThenTheReturnedResultMustHaveElements(int p0)
        {
            var result = ScenarioContext.Current.Get<IEnumerable<Auction>>();
            Assert.That(result, Has.Exactly(3).Items);
        }
    }
}
