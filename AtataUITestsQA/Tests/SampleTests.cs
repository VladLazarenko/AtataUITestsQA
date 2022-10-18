using Atata;
using AtataApp.UITests.Components.AppData;
using AtataApp.UITests.Components.DataProvider;
using AtataApp.UITests.Components.Enum;
using AtataApp.UITests.Components.Models;
using AtataApp.UITests.Components.Parent.Components;
using AtataUITestsQA.Components;
using NUnit.Framework;
using PutsboxWrapper;
using AtataApp.UITests.Components.StepDefinitions;

namespace AtataUITestsQA
{
    public class SampleTests : UITestFixture
    {
        string avatar = @"C:\Users\ribal\source\repos\DatumAutomationProject\images\contact.png";
        string listing = "Security Level 13.4.22 11.44.36";
        string _property;

        [Test]
        public void SampleTest()
        {
            Go.To<LoginParent>().

                LoginPopup.Click().
                CreateNewAccount.ClickAndGo().WaitSeconds(1).
                    EmailAddressInput.SetRandom(out string email).
                    Password.Type(Credentials.PASSWORD).
                    PasswordConfirm.Type(Credentials.PASSWORD).
                    CreateNewAccount.Click().WaitSeconds(2).
                        FirstName.SetRandom().
                        LastName.SetRandom().
                        Title.SetRandom().
                        Company.SetRandom().
                        Street.SetRandom().
                        Suite.SetRandom().
                        City.SetRandom().

                        State.Set(State.Alaska).
                        Country.Set(Country.UnitedStates).
                        ZipCode.SetRandom().
                        WorkPhone.Set("423-521-9196").
                        MobilePhone.Set("423-521-9196").

                        LinkedIn.SetRandom().
                        EmailAddressInput.Should.Equal(email).
                        EmailConfirm.Should.Equal(email).

                        IndustryRole.Set(IndustryRole.Broker).
                        BrokerType.Set(BrokerType.Sales).

                    GotItCookies.Click().

                        PencilIcon.Click().
                        AddPhoto.Set(avatar).
                        SavePhoto.Click().

                    Next.Click().

                        ExchangeStatus.Set(ExchangeStatus.NoExchange).

                        PreferredDealSize.Set("$50M-$100M").
                        PreferredDealSize.Set("$10M-$25M").

                        PreferredPropertyType.SetRandom().

                        PreferredInvestmentStrategy.Set("Core-Plus").
                        PreferredInvestmentStrategy.Set("Development").

                        PreferredReturnMetrics.Set("Cap Rate").
                        PreferredReturnMetrics.Set("IRR").
                        PreferredReturnMetrics.Set("Return-on-Cost").

                        PreferredMarkets.SetRandom().

                    Complete.Click();

            Go.ToUrl(Putsbox.GetLinkFromEmailWithValue(email, EmailLink.COMPLETE_REGISTRATION));

            Go.To<LoginParent>(navigate: false).
                EmailAddress.Type(email).
                Password.Type(Credentials.PASSWORD).
                Login.ClickAndGo().

             Do(_ => _.Subscriptions[x => x.PlanTitle == Subscription.Basic], x =>
             {
                 x.PlanTitle.Should.Exist();
                 x.PlanTag.Should.Contain("Select Plan");
                 x.Cost.Should.Contain(PlanAmount.BASIC);
                 x.PlanTitle.Click();
             }).

            Subscriptions[x => x.PlanTitle == Subscription.Lite].Click().
            Save.Click().
            IAgree.ClickAndGo().

            Amount.Should.Contain(PlanAmount.LITE).
            Email.Should.Contain(email).

            CardNumber.Type(BillingData.VALID_VISA_CARD_NUMBER).
            CardExpiry.Type(BillingData.VALID_CARD_EXPIRY).
            CardCvc.Type(BillingData.VALID_CARD_CVC).

            BillingName.Type(BillingData.CARD_NAME).

            BillingCountry.Set(CountryInitials.US).

            BillingAddressLine1.Type(BillingData.ADDRESS_1).
            BillingAddressLine2.Type(BillingData.ADDRESS_2).

            BillingLocality.Type(BillingData.CITY).
            BillingPostalCode.Type(BillingData.POSTAL_CODE).

            BillingAdministrativeArea.SetRandom().

            Submit.ClickAndGo().
            SubscriptionHasBeenActivedMessage.Should.BeVisible().

            WaitSeconds(20);




        }

        [TestCase("Atata")]
        public void GetAccessToDocumentVault(string property)
        {
            _property = SimpleDbRequest.Get_Last_Active_Listing_With_Name(property);

            Go.To<LoginParent>().
                LoginPopup.Click().
                EmailAddress.Type(Credentials.PARENT_EMAIL).
                Password.Type(Credentials.PASSWORD).
                Login.Click();


            Go.To<ListingsPage>().

                 Search.Type(_property).



                  Do(_ => _.ViewProperty[x => x.Title == _property], x =>
                  {
                      x.Title.Should.Exist();
                      x.PropertyType.Should.Equal(PropertyType.Healthcare);

                  }).
                 ViewProperty[x => x.Title == _property].Link.ClickAndGo().

                 OfferingMaterials.ClickAndGo().
                    FolderName.Should.Equal("Offering Materials").
                     
                    DocumentSection[x => x.FileName == "file1.pdf"].Should.Exist().
                    DocumentSection[x => x.FileName == "file2.avux"].Should.Exist().
                    DocumentSection[x => x.FileName == "First"].Should.Exist().
                    DocumentSection[x => x.FileName == "Second"].Should.Exist().


                     Do(_ => _.DocumentSection[x => x.FileName == "Second"], x =>
                     {
                         x.FileName.Should.Exist();
                         x.Expand().WaitSeconds(1);
                         
                         x.ExpandedFiles[x => x.FileName == "file1.docx"].Should.Exist();
                         x.ExpandedFiles[x => x.FileName == "file1.docx"].CreatedDate.Should.Equal("October 14, 2022");
                         x.ExpandedFiles[x => x.FileName == "file1.docx"].Checkbox.Check();

                     }).

                     Download();

            AtataContext.Current.Artifacts.Should.WithinSeconds(10).ContainFiles("file1.docx");
                        








                     //WaitSeconds(10);









                 //ClickHere.Click().

                 //Do(_ => _.Files[x => x.FileName == "Unexecuted CA_SecurityLevel13422114436.pdf"], x =>
                 //{
                 //    x.FileName.Should.Exist();
                 //    x.DateAdded.Should.Equal("May 05, 2022");
                 //    x.Checkbox.Click();
                 //}).




                // Download.Click();



            
        }
    }
}
