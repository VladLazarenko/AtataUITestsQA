using Atata;
using Atata.Bootstrap;
using AtataApp.UITests.Components.Controls;
using AtataApp.UITests.Components.Models;
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using _ = AtataApp.UITests.Components.Parent.Components.RegisterParent;
using AtataApp.UITests.Components.Enum;

namespace AtataApp.UITests.Components.Parent.Components
{
    public class RegisterParent : Page<_>
    {
        [WaitFor(Until.Missing, TriggerEvents.AfterClick)]
        [FindByCss("a.cookies-btn")]
        public Link<_> GotItCookies { get; private set; }

        [WaitUntilEnabled]
        [WaitFor(Until.Visible, PresenceTimeout = 10)]
        [RandomizeStringSettings("{0}@putsbox.com")]
        [FindById("email")]
        public TextInput<_> EmailAddressInput { get; private set; }

        [FindById("password")]
        public PasswordInput<_> Password { get; private set; }

        [FindById("passwordConfirm")]
        public PasswordInput<_> PasswordConfirm { get; private set; }

        [FindByXPath("//button[text()='Create New Account']")]
        public Button<_> CreateNewAccount { get; private set; }

        [FindById("firstName")]
        public TextInput<_> FirstName { get; private set; }

        [FindById("lastName")]
        public TextInput<_> LastName { get; private set; }

        [FindById("title")]
        public TextInput<_> Title { get; private set; }

        [FindById("company")]
        public TextInput<_> Company { get; private set; }

        [FindById("street")]
        public TextInput<_> Street { get; private set; }

        [FindById("suite")]
        public TextInput<_> Suite { get; private set; }

        [FindById("city")]
        public TextInput<_> City { get; private set; }

        [FindByXPath("//p-dropdown[@optionlabel='stateName']")]
        public PDropdown<State, _> State { get; private set; }

        [FindByXPath("//p-dropdown[@optionlabel='countryName']")]
        public PDropdown<Country, _> Country { get; private set; }

        [FindById("zipCode")]
        public TextInput<_> ZipCode { get; private set; }
        
        [FindById("linkedIn")]
        public TextInput<_> LinkedIn { get; private set; }
       
        [FindByXPath("//p-inputmask[@formcontrolname='workPhone']/input")]
        public TextInput<_> WorkPhone { get; private set; }

        [FindByXPath("//p-inputmask[@formcontrolname='mobilePhone']/input")]
        public TextInput<_> MobilePhone { get; private set; }

        [FindById("emailConfirm")]
        public TextInput<_> EmailConfirm { get; private set; }


        [ControlDefinition("label")]
        [FindItemByRelativeElementContent("@for")]
        [FindByCss("div.checkbox-group-wrapper div.contact-info-radio")]
        public RadioButtonList<IndustryRole?, _> IndustryRole { get; private set; }


        [ControlDefinition("label")]
        [FindItemByRelativeElementContent("@for")]
        [FindByCss("div.checkbox-group-wrapper div.contact-info-radio")]     
        public RadioButtonList<InvestorType?, _> InvestorType { get; private set; }
        
        [ControlDefinition("label")]
        [FindItemByRelativeElementContent("@for")]
        [FindByCss("div.checkbox-group-wrapper div.contact-info-radio")]     
        public RadioButtonList<BrokerType?, _> BrokerType { get; private set; }

        [FindByClass("datum_avatar_upload")]
        public Label<_> PencilIcon { get; private set; }
        
        [FindById("photo")]
        public FileInput<_> AddPhoto { get; private set; }
        
        [FindByAttribute("label")]
        public Button<_> SavePhoto { get; private set; }
        
        [FindByAttribute("label")]
        public Button<_> Next { get; private set; }
        
        [FindByAttribute("label")]
        public Button<_> Complete { get; private set; }

        [ControlDefinition("label")]
        [FindItemByRelativeElementContent("@for", TermCase.Snake)]
        [FindByCss("div.status div.checkbox-group-wrapper")]
        public RadioButtonList<ExchangeStatus?, _> ExchangeStatus { get; private set; }

        [ControlDefinition("label")]
        [FindItemByRelativeElementContent("@for")]
        [FindByXPath("//h4[text()='Preferred Deal Size ']/following::div[1]")]
        public RadioButtonList<string,_> PreferredDealSize { get; private set; }

        [ControlDefinition("label")]
        [FindItemByRelativeElementContent("@for")]
        [FindByXPath("//h4[text()='Preferred Property Type']/following::div[1]")]
        public RadioButtonList<PropertyType?, _> PreferredPropertyType { get; private set; }

        [ControlDefinition("label")]
        [FindItemByRelativeElementContent("@for")]
        [FindByXPath("//h4[text()='Preferred Investment Strategy']/following::div[1]")]
        public RadioButtonList<string, _> PreferredInvestmentStrategy { get; private set; }

        [ControlDefinition("label")]
        [FindItemByRelativeElementContent("@for")]
        [FindByXPath("//h4[text()='Preferred Return Metrics']/following::div[1]")]
        public RadioButtonList<string, _> PreferredReturnMetrics { get; private set; }

        [ControlDefinition("label")]
        [FindItemByRelativeElementContent("@for")]
        [FindByXPath("//h4[text()='Preferred Markets']/following::div[1]")]
        public RadioButtonList<State, _> PreferredMarkets { get; private set; }

    }






}
