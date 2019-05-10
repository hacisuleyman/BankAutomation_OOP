namespace BankaOtomasyonuDeneme
{
    partial class frmTicMusteriEkle
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
            this.txtTicTCNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTicTelefon = new System.Windows.Forms.TextBox();
            this.txtTicSoyad = new System.Windows.Forms.TextBox();
            this.txtTicAd = new System.Windows.Forms.TextBox();
            this.btnTicEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTicTCNo
            // 
            this.txtTicTCNo.Location = new System.Drawing.Point(76, 127);
            this.txtTicTCNo.MaxLength = 11;
            this.txtTicTCNo.Multiline = true;
            this.txtTicTCNo.Name = "txtTicTCNo";
            this.txtTicTCNo.Size = new System.Drawing.Size(114, 24);
            this.txtTicTCNo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "TCNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad";
            // 
            // txtTicTelefon
            // 
            this.txtTicTelefon.Location = new System.Drawing.Point(76, 172);
            this.txtTicTelefon.Multiline = true;
            this.txtTicTelefon.Name = "txtTicTelefon";
            this.txtTicTelefon.Size = new System.Drawing.Size(114, 26);
            this.txtTicTelefon.TabIndex = 10;
            // 
            // txtTicSoyad
            // 
            this.txtTicSoyad.Location = new System.Drawing.Point(76, 80);
            this.txtTicSoyad.Multiline = true;
            this.txtTicSoyad.Name = "txtTicSoyad";
            this.txtTicSoyad.Size = new System.Drawing.Size(114, 24);
            this.txtTicSoyad.TabIndex = 9;
            // 
            // txtTicAd
            // 
            this.txtTicAd.Location = new System.Drawing.Point(76, 33);
            this.txtTicAd.Multiline = true;
            this.txtTicAd.Name = "txtTicAd";
            this.txtTicAd.Size = new System.Drawing.Size(114, 26);
            this.txtTicAd.TabIndex = 8;
            // 
            // btnTicEkle
            // 
            this.btnTicEkle.Location = new System.Drawing.Point(260, 102);
            this.btnTicEkle.Name = "btnTicEkle";
            this.btnTicEkle.Size = new System.Drawing.Size(144, 68);
            this.btnTicEkle.TabIndex = 18;
            this.btnTicEkle.Text = "EKLE";
            this.btnTicEkle.UseVisualStyleBackColor = true;
            this.btnTicEkle.Click += new System.EventHandler(this.btnTicEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(76, 213);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(114, 25);
            this.txtKullaniciAdi.TabIndex = 16;
            // 
            // frmTicMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(521, 319);
            this.Controls.Add(this.btnTicEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtTicTCNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTicTelefon);
            this.Controls.Add(this.txtTicSoyad);
            this.Controls.Add(this.txtTicAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTicMusteriEkle";
            this.Text = "TicariMusteriEkle";
            this.Load += new System.EventHandler(this.TicariMusteriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTicTCNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTicTelefon;
        private System.Windows.Forms.TextBox txtTicSoyad;
        private System.Windows.Forms.TextBox txtTicAd;
        private System.Windows.Forms.Button btnTicEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
    }
}