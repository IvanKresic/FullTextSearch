using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace FullTextSearch
{
    public partial class Form1 : Form
    {
        private PostgreSQL pg = new PostgreSQL();
        private SQLquerys sqlQuerys = new SQLquerys();
        private DataSet dataSet = new DataSet();
        private DataTable dataTable = new DataTable();        
        private Parser parser = new Parser();

        private char odabirAndOr;
        private char vrstaPretrazivanja;
        private char analysisType;

        public Form1()
        {
            InitializeComponent();
            rbtn_AND.Checked = true;
            rbtnNeizmjenjeni.Checked = true;
            odabirAndOr = '*';
            radioButton_Day.Checked = true;
            radioButton_Day.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gb_unosPodataka.Enabled = false;
            groupBox_Search.Enabled = false;
            groupBox_Analysis.Enabled = false;
            button_Disconnect.Enabled = false;
            button_Pretrazi.BackColor = System.Drawing.Color.WhiteSmoke;
            button_Disconnect.BackColor = System.Drawing.Color.WhiteSmoke;
            button_unosTekstaUBazu.BackColor = System.Drawing.Color.WhiteSmoke;
            button1.BackColor = System.Drawing.Color.WhiteSmoke;            
        }     

        private void button_unosTekstaUBazu_Click(object sender, EventArgs e)
        {
            string searchTextBoxString = rTB_unosTextaUBazu.Text.ToString();

            if(searchTextBoxString != "")
            {
                pg.insertIntoTable(searchTextBoxString, pg.conn);
                MessageBox.Show(searchTextBoxString + " added to database!");
                rTB_unosTextaUBazu.Clear();                
            }
            else
            {
                MessageBox.Show("Empty data is not allowed!");
            }
        }

        private void button_Pretrazi_Click(object sender, EventArgs e)
        {
            string stringToSearch;
            string sql;
            string highlitedText;
            string rank;
            string check;

            stringToSearch = textBox_Pretrazivanje.Text.Trim();
            List<string> list = parser.parseInput(stringToSearch);

            sql = sqlQuerys.createSqlString(list, odabirAndOr, vrstaPretrazivanja);
            richTextBox1.Text = sql;

            check = sqlQuerys.testIfEmpty(stringToSearch);
            pg.insertIntoAnalysisTable(stringToSearch, pg.conn);

            pg.openConnection();

            NpgsqlCommand command = new NpgsqlCommand(sql, pg.conn);                
                    NpgsqlDataReader reader = command.ExecuteReader();
                    int count = 0;
                    linkLabel_Rezultat.Text = " ";
                    while (reader.Read())
                    {
                        highlitedText = reader[1].ToString() as string;
                        rank = reader[3].ToString() as string;
                        linkLabel_Rezultat.Text += highlitedText + "[" + rank + "]\n";
                        count++;
                    }
                    labelBrojac.Text = "Number of documents found: " + count.ToString();
            pg.closeConnection();
        }

        private void rbtn_AND_CheckedChanged(object sender, EventArgs e)
        {
            odabirAndOr = '*';
        }

        private void rbtn_OR_CheckedChanged(object sender, EventArgs e)
        {
            odabirAndOr = '+';
        }

        private void rbtnNeizmjenjeni_CheckedChanged(object sender, EventArgs e)
        {
            vrstaPretrazivanja = 'A';
        }

        private void rbtn_Rijecnici_CheckedChanged(object sender, EventArgs e)
        {
            vrstaPretrazivanja = 'B';
        }

        private void rbtn_Fuzzy_CheckedChanged(object sender, EventArgs e)
        {
            vrstaPretrazivanja = 'C';
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (connectMe())
            {
                gb_unosPodataka.Enabled = true;
                groupBox_Search.Enabled = true;
                groupBox_Analysis.Enabled = true;
                textBox_Database.Enabled = false;
                textBox_IP.Enabled = false;
                textBox_Port.Enabled = false;
                textBox_Password.Enabled = false;
                textBox_UserID.Enabled = false;
                button_Connect.Enabled = false;
                button_Disconnect.Enabled = true;

                button_Pretrazi.BackColor = System.Drawing.Color.SkyBlue;
                button_Disconnect.BackColor = System.Drawing.Color.IndianRed;
                button_unosTekstaUBazu.BackColor = System.Drawing.Color.MediumSeaGreen;
                button1.BackColor = System.Drawing.Color.MediumSeaGreen;
                button_Connect.BackColor = System.Drawing.Color.WhiteSmoke;
            }
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            gb_unosPodataka.Enabled = false;
            groupBox_Search.Enabled = false;
            groupBox_Analysis.Enabled = false;
            textBox_Database.Enabled = true;
            textBox_IP.Enabled = true;
            textBox_Port.Enabled = true;
            textBox_Password.Enabled = true;
            textBox_UserID.Enabled = true;
            button_Connect.Enabled = true;
            button_Disconnect.Enabled = false;

            button_Pretrazi.BackColor = System.Drawing.Color.WhiteSmoke;
            button_Disconnect.BackColor = System.Drawing.Color.WhiteSmoke;
            button_unosTekstaUBazu.BackColor = System.Drawing.Color.WhiteSmoke;
            button1.BackColor = System.Drawing.Color.WhiteSmoke;
            button_Connect.BackColor = System.Drawing.Color.MediumSeaGreen;

            textBox_Pretrazivanje.Text = "";
            linkLabel_Rezultat.Text = "";
            richTextBox1.Text = "";
            labelBrojac.Text = "";
        }


        string createConnString = "";
        private bool connectMe()
        {            
            createConnString += "Server=" + textBox_IP.Text + ";Port=" + textBox_Port.Text + ";User Id=" + textBox_UserID.Text + ";Password=" + textBox_Password.Text + ";Database=" + textBox_Database.Text + ";";
            sqlQuerys.setTheKey(createConnString);
            pg.setConnectionString();
            pg.setConnection();
            if(pg.openConnection())
            {                
                MessageBox.Show("You are successfuly connected!");
                pg.closeConnection();
                return true;
            }  
            else
            {
                return false;
            }        
             
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedTimestamp;
            selectedTimestamp = dateTimePicker_From.Value.ToString("dd-MM-yyyy hh:mm:ss")+" "+dateTimePicker_To.Value.ToString("dd-MM-yyyy hh:mm:ss");        
            Analysis analize = new Analysis(selectedTimestamp, analysisType);
            analize.Show();
        }

        private void radioButton_Day_CheckedChanged(object sender, EventArgs e)
        {
            analysisType = 'D';
        }

        private void radioButton_Hour_CheckedChanged(object sender, EventArgs e)
        {
            analysisType = 'H';
        }
    }
}
