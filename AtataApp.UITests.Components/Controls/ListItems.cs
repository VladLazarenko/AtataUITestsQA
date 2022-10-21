using Atata;

namespace AtataApp.UITests.Components.Controls
{
    [ListItemDefinition("label", "list item")]
    [FindSettings(OuterXPath = ".//")]
    public class InnerLabelItem<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }

    [ListItemDefinition("span", "list item")]
    public class SpanListItem<TOwner> : Control<TOwner> 
        where TOwner : PageObject<TOwner>
    {
    
    
    } 
    
    [ListItemDefinition("div", "list item")]
    public class DivListItem<TOwner> : ListItem<TOwner> 
        where TOwner : PageObject<TOwner>
    {
    }
    
    [ListItemDefinition("*", "list item")]
    public class DefaultListItem<TOwner> : ListItem<TOwner> 
        where TOwner : PageObject<TOwner>
    {
    }
}
