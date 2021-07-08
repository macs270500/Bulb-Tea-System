using System;
using System.Windows.Forms;

namespace Bulb_Tea_System
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }
        Stock_Management stock = new Stock_Management();
        frmPayroll payRoll = new frmPayroll();
        frmPurchase purchase = new frmPurchase();
        Form1 frmSales = new Form1();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Login_System login = new Login_System();
            Close();
            login.ShowDialog();
        }

        public void ButtonSelection(string Department)
        {
            if (Department.StartsWith("SL"))
            {
                BtnPayroll.Visible = false;
                BtnPurchase.Visible = false;
                BtnStock.Visible = false;
                frmSales.Employee = true;
            }
            else if (Department.StartsWith("SM"))
            {
                BtnPayroll.Visible = false;
                BtnSales.Visible = false;
                stock.Employee = true;
                purchase.Employee = true;
            }


        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            stock.Show();
            Close();
        }

        private void BtnPayroll_Click(object sender, EventArgs e)
        {
            payRoll.Show();
            Close();
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            frmSales.Show();
            Close();
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            purchase.Show();
            Close();
        }
    }
}
