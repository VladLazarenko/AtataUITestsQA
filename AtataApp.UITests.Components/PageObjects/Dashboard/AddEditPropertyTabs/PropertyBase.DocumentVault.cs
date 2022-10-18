using Atata;
using Atata.Bootstrap;
using AtataApp.UITests.Components.Controls;
using AtataApp.UITests.Components.Enum;
using AtataApp.UITests.Components.Models.ModalControls;
using System;
using _ = AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs.PropertyBase;

namespace AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs
{
    public partial class PropertyBase : Page<_>
    {
        [FindByCss("div.ChartToggle table")]
        public Table<OMAccessRow, _> OfferingMaterialsAccess { get; private set; }
        public class OMAccessRow : TableRow<_>
        {
            public Content<IndustryRole, _> IndustryRole { get; private set; }

            [FindSettings(OuterXPath = ".//")]
            [WaitForLayoutloaderIsHidden]
            [FindByClass("onoffswitch-label")]
            public Clickable<_> Access { get; private set; }
        }

        [FindById("treepanel-1063-bodyWrap")]
        [ControlDefinition("*")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAccess)]
        public CustomList<SpanListItem<_>, _> SidebarFolders { get; private set; }

        [FindById("button-1043-btnIconEl")]
        public ClickableDelegate<EditFolderPopup<_>, _> NewFolder { get; private set; }
        
        [FindById("button-1040-btnIconEl")]
        public ClickableDelegate<DeletePopup<_>, _> Delete { get; private set; }

        [FindById("button-1046-btnIconEl")]
        public ClickableDelegate<UploadPopup<_>, _> UploadModal { get; private set; }

        [FindById("ext-comp-1067")]
        public ControlList<InnerFile, _> InnerItems { get; private set; }

        [ControlDefinition("li", ContainingClass = "x-item")]
        public class InnerFile : Control<_>
        {
            [FindByClass("x-editable")]
            public Text<_> Name { get; private set; }
        }

        [FindByCss("div.om-access input")]
        [PressEnter(TriggerEvents.AfterSet)]
        public SearchInput<_> AutoApprovedContact { get; private set; }

    }






    [PageObjectDefinition("div[@role='alertdialog']", ContainingClass = "x-window")]
    [WindowTitle("Delete Folder")]
    public class DeletePopup<TNavigateTo> : FileExplorerAbsctractModal<DeletePopup<TNavigateTo>>
        where TNavigateTo : PageObject<TNavigateTo>
    {
        [FindById("button-1081-btnEl")]
        public ClickableDelegate<NotificationPopup<_>, DeletePopup<TNavigateTo>> Yes { get; private set; }

        [FindById("button-1082-btnEl")]
        public ClickableDelegate<TNavigateTo, DeletePopup<TNavigateTo>> No { get; private set; }


        [FindByClass("x-items")]
        public CustomList<SpanListItem<DeletePopup<TNavigateTo>>, DeletePopup<TNavigateTo>> Files { get; private set; }


    }



    [PageObjectDefinition("div", ContainingClass = "swal2-container")]
    public class NotificationPopup<TNavigateTo> : FileExplorerAbsctractModal<NotificationPopup<TNavigateTo>>
    where TNavigateTo : PageObject<TNavigateTo>
    {
        [FindById("swal2-content")]
        public Text<NotificationPopup<TNavigateTo>> Message { get; private set; }

        [FindByClass("swal2-close")]
        public ClickableDelegate<_,NotificationPopup<TNavigateTo>> Close { get; private set; }
    }



    [PageObjectDefinition("div[@role='dialog']", ContainingClass = "x-window")]
    public class UploadPopup<TNavigateTo> : FileExplorerAbsctractModal<UploadPopup<TNavigateTo>>
    where TNavigateTo : PageObject<TNavigateTo>
    {
        [FindByXPath("//input[@type='file' and @multiple='' and @accept='']")]
        public FileInput<UploadPopup<TNavigateTo>> AddFiles { get; private set; }


        [FindByClass("x-items")]
        [FindSettings(OuterXPath = ".//", TargetName = "Items")]
        public UnorderedList<SpanListItem<UploadPopup<TNavigateTo>>, UploadPopup<TNavigateTo>> AddedFiles { get; private set; }

        [ControlDefinition("*")]
        [FindById("button-1119-btnEl")]
        public ClickableDelegate<NotificationPopup<_>, UploadPopup<TNavigateTo>> Upload { get; private set; }
    }



    [PageObjectDefinition("div", ContainingClass = "x-message-box")]
    public class EditFolderPopup<TNavigateTo> : FileExplorerAbsctractModal<EditFolderPopup<TNavigateTo>>
        where TNavigateTo : PageObject<TNavigateTo>
    {
        [FindFirst]
        public TextInput<EditFolderPopup<TNavigateTo>> FolderName { get; private set; }

        [ControlDefinition("*")]
        [FindById("button-1080")]
        public ClickableDelegate<TNavigateTo, EditFolderPopup<TNavigateTo>> Ok { get; private set; }

        [ControlDefinition("*")]
        [FindById("button-1083")]
        public ClickableDelegate<TNavigateTo, EditFolderPopup<TNavigateTo>> Cancel { get; private set; }
    }






}
