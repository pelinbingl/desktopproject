namespace CalculatorApplication
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
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblOperatorSymbol = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.combobxOperatorSymbol = new System.Windows.Forms.ComboBox();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumber1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNumber1.Location = new System.Drawing.Point(94, 126);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(93, 22);
            this.lblNumber1.TabIndex = 1;
            this.lblNumber1.Text = "1.Number:";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumber2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNumber2.Location = new System.Drawing.Point(95, 207);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(93, 22);
            this.lblNumber2.TabIndex = 2;
            this.lblNumber2.Text = "2.Number:";
            // 
            // lblOperatorSymbol
            // 
            this.lblOperatorSymbol.AutoSize = true;
            this.lblOperatorSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOperatorSymbol.ForeColor = System.Drawing.Color.DarkRed;
            this.lblOperatorSymbol.Location = new System.Drawing.Point(95, 294);
            this.lblOperatorSymbol.Name = "lblOperatorSymbol";
            this.lblOperatorSymbol.Size = new System.Drawing.Size(83, 20);
            this.lblOperatorSymbol.TabIndex = 3;
            this.lblOperatorSymbol.Text = "Operator";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResult.Location = new System.Drawing.Point(109, 360);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(69, 20);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.Color.Red;
            this.btnCalculate.Location = new System.Drawing.Point(435, 391);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 53);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(237, 128);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(121, 22);
            this.txtNumber1.TabIndex = 6;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(237, 207);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(121, 22);
            this.txtNumber2.TabIndex = 7;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(237, 358);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(121, 22);
            this.txtResult.TabIndex = 8;
            // 
            // combobxOperatorSymbol
            // 
            this.combobxOperatorSymbol.FormattingEnabled = true;
            this.combobxOperatorSymbol.Location = new System.Drawing.Point(237, 291);
            this.combobxOperatorSymbol.Name = "combobxOperatorSymbol";
            this.combobxOperatorSymbol.Size = new System.Drawing.Size(121, 24);
            this.combobxOperatorSymbol.TabIndex = 9;
            this.combobxOperatorSymbol.SelectedIndexChanged += new System.EventHandler(this.combobxOperatorSymbol_SelectedIndexChanged);
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeadline.ForeColor = System.Drawing.Color.Red;
            this.lblHeadline.Location = new System.Drawing.Point(108, 53);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(328, 29);
            this.lblHeadline.TabIndex = 10;
            this.lblHeadline.Text = "Four Operations Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 489);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.combobxOperatorSymbol);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblOperatorSymbol);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblOperatorSymbol;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox combobxOperatorSymbol;
        private System.Windows.Forms.Label lblHeadline;
    }
}

