
namespace magasin
{
    partial class AddArticleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdophoto = new System.Windows.Forms.RadioButton();
            this.rdovideo = new System.Windows.Forms.RadioButton();
            this.rdodivers = new System.Windows.Forms.RadioButton();
            this.rdoinformatique = new System.Windows.Forms.RadioButton();
            this.rdotous = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(293, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(264, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(261, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Prix";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(44, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Designation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(44, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Article ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdotous);
            this.groupBox1.Controls.Add(this.rdoinformatique);
            this.groupBox1.Controls.Add(this.rdodivers);
            this.groupBox1.Controls.Add(this.rdovideo);
            this.groupBox1.Controls.Add(this.rdophoto);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(264, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 95);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorie";
            // 
            // rdophoto
            // 
            this.rdophoto.AutoSize = true;
            this.rdophoto.Location = new System.Drawing.Point(8, 17);
            this.rdophoto.Name = "rdophoto";
            this.rdophoto.Size = new System.Drawing.Size(52, 17);
            this.rdophoto.TabIndex = 0;
            this.rdophoto.TabStop = true;
            this.rdophoto.Text = "photo";
            this.rdophoto.UseVisualStyleBackColor = true;
            // 
            // rdovideo
            // 
            this.rdovideo.AutoSize = true;
            this.rdovideo.Location = new System.Drawing.Point(79, 17);
            this.rdovideo.Name = "rdovideo";
            this.rdovideo.Size = new System.Drawing.Size(51, 17);
            this.rdovideo.TabIndex = 1;
            this.rdovideo.TabStop = true;
            this.rdovideo.Text = "vidéo";
            this.rdovideo.UseVisualStyleBackColor = true;
            // 
            // rdodivers
            // 
            this.rdodivers.AutoSize = true;
            this.rdodivers.Location = new System.Drawing.Point(6, 40);
            this.rdodivers.Name = "rdodivers";
            this.rdodivers.Size = new System.Drawing.Size(53, 17);
            this.rdodivers.TabIndex = 2;
            this.rdodivers.TabStop = true;
            this.rdodivers.Text = "divers";
            this.rdodivers.UseVisualStyleBackColor = true;
            // 
            // rdoinformatique
            // 
            this.rdoinformatique.AutoSize = true;
            this.rdoinformatique.Location = new System.Drawing.Point(6, 63);
            this.rdoinformatique.Name = "rdoinformatique";
            this.rdoinformatique.Size = new System.Drawing.Size(82, 17);
            this.rdoinformatique.TabIndex = 3;
            this.rdoinformatique.TabStop = true;
            this.rdoinformatique.Text = "informatique";
            this.rdoinformatique.UseVisualStyleBackColor = true;
            // 
            // rdotous
            // 
            this.rdotous.AutoSize = true;
            this.rdotous.Location = new System.Drawing.Point(79, 40);
            this.rdotous.Name = "rdotous";
            this.rdotous.Size = new System.Drawing.Size(45, 17);
            this.rdotous.TabIndex = 4;
            this.rdotous.TabStop = true;
            this.rdotous.Text = "tous";
            this.rdotous.UseVisualStyleBackColor = true;
            // 
            // AddArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddArticleForm";
            this.Text = "AddArticleForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdotous;
        private System.Windows.Forms.RadioButton rdoinformatique;
        private System.Windows.Forms.RadioButton rdodivers;
        private System.Windows.Forms.RadioButton rdovideo;
        private System.Windows.Forms.RadioButton rdophoto;
    }
}