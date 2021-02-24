using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testProject.allForms
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {

            DataSet dsEmp=new DataSet();
           

            string  strEmp ="SELECT emp.EmployeeCode , emp.EmployeeName  , emp.TeamCode , emp.Gender ,dept.DepartmentName " +
                                ", sec.SectionName , des.DesignationName FROM Employees emp" +
                               " INNER JOIN Departments dept" +
                               " ON emp.DepartmentCode =  dept.DepartmentCode " +
                               " INNER JOIN Sections  sec " +
                           " ON  emp.SectionCode= sec.SectionCode " +
                            " INNER JOIN Designations des " +
                            " ON emp.DesignationCode = des.DesignationCode";

            dsEmp=Class.c_Connection.ConnectSQL( strEmp);

            DataTable dtemp = new DataTable();

            dsEmp.Tables[0].Columns.Add("Edit", typeof(String));

          // dsEmp.Tables[0].Rows.Add("test");


            for (int count = 0; count < dsEmp.Tables[0].Rows.Count; count++)
            {



            }
            this.dgEmployees.DataSource = dsEmp;
            this.dgEmployees.DataMember = "Table";







        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
