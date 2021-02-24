using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace testProject.allForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string struname = Convert.ToString(this.txtUname.Text).Trim(' ' , '*' , '.');
                
            string strpword = Convert.ToString(this.txtPword.Text).Trim(' ' , '*' , '.');

            if (struname == "" || strpword == "")
            {
                MessageBox.Show("Invalid Input" , "Access Denied!");
            }

            else
            {

                string strCheckuser = "Select  UserID , Password from Users where UserID=" +
                                         "'" + struname + "' AND Password='" +   strpword +  "'";
                                        
                              
                DataSet userLogin = new DataSet();

                userLogin = Class.c_Connection.ConnectSQL( strCheckuser);

             //   Console.WriteLine(userLogin);
                int CountUser= userLogin.Tables[0].Rows.Count;
               

                if (CountUser == 1)
                {
                    MessageBox.Show("Access granted", "Access Granted!");
                  //  allForms.MainForm
                    this.Hide();

                    allForms.MainForm newFrm = new allForms.MainForm();
                    newFrm.Show();

                }
                else if (CountUser ==0)  {
                    MessageBox.Show("Wrong Username or Password!", "Access Denied");
                }

                
            }
        }
    }
}
