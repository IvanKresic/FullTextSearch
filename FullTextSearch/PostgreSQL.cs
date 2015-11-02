using System;
using Npgsql;

namespace FullTextSearch
{
    public class PostgreSQL
    {
        public string connectionstring;
        public NpgsqlConnection conn;

        public PostgreSQL()
        {
            this.setConnectionString();
            this.setConnection();
        }

        private void setConnectionString()
        {
            this.connectionstring = String.Format("Server=192.168.56.12;Port=5432;" +
                    "User Id=postgres;Password=reverse;Database=postgres;");
        }

        private void setConnection()
        {
            this.conn = new NpgsqlConnection(connectionstring);
        }

        public void openConnection()
        {
            conn.Open();
        }

        public void closeConnection()
        {
            conn.Close();
        }

        public void insertIntoTable(string textToInsert, NpgsqlConnection nsqlConn)
        {
            string mySqlString = "INSERT INTO \"textTable\" (\"Text\") VALUES (@Param1)";

            NpgsqlParameter myParameter = new NpgsqlParameter("@Param1", NpgsqlTypes.NpgsqlDbType.Text);
            myParameter.Value = textToInsert;

            this.openConnection();

            NpgsqlCommand myCommand = new NpgsqlCommand(mySqlString, nsqlConn);
            myCommand.Parameters.Add(myParameter);

            myCommand.ExecuteNonQuery();

            this.closeConnection();
        }

        public void executeQuery(string queryText, NpgsqlConnection nsqlConn)
        {
            this.openConnection();

            NpgsqlCommand myCommand = new NpgsqlCommand(queryText, nsqlConn);
            myCommand.ExecuteNonQuery();

            this.closeConnection();
        }
    }
}
