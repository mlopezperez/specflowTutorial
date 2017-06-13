using NUnit.Framework;
using SpecflowTests.Context;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecflowTests.Steps.AuctionControllerSteps
{
    [Binding]
    public class AuctionControllerThenSteps
    {
        private readonly AuctionControllerContext _context;

        public AuctionControllerThenSteps(AuctionControllerContext context)
        {
            _context = context;
        }

        [Then(@"the returned result must have (.*) elements")]
        public void ThenTheReturnedResultMustHaveElements(int numberOfItems)
        {
            var result = _context.Auctions;
            Assert.That(result, Has.Exactly(numberOfItems).Items);
        }

        [Then(@"the auction in repo must have (.*) and ""(.*)""")]
        public void ThenTheAuctionInRepoMustHaveAnd(int expectedId, DateTime expectedEndDateTime)
        {
            var auction = _context.Auctions.FirstOrDefault(i => i.Id == expectedId);

            Assert.That(auction, Is.Not.Null);
            Assert.That(auction.Id, Is.EqualTo(expectedId));
            Assert.That(auction.EndDateTime, Is.EqualTo(expectedEndDateTime));
        }
    }
}
