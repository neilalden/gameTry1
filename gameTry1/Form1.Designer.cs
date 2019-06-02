namespace gameTry1
{
    partial class z
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
            this.lblTrivia = new System.Windows.Forms.Label();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.btnAns = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(47, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question   :";
            // 
            // lblTrivia
            // 
            this.lblTrivia.AutoSize = true;
            this.lblTrivia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTrivia.Location = new System.Drawing.Point(137, 133);
            this.lblTrivia.Name = "lblTrivia";
            this.lblTrivia.Size = new System.Drawing.Size(734, 39);
            this.lblTrivia.TabIndex = 1;
            this.lblTrivia.Text = "lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioA.Location = new System.Drawing.Point(219, 179);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(218, 43);
            this.radioA.TabIndex = 2;
            this.radioA.TabStop = true;
            this.radioA.Text = "radioButton1";
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioB.Location = new System.Drawing.Point(219, 208);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(218, 43);
            this.radioB.TabIndex = 3;
            this.radioB.TabStop = true;
            this.radioB.Text = "radioButton2";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioC.Location = new System.Drawing.Point(219, 237);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(218, 43);
            this.radioC.TabIndex = 4;
            this.radioC.TabStop = true;
            this.radioC.Text = "radioButton3";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioD.Location = new System.Drawing.Point(219, 266);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(218, 43);
            this.radioD.TabIndex = 5;
            this.radioD.TabStop = true;
            this.radioD.Text = "radioButton4";
            this.radioD.UseVisualStyleBackColor = true;
            // 
            // btnAns
            // 
            this.btnAns.Location = new System.Drawing.Point(238, 306);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(75, 29);
            this.btnAns.TabIndex = 7;
            this.btnAns.Text = "Answer";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(371, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Score   :";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblScore.Location = new System.Drawing.Point(437, 87);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(33, 39);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "0";
            // 
            // z
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 414);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.radioD);
            this.Controls.Add(this.radioC);
            this.Controls.Add(this.radioB);
            this.Controls.Add(this.radioA);
            this.Controls.Add(this.lblTrivia);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "z";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.z_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrivia;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
    }
}

