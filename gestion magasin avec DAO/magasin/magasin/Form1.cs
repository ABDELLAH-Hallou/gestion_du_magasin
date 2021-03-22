using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using magasin;
using MySql.Data.MySqlClient;
namespace magasin
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible==false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }else
                subMenu.Visible = false;
        }

        private void tableClient_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void tableCommande_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void tableArticle_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void tableLigne_Click(object sender, EventArgs e)
        {
            showSubMenu(panel4);
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddClientForm());
        }

        private void addCommande_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddCommandeForm());
        }

        private void addArticle_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddArticleForm());
        }

        private void addLigne_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddLigneForm());
        }

        private void updateClient_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new UpdateClientForm());
        }

        private void updateCommande_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new UpdateCommandeForm());
        }

        private void updateArticle_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new UpdateArticleForm());
        }

        private void updateLigne_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new UpdateLigneForm());
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new DeleteClientForm());
        }

        private void deleteCommande_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new DeleteCommandeForm());
        }

        private void deleteArticle_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new DeleteArticleForm());
        }

        private void deleteLigne_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new DeleteLigneForm());
        }

        private void showClient_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ShowClientForm());
        }

        private void showCommande_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ShowCommandeForm());
        }

        private void showArticle_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ShowArticleForm());
        }

        private void showLigne_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ShowLigneForm());
        }
    }
}
