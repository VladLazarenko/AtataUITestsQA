using Atata;
using _ = AtataApp.UITests.Components.PageObjects.Dashboard.ContactsPage;

namespace AtataApp.UITests.Components.PageObjects.Dashboard
{
    [Url("contacts")]
    public class ContactsPage : Page<_>
    {
        [FindById("companies")]
        public ClickableDelegate<_> CompaniesTab { get; private set; }
        
        [FindById("1031Tracker")]
        public ClickableDelegate<Tracker1031Page, _> Tracker1031Tab { get; private set; }
    }
}
