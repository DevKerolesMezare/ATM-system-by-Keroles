
using System;

using System.Data;
using System.Data.SqlClient;


namespace ATMDataAccessLayer
{
    public class clsCountryData
    {

        public static bool GetCountryByID(int CountryID, ref string Name)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from Countries Where CountryID = @CountryID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"CountryID", CountryID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    Name = (string)reader["CountryName"];
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                IsFound = false;
            }

            finally
            {
                connection.Close();
            }

            return IsFound;
        }
        public static bool GetCountryByName(string Name, ref int CountryID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from Countries Where CountryName = @CountryName ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"CountryName", Name);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    CountryID = (int)reader["CountryID"];
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                IsFound = false;
            }

            finally
            {
                connection.Close();
            }

            return IsFound;

        }
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string qurey = "SELECT * FROM Countries order by CountryName";

            SqlCommand command = new SqlCommand(qurey, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }


            return dt; 
        }

    }

}
    

