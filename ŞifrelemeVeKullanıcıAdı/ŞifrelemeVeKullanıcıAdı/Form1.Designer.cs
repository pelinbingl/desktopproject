namespace ŞifrelemeVeKullanıcıAdı
{
    partial class Form1
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
            this.labelKullanıcıAdı = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.textBoxKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.labelŞifre = new System.Windows.Forms.Label();
            this.comboBoxAlgoritma = new System.Windows.Forms.ComboBox();
            this.buttonKayıt = new System.Windows.Forms.Button();
            this.textBoxPlatform = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlatform = new System.Windows.Forms.Label();
            this.checkBoxSifre = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKullanıcıAdı
            // 
            this.labelKullanıcıAdı.AutoSize = true;
            this.labelKullanıcıAdı.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKullanıcıAdı.Location = new System.Drawing.Point(12, 168);
            this.labelKullanıcıAdı.Name = "labelKullanıcıAdı";
            this.labelKullanıcıAdı.Size = new System.Drawing.Size(200, 43);
            this.labelKullanıcıAdı.TabIndex = 0;
            this.labelKullanıcıAdı.Text = "Kullanıcı Adı:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonCikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 148);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Şifre Kayıt";
            // 
            // buttonCikis
            // 
            this.buttonCikis.Location = new System.Drawing.Point(374, 11);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(49, 48);
            this.buttonCikis.TabIndex = 0;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // textBoxKullanıcıAdı
            // 
            this.textBoxKullanıcıAdı.Location = new System.Drawing.Point(207, 168);
            this.textBoxKullanıcıAdı.Name = "textBoxKullanıcıAdı";
            this.textBoxKullanıcıAdı.Size = new System.Drawing.Size(201, 41);
            this.textBoxKullanıcıAdı.TabIndex = 2;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(207, 241);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(201, 41);
            this.textBoxSifre.TabIndex = 4;
            // 
            // labelŞifre
            // 
            this.labelŞifre.AutoSize = true;
            this.labelŞifre.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelŞifre.Location = new System.Drawing.Point(12, 241);
            this.labelŞifre.Name = "labelŞifre";
            this.labelŞifre.Size = new System.Drawing.Size(104, 43);
            this.labelŞifre.TabIndex = 3;
            this.labelŞifre.Text = "Şifre:";
            // 
            // comboBoxAlgoritma
            // 
            this.comboBoxAlgoritma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgoritma.FormattingEnabled = true;
            this.comboBoxAlgoritma.Location = new System.Drawing.Point(18, 440);
            this.comboBoxAlgoritma.Name = "comboBoxAlgoritma";
            this.comboBoxAlgoritma.Size = new System.Drawing.Size(390, 44);
            this.comboBoxAlgoritma.TabIndex = 5;
            this.comboBoxAlgoritma.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlgoritma_SelectedIndexChanged);
            // 
            // buttonKayıt
            // 
            this.buttonKayıt.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonKayıt.Font = new System.Drawing.Font("Ink Free", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKayıt.Location = new System.Drawing.Point(113, 527);
            this.buttonKayıt.Name = "buttonKayıt";
            this.buttonKayıt.Size = new System.Drawing.Size(180, 60);
            this.buttonKayıt.TabIndex = 6;
            this.buttonKayıt.Text = "Kayıt Et";
            this.buttonKayıt.UseVisualStyleBackColor = false;
            this.buttonKayıt.Click += new System.EventHandler(this.buttonKayıt_Click);
            // 
            // textBoxPlatform
            // 
            this.textBoxPlatform.Location = new System.Drawing.Point(207, 356);
            this.textBoxPlatform.Name = "textBoxPlatform";
            this.textBoxPlatform.Size = new System.Drawing.Size(201, 41);
            this.textBoxPlatform.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-104, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şifre:";
            // 
            // labelPlatform
            // 
            this.labelPlatform.AutoSize = true;
            this.labelPlatform.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlatform.Location = new System.Drawing.Point(12, 359);
            this.labelPlatform.Name = "labelPlatform";
            this.labelPlatform.Size = new System.Drawing.Size(161, 43);
            this.labelPlatform.TabIndex = 9;
            this.labelPlatform.Text = "Platform:";
            // 
            // checkBoxSifre
            // 
            this.checkBoxSifre.AutoSize = true;
            this.checkBoxSifre.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSifre.Location = new System.Drawing.Point(18, 297);
            this.checkBoxSifre.Name = "checkBoxSifre";
            this.checkBoxSifre.Size = new System.Drawing.Size(208, 38);
            this.checkBoxSifre.TabIndex = 10;
            this.checkBoxSifre.Text = "Şifreyi Göster";
            this.checkBoxSifre.UseVisualStyleBackColor = true;
            this.checkBoxSifre.CheckedChanged += new System.EventHandler(this.checkBoxSifre_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 663);
            this.Controls.Add(this.checkBoxSifre);
            this.Controls.Add(this.labelPlatform);
            this.Controls.Add(this.textBoxPlatform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKayıt);
            this.Controls.Add(this.comboBoxAlgoritma);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.labelŞifre);
            this.Controls.Add(this.textBoxKullanıcıAdı);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelKullanıcıAdı);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKullanıcıAdı;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxKullanıcıAdı;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label labelŞifre;
        private System.Windows.Forms.ComboBox comboBoxAlgoritma;
        private System.Windows.Forms.Button buttonKayıt;
        private System.Windows.Forms.TextBox textBoxPlatform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlatform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.CheckBox checkBoxSifre;
    }
}

