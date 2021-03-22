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
    public partial class UpdateCommandeForm : Form,ICommande
    {
        public UpdateCommandeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Commande cmnd = new Commande(this.textBox1.Text.Trim(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), this.textBox2.Text.Trim());
            try
            {
                if (!checkInfo())
                {
                    MessageBox.Show("les textbox sont vide !!");
                    return;
                }
                Update(cmnd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }
        private bool checkInfo()
        {
            if (this.textBox1.Text.Trim().Equals(string.Empty) ||
                this.textBox2.Text.Trim().Equals(string.Empty))
                return false;
            else
                return true;
        }
        public void Add(Commande commande) { }
        public void Delete(int idCommande, int position) { }
        public void Update(Commande commande) 
        {
            MySqlConnection con = MyConnexion.GetConnexion();
            if (con != null)
            {
                String query = "update commande set date = @date, idClient = @idClient where idCommande = @idCommande;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idCommande", commande.idCommande);
                cmd.Parameters.AddWithValue("@date", commande.date);
                cmd.Parameters.AddWithValue("@idClient", commande.idClient);
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
