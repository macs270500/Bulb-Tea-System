using System;
using System.Windows.Forms;

namespace Bulb_Tea_System
{
    public partial class frmDetailed_View : Form
    {
        public frmDetailed_View()
        {
            InitializeComponent();
        }

        Stock_Management frmStock = new Stock_Management();
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Detailed_View_Load(object sender, EventArgs e)
        {
            string sqlStr = "SELECT * FROM Stock_Management";
            clsDataGridDataSource DataSource = new clsDataGridDataSource();
            DetailedDataGridView.DataSource = DataSource.SqlDataTable(sqlStr);
        }

        private void Detailed_View_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
