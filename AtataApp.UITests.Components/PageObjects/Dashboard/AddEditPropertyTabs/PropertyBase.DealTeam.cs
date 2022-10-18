using Atata;
using AtataApp.UITests.Components.Controls;
using _ = AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs.PropertyBase;

namespace AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs
{
    public partial class PropertyBase : Page<_>
    {
       
        public ControlList<AgentItem,_> Agents { get; private set; }

        [ControlDefinition("div[contains(@class,'AgentSection')]/div")]
        public class AgentItem : Control<_>
        {
            [FindByCss("label")]
            public Text<_> Agent { get; private set; }

            [FindByXPath("input[@placeholder='Please Select']")]
            public TextInput<_> Input { get; private set; }

            [FindSettings(OuterXPath = ".//", TargetName = "Items")]
            public UnorderedList<DivListItem<_>, _> ListItem { get; private set; }

            [FindByCss("span.switch")]
            public Clickable<_> NotificationsToggle { get; private set; }
        }
    }
}
