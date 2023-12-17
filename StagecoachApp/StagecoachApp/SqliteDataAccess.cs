using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace StagecoachApp
{
    public class SqliteDataAccess
    {
        public static void GenerateDatabase()
        {
            //Drops the old table if it exists
            string Drop1 = "DROP TABLE IF EXISTS \"Stagecoach\";";
            string Drop2 = "DROP TABLE IF EXISTS \"Item\";";
            string Drop3 = "DROP TABLE IF EXISTS \"Inventory\";";
            string Drop4 = "DROP TABLE IF EXISTS \"Type\";";
            string Drop5 = "DROP TABLE IF EXISTS \"Action\";";
            string[] Drops = new string[] { Drop1, Drop2, Drop3, Drop4, Drop5 };

            //Creates new tables (when the app is supposed to auto copy the provided database but that's prone not doing that D: )
            string Table1 = "CREATE TABLE IF NOT EXISTS \"Stagecoach\" (\"stagecoachID\" INTEGER, \"hitPoints\" INTEGER NOT NULL, \"hitPointsMax\" INTEGER NOT NULL, \"horses\" INTEGER NOT NULL, \"rations\" INTEGER NOT NULL, \"water\" INTEGER NOT NULL, \"crewCount\" INTEGER NOT NULL, \"name\" VARCHAR(50) NOT NULL, PRIMARY KEY(\"stagecoachID\" AUTOINCREMENT)); ";
            string Table2 = "CREATE TABLE IF NOT EXISTS \"Item\"( \"itemID\" INTEGER, \"name\" VARCHAR(50) NOT NULL, \"value\" INTEGER NOT NULL, \"description\" TEXT NOT NULL, \"isUpgrade\" BOOLEAN, \"equippedSlot\" INTEGER, \"typeID\" INTEGER, PRIMARY KEY(\"itemID\" AUTOINCREMENT));";
            string Table3 = "CREATE TABLE IF NOT EXISTS \"Inventory\" ( \"stagecoachID\" INTEGER, \"itemID\" INTEGER, \"amount\" INTEGER NOT NULL, FOREIGN KEY(\"itemID\") REFERENCES \"Item\"(\"itemID\"), FOREIGN KEY(\"stagecoachID\") REFERENCES \"Stagecoach\"(\"stagecoachID\"), PRIMARY KEY(\"stagecoachID\",\"itemID\"));";
            string Table4 = "CREATE TABLE IF NOT EXISTS \"Type\" ( \"typeID\" INTEGER, \"name\" VARCHAR(30) NOT NULL, PRIMARY KEY(\"typeID\"));";
            string Table5 = "CREATE TABLE IF NOT EXISTS \"Action\" ( \"actionID\" INTEGER, \"name\" VARCHAR(30) NOT NULL, \"upgradeID\" INTEGER NOT NULL, \"duration\" INTEGER, \"description\" TEXT NOT NULL, \"typeID\" INTEGER, \"usesAmmo\" BOOLEAN NOT NULL, \"ammoID\" INTEGER, \"ammoUsed\" INTEGER, FOREIGN KEY(\"typeID\") REFERENCES \"Type\"(\"typeID\"), FOREIGN KEY(\"ammoID\") REFERENCES \"Item\"(\"itemID\"), FOREIGN KEY(\"upgradeID\") REFERENCES \"Item\"(\"itemID\"), PRIMARY KEY(\"actionID\" AUTOINCREMENT));";
            string[] Tables = new string[] { Table1, Table2, Table3, Table4, Table5 };

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                foreach (String Drop in Drops)
                {
                    cnn.Execute(Drop);
                }
                foreach (String Table in Tables)
                {
                    cnn.Execute(Table);
                }
            }

        }
        public static List<StagecoachModel> LoadStagecoaches()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<StagecoachModel>("select * from Stagecoach", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void CreateStagecoach(StagecoachModel stagecoach)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Stagecoach (hitPoints, hitPointsMax, horses, rations, water, crewCount, name) " +
                                        "values (@HitPoints, @HitPointsMax, @Horses, @Rations, @Water, @CrewCount, @Name)", stagecoach);

            }
        }
        
        public static StagecoachModel GetStagecoach(int StagecoachId)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                StagecoachModel stagecoach = new StagecoachModel();
                var sql = "select * from Stagecoach where stagecoachID = " + StagecoachId;
                stagecoach = cnn.QuerySingleOrDefault<StagecoachModel>(sql, new DynamicParameters());
                return stagecoach;
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void UpdateStagecoach(StagecoachModel stagecoach)
        {
            int usedStagecoachId = SelectedStagecoach.StagecoachId;

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var sql = "update Stagecoach set name = @Name ," +
                        "hitPoints = @HitPoints, " +
                        "hitPointsMax = @HitPointsMax, " +
                        "horses = @Horses, " +
                        "rations = @Rations, " +
                        "water = @Water, " +
                        "crewCount = @CrewCount " +
                         "where stagecoachID = " + usedStagecoachId.ToString();
                cnn.Execute(sql,stagecoach);

            }
        }

    }

}

