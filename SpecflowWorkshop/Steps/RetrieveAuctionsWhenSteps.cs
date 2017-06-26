using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctionApi.Controllers;
using AuctionApi.Models;
using AuctionApi.Repositories;
using TechTalk.SpecFlow;

namespace SpecflowWorkshop.Steps
{
    [Binding]
    class RetrieveAuctionsWhenSteps
    {

        [When(@"I get all auctions using API")]
        public void WhenIGetAllAuctionsUsingAPI()
        {
            var storage = ScenarioContext.Current.Get<IList<Auction>>();
            var controller = new AuctionController(new AuctionRepository(storage));
            var result = controller.Get();
            ScenarioContext.Current.Set(result);
        }

        [When(@"I get the auction with id ""(.*)""")]
        public void WhenIGetTheAuctionWithId(int id)
        {
            var storage = ScenarioContext.Current.Get<IList<Auction>>();
            var controller = new AuctionController(new AuctionRepository(storage));
            Auction result = controller.Get(id);
            ScenarioContext.Current.Set(result);
        }


    }
}
