using Atata;
using AtataApp.UITests.Components.DataProvider;
using AtataApp.UITests.Components.Enum;
using AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs;
using AtataUITestsQA.Components;
using NUnit.Framework;
using System;

namespace AtataUITestsQA.Tests
{
    public class DashboardTests : UITestFixture
    {
        string puth = @"C:\Users\ribal\source\repos\DatumAutomationProject\images\24.jpg";
        string puthFile = @"C:\Users\ribal\source\repos\DatumAutomationProject\files\Example-CA.pdf";
        private string _property;
        string dir = "My First Test Folder";

        [TestCase("Atata")]
        public void CreateListings(string name)
        {
            _property = Generator.ListingName(name);

            Go.To<LoginDashboard>().
                Email.Type(Credentials.AGENT_EMAIL).
                Password.Type(Credentials.PASSWORD).
                SignIn.Click();


            Go.To<PropertyBase>().
                DetailsTab().
                    FillAddressSection().
                    FillListingDetailsSection(_property, "Jason Amiroso").
                    FillPropertyDetailsSection().

                PricingTab().
                    AskingPrice.SetRandom().

                PhotosVideosTab().
                    FillPhotoVideoSection().

                DocumentVaultTab().
                    OfferingMaterialsAccess.Rows[x => x.IndustryRole == IndustryRole.Broker].Access.Click().
                    OfferingMaterialsAccess.Rows[x => x.IndustryRole == IndustryRole.Other].Access.Click().

                    UploadFilesToFolder(DocumentVault.OM).
                    SidebarFolders.Items[x => x.Content == DocumentVault.DD].Click().
                    InnerItems[x => x.Name == "Financials"].Should.Exist().
                    InnerItems[x => x.Name == "Leases"].Should.Exist().
                    InnerItems[x => x.Name == "Other"].Should.Exist().
                    DeleteInnerFolder("Other").
                    UploadFilesToFolder("Financials").

                    AutoApprovedContact.Type(Credentials.PARENT_EMAIL).

                ConfidentialityAgreementTab().
                    LoadDefaultCa().
                    MakeCaNotRequired().

                DealTeamTab().
                   AddAgent(1).

                ProfileTab().
                    FillMetaSection().

                DetailsTab().
                    Stage.Set(Stage.Active).

                MetaTab().
                     Complete.Click().
                        Message.Should.Equal("Listing saved successfully.");
        }
    }
}
