using Atata;
using AtataApp.UITests.Components.Controls;
using AtataApp.UITests.Components.Models.ModalControls;
using _ = AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs.PropertyBase;


namespace AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs
{
    public partial class PropertyBase
    {
        [FindById("LoadDefaultContent")]
        public Clickable<_> LoadDefaultCA { get; private set; }


        //[ControlDefinition("label[@for]")]
        [FindByXPath("//span[text()='CA Required']/following::div[1]")]
        public ClickableDelegate<CARequredPopup<_>, _> CARequired { get; private set; }



        [FindById("ConfidentialityAgreementContent_ifr")]
        public Frame<FormCA,_> FrameCA { get; private set; }

        public class FormCA : Page<FormCA>
        {
            [FindByCss("strong")]
            public Text<FormCA> Strong { get; private set; }

            public _ SwitchBack()
            {
                return SwitchToRoot<_>();
            }
        }
    }


    [PageObjectDefinition("div", ContainingClass = "swal2-container")]
    public class CARequredPopup<TNavigateTo> : DashboardAbstractModal<CARequredPopup<TNavigateTo>>
        where TNavigateTo : PageObject<TNavigateTo>
    {
        [FindByContent("Yes")]
        public ClickableDelegate<TNavigateTo, CARequredPopup<TNavigateTo>> Yes { get; private set; }

        [FindByContent("No")]
        public ClickableDelegate<TNavigateTo, CARequredPopup<TNavigateTo>> No { get; private set; }
        
        [FindById("swal2-content")]
        public Text<CARequredPopup<TNavigateTo>> Message { get; private set; }
    }
}
