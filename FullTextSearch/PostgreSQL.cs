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
        static int tempInt;

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

        public void createTempTable(NpgsqlConnection nsqlConn, char analysisType, string dateFrom, string dateTo)
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
                string insertIntoTempTable = "";
                int[] tempFrom = sql.parseForDates(dateFrom);
                int[] tempTo = sql.parseForDates(dateTo);
                

                while (tempFrom[0] != tempTo[0] || tempFrom[1] != tempTo[1])
                {

                    if (tempFrom[1] == tempTo[1])
                    {
                        if (tempFrom[0] != tempTo[0])
                        {
                            for (int i = 0; tempFrom[0] < tempTo[0]; i++)
                            {
                                insertIntoTempTable += "INSERT INTO \"dan\" VALUES (" + i + ");";
                                tempInt = i;
                                tempFrom[0]++;
                            }
                        }
                    }
                    if(tempFrom[1] != tempTo[1])
                    {                        
                        if(tempFrom[1] % 2 == 0 || tempFrom[1] == 7 || tempFrom[1] == 1)
                        {
                            for(int i = tempInt; tempFrom[0] < 31 && tempFrom[1] != tempTo[1]; i++ )
                            {
                                insertIntoTempTable += "INSERT INTO \"dan\" VALUES (" + i + ");";
                                tempInt = i;
                                tempFrom[0]++;
                                if (tempFrom[0] == 31)
                                {
                                    tempFrom[1]++;
                                    tempFrom[0] = 1;
                                }
                            }
                            
                        }
                    }
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
        }
    }
}
