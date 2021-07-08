using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bulb_Tea_System
{
    public partial class Form1 : Form
    {
        clsDataGridDataSource dataSource = new clsDataGridDataSource();
        public Form1()
        {
            InitializeComponent();
        }
        public static ListView lvi = new ListView();
        int price = 0;
        int total = 0;
        double Discount = 0;
        //SqlConnection con;
        //SqlCommand cmd;
        //SqlDataAdapter sda;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string sqlStr = "Select ProductName from Stock_Management";
        DataTable dt = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'bulbTeaDataSet.product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.bulbTeaDataSet.product);
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, dataSource.connStr);
            sda.Fill(dt);
            sda.Dispose();
            char c = char.Parse(" ");
            ; for (int i = 0; i < 2; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["ProductName"].ToString().TrimEnd(c));
            }

        }

        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Form2 f2 = new Form2();
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    txtFlavour.Text = f2.flavour;
                    groupBox1.Text = f2.based;

                }

            }
            if (comboBox1.SelectedIndex == 1)

            {
                Form3 f3 = new Form3();
                if (f3.ShowDialog() == DialogResult.OK)
                {
                    groupBox1.Text = f3.bas;
                    txtFlavour.Text = f3.fav;

                }
            }

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("do you want to close", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtBal.Text = (int.Parse(txtPaid.Text) - int.Parse(txtTP.Text)).ToString();
        }

        private void txtDis_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                errorProvider1.SetError(comboBox1, "choose a Base");
            }
            if (comboBox1.Text == "FruitTea(Syrup)")
            {
                errorProvider1.Dispose();

                if (radRegular.Checked)
                {
                    price = 90;
                }
                else if (radLarge.Checked)
                {
                    price = 110;
                }


            }

            if (comboBox1.Text == "MilkTea(Powder)")
            {
                errorProvider1.Dispose();
                if (radRegular.Checked)
                {

                    price = 110;
                }
                else if (radLarge.Checked)
                {

                    price = 125;
                }


            }
            if (txtQty.Text == "")
            {
                errorProvider2.SetError(txtQty, "Please enter quantity");
            }
            else
            {
                errorProvider2.Dispose();
                int Qty = int.Parse(txtQty.Text);

                price = Qty * price;
                total = int.Parse(txtPrice.Text) + price;
            }



            txtPrice.Text = total.ToString();
            string[] sp = new string[4];
            sp[0] = comboBox1.Text.ToString();
            sp[1] = txtFlavour.Text.ToString();
            sp[2] = txtQty.Text.ToString();
            sp[3] = price.ToString();
            ListViewItem spr = new ListViewItem(sp);
            ListViewItem spr2 = new ListViewItem(sp);
            listView1.Items.Add(spr);
            lvi.Items.Add(spr2);


            if (gbBulb.Enabled)
            {
                if (radBulb.Checked)
                {
                    Discount += (price * 0.10);
                    txtDis.Text = Discount.ToString();
                    txtTP.Text = ((int.Parse(txtPrice.Text) - (int.Parse(txtDis.Text)))).ToString();

                }
                else if (radNoBulb.Checked)
                {
                    txtTP.Text = total.ToString();
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Do you really want to delete this item", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Selected)
                        {
                            txtPrice.Text = (int.Parse(txtPrice.Text) - int.Parse(listView1.Items[i].SubItems[3].Text)).ToString();
                            Discount -= (double.Parse(listView1.Items[i].SubItems[3].Text) * .10);
                            txtDis.Text = Discount.ToString();
                            txtTP.Text = (double.Parse(txtPrice.Text) - Discount).ToString();
                            listView1.Items[i].Remove();
                            lvi.Items.RemoveAt(i);
                        }
                    }

                }

            }
        }

        DataTable DT = new DataTable();
        string SqlStr = "SELECT * FROM Transactions";
        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (txtPaid.Text == "")
            {
                errorProvider3.SetError(txtPaid, "Enter Amount paid");
            }
            else
            {
                errorProvider3.Dispose();
                DT = dataSource.SqlDataTable(SqlStr);
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    if (int.Parse(DT.Rows[i]["Used"].ToString()) == 100)
                    {

                        string SQLStr = $"Select productQty from Stock_Management Where ProductID = '{DT.Rows[i]["ProductID"]}'";

                        DataTable dT = new DataTable();
                        dT = dataSource.SqlDataTable(SQLStr);
                        string prodQty = dT.Rows[0].ToString();
                        int TotalQty = int.Parse(prodQty) - 1;
                        string SQL = $"update Stock_Management set ProductQty = {TotalQty} where ProductID = {DT.Rows[i]["ProductID"]} ";
                        dataSource.SqlCommandExecution(SQL);
                    }
                }
                Form4 f4 = new Form4(txtTP.Text, txtPaid.Text, txtBal.Text);
                f4.Show();
            }

        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void gbBulb_Enter(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }



        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ChartUsed f5 = new ChartUsed();
            //f5.ShowDialog();
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
    }
}
