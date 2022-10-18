using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtataApp.UITests.Components.Enum
{
    public enum PropertyType
    {
        Office,
        Industrial,
        Retail,
        Multifamily,
        Healthcare,
        Hospitality,
        [Term("Land/Development")]
        LandDevelopment
    }
}
