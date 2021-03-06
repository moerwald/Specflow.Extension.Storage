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
namespace SpecflowExtension.Storage.Test
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("StoreValueFromTable")]
    public partial class StoreValueFromTableFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StoreValueFromTable.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "StoreValueFromTable", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Store message parameters")]
        public virtual void StoreMessageParameters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Store message parameters", null, ((string[])(null)));
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "MessageType",
                        "TestMessage => $MessageType$"});
            table1.AddRow(new string[] {
                        "Destination",
                        "Destination1 =>$Destination$"});
            table1.AddRow(new string[] {
                        "IntValue",
                        "1=> $IntValue$"});
#line 4
 testRunner.Given("the following message is generated", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "MessageType",
                        "TestMessage"});
            table2.AddRow(new string[] {
                        "Destination",
                        "Destination1"});
            table2.AddRow(new string[] {
                        "IntValue",
                        "1"});
#line 9
 testRunner.Then("the storage has the following entries", ((string)(null)), table2, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "MessageType",
                        "TestMessage"});
            table3.AddRow(new string[] {
                        "Destination",
                        "Destination1"});
            table3.AddRow(new string[] {
                        "IntValue",
                        "1"});
#line 14
 testRunner.Then("the message contains", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Inject stored parameters")]
        public virtual void InjectStoredParameters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inject stored parameters", null, ((string[])(null)));
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "MessageType",
                        "TestMessage => $MessageType$"});
            table4.AddRow(new string[] {
                        "Destination",
                        "Destination1 =>$Destination$"});
            table4.AddRow(new string[] {
                        "IntValue",
                        "1=> $IntValue$"});
#line 21
   testRunner.Given("the following message is generated", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "MessageType",
                        "TestMessage"});
            table5.AddRow(new string[] {
                        "Destination",
                        "Destination1"});
            table5.AddRow(new string[] {
                        "IntValue",
                        "1"});
#line 26
   testRunner.Then("the storage has the following entries", ((string)(null)), table5, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "MessageType",
                        "<= $MessageType$"});
            table6.AddRow(new string[] {
                        "Destination",
                        "<= $Destination$"});
            table6.AddRow(new string[] {
                        "IntValue",
                        "<=$IntValue$"});
#line 31
   testRunner.When("the following message is generated", ((string)(null)), table6, "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "MessageType",
                        "TestMessage"});
            table7.AddRow(new string[] {
                        "Destination",
                        "Destination1"});
            table7.AddRow(new string[] {
                        "IntValue",
                        "1"});
#line 36
  testRunner.Then("the message contains", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Store dynamically generated message parameters")]
        public virtual void StoreDynamicallyGeneratedMessageParameters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Store dynamically generated message parameters", null, ((string[])(null)));
#line 42
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "MessageType",
                        "TestMessage => $MessageType$"});
            table8.AddRow(new string[] {
                        "Destination",
                        "Destination1 =>$Destination$"});
            table8.AddRow(new string[] {
                        "IntValue",
                        "1=> $IntValue$"});
            table8.AddRow(new string[] {
                        "MessageId",
                        "=> $MessageId$"});
#line 43
 testRunner.Given("the following message is generated", ((string)(null)), table8, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "MessageId",
                        "<= $MessageId$"});
#line 49
 testRunner.Then("the storage has the following entries", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
