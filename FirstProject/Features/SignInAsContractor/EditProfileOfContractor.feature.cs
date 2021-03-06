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
namespace FirstProject.Features.SignInAsContractor
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("EditProfileOfContractor")]
    public partial class EditProfileOfContractorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "EditProfileOfContractor.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "EditProfileOfContractor", "In order to test pages\r\nAs an contractor \r\nI want to be able to access the system" +
                    " after I enter my credencials and to test editing\r\nmy profile", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Edit Contractors Profile Invalid")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void EditContractorsProfileInvalid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Contractors Profile Invalid", null, new string[] {
                        "mytag"});
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
testRunner.Given("User logs in as contractor and navigates on profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
testRunner.When("Contractor deletes all values from the fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
testRunner.Then("Error messages are showed under Inputs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
testRunner.When("Contractor enters Invalid Values in input fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
testRunner.Then("Error messages are showed under Inputs 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Edit Contractors Profile Valid")]
        public virtual void EditContractorsProfileValid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Contractors Profile Valid", null, ((string[])(null)));
#line 15
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 16
testRunner.Given("User logs in as contractor and navigates on profile page 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
testRunner.When("Contractor enters new valid values and clicks the save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
testRunner.Then("Contractor is redirected on create claim page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
testRunner.When("Contractor navigate again on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
testRunner.Then("New values are in input fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
