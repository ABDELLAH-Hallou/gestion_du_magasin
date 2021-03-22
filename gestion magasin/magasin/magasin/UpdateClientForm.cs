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
    public partial class UpdateClientForm : Form
    {
        public UpdateClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkInfo())
                {
                    MessageBox.Show("les textbox sont vide !!");
                    return;
                }
                MySqlConnectionStringBuilder cox = new MySqlConnectionStringBuilder();
                cox.Server = "localhost";
                cox.UserID = "root";
                cox.Password = "Abdo@2020";
                cox.Database = "magasin";
                cox.Port = 3306;
                var cs = cox.ToString();
                MySqlConnection con = new MySqlConnection(cs);
                String nom = this.textBox2.Text.Trim();
                String prenom = this.textBox3.Text.Trim();
                String age = this.textBox4.Text.Trim();
                String adresse = this.textBox5.Text.Trim();
                String ville = this.textBox6.Text.Trim();
                String specialite = this.textBox7.Text.Trim();
                String mail = this.textBox8.Text.Trim();
                String query = "update client set nom = '" + nom + "',prenom='" + prenom + "',age=" +
                    age + ",adresse='" + adresse + "',ville='" + ville + "',specialite='" +
                     specialite + "',mail='" + mail + "' where idClient = " + this.textBox1.Text.Trim() + ";";
                MySqlCommand cmd = new MySqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                int a = cmd.ExecuteNonQuery();
                MessageBox.Show(a + " lines affected !");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox8.Text = String.Empty;
        }
        private bool checkInfo()
        {
            if (this.textBox1.Text.Trim().Equals(string.Empty) ||
                this.textBox2.Text.Trim().Equals(string.Empty) ||
                this.textBox3.Text.Trim().Equals(string.Empty) ||
                this.textBox4.Text.Trim().Equals(string.Empty) ||
                this.textBox5.Text.Trim().Equals(string.Empty) ||
                this.textBox6.Text.Trim().Equals(string.Empty))
                return false;
            else
                return true;
        }
    }
}
