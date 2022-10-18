using System;
using System.Collections.Generic;
using System.Text;

namespace AtataApp.UITests.Components.DataProvider
{
    public class Generator
    {
        public static string ListingName(string value) =>
           string.Format("{0} {1}", value, DateTime.Now.ToString("d.M.yy HH.mm.ss"));
    }
}
