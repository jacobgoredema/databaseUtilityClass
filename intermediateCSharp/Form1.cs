using intermediateCSharp.UtilityClasses;
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

namespace intermediateCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetSalary_Click(object sender, EventArgs e)
        {
            SqlParameter parameterId = new SqlParameter("@Id", SqlDbType.Int);
            SqlParameter parameterSalary = new SqlParameter("@Salary", SqlDbType.Money);

            parameterSalary.Direction = ParameterDirection.Output;
            parameterId.Value = txtId.Text;

            DatabaseUtility.ExecuteStoredProcedureNonQuery("GetSalary", parameterId, parameterSalary);

            if (parameterSalary.Value == DBNull.Value)
                MessageBox.Show("0");
            else
                MessageBox.Show(parameterSalary.Value.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetEmployeeSalary_Click(object sender, EventArgs e)
        {
            // get all employees ids
            string sql = "GetEmployees";
            SqlDataReader dataReader = DatabaseUtility.ExecuteStoredProcedureReader(sql);
            dataReader.Read();
            MessageBox.Show(dataReader[0].ToString());
            dataReader.NextResult();
            string s = string.Empty;
            while(dataReader.Read())
            {
                s += dataReader[0].ToString() + "\n";
            }

            dataReader.Close();
            MessageBox.Show(s);
        }
    }
}
