using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Bulb_Tea_System
{
    public class clsDataGridDataSource
    {
        public string connStr = "Data Source=MACS;Initial Catalog=BulbTea;Integrated Security=True";
        
        public DataTable SqlDataTable(string sqlStr)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sda.Dispose();
            return dt;
        }
        public void SqlCommandExecution(string sqlStr)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr.ToString());
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sqlStr;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
