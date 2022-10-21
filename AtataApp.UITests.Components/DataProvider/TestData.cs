using System;
using System.Collections.Generic;
using System.Text;

namespace AtataApp.UITests.Components.DataProvider
{
    public class Credentials
    {
        public const string PARENT_EMAIL = "parent-user-qa@putsbox.com";
        public const string AGENT_EMAIL = "vlad-qa-lazarenko@putsbox.com";
        public const string MASTER_ADMIN_EMAIL = "_tu@zetmail.com";
        public const string PASSWORD = "Test123!";
        public const string MASTER_ADMIN_PASSWORD = "Welcome@123";
        public const string AGENT_USER_NAME = "Vlad Lazarenko";
    }


    public class BillingData
    {
        public const string VALID_VISA_CARD_NUMBER = "4242 4242 4242 4242";
        public const string VALID_CARD_EXPIRY = "02/24";
        public const string VALID_CARD_CVC = "02/24";

        public const string CARD_NAME = "Test Card Name";
        public const string ADDRESS_1 = "Test Address 1";
        public const string ADDRESS_2 = "Test Address 2";
        public const string CITY = "Test City";
        public const string POSTAL_CODE = "4564564";
    }

    public class PlanAmount
    {
        public const string LITE = "49";
        public const string BASIC = "399";
    }


    public class EmailLink
    {
        public const string COMPLETE_REGISTRATION = "Complete Registration";
    }
    
    
    public class DocumentVault
    {
        public const string INTERNAL = "Internal";
        public const string PUBLIC = "Public";
        public const string OM = "Offering Materials";
        public const string DD = "Due Diligence";
        public const string HIGH = "High";
    }

    public class DB
    {
        public const string ConnectionString = "Server=datum.database.windows.net;Database=Datum-db_QA;User Id=datumadmin; password=Qbn5!4Yx$ys6;MultipleActiveResultSets=true;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";
        
    }


}
