using Atata;
using AtataApp.UITests.Components.Controls;
using _ = AtataApp.UITests.Components.PageObjects.Parent.CollabListings;

namespace AtataApp.UITests.Components.PageObjects.Parent
{
    [Url("collab")]
    public class CollabListings : Page<_>
    {
        public PaginationControl<_> Pagination { get; private set; }
    }




}
