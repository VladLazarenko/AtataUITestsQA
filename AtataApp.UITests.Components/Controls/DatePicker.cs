using Atata;
using AtataApp.UITests.Components.Enum;
using System;

namespace AtataApp.UITests.Components.Controls
{
    [ControlDefinition("input")]
    public class DatePicker<T, TOwner> : EditableField<T, TOwner> where TOwner : PageObject<TOwner>
    {
        [FindByCss("th.datepicker-switch", ScopeSource = ScopeSource.Page)]
        protected Clickable<TOwner> MonthSwitch { get; private set; }  


        [FindByXPath("table[@class='table-condensed']", ScopeSource = ScopeSource.Page)]
        [FindSettings(OuterXPath = ".//", TargetName = "Items")]
        [ListItemDefinition("tbody")]
        [TraceLog]
        protected UnorderedList<SpanListItem<TOwner>, TOwner> Months { get; private set; }
        
        
        [FindByXPath("table[@class=' table-condensed']", ScopeSource = ScopeSource.Page)]
        [FindSettings(OuterXPath = ".//", TargetName = "Items")]
        [ListItemDefinition("tbody")]
        [TraceLog]
        protected UnorderedList<DefaultListItem<TOwner>, TOwner> Days { get; private set; }



        protected override T GetValue()
        {
            return GetValue();
        }

        protected override void SetValue(T value)
        {
            DateTime dateTime = Convert.ToDateTime(value);

            Click();

            string date = dateTime.Day.ToString();
            string month = dateTime.Date.ToString("MMM");

            MonthSwitch.Click();
            Months[x => x.Content == month].Click();

            Days[x => x.Content == date].Click();
        }
    }
}

