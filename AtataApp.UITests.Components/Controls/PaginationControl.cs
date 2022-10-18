using Atata;

namespace AtataApp.UITests.Components.Controls
{
    [ControlDefinition("*")]
    public class PaginationControl<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
