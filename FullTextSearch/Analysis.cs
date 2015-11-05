using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullTextSearch
{
    public partial class Analysis : Form
    {

        private PostgreSQL pg = new PostgreSQL();
        private SQLquerys sqlQuerys = new SQLquerys();
        string dateFrom;
        string dateTo;
        string timeFrom;
        string timeTo;        
        char analysis;

        public Analysis()
        {
            InitializeComponent();
        }

        public Analysis(string timestamp, char analysisType)
        {
            string[] temp;
            analysis = analysisType;
            temp = timestamp.Split(' ');
            dateFrom = temp[0];
            timeFrom = temp[1];
            dateTo = temp[2];
            timeTo = temp[3];
        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            
        }
    }
}
