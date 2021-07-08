using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulb_Tea_System
{
    public partial class datagrid : Form
    {
        public datagrid()
        {
            InitializeComponent();
        }

        clsDataGridDataSource DataSource = new clsDataGridDataSource();
        frmPayroll payroll = new frmPayroll();
        private void datagrid_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DataSource.connStr);
            string sqlStr = "Select EmpID, EmpFName, EmpLName, EmpAddress, EmpPhone, EmpSalary from Employees";
            DataTable dt = new DataTable();
            dt = DataSource.SqlDataTable(sqlStr);
            dataGridView1.DataSource = dt;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
