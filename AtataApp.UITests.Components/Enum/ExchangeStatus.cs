using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtataApp.UITests.Components.Enum
{
    public enum ExchangeStatus
    {
        [Term("In an Exchange")]
        Exchange,
        [Term("Not in an Exchange")]
        NoExchange,
        [Term("Exchange Upcoming")]
        UpExchange
    }
}
