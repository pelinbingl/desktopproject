namespace AvgCalculation
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblOkul = new System.Windows.Forms.Label();
            this.lblSınav1 = new System.Windows.Forms.Label();
            this.lblSınav2 = new System.Windows.Forms.Label();
            this.radioLiseOrtaokul = new System.Windows.Forms.RadioButton();
            this.radioUniversite = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtSınav1 = new System.Windows.Forms.TextBox();
            this.txtSınav2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(244, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "AVG CALCULATİON";
            // 
            // lblOkul
            // 
            this.lblOkul.AutoSize = true;
            this.lblOkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOkul.ForeColor = System.Drawing.Color.DarkRed;
            this.lblOkul.Location = new System.Drawing.Point(99, 130);
            this.lblOkul.Name = "lblOkul";
            this.lblOkul.Size = new System.Drawing.Size(65, 20);
            this.lblOkul.TabIndex = 1;
            this.lblOkul.Text = "OKUL:";
            // 
            // lblSınav1
            // 
            this.lblSınav1.AutoSize = true;
            this.lblSınav1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSınav1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSınav1.Location = new System.Drawing.Point(99, 186);
            this.lblSınav1.Name = "lblSınav1";
            this.lblSınav1.Size = new System.Drawing.Size(76, 20);
            this.lblSınav1.TabIndex = 2;
            this.lblSınav1.Text = "1.Sınav:";
            // 
            // lblSınav2
            // 
            this.lblSınav2.AutoSize = true;
            this.lblSınav2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSınav2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSınav2.Location = new System.Drawing.Point(99, 261);
            this.lblSınav2.Name = "lblSınav2";
            this.lblSınav2.Size = new System.Drawing.Size(76, 20);
            this.lblSınav2.TabIndex = 3;
            this.lblSınav2.Text = "2.Sınav:";
            // 
            // radioLiseOrtaokul
            // 
            this.radioLiseOrtaokul.AutoSize = true;
            this.radioLiseOrtaokul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioLiseOrtaokul.Location = new System.Drawing.Point(249, 126);
            this.radioLiseOrtaokul.Name = "radioLiseOrtaokul";
            this.radioLiseOrtaokul.Size = new System.Drawing.Size(130, 24);
            this.radioLiseOrtaokul.TabIndex = 4;
            this.radioLiseOrtaokul.TabStop = true;
            this.radioLiseOrtaokul.Text = "Lise/Ortaokul";
            this.radioLiseOrtaokul.UseVisualStyleBackColor = true;
            // 
            // radioUniversite
            // 
            this.radioUniversite.AutoSize = true;
            this.radioUniversite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioUniversite.Location = new System.Drawing.Point(422, 126);
            this.radioUniversite.Name = "radioUniversite";
            this.radioUniversite.Size = new System.Drawing.Size(105, 24);
            this.radioUniversite.TabIndex = 5;
            this.radioUniversite.TabStop = true;
            this.radioUniversite.Text = "Üniversite";
            this.radioUniversite.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHesapla.Location = new System.Drawing.Point(447, 315);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(137, 45);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtSınav1
            // 
            this.txtSınav1.Location = new System.Drawing.Point(249, 186);
            this.txtSınav1.Name = "txtSınav1";
            this.txtSınav1.Size = new System.Drawing.Size(100, 22);
            this.txtSınav1.TabIndex = 7;
            // 
            // txtSınav2
            // 
            this.txtSınav2.ForeColor = System.Drawing.Color.Black;
            this.txtSınav2.Location = new System.Drawing.Point(249, 261);
            this.txtSınav2.Name = "txtSınav2";
            this.txtSınav2.Size = new System.Drawing.Size(100, 22);
            this.txtSınav2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSınav2);
            this.Controls.Add(this.txtSınav1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.radioUniversite);
            this.Controls.Add(this.radioLiseOrtaokul);
            this.Controls.Add(this.lblSınav2);
            this.Controls.Add(this.lblSınav1);
            this.Controls.Add(this.lblOkul);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOkul;
        private System.Windows.Forms.Label lblSınav1;
        private System.Windows.Forms.Label lblSınav2;
        private System.Windows.Forms.RadioButton radioLiseOrtaokul;
        private System.Windows.Forms.RadioButton radioUniversite;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtSınav1;
        private System.Windows.Forms.TextBox txtSınav2;
    }
}

