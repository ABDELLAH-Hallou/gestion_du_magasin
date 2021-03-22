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
    public partial class DeleteArticleForm : Form,IArticle
    {
        public DeleteArticleForm()
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
            position = this.dgvdeletearticle.CurrentRow.Index;
            String idArticle = this.dgvdeletearticle.Rows[position].Cells[0].Value.ToString();
            if (position == -1)
            {
                MessageBox.Show(position + "no row selected");
                return;
            }
            DialogResult dialog = MessageBox.Show("are you sure?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;
            Delete(idArticle, position);
        }
        public void Add(Article article) { }
        public void Delete(String idArticle, int position) 
        {
            MySqlConnection con = MyConnexion.GetConnexion();
            if (con != null)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "";
                cmd.CommandText = "delete from article where idArticle = @idArticle";
                cmd.Parameters.AddWithValue("@idArticle", idArticle);
                cmd.ExecuteNonQuery();
                this.dgvdeletearticle.Rows.RemoveAt(position);
                MessageBox.Show("Artcile deleted succesfully");
            }
            MyConnexion.CloseConnection();
        }
        public void Update(Article article) { }
        public new void Show()
        {
            MySqlConnection con = MyConnexion.GetConnexion();
            if (con != null)
            {
                String query = "select * from article";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    dgvdeletearticle.Rows.Clear();
                    while (rd.Read())
                    {
                        dgvdeletearticle.Rows.Add(rd[0], rd[1], rd[2], rd[3]);
                    }
                    con.Close();
                }
                else
                    MessageBox.Show("table Article est vide !");
                dgvdeletearticle.ClearSelection();
            }
            MyConnexion.CloseConnection();
        }
    }
}
