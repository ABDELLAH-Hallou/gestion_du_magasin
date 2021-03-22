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
    public partial class UpdateArticleForm : Form,IArticle
    {
        public UpdateArticleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String categorie;
            if (rdovideo.Checked)
                categorie = "vidéo";
            else if (rdophoto.Checked)
                categorie = "photo";
            else if (rdoinformatique.Checked)
                categorie = "informatique";
            else if (rdodivers.Checked)
                categorie = "divers";
            else
                categorie = "tous";
            Article artcl = new Article(this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), this.textBox3.Text.Trim(), categorie.Trim());
            try
            {
                if (!checkInfo())
                {
                    MessageBox.Show("les textbox sont vide !!");
                    return;
                }
                Update(artcl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }
        private bool checkInfo()
        {
            if (this.textBox1.Text.Trim().Equals(string.Empty) ||
                this.textBox2.Text.Trim().Equals(string.Empty) ||
                this.textBox3.Text.Trim().Equals(string.Empty))
                return false;
            else
                return true;
        }
        public void Add(Article article) { }
        public void Delete(String idArticle, int position) { }
        public void Update(Article article) 
        {
            MySqlConnection con = MyConnexion.GetConnexion();
            if (con != null)
            {
                String query = "update article set designation =@designation, prix = @prix, categorie =@categorie where idArticle =@idArticle;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idArticle", article.idArticle);
                cmd.Parameters.AddWithValue("@designation", article.designation);
                cmd.Parameters.AddWithValue("@prix", article.prix);
                cmd.Parameters.AddWithValue("@categorie", article.categorie);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                int a = cmd.ExecuteNonQuery();
                MessageBox.Show(a + " affected lines !");
            }
            MyConnexion.CloseConnection();
        }
        public new void Show() { }
    }
}
