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
    public partial class ShowClientForm : Form,IClient
    {
        public ShowClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show();
        }
        public void Add(Client client) { }
        public void Delete(int idClient, int position) { }
        public void Update(Client client) { }
        
        public new void Show()
        {
            MySqlConnection con = MyConnexion.GetConnexion();
            if (con != null)
            {
                String query = "select * from client";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader rd= cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    dgvClient.Rows.Clear();
                    while (rd.Read())
                    {
                        dgvClient.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6], rd[7]);
                    }
                }
                else
                    MessageBox.Show("table Client est vide !");
                dgvClient.ClearSelection();
            }
            MyConnexion.CloseConnection();
        }
    }
}
