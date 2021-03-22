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
    public partial class UpdateLigneForm : Form,ILigne
    {
        public UpdateLigneForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ligne lgn = new Ligne(this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), this.textBox3.Text.Trim());
            try
            {
                if (!checkInfo())
                {
                    MessageBox.Show("les textbox sont vide !!");
                    return;
                }
                Update(lgn);
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
        public void Add(Ligne ligne) { }
        public void Delete(int idCommande, String idArticle, int position) { }
        public void Update(Ligne ligne) 
        {
            MySqlConnection con = MyConnexion.GetConnexion();
            if (con != null)
            {
                String query = "update ligne set quantite = @quantite where idCommande = @idCommande and  idArticle = @idArticle;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idCommande", ligne.idCommande);
                cmd.Parameters.AddWithValue("@idArticle", ligne.idArticle);
                cmd.Parameters.AddWithValue("@quantite", ligne.quantite);
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
