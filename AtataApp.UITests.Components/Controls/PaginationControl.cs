using Atata;

namespace AtataApp.UITests.Components.Controls
{
    
    [ControlDefinition("ul", ContainingClass = "ngx-pagination", ComponentTypeName = "pagination")]
    public class PaginationControl<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        [FindByXPath("a[@aria-label='Previous page']")]
        [WaitForLoaderOverIsHidden(TriggerEvents.BeforeClick, Until.VisibleThenMissingOrHidden)]
        public ClickableDelegate<TOwner> Privious { get; private set; }

        [FindByXPath("a[@aria-label='Next page']")]
        [WaitForLoaderOverIsHidden(TriggerEvents.BeforeClick, Until.VisibleThenMissingOrHidden)]
        public ClickableDelegate<TOwner> Next { get; private set; }

        [FindByXPath("li[contains(@class, 'current')]/span[2]")]
        [WaitForLoaderOverIsHidden(TriggerEvents.BeforeClick, Until.VisibleThenMissingOrHidden)]
        public Clickable<TOwner> SelectedPageButton { get; private set; }

        public ValueProvider<int, TOwner> SelectedPageNumber =>
            CreateValueProvider("selected page number", () => int.Parse(SelectedPageButton.Content.Value));

        public Clickable<TOwner> FindButtonByPageNumber(int number)
        {
            string numberAsString = number.ToString();
            return Controls.CreateClickable(numberAsString, 
                new FindByContentAttribute(numberAsString), 
                new WaitForLoaderOverIsHidden(TriggerEvents.BeforeClick, Until.VisibleThenMissingOrHidden));
        }
        
    
    }
}
