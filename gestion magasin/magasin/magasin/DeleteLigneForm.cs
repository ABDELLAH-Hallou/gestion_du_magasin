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
    public partial class DeleteLigneForm : Form
    {
        public DeleteLigneForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder cox = new MySqlConnectionStringBuilder();
            cox.Server = "localhost";
            cox.UserID = "root";
            cox.Password = "Abdo@2020";
            cox.Database = "magasin";
            cox.Port = 3306;
            var cs = cox.ToString();
            MySqlConnection con = new MySqlConnection(cs);
            String query = "select * from ligne";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                dgvdeleteligne.Rows.Clear();
                while (rd.Read())
                {
                    dgvdeleteligne.Rows.Add(rd[0], rd[1], rd[2]);
                }
                con.Close();
            }
            else
                MessageBox.Show("table Ligne est vide !");
            dgvdeleteligne.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int position = -1;
            position = this.dgvdeleteligne.CurrentRow.Index;
            int idC = Convert.ToInt32(this.dgvdeleteligne.Rows[position].Cells[0].Value.ToString());
            String ida = this.dgvdeleteligne.Rows[position].Cells[1].Value.ToString();
            if (position == -1)
            {
                MessageBox.Show(position + "no row selected");
                return;
            }
            DialogResult dialog = MessageBox.Show("are you sure?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;
            MySqlConnectionStringBuilder cox = new MySqlConnectionStringBuilder();
            cox.Server = "localhost";
            cox.UserID = "root";
            cox.Password = "Abdo@2020";
            cox.Database = "magasin";
            cox.Port = 3306;
            var cs = cox.ToString();
            MySqlConnection con = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "";
            cmd.CommandText = "delete from ligne where idCommande = @idCommande and idArticle = @idArticle";
            cmd.Parameters.AddWithValue("@idCommande", idC);
            cmd.Parameters.AddWithValue("@idArticle", ida);
            con.Open();
            cmd.ExecuteNonQuery();
            this.dgvdeleteligne.Rows.RemoveAt(position);
            MessageBox.Show("Ligne deleted succesfully");
            con.Close();
        }
    }
}
