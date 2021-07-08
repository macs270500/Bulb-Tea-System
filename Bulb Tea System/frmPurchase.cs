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
    public partial class frmPurchase : Form
    {
        public frmPurchase()
        {
            InitializeComponent();
        }
        clsDataGridDataSource sqlCommand = new clsDataGridDataSource();
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            for (int i = 0; i < lviOrder.Items.Count; i++)
            {                
                string prodName = lviOrder.Items[i].SubItems[2].Text;
                string prodQty = lviOrder.Items[i].SubItems[3].Text;
                string SQLstr = $"Select ProductQty From Stock_Management Where ProductName = '{prodName}'";                
                DT = sqlCommand.SqlDataTable(SQLstr);
                string prodQuantity = DT.Rows[0]["ProductQty"].ToString();
                int totalQty = int.Parse(prodQty) + int.Parse(prodQuantity);
                string sqlStr = $"Exec SP_StockManagement @prodName='{prodName}',@prodQty='{totalQty}'";
                sqlCommand.SqlCommandExecution(sqlStr);
            }

            MessageBox.Show("Order confirmed. A guildeline to make the payement has been sent to you via mail. Take note that the order will be shipped after the payment validation. Thank You", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                lviOrder.Items.Clear();
            }

        }
        string connStr = "Data Source=MACS;Initial Catalog=BulbTea;Integrated Security=True";
        string sqlStr = "SELECT supID,SupName From Supplier";
        DataTable dt = new DataTable();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboSup.Text != "")
                if (txtProdName.Text != "")
                    if (TxtQty.Text != "")
                    {
                        ListViewItem lvi = new ListViewItem(comboSup.Text);
                        lvi.SubItems.Add(txtSupName.Text);
                        lvi.SubItems.Add(txtProdName.Text);
                        lvi.SubItems.Add(TxtQty.Text);
                        lviOrder.Items.Add(lvi);
                        txtProdName.Clear();
                        TxtQty.Clear();
                    }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviOrder.SelectedIndices.Count > 0)
            {
                int index = lviOrder.SelectedIndices[0];
                comboSup.Text = lviOrder.Items[index].Text;
                txtSupName.Text = lviOrder.Items[index].SubItems[1].Text;
                txtProdName.Text = lviOrder.Items[index].SubItems[2].Text;
                TxtQty.Text = lviOrder.Items[index].SubItems[3].Text;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSupName.Text = dt.Rows[comboSup.SelectedIndex]["SupName"].ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            sda.Fill(dt);
            sda.Dispose();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboSup.Items.Add(dt.Rows[i]["supID"]);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lviOrder.Items[lviOrder.SelectedIndices[0]].Remove();
        }
        public bool Employee = false;
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Employee == true)
            {
                Login_System login = new Login_System();
                login.Show();
                this.Close();
            }
            else
            {
                Main_Menu menu = new Main_Menu();
                menu.Show();
                this.Close();
            }
        }
    }
}
