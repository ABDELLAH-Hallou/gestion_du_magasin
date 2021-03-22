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
    public partial class DeleteClientForm : Form,IClient
    {
        public DeleteClientForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show();
        }
        
        private void dgvdeleteclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int position = -1;
            position = this.dgvdeleteclient.CurrentRow.Index;
            int idClient = Convert.ToInt32(this.dgvdeleteclient.Rows[position].Cells[0].Value.ToString());
            if (position ==-1)
            {
                MessageBox.Show(position+"no row selected");
                return;
            }
            DialogResult dialog = MessageBox.Show("are you sure?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;
            Delete(idClient, position);
        }
        public void Add(Client client) { }
        public void Delete(int idClient,int position) 
        {
            MySqlConnection con = MyConnexion.GetConnexion();
            if (con != null)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "";
                cmd.CommandText = "delete from client where idClient = @idClient";
                cmd.Parameters.AddWithValue("@idClient", idClient);
                cmd.ExecuteNonQuery();
                this.dgvdeleteclient.Rows.RemoveAt(position);
                MessageBox.Show("the Client is deleted succesfully");
            }
            MyConnexion.CloseConnection();
        }
        public void Update(Client client) { }

        public new void Show()
        {
            MySqlConnection con = MyConnexion.GetConnexion();
            if (con != null)
            {
                String query = "select * from client";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    dgvdeleteclient.Rows.Clear();
                    while (rd.Read())
                    {
                        dgvdeleteclient.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6], rd[7]);
                    }
                }
                else
                    MessageBox.Show("table Client est vide !");
                dgvdeleteclient.ClearSelection();
            }
            MyConnexion.CloseConnection();
        }
    }
}
