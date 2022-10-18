using Atata;
using AtataApp.UITests.Components.Controls;
using _ = AtataApp.UITests.Components.Parent.Components.PropertyDetailPage;

namespace AtataApp.UITests.Components.Parent.Components
{
    public class PropertyDetailPage : Page<_>
    {
        [WaitForLoaderOverIsHidden(TriggerEvents.BeforeClick)]
        [WaitFor(Until.Visible, PresenceTimeout = 10)]
        [FindByAttribute("label", "OFFERING MATERIALS")]
        public Button<DocumentVaultPopup<_>,_> OfferingMaterials { get; private set; }


        [FindById("npcg_d_options")]
        public Link<_> ClickHere { get; private set; }





    }




    [PageObjectDefinition("div[@role='dialog']", ContainingClass = "document-vault")]
    public class DocumentVaultPopup<TNavigateTo> : PopupWindow<DocumentVaultPopup<TNavigateTo>>
        where TNavigateTo : PageObject<TNavigateTo>
    {
        [FindByCss("span.p-dialog-title")]
        public Text<DocumentVaultPopup<TNavigateTo>> FolderName { get; private set; }

        [FindByCss("span.p-dialog-header-close-icon")]
        public ClickableDelegate<TNavigateTo, DocumentVaultPopup<TNavigateTo>> Close { get; private set; }

        [FindById("checkbox_id")]
        [ClicksUsingScript]
        public CheckBox<DocumentVaultPopup<TNavigateTo>> CheckAll { get; private set; }

        [FindByCss("div.document-section")]
        public ControlList<Row, DocumentVaultPopup<TNavigateTo>> DocumentSection { get; private set; }

        [FindById("download-button")]
        public ClickableDelegate<TNavigateTo, DocumentVaultPopup<TNavigateTo>> Download { get; private set; }



        [ControlDefinition("p-treenode/li")]
        public class Row : Control<DocumentVaultPopup<TNavigateTo>>
        {
            [ControlDefinition("div")]
            [FindByClass("p-checkbox-box")]
            [ClicksUsingScript]
            public CheckBox<DocumentVaultPopup<TNavigateTo>> Checkbox { get; private set; }

            [FindByCss("div.name-label")]
            public Text<DocumentVaultPopup<TNavigateTo>> FileName { get; private set; }
            
            [FindByCss("div.date-label")]
            public Text<DocumentVaultPopup<TNavigateTo>> CreatedDate { get; private set; }
            
            [FindByCss("button.p-tree-toggler")]
            [WaitForLoaderOverIsHidden(TriggerEvents.BeforeClick)]
            public ClickableDelegate<DocumentVaultPopup<TNavigateTo>> Expand { get; private set; }



            [FindByCss("ul")]
            public ControlList<ExpandedRow, DocumentVaultPopup<TNavigateTo>> ExpandedFiles { get; private set; }

            [ControlDefinition("p-treenode/li")]
            public class ExpandedRow : Control<DocumentVaultPopup<TNavigateTo>>
            {
                [ControlDefinition("div")]
                [FindByClass("p-checkbox-box")]
                [ClicksUsingScript]
                public CheckBox<DocumentVaultPopup<TNavigateTo>> Checkbox { get; private set; }

                [FindByCss("div.name-label")]
                public Text<DocumentVaultPopup<TNavigateTo>> FileName { get; private set; }

                [FindByCss("div.date-label")]
                public Text<DocumentVaultPopup<TNavigateTo>> CreatedDate { get; private set; }
            }
        }
































        public Button<TNavigateTo, DocumentVaultPopup<TNavigateTo>> Confirm { get; private set; }

        public Button<TNavigateTo, DocumentVaultPopup<TNavigateTo>> Cancel { get; private set; }
    }
}
