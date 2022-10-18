using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtataApp.UITests.Components.Enum
{
    public enum Country
    {
        [Term("Please Select")]
        None,
        UnitedStates,
        Albania,
        Andorra
    }


    public enum CountryInitials
    {
        US,
        UA
    }
}
