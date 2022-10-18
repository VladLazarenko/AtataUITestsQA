using Atata;
using AtataApp.UITests.Components.Controls;
using AtataApp.UITests.Components.Parent.Components;

namespace AtataUITestsQA.Components
{
    using _ = AtataUITestsQA.Components.LoginParent;

    [Url("")]
    public  class LoginParent : Page<_>
    {

        [WaitForLoaderOverIsHidden(TriggerEvents.BeforeClick)]
        [WaitFor(Until.Visible, PresenceTimeout = 20)]
        [FindByXPath("//button[@label='Login']")]
        public Button<_> LoginPopup { get; private set; }


        [FindById("email")]
        public TextInput<_> EmailAddress { get; private set; }


        [FindById("password")]
        public PasswordInput<_> Password { get; private set; }
        

        [WaitForLoaderOverIsHidden(TriggerEvents.BeforeClick)]
        [WaitFor(Until.MissingOrHidden, TriggerEvents.AfterAnyAction)]
        [FindByXPath("//div[@class='footer']//button[@label='Login']")]
        public Button<HomePage,_> Login { get; private set; }
        

        [FindByXPath("//button[@label='Create New Account']")]
        public Button<RegisterParent, _> CreateNewAccount { get; private set; }
       

    }

   
}
