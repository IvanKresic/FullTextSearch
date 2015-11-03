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
        private char odabirAndOr;
        private char vrstaPretrazivanja;
        private DataSet dataSet = new DataSet();
        private DataTable dataTable = new DataTable();        
        private Parser parser = new Parser();       

        public Form1()
        {
            InitializeComponent();
            rbtn_AND.Checked = true;
            rbtnNeizmjenjeni.Checked = true;
            odabirAndOr = '*';            
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

            stringToSearch = textBox_Pretrazivanje.Text.Trim();
            List<string> list = parser.parseInput(stringToSearch);

            sql = sqlQuerys.createSqlString(list, odabirAndOr, vrstaPretrazivanja);
            richTextBox1.Text = sql;

            pg.openConnection();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, pg.conn);
            dataSet.Reset();
            dataAdapter.Fill(dataSet);
            pg.closeConnection();

            using (pg.conn)
            {
                pg.conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(sql, pg.conn))
                {
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
                }
                pg.conn.Close();
            }
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
            connectMe();
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
        }


        string createConnString = "";
        private void connectMe()
        {            
            createConnString += "Server=" + textBox_IP.Text + ";Port=" + textBox_Port.Text + ";User Id=" + textBox_UserID.Text + ";Password=" + textBox_Password.Text + ";Database=" + textBox_Database.Text + ";";
            sqlQuerys.setTheKey(createConnString);
            pg.setConnectionString();
            pg.setConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from;
            string to;
            from = dateTimePicker_From.Value.ToString("dd/MM/yyyy hh:mm");
            to = dateTimePicker_To.Value.ToString("dd/MM/yyyy hh:mm");
            from += "";
            to += "";
        }
    }
}
