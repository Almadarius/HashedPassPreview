namespace HashedPassPreview
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
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaltBytes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaltString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudIterations = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultBytes = new System.Windows.Forms.TextBox();
            this.txtResultString = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHashedPasswordBytes = new System.Windows.Forms.TextBox();
            this.txtHashedPasswordString = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(79, 15);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(195, 20);
            this.txtPwd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // txtSaltBytes
            // 
            this.txtSaltBytes.Location = new System.Drawing.Point(79, 41);
            this.txtSaltBytes.Name = "txtSaltBytes";
            this.txtSaltBytes.ReadOnly = true;
            this.txtSaltBytes.Size = new System.Drawing.Size(195, 20);
            this.txtSaltBytes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salt (String)";
            // 
            // txtSaltString
            // 
            this.txtSaltString.Location = new System.Drawing.Point(79, 67);
            this.txtSaltString.Name = "txtSaltString";
            this.txtSaltString.ReadOnly = true;
            this.txtSaltString.Size = new System.Drawing.Size(195, 20);
            this.txtSaltString.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "# of Iterations";
            // 
            // nudIterations
            // 
            this.nudIterations.Location = new System.Drawing.Point(90, 110);
            this.nudIterations.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIterations.Name = "nudIterations";
            this.nudIterations.Size = new System.Drawing.Size(81, 20);
            this.nudIterations.TabIndex = 7;
            this.nudIterations.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Result (Bytes)";
            // 
            // txtResultBytes
            // 
            this.txtResultBytes.Location = new System.Drawing.Point(377, 11);
            this.txtResultBytes.Multiline = true;
            this.txtResultBytes.Name = "txtResultBytes";
            this.txtResultBytes.ReadOnly = true;
            this.txtResultBytes.Size = new System.Drawing.Size(241, 140);
            this.txtResultBytes.TabIndex = 9;
            // 
            // txtResultString
            // 
            this.txtResultString.Location = new System.Drawing.Point(377, 157);
            this.txtResultString.Multiline = true;
            this.txtResultString.Name = "txtResultString";
            this.txtResultString.ReadOnly = true;
            this.txtResultString.Size = new System.Drawing.Size(241, 133);
            this.txtResultString.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Result (String)";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(199, 107);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 12;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salt (Bytes)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hashed Password (Bytes)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hashed Password (String)";
            // 
            // txtHashedPasswordBytes
            // 
            this.txtHashedPasswordBytes.Location = new System.Drawing.Point(15, 173);
            this.txtHashedPasswordBytes.Multiline = true;
            this.txtHashedPasswordBytes.Name = "txtHashedPasswordBytes";
            this.txtHashedPasswordBytes.ReadOnly = true;
            this.txtHashedPasswordBytes.Size = new System.Drawing.Size(259, 43);
            this.txtHashedPasswordBytes.TabIndex = 15;
            // 
            // txtHashedPasswordString
            // 
            this.txtHashedPasswordString.Location = new System.Drawing.Point(15, 247);
            this.txtHashedPasswordString.Multiline = true;
            this.txtHashedPasswordString.Name = "txtHashedPasswordString";
            this.txtHashedPasswordString.ReadOnly = true;
            this.txtHashedPasswordString.Size = new System.Drawing.Size(259, 43);
            this.txtHashedPasswordString.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 309);
            this.Controls.Add(this.txtHashedPasswordString);
            this.Controls.Add(this.txtHashedPasswordBytes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResultString);
            this.Controls.Add(this.txtResultBytes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudIterations);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSaltString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaltBytes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPwd);
            this.Name = "Form1";
            this.Text = "Hashed Password Preview";
            ((System.ComponentModel.ISupportInitialize)(this.nudIterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaltBytes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaltString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudIterations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResultBytes;
        private System.Windows.Forms.TextBox txtResultString;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHashedPasswordBytes;
        private System.Windows.Forms.TextBox txtHashedPasswordString;
    }
}

