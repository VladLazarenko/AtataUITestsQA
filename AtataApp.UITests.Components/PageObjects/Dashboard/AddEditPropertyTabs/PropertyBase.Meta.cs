using Atata;
using _ = AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs.PropertyBase;

namespace AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs
{
    public partial class PropertyBase
    {
        [FindById("swal2-content")]
        public Text<_> Message { get; private set; }
    }
}
