namespace BankaOtomasyonuDeneme
{
    partial class frmHesapEkle
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
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(118, 46);
            this.txtMusteriNo.Multiline = true;
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(118, 26);
            this.txtMusteriNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Numarası";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHesapEkle
            // 
            this.btnHesapEkle.Location = new System.Drawing.Point(137, 78);
            this.btnHesapEkle.Name = "btnHesapEkle";
            this.btnHesapEkle.Size = new System.Drawing.Size(78, 29);
            this.btnHesapEkle.TabIndex = 2;
            this.btnHesapEkle.Text = "EKLE";
            this.btnHesapEkle.UseVisualStyleBackColor = true;
            this.btnHesapEkle.Click += new System.EventHandler(this.btnHesapEkle_Click);
            // 
            // frmHesapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(479, 273);
            this.Controls.Add(this.btnHesapEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMusteriNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmHesapEkle";
            this.Text = "Hesap Ekle";
            this.Load += new System.EventHandler(this.frmHesapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapEkle;
    }
}