using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bulb_Tea_System
{
    public partial class frmPayroll : Form
    {
        public frmPayroll()
        {
            InitializeComponent();
        }

        clsDataGridDataSource dataSource = new clsDataGridDataSource();
        public void fillComboBox()
        {
            SqlConnection con = new SqlConnection(dataSource.connStr);
            string sqlStr = "Select EmpID, EmpFName, EmpLName, EmpAddress, EmpPhone, EmpSalary from Employees";
            SqlCommand cmd = new SqlCommand(sqlStr, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string EmpID = myreader.GetString(0);
                    cBempID.Items.Add(EmpID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cBempID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(dataSource.connStr);
            string sqlStr = "Select EmpID, EmpFName, EmpLName, EmpAddress, EmpPhone, EmpSalary from Employees where EmpID = '" + cBempID.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlStr, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string prevTotal = myreader["EmpSalary"].ToString();
                    txtprevsal.Text = prevTotal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txthours.Clear();
            txtovertime.Clear();
            txtsalary.Clear();
            txttotalsal.Clear();


        }
        DateTime timeIn = DateTime.Now;
        DateTime timeOut = DateTime.Now;
        private void btnProcess_Click(object sender, EventArgs e)
        {

            try
            {
                timeIn = DateTime.Parse(txtIN.Text);
                timeOut = DateTime.Parse(txtOut.Text);
            }
            catch (FormatException)
            {

            }
            TimeSpan HoursWork = timeOut.Subtract(timeIn);
            txthours.Text = (HoursWork.Hours).ToString();

            Compute(timeIn, timeOut, HoursWork, out double overtime, out double salary, out double newsalary);

            txtovertime.Text = overtime.ToString();
            txtsalary.Text = salary.ToString();
            txttotalsal.Text = newsalary.ToString();


            string query = "UPDATE Employees SET EmpSalary ='" + txttotalsal.Text + "'where EmpID = '" + cBempID.Text + "'";
            dataSource.SqlCommandExecution(query);

        }



        private void Compute(DateTime timeIn, DateTime timeOut, TimeSpan HoursWork, out double overtime, out double salary, out double newsalary)
        {
            overtime = 0;
            newsalary = 0;
            if (HoursWork.Hours > 8)
            {
                overtime = ((HoursWork.Hours - 8) * 25);

            }
            else if ((HoursWork.Hours > 0) && (HoursWork.Hours < 9))
            {
                txtovertime.Text = "No Overtime";

            }
            else if (HoursWork.Hours < 0)
            {
                MessageBox.Show("Invalid Time Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            salary = 0;
            salary = (overtime + (HoursWork.Hours * 30));
            try
            {
                newsalary = (int.Parse(txtprevsal.Text)) + (HoursWork.Hours * 30) + (overtime);
            }
            catch (Exception)
            {

            }
        }
        public bool Employee = false;
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            int reset = 0;
            DialogResult result = MessageBox.Show("Are you sure you want to reset employees wages?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string query = "UPDATE Employees SET EmpSalary ='" + reset.ToString() + "'";
                dataSource.SqlCommandExecution(query);

                txthours.Clear();
                txtIN.Clear();
                txtOut.Clear();
                txtovertime.Clear();
                txtprevsal.Clear();
                txtsalary.Clear();
                txttotalsal.Clear();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            datagrid frm = new datagrid();
            frm.ShowDialog();
        }

        private void frmPayroll_Load(object sender, EventArgs e)
        {
            fillComboBox();
        }
    }
}
