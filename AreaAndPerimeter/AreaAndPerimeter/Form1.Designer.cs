namespace AreaAndPerimeter
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
            this.lblchoice1 = new System.Windows.Forms.Label();
            this.lblLongSide = new System.Windows.Forms.Label();
            this.lblShortSide = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.radiobtnSquare = new System.Windows.Forms.RadioButton();
            this.radiobtnRectangle = new System.Windows.Forms.RadioButton();
            this.radiobtnCircle = new System.Windows.Forms.RadioButton();
            this.txtLongSide = new System.Windows.Forms.TextBox();
            this.txtShortSide = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblChoıce2 = new System.Windows.Forms.Label();
            this.radiobtnArea = new System.Windows.Forms.RadioButton();
            this.radiobtnPerimeter = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(129, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area-Perimeter ";
            // 
            // lblchoice1
            // 
            this.lblchoice1.AutoSize = true;
            this.lblchoice1.Location = new System.Drawing.Point(34, 126);
            this.lblchoice1.Name = "lblchoice1";
            this.lblchoice1.Size = new System.Drawing.Size(70, 16);
            this.lblchoice1.TabIndex = 1;
            this.lblchoice1.Text = "1.CHOICE:";
            // 
            // lblLongSide
            // 
            this.lblLongSide.AutoSize = true;
            this.lblLongSide.Location = new System.Drawing.Point(34, 223);
            this.lblLongSide.Name = "lblLongSide";
            this.lblLongSide.Size = new System.Drawing.Size(81, 16);
            this.lblLongSide.TabIndex = 2;
            this.lblLongSide.Text = "LONG SİDE:";
            // 
            // lblShortSide
            // 
            this.lblShortSide.AutoSize = true;
            this.lblShortSide.Location = new System.Drawing.Point(34, 272);
            this.lblShortSide.Name = "lblShortSide";
            this.lblShortSide.Size = new System.Drawing.Size(92, 16);
            this.lblShortSide.TabIndex = 3;
            this.lblShortSide.Text = "SHORT SİDE:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(34, 357);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(64, 16);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "RESULT:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(369, 357);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(78, 55);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // radiobtnSquare
            // 
            this.radiobtnSquare.AutoSize = true;
            this.radiobtnSquare.Location = new System.Drawing.Point(132, 124);
            this.radiobtnSquare.Name = "radiobtnSquare";
            this.radiobtnSquare.Size = new System.Drawing.Size(85, 20);
            this.radiobtnSquare.TabIndex = 6;
            this.radiobtnSquare.TabStop = true;
            this.radiobtnSquare.Text = "SQUARE";
            this.radiobtnSquare.UseVisualStyleBackColor = true;
            this.radiobtnSquare.CheckedChanged += new System.EventHandler(this.radiobtnSquare_CheckedChanged);
            // 
            // radiobtnRectangle
            // 
            this.radiobtnRectangle.AutoSize = true;
            this.radiobtnRectangle.Location = new System.Drawing.Point(260, 122);
            this.radiobtnRectangle.Name = "radiobtnRectangle";
            this.radiobtnRectangle.Size = new System.Drawing.Size(110, 20);
            this.radiobtnRectangle.TabIndex = 7;
            this.radiobtnRectangle.TabStop = true;
            this.radiobtnRectangle.Text = "RECTANGLE";
            this.radiobtnRectangle.UseVisualStyleBackColor = true;
            this.radiobtnRectangle.CheckedChanged += new System.EventHandler(this.radiobtnRectangle_CheckedChanged);
            // 
            // radiobtnCircle
            // 
            this.radiobtnCircle.AutoSize = true;
            this.radiobtnCircle.Location = new System.Drawing.Point(396, 122);
            this.radiobtnCircle.Name = "radiobtnCircle";
            this.radiobtnCircle.Size = new System.Drawing.Size(75, 20);
            this.radiobtnCircle.TabIndex = 8;
            this.radiobtnCircle.TabStop = true;
            this.radiobtnCircle.Text = "CIRCLE";
            this.radiobtnCircle.UseVisualStyleBackColor = true;
            this.radiobtnCircle.CheckedChanged += new System.EventHandler(this.radiobtnCircle_CheckedChanged);
            // 
            // txtLongSide
            // 
            this.txtLongSide.Location = new System.Drawing.Point(135, 217);
            this.txtLongSide.Name = "txtLongSide";
            this.txtLongSide.Size = new System.Drawing.Size(100, 22);
            this.txtLongSide.TabIndex = 9;
            // 
            // txtShortSide
            // 
            this.txtShortSide.Location = new System.Drawing.Point(135, 269);
            this.txtShortSide.Name = "txtShortSide";
            this.txtShortSide.Size = new System.Drawing.Size(100, 22);
            this.txtShortSide.TabIndex = 10;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(135, 354);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 22);
            this.txtResult.TabIndex = 11;
            // 
            // lblChoıce2
            // 
            this.lblChoıce2.AutoSize = true;
            this.lblChoıce2.Location = new System.Drawing.Point(37, 174);
            this.lblChoıce2.Name = "lblChoıce2";
            this.lblChoıce2.Size = new System.Drawing.Size(70, 16);
            this.lblChoıce2.TabIndex = 12;
            this.lblChoıce2.Text = "2.CHOICE:";
            // 
            // radiobtnArea
            // 
            this.radiobtnArea.AutoSize = true;
            this.radiobtnArea.Location = new System.Drawing.Point(132, 174);
            this.radiobtnArea.Name = "radiobtnArea";
            this.radiobtnArea.Size = new System.Drawing.Size(65, 20);
            this.radiobtnArea.TabIndex = 13;
            this.radiobtnArea.TabStop = true;
            this.radiobtnArea.Text = "AREA";
            this.radiobtnArea.UseVisualStyleBackColor = true;
            // 
            // radiobtnPerimeter
            // 
            this.radiobtnPerimeter.AutoSize = true;
            this.radiobtnPerimeter.Location = new System.Drawing.Point(263, 172);
            this.radiobtnPerimeter.Name = "radiobtnPerimeter";
            this.radiobtnPerimeter.Size = new System.Drawing.Size(107, 20);
            this.radiobtnPerimeter.TabIndex = 14;
            this.radiobtnPerimeter.TabStop = true;
            this.radiobtnPerimeter.Text = "PERIMETER";
            this.radiobtnPerimeter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 464);
            this.Controls.Add(this.radiobtnPerimeter);
            this.Controls.Add(this.radiobtnArea);
            this.Controls.Add(this.lblChoıce2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtShortSide);
            this.Controls.Add(this.txtLongSide);
            this.Controls.Add(this.radiobtnCircle);
            this.Controls.Add(this.radiobtnRectangle);
            this.Controls.Add(this.radiobtnSquare);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblShortSide);
            this.Controls.Add(this.lblLongSide);
            this.Controls.Add(this.lblchoice1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblchoice1;
        private System.Windows.Forms.Label lblLongSide;
        private System.Windows.Forms.Label lblShortSide;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton radiobtnSquare;
        private System.Windows.Forms.RadioButton radiobtnRectangle;
        private System.Windows.Forms.RadioButton radiobtnCircle;
        private System.Windows.Forms.TextBox txtLongSide;
        private System.Windows.Forms.TextBox txtShortSide;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblChoıce2;
        private System.Windows.Forms.RadioButton radiobtnArea;
        private System.Windows.Forms.RadioButton radiobtnPerimeter;
    }
}

