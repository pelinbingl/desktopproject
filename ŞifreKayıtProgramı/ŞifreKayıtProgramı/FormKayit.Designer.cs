namespace ŞifreKayıtProgramı
{
    partial class FormKayit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.textBoxAlgSifre = new System.Windows.Forms.TextBox();
            this.labelAlgSifre = new System.Windows.Forms.Label();
            this.checkBoxSifre = new System.Windows.Forms.CheckBox();
            this.labelPlatform = new System.Windows.Forms.Label();
            this.textBoxPlatform = new System.Windows.Forms.TextBox();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.comboBoxAlgoritma = new System.Windows.Forms.ComboBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.labelŞifre = new System.Windows.Forms.Label();
            this.textBoxKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.labelKullanıcıAdı = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewVeriler = new System.Windows.Forms.DataGridView();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonCikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 128);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Şifre Kayıt";
            // 
            // buttonCikis
            // 
            this.buttonCikis.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCikis.Location = new System.Drawing.Point(1335, 31);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(49, 48);
            this.buttonCikis.TabIndex = 0;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKaydet.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(240, 568);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(172, 50);
            this.btnKaydet.TabIndex = 44;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSil.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSil.Location = new System.Drawing.Point(18, 699);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(172, 48);
            this.buttonSil.TabIndex = 43;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // textBoxAlgSifre
            // 
            this.textBoxAlgSifre.Enabled = false;
            this.textBoxAlgSifre.Location = new System.Drawing.Point(224, 272);
            this.textBoxAlgSifre.Name = "textBoxAlgSifre";
            this.textBoxAlgSifre.Size = new System.Drawing.Size(177, 22);
            this.textBoxAlgSifre.TabIndex = 3;
            // 
            // labelAlgSifre
            // 
            this.labelAlgSifre.AutoSize = true;
            this.labelAlgSifre.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgSifre.Location = new System.Drawing.Point(12, 266);
            this.labelAlgSifre.Name = "labelAlgSifre";
            this.labelAlgSifre.Size = new System.Drawing.Size(142, 28);
            this.labelAlgSifre.TabIndex = 40;
            this.labelAlgSifre.Text = "Oluşan Şifre:";
            // 
            // checkBoxSifre
            // 
            this.checkBoxSifre.AutoSize = true;
            this.checkBoxSifre.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSifre.Location = new System.Drawing.Point(224, 311);
            this.checkBoxSifre.Name = "checkBoxSifre";
            this.checkBoxSifre.Size = new System.Drawing.Size(177, 32);
            this.checkBoxSifre.TabIndex = 39;
            this.checkBoxSifre.Text = "Şifreyi Göster";
            this.checkBoxSifre.UseVisualStyleBackColor = true;
            this.checkBoxSifre.CheckedChanged += new System.EventHandler(this.checkBoxSifre_CheckedChanged);
            // 
            // labelPlatform
            // 
            this.labelPlatform.AutoSize = true;
            this.labelPlatform.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlatform.Location = new System.Drawing.Point(12, 357);
            this.labelPlatform.Name = "labelPlatform";
            this.labelPlatform.Size = new System.Drawing.Size(108, 28);
            this.labelPlatform.TabIndex = 38;
            this.labelPlatform.Text = "Platform:";
            // 
            // textBoxPlatform
            // 
            this.textBoxPlatform.Location = new System.Drawing.Point(224, 363);
            this.textBoxPlatform.Name = "textBoxPlatform";
            this.textBoxPlatform.Size = new System.Drawing.Size(177, 22);
            this.textBoxPlatform.TabIndex = 4;
            // 
            // btnSifrele
            // 
            this.btnSifrele.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSifrele.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifrele.Location = new System.Drawing.Point(18, 568);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(172, 50);
            this.btnSifrele.TabIndex = 36;
            this.btnSifrele.Text = "Sifrele";
            this.btnSifrele.UseVisualStyleBackColor = false;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // comboBoxAlgoritma
            // 
            this.comboBoxAlgoritma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgoritma.FormattingEnabled = true;
            this.comboBoxAlgoritma.Location = new System.Drawing.Point(224, 460);
            this.comboBoxAlgoritma.Name = "comboBoxAlgoritma";
            this.comboBoxAlgoritma.Size = new System.Drawing.Size(177, 24);
            this.comboBoxAlgoritma.TabIndex = 35;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(224, 211);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(177, 22);
            this.textBoxSifre.TabIndex = 34;
            // 
            // labelŞifre
            // 
            this.labelŞifre.AutoSize = true;
            this.labelŞifre.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelŞifre.Location = new System.Drawing.Point(12, 211);
            this.labelŞifre.Name = "labelŞifre";
            this.labelŞifre.Size = new System.Drawing.Size(66, 28);
            this.labelŞifre.TabIndex = 33;
            this.labelŞifre.Text = "Şifre:";
            // 
            // textBoxKullanıcıAdı
            // 
            this.textBoxKullanıcıAdı.Location = new System.Drawing.Point(224, 157);
            this.textBoxKullanıcıAdı.Name = "textBoxKullanıcıAdı";
            this.textBoxKullanıcıAdı.Size = new System.Drawing.Size(177, 22);
            this.textBoxKullanıcıAdı.TabIndex = 32;
            // 
            // labelKullanıcıAdı
            // 
            this.labelKullanıcıAdı.AutoSize = true;
            this.labelKullanıcıAdı.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKullanıcıAdı.Location = new System.Drawing.Point(12, 156);
            this.labelKullanıcıAdı.Name = "labelKullanıcıAdı";
            this.labelKullanıcıAdı.Size = new System.Drawing.Size(150, 28);
            this.labelKullanıcıAdı.TabIndex = 31;
            this.labelKullanıcıAdı.Text = "Kullanıcı Adı:";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonTemizle.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTemizle.Location = new System.Drawing.Point(18, 634);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(172, 48);
            this.buttonTemizle.TabIndex = 46;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = false;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(224, 507);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(177, 22);
            this.textBoxAra.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "Platform Ara:";
            // 
            // buttonAra
            // 
            this.buttonAra.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAra.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAra.Location = new System.Drawing.Point(240, 632);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(172, 50);
            this.buttonAra.TabIndex = 49;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = false;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewVeriler);
            this.panel2.Location = new System.Drawing.Point(422, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 591);
            this.panel2.TabIndex = 50;
            // 
            // dataGridViewVeriler
            // 
            this.dataGridViewVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVeriler.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewVeriler.Name = "dataGridViewVeriler";
            this.dataGridViewVeriler.RowHeadersWidth = 51;
            this.dataGridViewVeriler.RowTemplate.Height = 24;
            this.dataGridViewVeriler.Size = new System.Drawing.Size(963, 591);
            this.dataGridViewVeriler.TabIndex = 0;
            this.dataGridViewVeriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVeriler_CellDoubleClick);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(12, 405);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(77, 28);
            this.labelEmail.TabIndex = 52;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(224, 411);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(177, 22);
            this.textBoxEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 28);
            this.label3.TabIndex = 53;
            this.label3.Text = "Algoritma Seçim:";
            // 
            // FormKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 766);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.textBoxAlgSifre);
            this.Controls.Add(this.labelAlgSifre);
            this.Controls.Add(this.checkBoxSifre);
            this.Controls.Add(this.labelPlatform);
            this.Controls.Add(this.textBoxPlatform);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.comboBoxAlgoritma);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.labelŞifre);
            this.Controls.Add(this.textBoxKullanıcıAdı);
            this.Controls.Add(this.labelKullanıcıAdı);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.TextBox textBoxAlgSifre;
        private System.Windows.Forms.Label labelAlgSifre;
        private System.Windows.Forms.CheckBox checkBoxSifre;
        private System.Windows.Forms.Label labelPlatform;
        private System.Windows.Forms.TextBox textBoxPlatform;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.ComboBox comboBoxAlgoritma;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label labelŞifre;
        private System.Windows.Forms.TextBox textBoxKullanıcıAdı;
        private System.Windows.Forms.Label labelKullanıcıAdı;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewVeriler;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label3;
    }
}

