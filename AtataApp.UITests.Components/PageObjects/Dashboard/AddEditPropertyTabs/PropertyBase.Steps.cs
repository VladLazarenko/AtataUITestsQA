using Atata;
using AtataApp.UITests.Components.DataProvider;
using AtataApp.UITests.Components.Enum;
using _ = AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs.PropertyBase;

namespace AtataApp.UITests.Components.PageObjects.Dashboard.AddEditPropertyTabs
{
    public partial class PropertyBase : Page<_>
    {
        public _ FillAddressSection()
        {
                Address1.SetRandom().
                City.SetRandom().
                State.SetRandom().
                ZipCode.SetRandom().

                Country.Should.Equal(Enum.Country.None).
                Country.Set(Enum.Country.UnitedStates).
                Country.Should.Equal(Enum.Country.UnitedStates).

                Latitude.SetRandom().
                Longitude.SetRandom();
            return this;
        }
        
        public _ FillListingDetailsSection(string listingName, string sellerContact)
        {
            ListingName.Type(listingName).
            Stage.Should.Equal(Enum.Stage.Draft).
            ListingStatus.SetRandom().
            SellerContact.Set(sellerContact).
            EstimatedCommission.SetRandom();
            return this;
        }
        
        public _ FillPropertyDetailsSection()
        {
            PropertyType.SetRandom().
            SquareFeet.SetRandom().
            Occupancy.SetRandom();
            return this;
        }
        
        public _ FillPhotoVideoSection()
        {
            string puth = @"C:\Users\ribal\source\repos\DatumAutomationProject\images\24.jpg";
            MainPropertyImage.Type(puth).
            BannerImage.Type(puth).
            ListingPageSlideshow.Type(puth).
            IHaveTheRightToPublish.Click();
            return this;
        }
        
        public _ FillMetaSection()
        {
            ProfileDealSize.Set("$10M-$25M").
            ProfilePropertyType.SetRandom().
            ProfileInvestmentStrategy.Set("Core").
            ProfileReturnMetrics.Set("IRR").
            ProfileMarkets.SetRandom();
            return this;
        }
        
        public _ UploadFilesToFolder(string folderName)
        {
            string puthFile = @"C:\Users\ribal\source\repos\DatumAutomationProject\files\Example-CA.pdf";

            SidebarFolders.Items[x => x.Content == folderName].Click().

            UploadModal().
                AddFiles.Type(puthFile).
                AddedFiles.Items[x => x.Content == "Example-CA"].Should.Exist().
                Upload().
                    Message.Should.Contain("Document(s) uploaded successfully.").
                    Close().

            InnerItems[x => x.Name == "Example-CA"].Should.Exist();
            return this;
        }

        public _ DeleteInnerFolder(string folderName)
        {
            InnerItems[x => x.Name == folderName].Click().
            Delete().
                Files.Items[x => x.Content == folderName].Should.Exist().
                Yes().
                    Message.Should.Contain("Document(s) deleted successfully.").
                    Close().

            InnerItems[x => x.Name == folderName].Should.Not.Exist();
            return this;
        }


        public _ LoadDefaultCa()
        {
            LoadDefaultCA.Click().
                FrameCA.DoWithin(x => x.Strong.Should.Contain("CONFIDENTIALITY AND NON-DISCLOSURE AGREEMENT"));
            return this;
        }
        
        public _ MakeCaNotRequired()
        {
            CARequired().
                Yes().WaitSeconds(1);
            return this;
        }
        
        public _ AddAgent(int serialNumber, string agentUserName = Credentials.AGENT_USER_NAME)
        {
            Do(_ => _.Agents[x => x.Agent == $"Agent {serialNumber}"], x =>
            {
                x.Input.Type(agentUserName);
                x.ListItem[x => x.Content == agentUserName].Click();
                x.NotificationsToggle.Click();
            });
            return this;
        }
    }
}
