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
        static int tempInt=1;

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

        public bool openConnection()
        {
            try
            {
                conn.Open();
                return true;     
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Unable to connect! Check parameters!");
                return false;
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

        public void insertIntoAnalysisTable(string textToInsert, NpgsqlConnection nsqlConn)
        {
            string dateTime = DateTime.Now.ToString();
            string[] temp;
            temp = dateTime.Split(' ');
            
            string mySqlString = "INSERT INTO \"analysisTable\" (\"searchedText\", \"dateOfSearch\", \"timeOfSearch\") VALUES ('" + textToInsert + "', '" + temp[0] + "'" + ", '" + temp[1] + "');";

            this.openConnection();

            NpgsqlCommand myCommand = new NpgsqlCommand(mySqlString, nsqlConn);
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

        public void createTempTable(NpgsqlConnection nsqlConn, char analysisType, string dateFrom, string dateTo, string splitMe)
        {
            
            if (analysisType == 'H')
            {
                string dropIfExists = "DROP TABLE IF EXISTS \"sat\";";
                string createTempTable = "CREATE TABLE IF NOT EXISTS \"sat\" (rbrSata INT);";
                string insertIntoTempTable = "";
                for (int i = 0; i < 24; i++)
                {
                    insertIntoTempTable += "INSERT INTO \"sat\" VALUES (" + i + ");";
                }

                this.openConnection();

                NpgsqlCommand commandDrop = new NpgsqlCommand(dropIfExists, nsqlConn);
                commandDrop.ExecuteNonQuery();

                NpgsqlCommand commandCreate = new NpgsqlCommand(createTempTable, nsqlConn);
                commandCreate.ExecuteNonQuery();

                NpgsqlCommand commandInsert = new NpgsqlCommand(insertIntoTempTable, nsqlConn);
                commandInsert.ExecuteNonQuery();

                this.closeConnection();
            }
            else if(analysisType == 'D')
            {
                string dropIfExists = "DROP TABLE IF EXISTS \"dan\";";
                string createTempTable = "CREATE TABLE IF NOT EXISTS \"dan\" (rbrDana INT);";
                string insertIntoTempTable = splitMe;         

                this.openConnection();

                NpgsqlCommand commandDrop = new NpgsqlCommand(dropIfExists, nsqlConn);
                commandDrop.ExecuteNonQuery();

                NpgsqlCommand commandCreate = new NpgsqlCommand(createTempTable, nsqlConn);
                commandCreate.ExecuteNonQuery();

                NpgsqlCommand commandInsert = new NpgsqlCommand(insertIntoTempTable, nsqlConn);
                commandInsert.ExecuteNonQuery();

                this.closeConnection();
            }
        }
    }
}
