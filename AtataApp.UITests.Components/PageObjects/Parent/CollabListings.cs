using Atata;
using _ = AtataApp.UITests.Components.PageObjects.Parent.CollabListings;

namespace AtataApp.UITests.Components.PageObjects.Parent
{
    public class CollabListings : Page<_>
    {

    }




    public class PaginationParent : Page<_>
    {
        [Name("Main")]
        public MuiPagination<_> Pagination { get; private set; }
    }
}
