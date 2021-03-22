using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace magasin
{
    class MyConnexion
    {
        private static MySqlConnection con;
        private MyConnexion()
        {
            MySqlConnectionStringBuilder cox = new MySqlConnectionStringBuilder();
            cox.Server = "localhost";
            cox.UserID = "root";
            cox.Password = "Abdo@2020";
            cox.Database = "magasin";
            cox.Port = 3306;
            var cs = cox.ToString();
            con = new MySqlConnection(cs);
            try
            {
                con.Open();
            }
            catch (MySqlException e)
            {
                con = null;
                MessageBox.Show(e.StackTrace);
            }
        }
        public static MySqlConnection GetConnexion()
        {
            if (con == null)
            {
                new MyConnexion();
            }
            return con;
        }
        public static void CloseConnection()
        {
            if (con != null)
            {
                con.Close();
                con = null;
            }
        }
    }
}
