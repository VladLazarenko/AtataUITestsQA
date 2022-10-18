using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtataApp.UITests.Components.Models
{

    [ControlDefinition("p-dropdown", ComponentTypeName = "select")]
    public class PDropdown<T, TOwner> : EditableField<T, TOwner> where TOwner : PageObject<TOwner>
    {
        [FindByClass("p-dropdown-label")]
        [TraceLog]
        protected Text<TOwner> SelectedValue { get; private set; }


        [FindByClass("p-dropdown-items-wrapper", ScopeSource = ScopeSource.Page)]
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
            Click();
            Options[x => x.Content == valueAsString].Click();
        }
    }
}
