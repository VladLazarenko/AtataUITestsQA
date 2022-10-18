using Atata;
using AtataApp.UITests.Components.Controls;
using _ = AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs.PropertyBase;

namespace AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs
{
    //[ScrollUp(TriggerEvents.BeforeClick)]
    public partial class PropertyBase : Page<_>
    {
        [FindByTitle]
        public Button<_> Next { get; private set; }
        
        [FindById("btnSave")]
        public Button<_> Save { get; private set; }

        [FindById]
        public Button<_> Cancel { get; private set; }

        [FindById("btnSubmitMetaSection")]
        [WaitForLayoutloaderIsHidden(TriggerEvents.AfterClick, AbsenceTimeout = 100)]
        public Button<_> Complete { get; private set; }

        [FindById("stepTab1")]
        [ScrollUp(TriggerEvents.BeforeClick)]
        public ClickableDelegate<_> DetailsTab { get; private set; }
        
        [FindById("stepTab2")]
        [ScrollUp(TriggerEvents.BeforeClick)]
        public ClickableDelegate<_> PricingTab { get; private set; }

        [FindById("stepTab3")]
        [ScrollUp(TriggerEvents.BeforeClick)]
        public ClickableDelegate<_> HighlightsTab { get; private set; }

        [FindById("stepTab4")]
        [ScrollUp(TriggerEvents.BeforeClick)]
        public ClickableDelegate<_> DescriptionTab { get; private set; }

        [FindById("stepTab5")]
        [ScrollUp(TriggerEvents.BeforeClick)]
        public ClickableDelegate<_> PhotosVideosTab { get; private set; }

        [FindById("stepTab6")]
        [ScrollUp(TriggerEvents.BeforeClick)]
        public ClickableDelegate<_> DocumentVaultTab { get; private set; }

        [FindById("stepTab7")]
        [ScrollUp(TriggerEvents.BeforeClick)]
        public ClickableDelegate<_> ConfidentialityAgreementTab { get; private set; }

        [FindById("stepTab8")]
        [ScrollUp(TriggerEvents.BeforeClick)]
        public ClickableDelegate<_> DealTeamTab { get; private set; }

        [FindById("stepTab9")]
        [ScrollUp(TriggerEvents.BeforeClick)]
        public ClickableDelegate<_> ProfileTab { get; private set; }

        [FindById("stepTab10")]
        [ScrollUp(TriggerEvents.BeforeClick)]
        public ClickableDelegate<_> MetaTab { get; private set; }
        
       
    }




}
