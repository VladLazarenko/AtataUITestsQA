using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtataApp.UITests.Components.Models
{
    [ControlDefinition("*")]
    public class SmartDropdown<T, TOwner> : EditableField<T, TOwner> where TOwner : PageObject<TOwner>
    {
        [FindByClass("p-dropdown-label")]      // IN PROGRESS
        protected Text<TOwner> SelectedValue { get; private set; } // IN PROGRESS

        [FindByCss("input")]
        protected TextInput<TOwner> SmartInput { get; private set; }

        [FindSettings(OuterXPath = ".//", TargetName = "Items")]
        [TraceLog]
        protected UnorderedList<ListItem<TOwner>, TOwner> Options { get; private set; }

        protected override T GetValue()
        {
            string valueAsString = SelectedValue.Value;
            return ConvertStringToValue(valueAsString);
        }

        protected override void SetValue(T value)
        {
            string valueAsString = ConvertValueToString(value);
            SmartInput.Type(valueAsString);
            Options[x => x.Content == valueAsString].Click();
        }
    }




  
    
}
