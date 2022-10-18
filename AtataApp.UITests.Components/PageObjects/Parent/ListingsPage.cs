using Atata;
using AtataApp.UITests.Components.Controls;
using AtataApp.UITests.Components.Enum;
using _ = AtataApp.UITests.Components.Parent.Components.ListingsPage;


namespace AtataApp.UITests.Components.Parent.Components
{
    [Url("listings")]
    public class ListingsPage : Page<_>
    {

        [PressEnter(TriggerEvents.AfterAnyAction)]
        [WaitForLoaderOverIsHidden(TriggerEvents.BeforeAccess, AbsenceTimeout = 25)]
        [FindByPlaceholder("Search by Location, Property Type, or Description")]
        public TextInput<_> Search { get; private set; }




        [FindByCss("app-listing-card")]
        public ControlList<PropertyItem,_> ViewProperty { get; private set; }


        [ControlDefinition("app-listing-card")]
        public class PropertyItem : Control<_>
        {
            [FindByCss("div.content-header.pointer a")]
            public Text<_> Title { get; private set; }

            [WaitForLoaderOverIsHidden(TriggerEvents.BeforeAccess)]
            [WaitSeconds(2, TriggerEvents.BeforeClick)]
            [FindByCss("div.content-header.pointer a")]
            public Link<PropertyDetailPage,_> Link { get; private set; }

            [FindByCss("div.content-header.pointer span")]
            public Text<_> AskingPrice { get; private set; }
            
            [FindByCss("div.content div.description")]
            public Text<_> Location { get; private set; }
            
            [FindByCss("div.content div.author a")]
            public Link<_> Author { get; private set; }
            
            [FindByCss("div.content div.footer span")]
            public Content<PropertyType, _> PropertyType { get; private set; }

            [FindByXPath("//div[@class='footer']/span[2]")]
            public Content<ListingsStatus, _> ListingsStatus { get; private set; }
        }
    }
}
