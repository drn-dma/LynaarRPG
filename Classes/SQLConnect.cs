using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Lynaar_GUI.Classes;

namespace Lynaar_GUI
{
    internal class SQLConnect
    {
        
        #region Properties

        private static string _dataSource = "lynaarrpg-srv.database.windows.net";
        private static string _initialCatalog = "Lynaar";
        private static string _userID = "lynaar";
        private static string _password = "1596357Dd";

        #endregion


        //! Execute une requête SQL dans une colonne spécifié et retourne le résultat dans un string
        public static List<Dictionary<string, object>> readDataFromSQL(string queryToRead)
        {
            var builder = new SqlConnectionStringBuilder();

            builder.DataSource = _dataSource;
            builder.InitialCatalog = _initialCatalog;
            builder.UserID = _userID;
            builder.Password = _password;
            
            //Dictionary<string, object> result = new Dictionary<string, dynamic>();
            List<Dictionary<string,object>> resultList = new List<Dictionary<string, object>>();

            using (var conn = new SqlConnection(builder.ConnectionString))
            {
                conn.Open();

                 /*using (var command = new SqlCommand(queryToRead, conn))
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
                    
                }*/
                 
                using(var command = new SqlCommand(queryToRead, conn))
                {
                    command.CommandText = queryToRead;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int fieldCount = reader.FieldCount;
                        int rowCount = 0;

                        while (reader.Read())
                        {                                
                            resultList.Add(new Dictionary<string, object>());

                            for(int i = 0; i < fieldCount; i++)
                            {
                                try
                                {
                                    resultList[rowCount].Add(reader.GetName(i),reader.GetString(i));

                                }
                                catch (Exception ex)
                                {
                                    if (ex is InvalidCastException)
                                    {
                                        try
                                        {
                                            resultList[rowCount].Add(reader.GetName(i),reader.GetInt32(i));
                                        }
                                        catch
                                        {
                                            resultList[rowCount].Add(reader.GetName(i),reader.GetBoolean(i));
                                        }
                                    }
                                }
                            }
                            rowCount++;
                        }
                    }
                }   
                conn.Close();
            }
            
            return resultList;
        }


        public static bool ExecuteSQL(string queryToWrite)
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
                conn.Close();
            }
            return sucess;
        }
        
    }
}
