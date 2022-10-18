using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtataApp.UITests.Components.Models
{
    [ControlDefinition("*")]
    public class AdvancedCheckBoxList<T, TOwner> : EditableField<T, TOwner> where TOwner : PageObject<TOwner>
    {
        [FindByClass("anchor")]
        [TraceLog]
        protected Text<TOwner> SelectedValue { get; private set; }

        [FindByClass("checkbox-accordian")]        
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
        }
    }

    [ListItemDefinition("label", ContainingClass = "kt-checkbox")]
    public class CheckboxListItem<TOwner> : Control<TOwner> where TOwner : PageObject<TOwner>
    {
    }


}
