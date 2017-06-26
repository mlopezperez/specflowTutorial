using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctionApi.Models;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecflowWorkshop.Steps
{
    [Binding]
    class RetrieveAuctionsThenSteps
    {
        private readonly RetrieveAuctionContext _context;

        public RetrieveAuctionsThenSteps(RetrieveAuctionContext context)
        {
            _context = context;
        }

        [Then(@"the returned list has (.*) items")]
        public void ThenTheReturnedListHasItems(int expectedNumberOfItems)
        {
            Assert.AreEqual(expectedNumberOfItems, _context.Results.Count);
        }


        [Then(@"the returned auction must have id ""(.*)"" and start date ""(.*)""")]
        public void ThenTheReturnedAuctionMustHaveIdAndStartDate(int id, DateTime startDateTime)
        {
            var result = _context.Result;
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.StartDateTime, Is.EqualTo(startDateTime));
        }

    }
}
