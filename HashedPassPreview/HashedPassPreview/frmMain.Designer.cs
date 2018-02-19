namespace HashedPassPreview
{
    partial class frmMain
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
            this.btnPBKDF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPBKDF2
            // 
            this.btnPBKDF2.Location = new System.Drawing.Point(12, 12);
            this.btnPBKDF2.Name = "btnPBKDF2";
            this.btnPBKDF2.Size = new System.Drawing.Size(429, 23);
            this.btnPBKDF2.TabIndex = 0;
            this.btnPBKDF2.Text = "PBKDF2";
            this.btnPBKDF2.UseVisualStyleBackColor = true;
            this.btnPBKDF2.Click += new System.EventHandler(this.btnPBKDF2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 291);
            this.Controls.Add(this.btnPBKDF2);
            this.Name = "frmMain";
            this.Text = "Hashed Password Preview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPBKDF2;
    }
}