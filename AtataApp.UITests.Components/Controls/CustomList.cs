using Atata;

namespace AtataApp.UITests.Components.Controls
{
    [ControlDefinition("*", ComponentTypeName = "custom list")]
    [FindSettings(OuterXPath = ".//", TargetName = "Items")]
    public class CustomList<TItem, TOwner> : ItemsControl<TItem, TOwner> where TItem : Control<TOwner> where TOwner : PageObject<TOwner>
    {
    }
}
