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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
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
                String query = "insert into client values (" + this.textBox1.Text.Trim() + ",'" + this.textBox2.Text.Trim() + "','" +
                        this.textBox3.Text.Trim() + "'," + this.textBox4.Text.Trim() + ",'" + this.textBox5.Text.Trim() + "','" + 
                        this.textBox6.Text.Trim() + "','" + this.textBox7.Text.Trim() + "','" + this.textBox8.Text.Trim() + "');";
                MySqlCommand cmd = new MySqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                int a = cmd.ExecuteNonQuery();
                MessageBox.Show(a + " affected lines !");
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
