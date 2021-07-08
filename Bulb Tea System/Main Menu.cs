using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

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
            this.Close();
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
            this.Close();
        }

        private void BtnPayroll_Click(object sender, EventArgs e)
        {
            payRoll.Show();
            this.Close();
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            frmSales.Show();
            this.Close();
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            purchase.Show();
            this.Close();
        }
    }
}
