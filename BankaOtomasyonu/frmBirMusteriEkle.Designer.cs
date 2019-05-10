namespace BankaOtomasyonuDeneme
{
    partial class frmBirMusteriEkle
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
            this.txtBirAd = new System.Windows.Forms.TextBox();
            this.txtBirSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBirTelefon = new System.Windows.Forms.TextBox();
            this.btnBirEkle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBirTCNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBirAd
            // 
            this.txtBirAd.Location = new System.Drawing.Point(67, 43);
            this.txtBirAd.Multiline = true;
            this.txtBirAd.Name = "txtBirAd";
            this.txtBirAd.Size = new System.Drawing.Size(114, 26);
            this.txtBirAd.TabIndex = 0;
            this.txtBirAd.TextChanged += new System.EventHandler(this.txtBirAd_TextChanged);
            // 
            // txtBirSoyad
            // 
            this.txtBirSoyad.Location = new System.Drawing.Point(67, 90);
            this.txtBirSoyad.Multiline = true;
            this.txtBirSoyad.Name = "txtBirSoyad";
            this.txtBirSoyad.Size = new System.Drawing.Size(114, 24);
            this.txtBirSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TCNo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon";
            // 
            // txtBirTelefon
            // 
            this.txtBirTelefon.Location = new System.Drawing.Point(67, 177);
            this.txtBirTelefon.Multiline = true;
            this.txtBirTelefon.Name = "txtBirTelefon";
            this.txtBirTelefon.Size = new System.Drawing.Size(114, 24);
            this.txtBirTelefon.TabIndex = 7;
            // 
            // btnBirEkle
            // 
            this.btnBirEkle.Location = new System.Drawing.Point(248, 93);
            this.btnBirEkle.Name = "btnBirEkle";
            this.btnBirEkle.Size = new System.Drawing.Size(150, 64);
            this.btnBirEkle.TabIndex = 8;
            this.btnBirEkle.Text = "EKLE";
            this.btnBirEkle.UseVisualStyleBackColor = true;
            this.btnBirEkle.Click += new System.EventHandler(this.btnBirEkle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBirTCNo
            // 
            this.txtBirTCNo.Location = new System.Drawing.Point(67, 132);
            this.txtBirTCNo.MaxLength = 11;
            this.txtBirTCNo.Multiline = true;
            this.txtBirTCNo.Name = "txtBirTCNo";
            this.txtBirTCNo.Size = new System.Drawing.Size(114, 25);
            this.txtBirTCNo.TabIndex = 9;
            this.txtBirTCNo.TextChanged += new System.EventHandler(this.txtBirTCNo_TextChanged);
            // 
            // frmBirMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(550, 385);
            this.Controls.Add(this.txtBirTCNo);
            this.Controls.Add(this.btnBirEkle);
            this.Controls.Add(this.txtBirTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBirSoyad);
            this.Controls.Add(this.txtBirAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmBirMusteriEkle";
            this.Text = "BireyselMusteriEkle";
            this.Load += new System.EventHandler(this.frmMusteriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirAd;
        private System.Windows.Forms.TextBox txtBirSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBirTelefon;
        private System.Windows.Forms.Button btnBirEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBirTCNo;
    }
}