using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtataApp.UITests.Components.Controls
{    
    public class WaitForLoaderOverIsHidden : WaitForElementAttribute
    {
        //public WaitForLoaderOverIsHidden(TriggerEvents on = TriggerEvents.Init, Until until = Until.VisibleThenMissingOrHidden)
        public WaitForLoaderOverIsHidden(TriggerEvents on = TriggerEvents.Init, Until until = Until.MissingOrHidden)
            : base (WaitBy.Id, "loadingover", until, on)
        {
            PresenceTimeout = 1;
            ThrowOnPresenceFailure = false;

            AbsenceTimeout = 10;
        }
    }
    
    public class WaitForProgressBarIsHidden : WaitForElementAttribute
    {
        public WaitForProgressBarIsHidden(TriggerEvents on = TriggerEvents.Init)
            : base (WaitBy.Id, "progressBarOver", Until.VisibleThenMissingOrHidden, on)
        {
            PresenceTimeout = 1;
            ThrowOnPresenceFailure = false;

            AbsenceTimeout = 10;
        }
    }
    
    public class WaitForLayoutloaderIsHidden : WaitForElementAttribute
    {
        public WaitForLayoutloaderIsHidden(TriggerEvents on = TriggerEvents.Init)
            : base (WaitBy.Id, "layoutloader", Until.VisibleThenMissingOrHidden, on)
        {
            PresenceTimeout = 1;
            ThrowOnPresenceFailure = false;

            AbsenceTimeout = 10;
        }
    }
    
    public class WaitForTableIsLoaded : WaitForElementAttribute
    {
        public WaitForTableIsLoaded(TriggerEvents on = TriggerEvents.Init, Until until = Until.VisibleThenMissingOrHidden)
            : base (WaitBy.XPath, "//*[contains(text(), 'Processing...')]", until, on)
        {
            PresenceTimeout = 1;
            ThrowOnPresenceFailure = false;

            AbsenceTimeout = 10;
        }
    }
}
