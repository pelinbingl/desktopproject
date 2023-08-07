namespace GameLoadingProgress
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
            this.components = new System.ComponentModel.Container();
            this.progressLoading = new System.Windows.Forms.ProgressBar();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressLoading
            // 
            this.progressLoading.Location = new System.Drawing.Point(34, 88);
            this.progressLoading.Name = "progressLoading";
            this.progressLoading.Size = new System.Drawing.Size(237, 38);
            this.progressLoading.TabIndex = 0;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(138, 100);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(14, 16);
            this.lblPercentage.TabIndex = 1;
            this.lblPercentage.Text = "0";
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(89, 168);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 22);
            this.txtPercentage.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(89, 263);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 74);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(12, 44);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(283, 25);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Application Installation Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 467);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.progressLoading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressLoading;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeader;
    }
}

