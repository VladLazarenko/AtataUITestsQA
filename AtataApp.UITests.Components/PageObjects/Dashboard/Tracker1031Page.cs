using Atata;
using AtataApp.UITests.Components.Controls;
using AtataApp.UITests.Components.Enum;
using AtataApp.UITests.Components.Models;
using System;
using _ = AtataApp.UITests.Components.PageObjects.Dashboard.Tracker1031Page;

namespace AtataApp.UITests.Components.PageObjects.Dashboard
{
    public class Tracker1031Page : Page<_>
    {
        [FindById("btnFilter")]
        [FindOnlyVisible]
        public ClickableDelegate<FilterPopup<_>, _> Filter { get; private set; }



        [FindById("tracker-table")]
        [WaitForTableIsLoaded(TriggerEvents.BeforeAccess)]
        public Table<Tracker1031TableRow,_> Exchanges {  get; private set; }

        public class Tracker1031TableRow : TableRow<_>
        {
            [FindByCss("a.kt-user-card-v2__name")]
            public Number<_> Id { get; private set; }

            [FindByCss("select.dllExchange")]
            public Select<ExchangeStatus,_> Status { get; private set; }

            public Text<_> Name { get; private set; }

            public Text<_> Company { get; private set; }
            
            public Content<IndustryRole, _> Role { get; private set; }
            
            [FindByCss("input.amount")]
            [GetsContentFromAttribute("value")]
            public Currency<_> Amount { get; private set; }
            
            [FindByCss("input.Expirationdate")]
            [GetsContentFromAttribute("value")]
            public TextInput<_> Expiration { get; private set; }
            
            [FindByXPath("a[@title='Edit details']")]
            public ClickableDelegate<_> Edit { get; private set; }

        }
    }



    [PageObjectDefinition("div[@role='document']", ContainingClass = "modal-dialog")]
    public class FilterPopup<TNavigateTo> : PopupWindow<FilterPopup<TNavigateTo>>
        where TNavigateTo : PageObject<TNavigateTo>
    {
        [FindById("FilterByExchangeId")]
        public NumberInput<FilterPopup<TNavigateTo>> ExchangeId { get; private set; }
        
        [FindById("FilterByExchangeStatuslist")]
        public BulkCheckboxList<ExchangeStatus, FilterPopup<TNavigateTo>> ExchangeStatus { get; private set; }

        [FindById("FilterByName")]
        public TextInput<FilterPopup<TNavigateTo>> Name { get; private set; }

        [FindById("FilterByCompany_t")]
        public TextInput<FilterPopup<TNavigateTo>> Company { get; private set; }

        [FindById("FilterByFromExchangeAmount")]
        public TextInput<FilterPopup<TNavigateTo>> FromExchangeAmount { get; private set; }

        [FindById("FilterByToExchangeAmount")]
        public TextInput<FilterPopup<TNavigateTo>> ToExchangeAmount { get; private set; }
        
        [FindById("FilterByExpirationFromDate")]
        public DatePicker<DateTime, FilterPopup<TNavigateTo>> FromIdentificationExpirationDate { get; private set; }
        
        [FindById("FilterByExpirationToDate")]
        public DatePicker<DateTime, FilterPopup<TNavigateTo>> ToIdentificationExpirationDate { get; private set; }

        [FindById("filterByIndustryRole_t")]
        public BulkCheckboxList<IndustryRole, FilterPopup<TNavigateTo>> IndustryRole { get; private set; }
        
        [FindById("FilterByPreferredDealSizelst")]
        public BulkCheckboxList<DealSize, FilterPopup<TNavigateTo>> PreferredDealSize { get; private set; }
        
        [FindById("FilterByPreferredPropertyTypelst")]
        public BulkCheckboxList<PropertyType, FilterPopup<TNavigateTo>> PreferredPropertyType { get; private set; }
        
        [FindById("FilterByPreferredMarketslst")]
        public BulkCheckboxList<State, FilterPopup<TNavigateTo>> PreferredMarkets { get; private set; }

        [FindById("filterByFavorite")]
        [ClicksUsingScript]
        public CheckBox<FilterPopup<TNavigateTo>> Favorite { get; private set; }
        
        [FindById("filterByNotFavorite")]
        [ClicksUsingScript]
        public CheckBox<FilterPopup<TNavigateTo>> NotFavorite { get; private set; }


        [FindByXPath("button[text()='Apply']")]
        [FindOnlyVisible]
        public ClickableDelegate<_, FilterPopup<TNavigateTo>> Apply { get; private set; }
    }
}
