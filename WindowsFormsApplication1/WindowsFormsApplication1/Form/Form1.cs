using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

            DataSet dsEmployee = new DataSet();
            DataTable dtEmployee = dsEmployee.Tables.Add("Employees");
            DataTable dtDept = dsEmployee.Tables.Add("Departments");


            string strEmp = "select employeecode, employeename from employees";
          
            //  string strdept = "select departmentcode, departmentname from departments";


            dsEmployee = Class.C_Connection.Connect_SQL(strEmp);



            //dtDept = Class.C_Connection.Connect_SQL(strDept).Tables[0];
            //dtDept.TableName = "Departments";
           // dsEmployee.Tables.Add(dtDept);
           // DataTable dtDept = new DataTable("Departments");
           // dsEmployee.Tables.Add(dtDept);


            dgvEmp.DataSource = dsEmployee;
            dgvEmp.DataMember = "Table";

        }


    }
}
