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
    public partial class DeleteLigneForm : Form,ILigne
    {
        public DeleteLigneForm()
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
            position = this.dgvdeleteligne.CurrentRow.Index;
            int idCommande = Convert.ToInt32(this.dgvdeleteligne.Rows[position].Cells[0].Value.ToString());
            String idArticle = this.dgvdeleteligne.Rows[position].Cells[1].Value.ToString();
            if (position == -1)
            {
                MessageBox.Show(position + "no row selected");
                return;
            }
            DialogResult dialog = MessageBox.Show("are you sure?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;
            Delete(idCommande, idArticle, position);
        }
        public void Add(Ligne ligne) { }
        public void Delete(int idCommande, String idArticle, int position) 
        {
            MySqlConnection con = MyConnexion.GetConnexion();
            if (con != null)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "";
                cmd.CommandText = "delete from ligne where idCommande = @idCommande and idArticle = @idArticle";
                cmd.Parameters.AddWithValue("@idCommande", idCommande);
                cmd.Parameters.AddWithValue("@idArticle", idArticle);
                cmd.ExecuteNonQuery();
                this.dgvdeleteligne.Rows.RemoveAt(position);
                MessageBox.Show("Ligne deleted succesfully");
            }
            MyConnexion.CloseConnection();
        }
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
                    dgvdeleteligne.Rows.Clear();
                    while (rd.Read())
                    {
                        dgvdeleteligne.Rows.Add(rd[0], rd[1], rd[2]);
                    }
                }
                else
                    MessageBox.Show("table Ligne est vide !");
                dgvdeleteligne.ClearSelection();
            }
            MyConnexion.CloseConnection();
        }
    }
}
