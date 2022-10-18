using Atata;
using _ = AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs.PropertyBase;

namespace AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs
{
    public partial class PropertyBase : Page<_>
    {
        [FindById("MainPropertyFile")]
        public FileInput<_> MainPropertyImage { get; private set; }

        [FindById("BannerImage")]
        public FileInput<_> BannerImage { get; private set; }

        [FindById("PropertyMainVideo")]
        public TextInput<_> PropertyMainVideo { get; private set; }
        
        [ControlDefinition("input")]
        [FindByXPath("//*[@class='dz-hidden-input'][@accept='.png,.jpg,.jpeg']")]
        public HiddenInput<_> ListingPageSlideshow { get; private set; }

        [FindByXPath("//*[@id='IsImageRight']/following::span[1]")]
        public Clickable<_> IHaveTheRightToPublish { get; private set; }
    }
}
