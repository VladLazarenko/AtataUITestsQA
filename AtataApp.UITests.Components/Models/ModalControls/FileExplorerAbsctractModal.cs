using Atata;

namespace AtataApp.UITests.Components.Models.ModalControls
{
    [WindowTitleElementDefinition(ContainingClass = TitleClass)]
    public abstract class FileExplorerAbsctractModal<TOwner> : PopupWindow<TOwner>
    where TOwner : FileExplorerAbsctractModal<TOwner>
    {
        private const string TitleClass = "x-title-text";

        protected FileExplorerAbsctractModal(params string[] windowTitleValues)
            : base(windowTitleValues)
        {
        }

        [FindByClass(TitleClass)]
        public Text<TOwner> ModalTitle { get; private set; }
    }
}
