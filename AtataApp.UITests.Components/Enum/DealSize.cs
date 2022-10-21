using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtataApp.UITests.Components.Enum
{
    public enum DealSize
    {
        [Term("$1M-$10M")]
        _1M_10M,
        [Term("$10M-$25M")]
        _10M_25M,
        [Term("$25M-$50M")]
        _25M_50M,
        [Term("$50M-$100M")]
        _50M_100M,
        [Term("$100M+")]
        More100M

    }
}
