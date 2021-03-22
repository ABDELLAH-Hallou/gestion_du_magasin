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
    public partial class DeleteClientForm : Form
    {
        public DeleteClientForm()
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
            String query = "select * from client";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                dgvdeleteclient.Rows.Clear();
                while (rd.Read())
                {
                    dgvdeleteclient.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6], rd[7]);
                }
                con.Close();
            }
            else
                MessageBox.Show("table Client est vide !");
            dgvdeleteclient.ClearSelection();
        }
        
        private void dgvdeleteclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int position = -1;
            position = this.dgvdeleteclient.CurrentRow.Index;
            int idC = Convert.ToInt32(this.dgvdeleteclient.Rows[position].Cells[0].Value.ToString());
            if (position ==-1)
            {
                MessageBox.Show(position+"no row selected");
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
            cmd.CommandText = "delete from client where idClient = @idClient";
            cmd.Parameters.AddWithValue("@idClient",idC);
            con.Open();
            cmd.ExecuteNonQuery();
            this.dgvdeleteclient.Rows.RemoveAt(position);
            MessageBox.Show("the Client is deleted succesfully");
            con.Close();
        }
    }
}
