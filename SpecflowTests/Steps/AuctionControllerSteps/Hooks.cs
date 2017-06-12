using AuctionApi.Controllers;
using AuctionApi.Repositories;
using TechTalk.SpecFlow;

namespace SpecflowTests.Steps.AuctionControllerSteps
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario("controllerTest")]
        public static void BeforeScenario()
        {
            IAuctionRepository repo = new AuctionRepository();
            var controller = new AuctionController(repo);

            ScenarioContext.Current.Set(repo);
            ScenarioContext.Current.Set(controller);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            // Nothing to do here yet;
        }
    }
}
