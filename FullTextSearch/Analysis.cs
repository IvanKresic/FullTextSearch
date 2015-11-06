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
            string analysisQuery;
            analysisQuery = sqlQuerys.queryForAnalysis(analysisLetter);

            try
            {
                pg.createTempTable(pg.conn, analysisLetter, dateFrom, dateTo);

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
    }
}
