﻿using System;
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
    public partial class UpdateCommandeForm : Form
    {
        public UpdateCommandeForm()
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
                String query = "update commande set date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',idClient = " + 
                    this.textBox2.Text.Trim() + " where idCommande = " + this.textBox1.Text.Trim() + ";";
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
    }
}
