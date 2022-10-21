using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtataApp.UITests.Components.Enum
{
    public enum Month
    {
        [Term("Jan")]
        January,
        [Term("Feb")]
        February,
        [Term("Mar")]
        March,
        [Term("Apr")]
        April,
        [Term("May")]
        May,
        [Term("Jun")]
        June,
        [Term("Jul")]
        July,
        [Term("Aug")]
        August,
        [Term("Sep")]
        September,
        [Term("Oct")]
        October,
        [Term("Nov")]
        November,
        [Term("Dec")]
        December
    }
}
