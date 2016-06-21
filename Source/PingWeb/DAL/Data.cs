using System.Data.SQLite;

namespace HttpRequestTester.DAL
{
    using HttpRequestTester.Model;

    public class Data
    {
        private static readonly SQLiteConnection DbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");

        public static void CreateDatabase()
        {
            DbConnection.Open();

            const string SqlCreateTable = @"CREATE TABLE IF NOT EXISTS  Request 
                                    (RequestId INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
                                    RequestUrl VARCHAR(100), 
                                    Response VARCHAR(100), 
                                    DateRequest DATETIME, 
                                    ResponseTime INT, 
                                    IsSuccess BOOLEAN)";

            var command = new SQLiteCommand(SqlCreateTable, DbConnection);
            command.ExecuteNonQuery();
            
            DbConnection.Close();
        }

        public static void SaveToDb(HttpGet data)
        {
            DbConnection.Open();

            var sqlInsert =
                string.Format(
                    @"INSERT INTO Request 
                        (RequestUrl, Response, DateRequest, ResponseTime, IsSuccess) 
                        VALUES ('{0}', '{1}', '{2}', '{3}', '{4}' )",
                    data.Url,
                    (data.Response == null ? string.Empty : data.Response.Replace("'", "''")),
                    data.RequestDateTime,
                    data.ResponseTime,
                    data.IsSuccess);

            var command = new SQLiteCommand(sqlInsert, DbConnection);
            command.ExecuteNonQuery();

            DbConnection.Close();
        }


    }
}
