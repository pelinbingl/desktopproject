namespace RezervasyonSystem
{
    partial class FormMüsteriKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMüsteriKayit));
            this.groupBoxMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.labelCinsiyet = new System.Windows.Forms.Label();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.textBoxUcret = new System.Windows.Forms.TextBox();
            this.labelucret = new System.Windows.Forms.Label();
            this.buttonKayıtet = new System.Windows.Forms.Button();
            this.dateTimePickerCikis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerGiris = new System.Windows.Forms.DateTimePicker();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTc = new System.Windows.Forms.TextBox();
            this.textBoxodano = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.labelÇıkışTarihi = new System.Windows.Forms.Label();
            this.labelGirişTarihi = new System.Windows.Forms.Label();
            this.labelOdano = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.groupBoxRooms = new System.Windows.Forms.GroupBox();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonYenile = new System.Windows.Forms.Button();
            this.groupBoxMusteriBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMusteriBilgileri
            // 
            this.groupBoxMusteriBilgileri.Controls.Add(this.labelCinsiyet);
            this.groupBoxMusteriBilgileri.Controls.Add(this.comboBoxCinsiyet);
            this.groupBoxMusteriBilgileri.Controls.Add(this.textBoxUcret);
            this.groupBoxMusteriBilgileri.Controls.Add(this.labelucret);
            this.groupBoxMusteriBilgileri.Controls.Add(this.buttonKayıtet);
            this.groupBoxMusteriBilgileri.Controls.Add(this.dateTimePickerCikis);
            this.groupBoxMusteriBilgileri.Controls.Add(this.dateTimePickerGiris);
            this.groupBoxMusteriBilgileri.Controls.Add(this.textBoxSoyad);
            this.groupBoxMusteriBilgileri.Controls.Add(this.textBoxTelefon);
            this.groupBoxMusteriBilgileri.Controls.Add(this.textBoxMail);
            this.groupBoxMusteriBilgileri.Controls.Add(this.textBoxTc);
            this.groupBoxMusteriBilgileri.Controls.Add(this.textBoxodano);
            this.groupBoxMusteriBilgileri.Controls.Add(this.textBoxAd);
            this.groupBoxMusteriBilgileri.Controls.Add(this.labelÇıkışTarihi);
            this.groupBoxMusteriBilgileri.Controls.Add(this.labelGirişTarihi);
            this.groupBoxMusteriBilgileri.Controls.Add(this.labelOdano);
            this.groupBoxMusteriBilgileri.Controls.Add(this.labelTc);
            this.groupBoxMusteriBilgileri.Controls.Add(this.labelMail);
            this.groupBoxMusteriBilgileri.Controls.Add(this.labelTelefon);
            this.groupBoxMusteriBilgileri.Controls.Add(this.labelSoyad);
            this.groupBoxMusteriBilgileri.Controls.Add(this.labelAd);
            this.groupBoxMusteriBilgileri.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxMusteriBilgileri.Location = new System.Drawing.Point(23, 19);
            this.groupBoxMusteriBilgileri.Name = "groupBoxMusteriBilgileri";
            this.groupBoxMusteriBilgileri.Size = new System.Drawing.Size(435, 485);
            this.groupBoxMusteriBilgileri.TabIndex = 2;
            this.groupBoxMusteriBilgileri.TabStop = false;
            this.groupBoxMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // labelCinsiyet
            // 
            this.labelCinsiyet.AutoSize = true;
            this.labelCinsiyet.Location = new System.Drawing.Point(6, 151);
            this.labelCinsiyet.Name = "labelCinsiyet";
            this.labelCinsiyet.Size = new System.Drawing.Size(75, 25);
            this.labelCinsiyet.TabIndex = 39;
            this.labelCinsiyet.Text = "Cinsiyet";
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(176, 143);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(199, 33);
            this.comboBoxCinsiyet.TabIndex = 4;
            // 
            // textBoxUcret
            // 
            this.textBoxUcret.Enabled = false;
            this.textBoxUcret.Location = new System.Drawing.Point(177, 296);
            this.textBoxUcret.Name = "textBoxUcret";
            this.textBoxUcret.Size = new System.Drawing.Size(200, 32);
            this.textBoxUcret.TabIndex = 8;
            // 
            // labelucret
            // 
            this.labelucret.AutoSize = true;
            this.labelucret.Location = new System.Drawing.Point(7, 303);
            this.labelucret.Name = "labelucret";
            this.labelucret.Size = new System.Drawing.Size(55, 25);
            this.labelucret.TabIndex = 36;
            this.labelucret.Text = "Ücret";
            // 
            // buttonKayıtet
            // 
            this.buttonKayıtet.BackColor = System.Drawing.Color.DarkGray;
            this.buttonKayıtet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKayıtet.Location = new System.Drawing.Point(177, 410);
            this.buttonKayıtet.Name = "buttonKayıtet";
            this.buttonKayıtet.Size = new System.Drawing.Size(201, 44);
            this.buttonKayıtet.TabIndex = 11;
            this.buttonKayıtet.Text = "KAYDET";
            this.buttonKayıtet.UseVisualStyleBackColor = false;
            this.buttonKayıtet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // dateTimePickerCikis
            // 
            this.dateTimePickerCikis.Location = new System.Drawing.Point(177, 372);
            this.dateTimePickerCikis.Name = "dateTimePickerCikis";
            this.dateTimePickerCikis.Size = new System.Drawing.Size(200, 32);
            this.dateTimePickerCikis.TabIndex = 10;
            this.dateTimePickerCikis.ValueChanged += new System.EventHandler(this.dateTimePickerCikis_ValueChanged_1);
            // 
            // dateTimePickerGiris
            // 
            this.dateTimePickerGiris.Location = new System.Drawing.Point(177, 334);
            this.dateTimePickerGiris.Name = "dateTimePickerGiris";
            this.dateTimePickerGiris.Size = new System.Drawing.Size(198, 32);
            this.dateTimePickerGiris.TabIndex = 9;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(177, 67);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(199, 32);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(177, 182);
            this.textBoxTelefon.MaxLength = 11;
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(200, 32);
            this.textBoxTelefon.TabIndex = 5;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(177, 220);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(200, 32);
            this.textBoxMail.TabIndex = 6;
            // 
            // textBoxTc
            // 
            this.textBoxTc.Location = new System.Drawing.Point(176, 105);
            this.textBoxTc.MaxLength = 11;
            this.textBoxTc.Name = "textBoxTc";
            this.textBoxTc.Size = new System.Drawing.Size(200, 32);
            this.textBoxTc.TabIndex = 3;
            // 
            // textBoxodano
            // 
            this.textBoxodano.Location = new System.Drawing.Point(177, 258);
            this.textBoxodano.Name = "textBoxodano";
            this.textBoxodano.Size = new System.Drawing.Size(200, 32);
            this.textBoxodano.TabIndex = 7;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(177, 29);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(199, 32);
            this.textBoxAd.TabIndex = 1;
            // 
            // labelÇıkışTarihi
            // 
            this.labelÇıkışTarihi.AutoSize = true;
            this.labelÇıkışTarihi.Location = new System.Drawing.Point(7, 379);
            this.labelÇıkışTarihi.Name = "labelÇıkışTarihi";
            this.labelÇıkışTarihi.Size = new System.Drawing.Size(102, 25);
            this.labelÇıkışTarihi.TabIndex = 26;
            this.labelÇıkışTarihi.Text = "Çıkış Tarihi";
            // 
            // labelGirişTarihi
            // 
            this.labelGirişTarihi.AutoSize = true;
            this.labelGirişTarihi.Location = new System.Drawing.Point(7, 334);
            this.labelGirişTarihi.Name = "labelGirişTarihi";
            this.labelGirişTarihi.Size = new System.Drawing.Size(102, 25);
            this.labelGirişTarihi.TabIndex = 25;
            this.labelGirişTarihi.Text = "Giriş Tarihi";
            // 
            // labelOdano
            // 
            this.labelOdano.AutoSize = true;
            this.labelOdano.Location = new System.Drawing.Point(7, 261);
            this.labelOdano.Name = "labelOdano";
            this.labelOdano.Size = new System.Drawing.Size(131, 25);
            this.labelOdano.TabIndex = 24;
            this.labelOdano.Text = "Oda Numarası";
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Location = new System.Drawing.Point(9, 112);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(30, 25);
            this.labelTc.TabIndex = 23;
            this.labelTc.Text = "Tc";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(7, 223);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(47, 25);
            this.labelMail.TabIndex = 22;
            this.labelMail.Text = "Mail";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(9, 185);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(71, 25);
            this.labelTelefon.TabIndex = 21;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Location = new System.Drawing.Point(6, 74);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(60, 25);
            this.labelSoyad.TabIndex = 20;
            this.labelSoyad.Text = "Soyad";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(9, 36);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(34, 25);
            this.labelAd.TabIndex = 19;
            this.labelAd.Text = "Ad";
            // 
            // groupBoxRooms
            // 
            this.groupBoxRooms.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxRooms.Location = new System.Drawing.Point(464, 19);
            this.groupBoxRooms.Name = "groupBoxRooms";
            this.groupBoxRooms.Size = new System.Drawing.Size(497, 485);
            this.groupBoxRooms.TabIndex = 3;
            this.groupBoxRooms.TabStop = false;
            this.groupBoxRooms.Text = "Odalar";
            // 
            // buttonGeri
            // 
            this.buttonGeri.BackColor = System.Drawing.Color.DarkGray;
            this.buttonGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeri.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.Location = new System.Drawing.Point(749, 525);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(75, 75);
            this.buttonGeri.TabIndex = 10;
            this.buttonGeri.Text = "GERİ";
            this.buttonGeri.UseVisualStyleBackColor = false;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonYenile
            // 
            this.buttonYenile.BackColor = System.Drawing.Color.DarkGray;
            this.buttonYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYenile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYenile.Location = new System.Drawing.Point(854, 525);
            this.buttonYenile.Name = "buttonYenile";
            this.buttonYenile.Size = new System.Drawing.Size(107, 75);
            this.buttonYenile.TabIndex = 11;
            this.buttonYenile.Text = "YENİLE";
            this.buttonYenile.UseVisualStyleBackColor = false;
            this.buttonYenile.Click += new System.EventHandler(this.buttonYenile_Click);
            // 
            // FormMüsteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(975, 618);
            this.Controls.Add(this.buttonYenile);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.groupBoxRooms);
            this.Controls.Add(this.groupBoxMusteriBilgileri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMüsteriKayit";
            this.Text = "FormMüsteriKayit";
            this.Load += new System.EventHandler(this.FormMüsteriKayit_Load);
            this.Click += new System.EventHandler(this.FormMüsteriKayit_Click);
            this.groupBoxMusteriBilgileri.ResumeLayout(false);
            this.groupBoxMusteriBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMusteriBilgileri;
        private System.Windows.Forms.Button buttonKayıtet;
        private System.Windows.Forms.DateTimePicker dateTimePickerCikis;
        private System.Windows.Forms.DateTimePicker dateTimePickerGiris;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTc;
        private System.Windows.Forms.TextBox textBoxodano;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label labelÇıkışTarihi;
        private System.Windows.Forms.Label labelGirişTarihi;
        private System.Windows.Forms.Label labelOdano;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.GroupBox groupBoxRooms;
        private System.Windows.Forms.TextBox textBoxUcret;
        private System.Windows.Forms.Label labelucret;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Label labelCinsiyet;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.Button buttonYenile;
    }
}