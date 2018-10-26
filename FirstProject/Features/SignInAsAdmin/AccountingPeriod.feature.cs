﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FirstProject.Features.SignInAsAdmin
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AccountingPeriod")]
    public partial class AccountingPeriodFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AccountingPeriod.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AccountingPeriod", @"In order to test pages
As an admin 
I want to be able to access the system after I enter my credencials and to test 
create and edit accounting period page with invalid values, create and edit new period
with valid values and assert that new accounting period is showen 
in all dropdowns and lists", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Accounting Period Invalid")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void CreateAccountingPeriodInvalid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Accounting Period Invalid", null, new string[] {
                        "mytag"});
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
testRunner.Given("User logs in as admin and navigate on Accouting period create page 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
testRunner.When("Admin clears Year input and click create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
testRunner.Then("Error messages are showed 6", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
testRunner.When("Admin enters year that is less than 1990.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
testRunner.Then("Error messages are showed 7", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
testRunner.When("Admin enters year that is greater than 2100.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
testRunner.Then("Error messages are showed 13", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
testRunner.When("Admin enters valid year and invalid special characters in claims inputs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
testRunner.Then("Error messages are showed 8", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
testRunner.When("Admin enters valid year and invalid formats in claims inputs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
testRunner.Then("Error messages are showed 12", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
testRunner.When("User select month and enters year for accounting period that already exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
testRunner.Then("Error message is showed 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create And Assert Accounting Period")]
        public virtual void CreateAndAssertAccountingPeriod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create And Assert Accounting Period", null, ((string[])(null)));
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 26
testRunner.Given("User logs in as admin and navigate on Accouting period create page 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
testRunner.When("User enters valid values in create accounting period form 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
testRunner.Then("Accounting period is successfully created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
testRunner.When("Admin navigates on Invoice Validator home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
testRunner.Then("Admin should be able to select new accounting period", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
testRunner.When("Admin logs out and logs in as contractor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
testRunner.Then("New accounting period should be in create claim dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create And Edit Accounting Period")]
        public virtual void CreateAndEditAccountingPeriod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create And Edit Accounting Period", null, ((string[])(null)));
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 35
testRunner.Given("User logs in as admin and navigate on Accouting period create page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
testRunner.When("Admin enters valid values in create accounting period page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
testRunner.And("Admin navigates on Edit link for created accounting period and deletes all values" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
testRunner.Then("Error messeges are showed 9", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
testRunner.When("Admin enters year that is less than 1990. in edit year input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
testRunner.Then("Error message is showed 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
testRunner.When("Admin enters year that is greater than 2100. in edit year input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
testRunner.Then("Error message is showed 13", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
testRunner.When("User change claim date values to invalid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
testRunner.Then("Error messages showed 9", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
testRunner.When("User select month and enters year for accounting period that already exists 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
testRunner.Then("Error message is showed 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
testRunner.When("Admin change month, year and claim dates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
testRunner.Then("Accounting period is changed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
