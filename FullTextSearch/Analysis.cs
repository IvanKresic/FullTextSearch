using System;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace FullTextSearch
{
    public partial class Analysis : Form
    {
        private PostgreSQL pg = new PostgreSQL();
        private SQLquerys sqlQuerys = new SQLquerys();
        private DataSet dataSet = new DataSet();
        private DataTable dataTable = new DataTable();
        static string analysisQuery;

        string dateFrom;
        string dateTo;
        string timeFrom;
        string timeTo;        
        char analysisLetter;

        public Analysis()
        {
            InitializeComponent();
        }

        public Analysis(string timestamp, char analysisType)
        {
            InitializeComponent();
            string[] temp;
            analysisLetter = analysisType;
            temp = timestamp.Split(' ');
            dateFrom = temp[0];
            timeFrom = temp[1];
            dateTo = temp[2];
            timeTo = temp[3];
        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            
        }

        private void button_LoadData_Click(object sender, EventArgs e)
        {
            sqlQuerys.setCounter();
            analysisQuery = sqlQuerys.queryForAnalysis(analysisLetter);
            if (analysisLetter == 'H')
            {
                try
                {
                    pg.createTempTable(pg.conn, analysisLetter, dateFrom, dateTo, "asdasdad");

                    NpgsqlCommand command = new NpgsqlCommand(analysisQuery, pg.conn);

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable dbTable = new DataTable();
                    adapter.Fill(dbTable);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbTable;
                    dataGridView1.DataSource = bSource;
                    adapter.Update(dbTable);
                }
                catch
                {

                }
            }
            else if(analysisLetter == 'D')
            {
                string[] temp;
                string sqlForDayAnalysis = sqlQuerys.createSqlForDayAnalysis(dateFrom, dateTo);
                analysisQuery = sqlQuerys.queryForAnalysis(analysisLetter);
                analysisQuery += sqlForDayAnalysis;
                temp = analysisQuery.Split('#');
                
                try
                {
                    pg.createTempTable(pg.conn, analysisLetter, dateFrom, dateTo, temp[1]);

                    NpgsqlCommand command = new NpgsqlCommand(temp[0], pg.conn);

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable dbTable = new DataTable();
                    adapter.Fill(dbTable);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbTable;
                    dataGridView1.DataSource = bSource;
                    adapter.Update(dbTable);
                }
                catch
                {

                }
            }
        }
    }
}
