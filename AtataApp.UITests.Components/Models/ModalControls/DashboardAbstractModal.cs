using Atata;

namespace AtataApp.UITests.Components.Models.ModalControls
{

    [WindowTitleElementDefinition(ContainingClass = TitleClass)]
    public abstract class DashboardAbstractModal<TOwner> : PopupWindow<TOwner>
   where TOwner : DashboardAbstractModal<TOwner>
    {
        private const string TitleClass = "x-title-text";

        protected DashboardAbstractModal(params string[] windowTitleValues)
            : base(windowTitleValues)
        {
        }

        [FindByClass(TitleClass)]
        public Text<TOwner> ModalTitle { get; private set; }
    }
}
