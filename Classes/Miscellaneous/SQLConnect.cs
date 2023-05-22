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

        private readonly static string _dataSource = "lynaarrpg-srv.database.windows.net";
        private readonly static string _initialCatalog = "Lynaar";
        private readonly static string _userID = "lynaar";
        private readonly static string _password = "1596357Dd";

        #endregion

        #region readDataFromSQL Methods


        /// <summary>
        //! Execute une requête SQL et retourne le résultat dans un string (pour les requêtes de type SELECT)
        //// </summary>
        /// <param name="queryToRead"></param>
        //! <returns>List of dictionnary representating all rows return by SQL Query</returns>


        //x Fonctionnement :
        /*?
         * var sqlResult = SQLConnect.readDataFromSQL("SELECT * FROM Equipement");
         * 
         * string stringResult = "";
         * 
         * foreach(var row in sqlResult)
         * {
         *  stringResult += row["isWeapon"].toString() + "\n";
         * }
         * MessageBox.Show(stringResult);
        */


        public static List<Dictionary<string, object>> readDataFromSQL(string queryToRead)
        {
            //! Création des données de connexion
            #region Connection String

            var builder = new SqlConnectionStringBuilder();

            builder.DataSource = _dataSource;
            builder.InitialCatalog = _initialCatalog;
            builder.UserID = _userID;
            builder.Password = _password;

            #endregion

            //! Liste de dictionnaire contenant les résultats de la requête (simulation des différentes lignes de résultat de notre requête)
            List<Dictionary<string,object>> resultList = new List<Dictionary<string, object>>();


            using (var conn = new SqlConnection(builder.ConnectionString))
            {
                //! Ouverture de la connexion
                conn.Open();
                 
                using(var command = new SqlCommand(queryToRead, conn))
                {
                    //! Execution de la requête
                    command.CommandText = queryToRead;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //! Récupération du nombre de colonne et initialisation du nombre de ligne
                        int fieldCount = reader.FieldCount;
                        int rowCount = 0;

                        //! Parcours des lignes de résultat
                        while (reader.Read())
                        {                 
                            //! Ajout d'un dictionnaire dans la liste de dictionnaire pour chaque ligne de résultat
                            resultList.Add(new Dictionary<string, object>());

                            for(int i = 0; i < fieldCount; i++)
                            {
                                //! Ajout de la colonne et de la valeur dans le dictionnaire
                                #region Ajout Valeur dans le dictionnaire en fonction du type
                                try
                                {
                                    //! Ajout dans le dictionnaire si la valeur est un string
                                    resultList[rowCount].Add(reader.GetName(i),reader.GetString(i));

                                }
                                catch (Exception ex)
                                {
                                    if (ex is InvalidCastException)
                                    {
                                        try
                                        {
                                            //! Ajout dans le dictionnaire si la valeur est un int
                                            resultList[rowCount].Add(reader.GetName(i),reader.GetInt32(i));
                                        }
                                        catch(Exception exept)
                                        {
                                            if(exept is InvalidCastException)
                                            {
                                                try
                                                {
                                                    //! Ajout dans le dictionnaire si la valeur est un bool
                                                    resultList[rowCount].Add(reader.GetName(i), reader.GetBoolean(i));
                                                }
                                                catch
                                                {
                                                    resultList[rowCount].Add(reader.GetName(i), DateTime.Parse(reader.GetValue(i).ToString()));
                                                }
                                            }
                                        }
                                    }
                                }
                                #endregion
                            }
                            //! Incrémentation du nombre de ligne
                            rowCount++;
                        }
                    }
                }   
                //! Fermeture de la connexion
                conn.Close();
            }
            
            return resultList;
        }

        public static List<Dictionary<string, object>> getAllPlayers()
        {
            return readDataFromSQL("SELECT * FROM Player");
        }

        public static List<Dictionary<string, object>> getPlayerEquipement(int idPlayer)
        {
            return readDataFromSQL($"SELECT * FROM Inventory_Equipement WHERE Id_Player = {idPlayer}");
        }

        public static List<Dictionary<string, object>> getPlayerConsumable(int idPlayer)
        {
            return readDataFromSQL($"SELECT * FROM possessed WHERE Id_Player = {idPlayer}");
        }

        public static bool isEquiped(int idPlayer, int idEquipement)
        {
            return readDataFromSQL($"SELECT * FROM Inventory_Equipement WHERE Id_Player = {idPlayer} AND Id_Equipement = {idEquipement}")[0]["isEquiped"].ToString() == "True";
        }

        public static List<Dictionary<string, object>> viewMonsters()
        {
            return readDataFromSQL("SELECT * FROM Enemy JOIN Monsters on Monsters.Id_Entity = Enemy.Id_Entity");
        }

        public static int getAdditionnalDamage(int idItem)
        {
            return int.Parse(readDataFromSQL($"SELECT atk FROM Equipement WHERE Id_Equipement = {idItem}")[0]["atk"].ToString());
        }

        public static int getAdditionnalHealth(int idItem)
        {
            return int.Parse(readDataFromSQL($"SELECT pv FROM Equipement WHERE Id_Equipement = {idItem}")[0]["pv"].ToString());
        }

        #endregion


        #region ExecuteSQL Methods


        /// <summary>
        //! Execute une requête SQL en base et retourne un booléen si la requête s'est bien exécuté (pour les requêtes de type INSERT, UPDATE, DELETE)
        //// </summary>
        /// <param name="queryToWrite"></param>
        //! <returns>True or False on succes / error</returns>
        public static bool ExecuteSQL(string queryToWrite)
        {
            //! Création des données de connexion
            #region Connection String
            var builder = new SqlConnectionStringBuilder();

            builder.DataSource = _dataSource;
            builder.InitialCatalog = _initialCatalog;
            builder.UserID = _userID;
            builder.Password = _password;

            #endregion

            //! Booléen de retour si la requête s'est bien exécuté
            bool sucess = false;

            using (var conn = new SqlConnection(builder.ConnectionString))
            {
                //! Ouverture de la connexion
                conn.Open();

                using (var command = new SqlCommand(queryToWrite, conn))
                {
                    //! Execution de la requête
                    command.CommandText = queryToWrite;
                    
                    //! Vérification si la requête s'est bien exécuté + éxécution de la requête
                    if(command.ExecuteNonQuery() > 0)
                    {
                        sucess = true;
                    }
                }
                //! Fermeture de la connexion
                conn.Close();
            }
            return sucess;
        }


        public static bool equipWeaponOrArmor(int idPlayer, int idEquipement)
        {
            return ExecuteSQL($"UPDATE Inventory_Equipement SET IsEquiped = 1 WHERE Id_Player = {idPlayer} AND Id_Equipement = {idEquipement}");
        }

        public static bool unequipWeaponOrArmor(int idPlayer, int idEquipement)
        {
            return ExecuteSQL($"UPDATE Inventory_Equipement SET IsEquiped = 0 WHERE Id_Player = {idPlayer} AND Id_Equipement = {idEquipement}");
        }

        

        /*public static bool savePlayer(Player player)
        {
            //save or insert player in database
            if (player.Id == 0)
            {
                int tempID;
                try
                {
                    var data = readDataFromSQL("SELECT Id_Player FROM Player order by Id_Player asc");

                    if (int.Parse(data[0]["Id_Player"].ToString()) != 1 && int.Parse(data[1]["Id_Player"].ToString()).E){
                        player.Id = 1;
                    }else if (){

                    }
                }
                catch
                {
                    player.Id = 1;
                }


                

                return ExecuteSQL($"INSERT INTO Player (Id_Player,playerName,classes,level,xp,hp,maxHp,damage,additionalDamage,endurance,intelligence,gold,fightNumber,dateSave) VALUES (1,{player.PlayerName},)");
            }
            else
            {
                return ExecuteSQL($"UPDATE Player SET Name = '{player.Name}', PV = {player.PV}, ATK = {player.ATK}, DEF = {player.DEF}, Id_Entity = {player.Id_Entity} WHERE Id_Player = {player.Id_Player}");
            }
        }*/
        #endregion

    }
}
