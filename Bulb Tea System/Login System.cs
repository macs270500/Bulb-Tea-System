using System;
using System.Data;
using System.Windows.Forms;

namespace Bulb_Tea_System
{

    public partial class Login_System : Form
    {
        public Login_System()
        {
            InitializeComponent();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        clsDataGridDataSource clsData = new clsDataGridDataSource();
        DataTable DT = new DataTable();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string Password = txtPassword.Text;

            if (ID.StartsWith("0"))
            {
                string sqlStr = $"Select OwnerID, Password from owner Where OwnerID = '{ID}'";
                DT = clsData.SqlDataTable(sqlStr);
            }
            else
            {
                string sqlStr = $"Select EmpID, Password from Employees Where EmpID = '{ID}'";
                DT = clsData.SqlDataTable(sqlStr);
            }
            try
            {
                if (Password == DT.Rows[0]["Password"].ToString())
                {
                    Loading_Screen loading = new Loading_Screen();
                    if (ID.StartsWith("0"))
                    {
                        loading.Show();
                        Hide();
                    }
                    else if (ID.StartsWith("BT"))
                    {
                        loading.Show();
                        loading.btnSelection(Password);
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password!! Try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("ID or Password not found!! Please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Clear();
                txtPassword.Clear();
                txtID.Focus();
            }

        }
    }
}

