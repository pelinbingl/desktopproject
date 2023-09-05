namespace RezervasyonSystem
{
    partial class FormAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnasayfa));
            this.buttonMüsteriKayit = new System.Windows.Forms.Button();
            this.buttonAdminGiris = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonMusteriler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMüsteriKayit
            // 
            this.buttonMüsteriKayit.BackColor = System.Drawing.Color.Snow;
            this.buttonMüsteriKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMüsteriKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMüsteriKayit.ForeColor = System.Drawing.Color.Black;
            this.buttonMüsteriKayit.Location = new System.Drawing.Point(321, 52);
            this.buttonMüsteriKayit.Name = "buttonMüsteriKayit";
            this.buttonMüsteriKayit.Size = new System.Drawing.Size(296, 150);
            this.buttonMüsteriKayit.TabIndex = 0;
            this.buttonMüsteriKayit.Text = "MÜŞTERİ KAYIT";
            this.buttonMüsteriKayit.UseVisualStyleBackColor = false;
            this.buttonMüsteriKayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdminGiris
            // 
            this.buttonAdminGiris.BackColor = System.Drawing.Color.Snow;
            this.buttonAdminGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminGiris.ForeColor = System.Drawing.Color.Black;
            this.buttonAdminGiris.Location = new System.Drawing.Point(30, 52);
            this.buttonAdminGiris.Name = "buttonAdminGiris";
            this.buttonAdminGiris.Size = new System.Drawing.Size(266, 150);
            this.buttonAdminGiris.TabIndex = 2;
            this.buttonAdminGiris.Text = "ADMİN GİRİŞ";
            this.buttonAdminGiris.UseVisualStyleBackColor = false;
            this.buttonAdminGiris.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Snow;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Black;
            this.buttonCikis.Location = new System.Drawing.Point(321, 227);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(296, 150);
            this.buttonCikis.TabIndex = 8;
            this.buttonCikis.Text = "ÇIKIŞ";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click_1);
            // 
            // buttonMusteriler
            // 
            this.buttonMusteriler.BackColor = System.Drawing.Color.Snow;
            this.buttonMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMusteriler.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMusteriler.ForeColor = System.Drawing.Color.Black;
            this.buttonMusteriler.Location = new System.Drawing.Point(30, 227);
            this.buttonMusteriler.Name = "buttonMusteriler";
            this.buttonMusteriler.Size = new System.Drawing.Size(266, 150);
            this.buttonMusteriler.TabIndex = 3;
            this.buttonMusteriler.Text = "MÜŞTERİLER";
            this.buttonMusteriler.UseVisualStyleBackColor = false;
            this.buttonMusteriler.Click += new System.EventHandler(this.buttonMusteriler_Click);
            // 
            // FormAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(665, 459);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonMusteriler);
            this.Controls.Add(this.buttonAdminGiris);
            this.Controls.Add(this.buttonMüsteriKayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAnasayfa";
            this.Text = "FormAnasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMüsteriKayit;
        private System.Windows.Forms.Button buttonAdminGiris;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonMusteriler;
    }
}