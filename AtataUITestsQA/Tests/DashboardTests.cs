using Atata;
using AtataApp.UITests.Components.DataProvider;
using AtataApp.UITests.Components.Enum;
using AtataApp.UITests.Components.PageObjects.Dashboard;
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


        [TestCase]
        public void CheckExchangePage()
        {
            var fromDate = new DateTime(2022, 10, 19);
            var toDate = new DateTime(2022, 10, 22);

            Go.To<LoginDashboard>().
                Email.Type(Credentials.MASTER_ADMIN_EMAIL).
                Password.Type(Credentials.MASTER_ADMIN_PASSWORD).
                SignIn.Click();


            Go.To<ContactsPage>().
                Tracker1031Tab().
                 

                Filter().
                    ExchangeId.Type("3215").
                    ExchangeStatus.Set(ExchangeStatus.UpExchange).
                    Name.Type("Qatest Tegqg").
                    Company.Type("Test Company").
                    FromExchangeAmount.Type("40000").
                    ToExchangeAmount.Type("50000").
                    FromIdentificationExpirationDate.Set(fromDate).
                    ToIdentificationExpirationDate.Set(toDate).

                    IndustryRole.Set(IndustryRole.Investor).
                    PreferredDealSize.Set(DealSize._25M_50M).
                    PreferredPropertyType.Set(PropertyType.Retail).
                    PreferredMarkets.Set(State.Connecticut).

                    Favorite.Should.BeChecked().
                    NotFavorite.Should.BeChecked().
                    Favorite.Uncheck().
                    Favorite.Should.Not.BeChecked().

                    WaitSeconds(5).

                    Apply().

                 Do(_ => _.Exchanges.Rows[x => x.Id == 3215], x =>
                 {
                     x.Should.Exist();
                     x.Status.SelectedOption.Should.Equal(ExchangeStatus.UpExchange);
                     x.Name.Should.Equal("Qatest Tegqg");
                     x.Company.Should.Equal("Test Company");
                     x.Role.Should.Equal(IndustryRole.Investor);
                     x.Amount.Should.Equal(45000);
                     x.Expiration.Should.Equal("10/28/2022");
                     x.Edit();
                 }).

                 WaitSeconds(5);

                   
        }
    }
}
