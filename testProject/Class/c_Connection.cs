using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace testProject.Class
{
    class c_Connection
    {

        public static string Err { get; set; }
        public static DataSet ConnectSQL(string strQuery )
        {

            var sqlCon = new SqlConnection(Properties.Resources.strConnectionString);
            var sqlAdapter = new SqlDataAdapter(strQuery, sqlCon);

            DataSet dsUser = new DataSet();

            try
            {
                sqlCon.Open();
                sqlAdapter.Fill(dsUser);
                

            }
            catch(Exception getErr) {
                Err = getErr.Message;
                
            }
            finally
            {
                sqlCon.Close();
            }

            Console.WriteLine(dsUser);
            return dsUser;
            
        }
    }
}
