using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulb_Tea_System
{
    public partial class frmRestock : Form
    {
        public frmRestock()
        {
            InitializeComponent();
        }
        Stock_Management Stock = new Stock_Management();
        private void frmRestock_Load(object sender, EventArgs e)
        {
            clsDataGridDataSource DataSource = new clsDataGridDataSource();
            string sqlStr = "EXEC SP_CheckStockLevel";
            DataSource.SqlCommandExecution(sqlStr);
            string SqlStr = "SELECT ProductId, ProductName, ProductPrice,ProductQty " +
                "FROM Stock_Management " +
                "WHERE HasToRestock = 'Yes'";
            RestockDataGridView.DataSource = DataSource.SqlDataTable(SqlStr);            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
