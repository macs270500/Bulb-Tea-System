using System;
using System.Data;
using System.Windows.Forms;

namespace Bulb_Tea_System
{
    public partial class Stock_Management : Form
    {
        public Stock_Management()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        int rowIndex = 0;
        clsDataGridDataSource DataSource = new clsDataGridDataSource();

        private void btnDetail_Click(object sender, EventArgs e)
        {
            frmDetailed_View frmDV = new frmDetailed_View();
            frmDV.ShowDialog();
        }
        public bool Employee = false;
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Employee == true)
            {
                Login_System login = new Login_System();
                login.Show();
                Close();
            }
            else
            {
                Main_Menu menu = new Main_Menu();
                menu.Show();
                Close();
            }
        }

        private void frmStockManagement_Load(object sender, EventArgs e)
        {
            string SqlStr = "EXEC SP_CheckStockLevel";
            DataSource.SqlCommandExecution(SqlStr);
            LoadToolTip();
            UpdateDatatable();
            UpdateTextBoxes();
        }
        private void UpdateDatatable()
        {
            string sqlStr = "SELECT * FROM Stock_Management";
            dt = DataSource.SqlDataTable(sqlStr);
        }
        private void UpdateTextBoxes()
        {

            txtProdID.Text = dt.Rows[rowIndex]["ProductID"].ToString();
            txtProdName.Text = dt.Rows[rowIndex]["ProductName"].ToString();
            txtProdPrice.Text = dt.Rows[rowIndex]["ProductPrice"].ToString();
            txtProdQuantity.Text = dt.Rows[rowIndex]["ProductQty"].ToString();
            txtRestock.Text = dt.Rows[rowIndex]["HasToRestock"].ToString();
            MtxtDate.Text = dt.Rows[rowIndex]["DateModified"].ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            UpdateDatatable();
            if (rowIndex > 0)
            {
                rowIndex--;
                UpdateTextBoxes();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            UpdateDatatable();
            if (rowIndex < dt.Rows.Count)
            {
                UpdateTextBoxes();
                rowIndex++;
            }
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            UpdateDatatable();
            if (rowIndex >= 0)
            {
                rowIndex = 0;
                UpdateTextBoxes();
            }

        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            UpdateDatatable();
            if (rowIndex < dt.Rows.Count)
            {
                rowIndex = dt.Rows.Count - 1;
                UpdateTextBoxes();
            }
        }

        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            frmRestock restock = new frmRestock();
            restock.ShowDialog();
        }

        private void LoadToolTip()
        {
            toolTipCheckStock.SetToolTip(btnCheckStock, "To check which items needs to be restocked");
            toolTipCheckStock.AutoPopDelay = 5000;
            toolTipCheckStock.InitialDelay = 3000;
            toolTipDetailedView.SetToolTip(btnDetail, "To view the entire Stock Table");
            toolTipDetailedView.AutoPopDelay = 5000;
            toolTipDetailedView.InitialDelay = 3000;
            toolTipFirstRecord.SetToolTip(btnFirst, "Displays The First record in the Table");
            toolTipFirstRecord.AutoPopDelay = 5000;
            toolTipFirstRecord.InitialDelay = 3000;
            toolTipPreviousRecord.SetToolTip(btnPrevious, "Displays the Previous record in the Table");
            toolTipPreviousRecord.AutoPopDelay = 5000;
            toolTipPreviousRecord.InitialDelay = 3000;
            toolTipNextRecord.SetToolTip(btnNext, "Displays the Next record in the Table");
            toolTipNextRecord.AutoPopDelay = 5000;
            toolTipNextRecord.InitialDelay = 3000;
            toolTipLastRecord.SetToolTip(btnLast, "Displays the Last record in the Table");
            toolTipLastRecord.AutoPopDelay = 5000;
            toolTipLastRecord.InitialDelay = 3000;
        }
    }
}
