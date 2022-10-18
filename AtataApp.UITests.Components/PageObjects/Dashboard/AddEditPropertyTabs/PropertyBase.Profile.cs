using Atata;
using AtataApp.UITests.Components.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using _ = AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs.PropertyBase;

namespace AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs
{
    public partial class PropertyBase
    {
        [ControlDefinition("*")]
        [FindSettings(OuterXPath = ".//", TargetName = "Items")]
        [FindByXPath("//input[@id='SelectedDealSize']/parent::div[1]")]
        [FindItemByRelativeElementContent("text()")]
        public RadioButtonList<string, _> ProfileDealSize { get; private set; }

        [ControlDefinition("*")]
        [FindSettings(OuterXPath = ".//", TargetName = "Items")]
        [FindByXPath("//input[@id='SelectedPrefferedProperty']/parent::div[1]")]
        [FindItemByRelativeElementContent("text()")]
        public RadioButtonList<PropertyType, _> ProfilePropertyType { get; private set; }

        [ControlDefinition("*")]
        [FindSettings(OuterXPath = ".//", TargetName = "Items")]
        [FindByXPath("//input[@id='SelectedInvestmentStrategy']/parent::div[1]")]
        [FindItemByRelativeElementContent("text()")]
        public RadioButtonList<string, _> ProfileInvestmentStrategy { get; private set; }

        [ControlDefinition("*")]
        [FindSettings(OuterXPath = ".//", TargetName = "Items")]
        [FindByXPath("//input[@id='SelectedReturnMetrics']/parent::div[1]")]
        [FindItemByRelativeElementContent("text()")]
        public RadioButtonList<string, _> ProfileReturnMetrics { get; private set; }

        [ControlDefinition("*")]
        [FindSettings(OuterXPath = ".//", TargetName = "Items")]
        [FindByXPath("//input[@id='SelectedPrefferedMarket']/parent::div[1]")]
        [FindItemByRelativeElementContent("text()")]
        public RadioButtonList<State, _> ProfileMarkets { get; private set; }
    }
}
