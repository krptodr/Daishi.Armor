﻿#region Designer generated code

#region Includes

using TechTalk.SpecFlow;

#endregion

#pragma warning disable

namespace Daishi.Armor.Specs {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ArmorTokenIsSerialised")]
    public partial class ArmorTokenIsSerialisedFeature {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "ArmorTokenIsSerialised.feature"
#line hidden

        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup() {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ArmorTokenIsSerialised", "In order to prove that a given ArmorToken is serialised\r\nAs an ArmorTokenSerialis" +
                                                                                                                                         "or\r\nI want to serialise an ArmorToken", ProgrammingLanguage.CSharp, ((string[]) (null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown() {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize() {}

        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown() {
            testRunner.OnScenarioEnd();
        }

        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo) {
            testRunner.OnScenarioStart(scenarioInfo);
        }

        public virtual void ScenarioCleanup() {
            testRunner.CollectScenarioErrors();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Serialise an ArmorToken")]
        [NUnit.Framework.CategoryAttribute("armorTokenSerialisor")]
        public virtual void SerialiseAnArmorToken() {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialise an ArmorToken", new string[] {
                "armorTokenSerialisor"
            });
#line 7
            this.ScenarioSetup(scenarioInfo);
#line 8
            testRunner.Given("I have supplied an ArmorToken", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Given ");
#line 9
            testRunner.When("I serialise the ArmorToken", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 10
            testRunner.Then("ArmorTokenSerialisor creates a JSON representation of the ArmorToken", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}

#pragma warning restore

#endregion