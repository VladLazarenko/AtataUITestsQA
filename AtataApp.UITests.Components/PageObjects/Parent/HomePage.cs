using Atata;
using AtataApp.UITests.Components.Controls;
using AtataApp.UITests.Components.Enum;
using _ = AtataApp.UITests.Components.Parent.Components.HomePage;

namespace AtataApp.UITests.Components.Parent.Components
{
    public class HomePage : Page<_>
    {
        [FindByAttribute("label")]
        public Button< _> Save { get; private set; }
        
        [WaitForLoaderOverIsHidden(TriggerEvents.BeforeClick)]
        [WaitForLoaderOverIsHidden(TriggerEvents.AfterClick)]
        [FindByAttribute("label")]
        public Button<Stripe,_> IAgree { get; private set; }


        [FindByCss("app-subscriptions")]
        public ControlList<PlanItem, _> Subscriptions { get; private set; }


        [ControlDefinition("div", ContainingClass = "plan")]
        public class PlanItem : Control<_>
        {
            [FindByCss("div.header h3")]
            public Content<Subscription, _> PlanTitle { get; private set; }
            
            [FindByCss("div.header span.plan-tag")]
            public Text<_> PlanTag { get; private set; }
            
            [FindByCss("div.payment span")]
            public Text<_> Cost { get; private set; }
        }

        [WaitFor(Until.Visible, TriggerEvents.BeforeAccess, PresenceTimeout = 15)]
        [FindByXPath("//p[text()='Your subscription has been successfully activated.']")]
        public Text<_> SubscriptionHasBeenActivedMessage { get; private set; }
    }
}

