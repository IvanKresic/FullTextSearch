using System;
using Npgsql;

namespace FullTextSearch
{
    public class PostgreSQL
    {
        public string connectionstring;
        public NpgsqlConnection conn;
        SQLquerys sql = new SQLquerys();
        private string newConnString;

        public PostgreSQL()
        {
            this.setConnectionString();
            this.setConnection();
        }

        public void setConnectionString()
        {
            newConnString = sql.getTheKey();
            this.connectionstring = String.Format(newConnString);
            this.setConnection();
        }

        public void setConnection()
        {
            this.conn = new NpgsqlConnection(connectionstring);
        }

        public void openConnection()
        {
            try
            {
                conn.Open();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Nije se moguće spojiti! Provjerite podatke!");
            }
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
