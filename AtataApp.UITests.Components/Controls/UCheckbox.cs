using Atata;

namespace AtataApp.UITests.Components.Controls
{

    [ControlDefinition("*")]
    public class UCheckbox<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        [FindByCss("input")]
        [ClicksUsingScript]
        public CheckBox<TOwner> State { get; set; }

        [ControlDefinition("label")]
        [WaitForLoaderOverIsHidden(TriggerEvents.BeforeAccess, Until.MissingOrHidden)]
        public ClickableDelegate<TOwner> Check { get; set; }
        
        [ControlDefinition("label")]
        [WaitForLoaderOverIsHidden(TriggerEvents.BeforeAccess, Until.MissingOrHidden)]
        public ClickableDelegate<TOwner> Uncheck { get; set; }
    }
}
