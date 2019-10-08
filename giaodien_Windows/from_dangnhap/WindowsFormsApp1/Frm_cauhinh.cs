using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Frm_cauhinh : Form
    {
        public Frm_cauhinh()
        {
            InitializeComponent();
        }
        QL_nguoidung Cauhinh = new QL_nguoidung();
        private void cbosever_dropdown(object sender,EventArgs e)
        {
            DataTable dt = Cauhinh.GetServerName();
            cbo_sever.Items.Clear();
            foreach(System.Data.DataRow row in dt.Rows)
            {
                foreach(System.Data.DataColumn column in dt.Columns)
                {
                    cbo_sever.Items.Add(row[column]);
                }
            }
        }
    }
}
