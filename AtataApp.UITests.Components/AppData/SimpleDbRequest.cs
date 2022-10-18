using AtataApp.UITests.Components.DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AtataApp.UITests.Components.AppData
{
    public class SimpleDbRequest
    {
        private static SqlCommand _command;
        private static string _query, _listingName;


        public static string Get_Last_Active_Listing_With_Name(string listingName)
        {
            string _query = "SELECT TOP 1 Name FROM Property WHERE Name LIKE @Name AND PropertyStatusId != 5 AND SaveStatusId = 2 ORDER BY CreatedDate DESC";
            using (SqlConnection db = new SqlConnection(DB.ConnectionString))
            {
                _command = new SqlCommand(_query, db);
                _command.Parameters.AddWithValue("@Name", DbType.Int32).Value = listingName + '%';
                db.Open();
                SqlDataReader reader = _command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        _listingName = reader.GetValue(0).ToString();
            }
            return _listingName;
        }
    }
}
