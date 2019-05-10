namespace BankaOtomasyonuDeneme
{
    partial class frmBankaRapor
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
            this.btnGosterBr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGosterBr
            // 
            this.btnGosterBr.Location = new System.Drawing.Point(109, 40);
            this.btnGosterBr.Name = "btnGosterBr";
            this.btnGosterBr.Size = new System.Drawing.Size(123, 52);
            this.btnGosterBr.TabIndex = 0;
            this.btnGosterBr.Text = "GÖSTER";
            this.btnGosterBr.UseVisualStyleBackColor = true;
            this.btnGosterBr.Click += new System.EventHandler(this.btnGosterBr_Click);
            // 
            // frmBankaRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(342, 139);
            this.Controls.Add(this.btnGosterBr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmBankaRapor";
            this.Text = "Banka Raporu";
            this.Load += new System.EventHandler(this.frmBankaRapor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGosterBr;
    }
}