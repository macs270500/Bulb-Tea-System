using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Bulb_Tea_System
{
    public partial class Form4 : Form
    {
        clsDataGridDataSource dataSource = new clsDataGridDataSource();
        public Form4(string S, string P, string T)
        {
            InitializeComponent();
            txtS.Text = int.Parse(S).ToString("C2");
            txtP.Text = int.Parse(P).ToString("C2");
            txtC.Text = int.Parse(T).ToString("C2");

        }
        Form1 f1 = new Form1();

        private void Form4_Load(object sender, EventArgs e)
        {
            int FruitUsed = 0;
            int MilkUsed = 0;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            for (int i = 0; i < Form1.lvi.Items.Count; i++)
            {
                ListViewItem lcc = new ListViewItem(Form1.lvi.Items[i].Text);
                lcc.SubItems.Add(Form1.lvi.Items[i].SubItems[1].Text);
                lcc.SubItems.Add(Form1.lvi.Items[i].SubItems[2].Text);
                lcc.SubItems.Add(Form1.lvi.Items[i].SubItems[3].Text);

                listCusCopy.Items.Add(lcc);
                if (listCusCopy.Items[i].Text == "FruitTea(Syrup)")
                {
                    FruitUsed += int.Parse(listCusCopy.Items[i].SubItems[2].Text);
                }
                else
                {
                    MilkUsed += int.Parse(listCusCopy.Items[i].SubItems[2].Text);

                }
            }
            if (FruitUsed > 0)
            {
                SqlConnection connStr = new SqlConnection(dataSource.connStr);
                connStr.Open();
                SqlCommand cmd = new SqlCommand($"exec UpdateTransactions @Qty = {FruitUsed} , @ID = '0001'", connStr);
                SqlCommand cmd1 = new SqlCommand($"exec UpdateTransactions @Qty = {FruitUsed} , @ID = '0003'", connStr);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd.Dispose();
                cmd1.Dispose();
                connStr.Close();
            }
            if (MilkUsed > 0)
            {
                SqlConnection connStr = new SqlConnection(dataSource.connStr);
                connStr.Open();
                SqlCommand cmd = new SqlCommand($"exec UpdateTransactions @Qty = {MilkUsed} , @ID = '0002'", connStr);
                SqlCommand cmd1 = new SqlCommand($"exec UpdateTransactions @Qty = {MilkUsed} , @ID = '0004'", connStr);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd.Dispose();
                cmd1.Dispose();
                connStr.Close();

            }

        }

        private void listCusCopy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

    }
}
