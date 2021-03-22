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
    public partial class ShowCommandeForm : Form,ICommande
    {
        public ShowCommandeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show();
        }
        public void Add(Commande commande) { }
        public void Delete(int idCommande, int position) { }
        public void Update(Commande commande) { }
        public new void Show() 
        {
            MySqlConnection con = MyConnexion.GetConnexion();
            if (con != null)
            {
                String query = "select * from commande";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    dgvCommande.Rows.Clear();
                    while (rd.Read())
                    {
                        dgvCommande.Rows.Add(rd[0], rd[1], rd[2]);
                    }
                }
                else
                    MessageBox.Show("table commande est vide !");
                dgvCommande.ClearSelection();
            }
            MyConnexion.CloseConnection();
        }
    }
}
