﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecflowTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Retrieve auctions from API")]
    public partial class RetrieveAuctionsFromAPIFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RetrieveAuctions.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Retrieve auctions from API", "\tIn order to manage auctions in my custom application\r\n\tAs an API consumer\r\n\tI wa" +
                    "nt to retrieve distinct auctions from API", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get all auctions")]
        [NUnit.Framework.CategoryAttribute("controllerTest")]
        public virtual void GetAllAuctions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get all auctions", new string[] {
                        "controllerTest"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "StartDateTime"});
            table1.AddRow(new string[] {
                        "1",
                        "\"09/06/2017\""});
            table1.AddRow(new string[] {
                        "2",
                        "\"01/06/2017\""});
            table1.AddRow(new string[] {
                        "3",
                        "\"02/06/2017\""});
#line 8
 testRunner.Given("A list of auctions stored in database", ((string)(null)), table1, "Given ");
#line 13
 testRunner.When("I retrieve all actions from controller", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("the returned result must have 3 elements", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check end date time is properly set")]
        [NUnit.Framework.CategoryAttribute("controllerTest")]
        [NUnit.Framework.TestCaseAttribute("4", "\"28/02/2016\"", "4", "\"29/02/2016\"", new string[0])]
        [NUnit.Framework.TestCaseAttribute("5", "\"28/02/2017\"", "5", "\"01/03/2017\"", new string[0])]
        public virtual void CheckEndDateTimeIsProperlySet(string id, string startDateTime, string expectedId, string expectedEndDate, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "controllerTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check end date time is properly set", @__tags);
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given(string.Format("A an auction with {0} and {1}", id, startDateTime), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.When("I save it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then(string.Format("the auction in repo must have {0} and {1}", expectedId, expectedEndDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check login credentials")]
        [NUnit.Framework.CategoryAttribute("loginTest")]
        [NUnit.Framework.TestCaseAttribute("aroaTrader", "AroaTrader01", "200", new string[0])]
        [NUnit.Framework.TestCaseAttribute("manuTrader", "ManuPassword01", "403", new string[0])]
        public virtual void CheckLoginCredentials(string login, string password, string httpCode, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "loginTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check login credentials", @__tags);
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given(string.Format("the user credentials {0} and {1}", login, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
 testRunner.When("I try to log in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then(string.Format("the server must return an {0}", httpCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
