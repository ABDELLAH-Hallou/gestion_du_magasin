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
    public partial class ShowLigneForm : Form,ILigne
    {
        public ShowLigneForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show();       
        }
        public void Add(Ligne ligne) { }
        public void Delete(int idCommande, String idArticle, int position) { }
        public void Update(Ligne ligne) { }
        public new void Show() 
        {
            MySqlConnection con = MyConnexion.GetConnexion();
            if (con != null)
            {
                String query = "select * from ligne";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    dgvLigne.Rows.Clear();
                    while (rd.Read())
                    {
                        dgvLigne.Rows.Add(rd[0], rd[1], rd[2]);
                    }
                }
                else
                    MessageBox.Show("table Ligne est vide !");
                dgvLigne.ClearSelection();
            }
            MyConnexion.CloseConnection();
        }
    }
}
