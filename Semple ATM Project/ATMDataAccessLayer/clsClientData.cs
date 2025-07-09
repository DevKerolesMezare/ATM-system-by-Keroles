
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;





namespace ATMDataAccessLayer
{
    public class clsClientData
    {

       public static bool GetClientByID(int ID , ref string FirstName , ref string LastName 
           , ref DateTime DateOfBirth  , ref string Phone , ref string Address , 
           ref string Email ,ref string AccountNumber , ref string PinCode,ref float AccountBalance ,
           ref int CountryID , ref string ImagePath)
        {
            bool IsFound  = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string quere = "SELECT  * FROM Clients Where ClientID = @ID";


            SqlCommand command = new SqlCommand(quere, connection);

            command.Parameters.AddWithValue("@ID" , ID);



            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ID = (int)reader["ClientID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["BirthDate"];
                    Phone = (string)reader["Phone"];

                    if (reader["Address"] != DBNull.Value)
                    {
                        Address = (string)reader["Address"];
                    }
                    else
                    {
                        Address = "";
                    }


                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    AccountNumber = (string)reader["AccountNumber"];
                    PinCode = (string)reader["PinCode"];

                    AccountBalance = Convert.ToSingle(reader["AccountBalance"]);

                    CountryID = (int)reader["CountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }



                }

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

        public static bool GetClientByِAccountNumbrt(string AccountNumber, ref int ID, ref string FirstName, ref string LastName, 
            ref DateTime DateOfBirth, ref string Phone, ref string Address, ref string Email,
            ref string PinCode, ref float AccountBalance, ref int CountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT  * FROM Clients Where AccountNumber = @AccountNumber ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ID = (int)reader["ClientID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["BirthDate"];
                    Phone = (string)reader["Phone"];

                    if (reader["Address"] != DBNull.Value)
                    {
                        Address = (string)reader["Address"];
                    }
                    else
                    {
                        Address = "";
                    }


                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    AccountNumber = (string)reader["AccountNumber"];
                    PinCode = (string)reader["PinCode"];

                    AccountBalance = Convert.ToSingle(reader["AccountBalance"]);
                    CountryID = (int)reader["CountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }



                }

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

        public static bool GetClientByِAccountNumberAndPinCode(string AccountNumber,string PinCode,
            ref int ID, ref string FirstName, ref string LastName,
            ref DateTime DateOfBirth, ref string Phone, ref string Address, ref string Email, 
            ref float AccountBalance, ref int CountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT  * FROM Clients Where AccountNumber = @AccountNumber and PinCode = @PinCode;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ID = (int)reader["ClientID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["BirthDate"];
                    Phone = (string)reader["Phone"];

                    if (reader["Address"] != DBNull.Value)
                    {
                        Address = (string)reader["Address"];
                    }
                    else
                    {
                        Address = "";
                    }
                  

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    AccountNumber = (string)reader["AccountNumber"]; 
                    PinCode = (string)reader["PinCode"];

                    AccountBalance = Convert.ToSingle(reader["AccountBalance"]);

                    CountryID = (int)reader["CountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }



                }

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


        public static int AddNewClient(string FirstName,  string LastName
           ,  DateTime BirthDate,  string Phone,  string Address,
            string Email,  string AccountNumber,  string PinCode,  float AccountBalance,
            int CountryID,  string ImagePath)
        {
            int ClientID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                            INSERT INTO Clients 
                            (FirstName, LastName, BirthDate, Phone, Address, Email, AccountNumber, PinCode, AccountBalance, CountryID, ImagePath) 
                            VALUES 
                            (@FirstName, @LastName, @BirthDate, @Phone, @Address, @Email, @AccountNumber, @PinCode, @AccountBalance, @CountryID, @ImagePath); 
                            
                            SELECT SCOPE_IDENTITY();";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"FirstName", FirstName);
            command.Parameters.AddWithValue(@"LastName", LastName);
            command.Parameters.AddWithValue(@"BirthDate", BirthDate);
            command.Parameters.AddWithValue(@"Phone", Phone);

            if (!string.IsNullOrEmpty(Address))
            {
                command.Parameters.AddWithValue(@"Address", Address);
            }
            else
            {
                command.Parameters.AddWithValue(@"Address", System.DBNull.Value); 
            }


            if (!string.IsNullOrEmpty(Email))
            {
                command.Parameters.AddWithValue(@"Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue(@"Email", System.DBNull.Value);
            }

            command.Parameters.AddWithValue(@"AccountNumber", AccountNumber);
            command.Parameters.AddWithValue(@"PinCode", PinCode);
            command.Parameters.AddWithValue(@"AccountBalance", AccountBalance);
            command.Parameters.AddWithValue(@"CountryID", CountryID);

            if (ImagePath != "")
            {
                command.Parameters.AddWithValue(@"ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue(@"ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ClientID = InsertedID;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return ClientID;
        }

        public static bool IsAccountNumberExict(string AccountNumber)
        {
            bool isFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select top 1 1 From Clients where AccountNumber = @AccountNumber"; 

            SqlCommand command = new SqlCommand(query , connection);

            command.Parameters.AddWithValue("@AccountNumber" , AccountNumber);

            try
            {
                connection.Open ();

                object result = command.ExecuteScalar();

                isFound = (result != null); 
   
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound; 
        }

        public static bool UpdateAccountBalance(int ID , float AccountBalance)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Clients  
                            set 
                               AccountBalance = @AccountBalance
                                where ClientID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID" , ID);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {            
                return (rowsAffected > 0);
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool UpdatePINCode(int ID , string PinCode)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Clients  
                            set 
                               PinCode = @PinCode
                                where ClientID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID" , ID);
            command.Parameters.AddWithValue("@PinCode", PinCode);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                
                return (rowsAffected > 0);
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static bool UpdateClientInfo(int ClientID,string FirstName, string LastName
           , DateTime BirthDate, string Phone, string Address,
            string Email, string AccountNumber, string PinCode, float AccountBalance,
            int CountryID, string ImagePath)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection (clsDataAccessSettings.ConnectionString);

            string query = @"Update Clients
                            set 

                              FirstName     =  @FirstName     ,
                              LastName      =  @LastName      ,
                              BirthDate     =  @BirthDate     ,
                              Phone         =  @Phone         ,
                              Address       =  @Address       ,
                              Email         =  @Email         ,
                              AccountNumber =  @AccountNumber ,
                              PinCode       =  @PinCode       ,
                              AccountBalance=  @AccountBalance,
                              CountryID     =  @CountryID     ,
                              ImagePath     =  @ImagePath                      
                                                              
                              Where ClientID = @ClientID
                                    "; 
    

            SqlCommand command = new SqlCommand(query , connection);

            command.Parameters.AddWithValue(@"ClientID", ClientID);
            command.Parameters.AddWithValue(@"FirstName", FirstName);
            command.Parameters.AddWithValue(@"LastName", LastName);
            command.Parameters.AddWithValue(@"BirthDate", BirthDate);
            command.Parameters.AddWithValue(@"Phone", Phone);

            if (!string.IsNullOrEmpty(Address))
            {
                command.Parameters.AddWithValue(@"Address", Address);
            }
            else
            {
                command.Parameters.AddWithValue(@"Address", System.DBNull.Value);
            }


            if (!string.IsNullOrEmpty(Email))
            {
                command.Parameters.AddWithValue(@"Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue(@"Email", System.DBNull.Value);
            }

            command.Parameters.AddWithValue(@"AccountNumber", AccountNumber);
            command.Parameters.AddWithValue(@"PinCode", PinCode);
            command.Parameters.AddWithValue(@"AccountBalance", AccountBalance);
            command.Parameters.AddWithValue(@"CountryID", CountryID);

            if (ImagePath != null)
            {
                command.Parameters.AddWithValue(@"ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue(@"ImagePath", System.DBNull.Value);
            }


            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();   

            }
            catch(Exception ex) 
            {
                rowsAffected = 0;
            }
            finally
            {
                connection.Close();
            }


            return (rowsAffected > 0) ; 
        }




        public static bool DeleteCLientByClientID(int ClientID)
        {
            
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Delete From Clients Where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query , connection);

            command.Parameters.AddWithValue(@"ClientID" , ClientID);

            try
            {
                connection.Open ();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }



        public static DataTable GetAllClients()
        {
            DataTable dt = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = "SELECT Clients.ClientID, " +
                "FullName = (Clients.FirstName + ' ' +  Clients.LastName )," +
                " Clients.BirthDate, Clients.Phone," +
                " Clients.AccountNumber, Clients.PinCode, Clients.AccountBalance," +
                " Countries.CountryName FROM  " +
                "   Countries INNER JOIN                " +
                "   Clients ON Countries.CountryID = Clients.CountryID";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
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

            return dt ;
        }
    }
}
