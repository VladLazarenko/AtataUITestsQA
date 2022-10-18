using Atata;
using _ = AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs.PropertyBase;

namespace AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs
{
    public partial class PropertyBase : Page<_>
    {
        [FindById("AskingPrice")]
        [RandomizeNumberSettings(10000000, 900000000)]
        public NumberInput<_> AskingPrice { get; private set; }
    }
}
