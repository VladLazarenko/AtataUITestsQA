using Atata;

namespace AtataApp.UITests.Components.StepDefinitions
{
    public abstract class BaseSteps 
    {
        protected static TPageObject On<TPageObject>() where TPageObject : PageObject<TPageObject>
            =>
            (AtataContext.Current.PageObject as TPageObject)
                ?? Go.To<TPageObject>(navigate: false);
    }
}
