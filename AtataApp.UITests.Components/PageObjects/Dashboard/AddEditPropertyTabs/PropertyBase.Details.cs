using Atata;
using AtataApp.UITests.Components.Enum;
using AtataApp.UITests.Components.Models;
using _ = AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs.PropertyBase;

namespace AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs
{
    [Url("manager/add")]
    public partial class PropertyBase : Page<_>
    {
        [RandomizeStringSettings("{0}", 10)]
        [FindById("Address")]
        public TextInput<_> Address1 { get; private set; }

        [FindById("City")]
        public EditableTextField<City, _> City { get; private set; }

        [FindById("Country")]
        public Select<Country, _> Country { get; private set; }

        [FindById("State")]
        public Select<State, _> State { get; private set; }

        [FindById("ZipCode")]
        [RandomizeNumberSettings(30000, 90000)]
        public NumberInput<_> ZipCode { get; private set; }

        [FindById("Latitude")]
        [RandomizeNumberSettings(-90, 90)]
        public NumberInput<_> Latitude { get; private set; }

        [FindById("Longitude")]
        [RandomizeNumberSettings(-180, 180)]
        public NumberInput<_> Longitude { get; private set; }



        [FindById("ListingName")]
        public TextInput<_> ListingName { get; private set; }

        [FindById("SaveStatusID")]
        public Select<Stage, _> Stage { get; private set; }

        [FindById("ListingStatusID")]
        public Select<ListingsStatus, _> ListingStatus { get; private set; }

        [FindByCss("div.CustomContactSelection.seller-contact")]
        public SmartDropdown<string, _> SellerContact { get; private set; }

        [FindById("EstimatedCommission")]
        [RandomizeNumberSettings(1000000, 9000000)]
        public NumberInput<_> EstimatedCommission { get; private set; }



        [FindById("ChkPropertyType")]
        public AdvancedCheckBoxList<PropertyType, _> PropertyType { get; private set; }

        [FindById("SquareFeet")]
        [RandomizeNumberSettings(1000000, 9000000)]
        public NumberInput<_> SquareFeet { get; private set; }

        [FindById("Occupancy")]
        [RandomizeNumberSettings(1, 500)]
        public NumberInput<_> Occupancy { get; private set; }


    }
}
