using Atata;
using AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs;
using System;
using _ = AtataUITestsQA.Components.ManagerPage;

namespace AtataUITestsQA.Components
{
    [Url("manager")]
    public class ManagerPage : Page<_>
    {
        [FindByPlaceholder("Search")]
        public SearchInput<_> Search { get; private set; }


        [FindByValue("Filter")]
        public Button<_> Filter { get; private set; }
        

        [FindByXPath("//a[@href='/manager/add']")]
        public LinkDelegate<PropertyBase, _> CreateListing { get; private set; }



        public Table<ManagerTableRow, _> Manager { get; private set; }

        public class ManagerTableRow : TableRow<_>
        {
            public Text<_> ListingName { get; private set; }

            [FindById("ListingStatus")]
            public Select<_> ListingStatus { get; private set; }


            [FindByTitle("Edit Listing")]
            public LinkDelegate<_> Edit { get; private set; }
        }
    }
}
