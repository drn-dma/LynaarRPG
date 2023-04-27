using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lynaar_GUI
{
    internal class SQLConnect
    {
        private static string _dataSource = "lynaarrpg-srv.database.windows.net";
        private static string _initialCatalog = "Lynaar";
        private static string _userID = "lynaar";
        private static string _password = "1596357Dd";

        public static string ExecuteSql(string queryToRead, int numColumnToReturn)
        {
            var builder = new SqlConnectionStringBuilder();

            builder.DataSource = _dataSource;
            builder.InitialCatalog = _initialCatalog;
            builder.UserID = _userID;
            builder.Password = _password;
            
            var result = "";

            using (var conn = new SqlConnection(builder.ConnectionString))
            {
                conn.Open();
                using (var command =new SqlCommand(queryToRead, conn))
                {
                    command.CommandText = queryToRead;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                result += reader.GetString(numColumnToReturn).ToString();

                            }
                            catch(Exception ex)
                            {
                                if (ex is InvalidCastException)
                                {
                                    try
                                    {
                                        result += reader.GetInt32(numColumnToReturn).ToString();
                                    }
                                    catch
                                    {
                                        result += reader.GetBoolean(numColumnToReturn).ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            return result;
        }


        public static bool ExecuteSql(string queryToWrite)
        {
            var builder = new SqlConnectionStringBuilder();

            builder.DataSource = _dataSource;
            builder.InitialCatalog = _initialCatalog;
            builder.UserID = _userID;
            builder.Password = _password;

            bool sucess = false;

            using (var conn = new SqlConnection(builder.ConnectionString))
            {
                conn.Open();
                using (var command = new SqlCommand(queryToWrite, conn))
                {
                    command.CommandText = queryToWrite;
                    
                    if(command.ExecuteNonQuery() > 0)
                    {
                        sucess = true;
                    }
                }
            }
            return sucess;
        }
        
    }
}
