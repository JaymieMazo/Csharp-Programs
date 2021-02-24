using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Class
{
    class C_Connection
    {
        public static string Err { get; set; }
        public static DataSet Connect_SQL(string strQuery) {

            var sqlCon = new SqlConnection(Properties.Resources.connectionString);
            var sqlAdptr = new SqlDataAdapter(strQuery, sqlCon);
            DataSet dsData = new DataSet();

            try
            {
                sqlCon.Open();
                sqlAdptr.Fill(dsData);
            }
            catch (Exception ex)
            {
                Err = ex.Message;
            }
            finally { 
                sqlCon.Close();
            }
            return dsData;
        }
    }
}
