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
    public partial class ShowArticleForm : Form,IArticle
    {
        public ShowArticleForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show();
        }
        public void Add(Article article) { }
        public void Delete(String idArticle, int position) { }
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
                    dgvArticle.Rows.Clear();
                    while (rd.Read())
                    {
                        dgvArticle.Rows.Add(rd[0], rd[1], rd[2], rd[3]);
                    }
                    con.Close();
                }
                else
                    MessageBox.Show("table Article est vide !");
                dgvArticle.ClearSelection();
            }
            MyConnexion.CloseConnection();
        }
    }
}
