using Atata;
using AtataApp.UITests.Components.Enum;
using _ = AtataApp.UITests.Components.Parent.Components.Stripe;

namespace AtataApp.UITests.Components.Parent.Components
{
    public class Stripe : Page<_>
    {
        [FindByCss("div.ReadOnlyFormField-title")]
        public Text<_> Email { get; private set; }

        [FindById("cardNumber")]
        public TextInput<_> CardNumber { get; private set; }

        [FindById("cardExpiry")]
        public TextInput<_> CardExpiry { get; private set; }

        [FindById("cardCvc")]
        public TextInput<_> CardCvc { get; private set; }

        [FindById("billingName")]
        public TextInput<_> BillingName { get; private set; }

        [SelectsOptionByValue]
        [FindById("billingCountry")]
        public Select<CountryInitials, _> BillingCountry { get; private set; }

        [FindById("billingAddressLine1")]
        public TextInput<_> BillingAddressLine1 { get; private set; }

        [FindById("billingAddressLine2")]
        public TextInput<_> BillingAddressLine2 { get; private set; }

        [FindById("billingLocality")]
        public TextInput<_> BillingLocality { get; private set; }

        [FindById("billingAdministrativeArea")]
        public Select<State,_> BillingAdministrativeArea { get; private set; }

        [FindById("billingPostalCode")]
        public TextInput<_> BillingPostalCode { get; private set; }

        [WaitFor(Until.MissingOrHidden, TriggerEvents.AfterClick, AbsenceTimeout = 15)]
        [FindByCss("button.SubmitButton")]
        public Button<HomePage, _> Submit { get; private set; }
        
        [FindByCss("div.ProductSummaryDescription span")]
        public Text<_> Amount { get; private set; }

    }
}
