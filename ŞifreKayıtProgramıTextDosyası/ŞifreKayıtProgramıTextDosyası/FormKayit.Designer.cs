namespace ŞifreKayıtProgramıTextDosyası
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewVeriler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonCikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 128);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(467, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 637);
            this.panel2.TabIndex = 74;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapat.Location = new System.Drawing.Point(1210, 20);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(55, 48);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Şifre Kayıt";
            // 
            // buttonCikis
            // 
            this.buttonCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCikis.Location = new System.Drawing.Point(1502, 31);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(55, 48);
            this.buttonCikis.TabIndex = 0;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 29);
            this.label3.TabIndex = 73;
            this.label3.Text = "Algoritma Seçim:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(23, 393);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(86, 29);
            this.labelEmail.TabIndex = 72;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(235, 399);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(177, 22);
            this.textBoxEmail.TabIndex = 4;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(251, 620);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(172, 50);
            this.btnAra.TabIndex = 71;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(235, 495);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(177, 22);
            this.textBoxAra.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 70;
            this.label1.Text = "Platform Ara:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(29, 622);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(172, 48);
            this.btnTemizle.TabIndex = 69;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(251, 556);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(172, 50);
            this.btnKaydet.TabIndex = 68;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(29, 687);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(172, 48);
            this.btnSil.TabIndex = 67;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // textBoxAlgSifre
            // 
            this.textBoxAlgSifre.Enabled = false;
            this.textBoxAlgSifre.Location = new System.Drawing.Point(235, 260);
            this.textBoxAlgSifre.Name = "textBoxAlgSifre";
            this.textBoxAlgSifre.Size = new System.Drawing.Size(177, 22);
            this.textBoxAlgSifre.TabIndex = 54;
            // 
            // labelAlgSifre
            // 
            this.labelAlgSifre.AutoSize = true;
            this.labelAlgSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgSifre.Location = new System.Drawing.Point(23, 254);
            this.labelAlgSifre.Name = "labelAlgSifre";
            this.labelAlgSifre.Size = new System.Drawing.Size(164, 29);
            this.labelAlgSifre.TabIndex = 66;
            this.labelAlgSifre.Text = "Oluşan Şifre:";
            // 
            // checkBoxSifre
            // 
            this.checkBoxSifre.AutoSize = true;
            this.checkBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSifre.Location = new System.Drawing.Point(235, 299);
            this.checkBoxSifre.Name = "checkBoxSifre";
            this.checkBoxSifre.Size = new System.Drawing.Size(194, 33);
            this.checkBoxSifre.TabIndex = 65;
            this.checkBoxSifre.Text = "Şifreyi Göster";
            this.checkBoxSifre.UseVisualStyleBackColor = true;
            this.checkBoxSifre.CheckedChanged += new System.EventHandler(this.checkBoxSifre_CheckedChanged);
            // 
            // labelPlatform
            // 
            this.labelPlatform.AutoSize = true;
            this.labelPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlatform.Location = new System.Drawing.Point(23, 345);
            this.labelPlatform.Name = "labelPlatform";
            this.labelPlatform.Size = new System.Drawing.Size(117, 29);
            this.labelPlatform.TabIndex = 64;
            this.labelPlatform.Text = "Platform:";
            // 
            // textBoxPlatform
            // 
            this.textBoxPlatform.Location = new System.Drawing.Point(235, 351);
            this.textBoxPlatform.Name = "textBoxPlatform";
            this.textBoxPlatform.Size = new System.Drawing.Size(177, 22);
            this.textBoxPlatform.TabIndex = 3;
            // 
            // btnSifrele
            // 
            this.btnSifrele.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSifrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifrele.Location = new System.Drawing.Point(29, 556);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(172, 50);
            this.btnSifrele.TabIndex = 63;
            this.btnSifrele.Text = "Sifrele";
            this.btnSifrele.UseVisualStyleBackColor = false;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // comboBoxAlgoritma
            // 
            this.comboBoxAlgoritma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgoritma.FormattingEnabled = true;
            this.comboBoxAlgoritma.Location = new System.Drawing.Point(235, 448);
            this.comboBoxAlgoritma.Name = "comboBoxAlgoritma";
            this.comboBoxAlgoritma.Size = new System.Drawing.Size(177, 24);
            this.comboBoxAlgoritma.TabIndex = 5;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(235, 199);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(177, 22);
            this.textBoxSifre.TabIndex = 2;
            // 
            // labelŞifre
            // 
            this.labelŞifre.AutoSize = true;
            this.labelŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelŞifre.Location = new System.Drawing.Point(23, 199);
            this.labelŞifre.Name = "labelŞifre";
            this.labelŞifre.Size = new System.Drawing.Size(75, 29);
            this.labelŞifre.TabIndex = 60;
            this.labelŞifre.Text = "Şifre:";
            // 
            // textBoxKullanıcıAdı
            // 
            this.textBoxKullanıcıAdı.Location = new System.Drawing.Point(235, 145);
            this.textBoxKullanıcıAdı.Name = "textBoxKullanıcıAdı";
            this.textBoxKullanıcıAdı.Size = new System.Drawing.Size(177, 22);
            this.textBoxKullanıcıAdı.TabIndex = 1;
            // 
            // labelKullanıcıAdı
            // 
            this.labelKullanıcıAdı.AutoSize = true;
            this.labelKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKullanıcıAdı.Location = new System.Drawing.Point(23, 144);
            this.labelKullanıcıAdı.Name = "labelKullanıcıAdı";
            this.labelKullanıcıAdı.Size = new System.Drawing.Size(165, 29);
            this.labelKullanıcıAdı.TabIndex = 58;
            this.labelKullanıcıAdı.Text = "Kullanıcı Adı:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewVeriler);
            this.panel3.Location = new System.Drawing.Point(445, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 620);
            this.panel3.TabIndex = 74;
            // 
            // dataGridViewVeriler
            // 
            this.dataGridViewVeriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVeriler.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewVeriler.Name = "dataGridViewVeriler";
            this.dataGridViewVeriler.RowHeadersWidth = 51;
            this.dataGridViewVeriler.RowTemplate.Height = 24;
            this.dataGridViewVeriler.Size = new System.Drawing.Size(832, 620);
            this.dataGridViewVeriler.TabIndex = 0;
            this.dataGridViewVeriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVeriler_CellDoubleClick);
            // 
            // FormKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 777);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewVeriler;
    }
}

