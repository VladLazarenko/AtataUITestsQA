using Atata;

namespace AtataApp.UITests.Components.Models
{
    [ControlDefinition("*")]
    public class BulkCheckboxList<T, TOwner> : EditableField<T, TOwner> where TOwner : PageObject<TOwner>
    {
        [FindByClass("p-dropdown-label")]
        [TraceLog]
        protected Text<TOwner> SelectedValue { get; private set; }   // NEED TO FIX


        [FindByCss("ul.items")]
        [FindSettings(OuterXPath = ".//", TargetName = "Items")]
        [TraceLog]
        protected UnorderedList<CheckboxListItem<TOwner>, TOwner> Options { get; private set; }

        protected override T GetValue()
        {
            string valueAsString = SelectedValue.Value;

            return ConvertStringToValue(valueAsString);
        }

        protected override void SetValue(T value)
        {
            string valueAsString = ConvertValueToString(value);
            Click();
            Options[x => x.Content == valueAsString].Click();
            Click();
        }
    }
}
