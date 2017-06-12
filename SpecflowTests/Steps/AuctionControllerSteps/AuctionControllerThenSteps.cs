using System;
using AuctionApi.Models;
using AuctionApi.Repositories;
using NUnit.Framework;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecflowTests.Steps.AuctionControllerSteps
{
    [Binding]
    public class AuctionControllerThenSteps
    {
        [Then(@"the returned result must have (.*) elements")]
        public void ThenTheReturnedResultMustHaveElements(int p0)
        {
            var result = ScenarioContext.Current.Get<IEnumerable<Auction>>();
            Assert.That(result, Has.Exactly(3).Items);
        }

        [Then(@"the auction in repo must have (.*) and ""(.*)""")]
        public void ThenTheAuctionInRepoMustHaveAnd(int expectedId, DateTime expectedEndDateTime)
        {
            var repo = ScenarioContext.Current.Get<IAuctionRepository>();
            var auction = repo.GetAuction(expectedId);

            Assert.That(auction.Id, Is.EqualTo(expectedId));
            Assert.That(auction.EndDateTime, Is.EqualTo(expectedEndDateTime));
        }
    }
}
