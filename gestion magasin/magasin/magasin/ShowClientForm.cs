using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace magasin
{
    public partial class ShowClientForm : Form
    {
        public ShowClientForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder cox = new MySqlConnectionStringBuilder();
            cox.Server = "localhost";
            cox.UserID = "root";
            cox.Password = "Abdo@2020";
            cox.Database = "magasin";
            cox.Port = 3306;
            var cs = cox.ToString();
            MySqlConnection con = new MySqlConnection(cs);
            String query = "select * from client";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                dgvClient.Rows.Clear();
                while (rd.Read())
                {
                    dgvClient.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6], rd[7]);
                }
                con.Close();
            }
            else
                MessageBox.Show("table Client est vide !");
            dgvClient.ClearSelection();
        }
    }
}
