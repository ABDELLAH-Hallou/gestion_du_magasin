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
    public partial class DeleteCommandeForm : Form,ICommande
    {
        public DeleteCommandeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int position = -1;
            position = this.dgvdeletecommande.CurrentRow.Index;
            int idCommande = Convert.ToInt32(this.dgvdeletecommande.Rows[position].Cells[0].Value.ToString());
            if (position == -1)
            {
                MessageBox.Show(position + "no row selected");
                return;
            }
            DialogResult dialog = MessageBox.Show("are you sure?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;
            Delete(idCommande, position);
        }
        public void Add(Commande commande) { }
        public void Delete(int idCommande, int position) 
        {
            MySqlConnection con = MyConnexion.GetConnexion();
            if (con != null)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "";
                cmd.CommandText = "delete from commande where idCommande = @idCommande";
                cmd.Parameters.AddWithValue("@idCommande", idCommande);
                cmd.ExecuteNonQuery();
                this.dgvdeletecommande.Rows.RemoveAt(position);
                MessageBox.Show("Commande deleted succesfully");
            }
            MyConnexion.CloseConnection();
        }
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
                    dgvdeletecommande.Rows.Clear();
                    while (rd.Read())
                    {
                        dgvdeletecommande.Rows.Add(rd[0], rd[1], rd[2]);
                    }
                }
                else
                    MessageBox.Show("table commande est vide !");
                dgvdeletecommande.ClearSelection();
            }
            MyConnexion.CloseConnection();
        }
    }
}
