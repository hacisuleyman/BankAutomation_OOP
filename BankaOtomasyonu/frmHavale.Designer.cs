namespace BankaOtomasyonuDeneme
{
    partial class frmHavale
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
            this.txtGonHesNo = new System.Windows.Forms.TextBox();
            this.txtAlHesNo = new System.Windows.Forms.TextBox();
            this.btnGonBul = new System.Windows.Forms.Button();
            this.btnAlBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGoruntuleHav = new System.Windows.Forms.TextBox();
            this.txtHavaleTutar = new System.Windows.Forms.TextBox();
            this.btnHavaleYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGonHesNo
            // 
            this.txtGonHesNo.Location = new System.Drawing.Point(144, 26);
            this.txtGonHesNo.Name = "txtGonHesNo";
            this.txtGonHesNo.Size = new System.Drawing.Size(100, 20);
            this.txtGonHesNo.TabIndex = 0;
            // 
            // txtAlHesNo
            // 
            this.txtAlHesNo.Location = new System.Drawing.Point(144, 101);
            this.txtAlHesNo.Name = "txtAlHesNo";
            this.txtAlHesNo.Size = new System.Drawing.Size(100, 20);
            this.txtAlHesNo.TabIndex = 1;
            // 
            // btnGonBul
            // 
            this.btnGonBul.Location = new System.Drawing.Point(156, 52);
            this.btnGonBul.Name = "btnGonBul";
            this.btnGonBul.Size = new System.Drawing.Size(75, 23);
            this.btnGonBul.TabIndex = 2;
            this.btnGonBul.Text = "BUL";
            this.btnGonBul.UseVisualStyleBackColor = true;
            this.btnGonBul.Click += new System.EventHandler(this.btnGonBul_Click);
            // 
            // btnAlBul
            // 
            this.btnAlBul.Location = new System.Drawing.Point(156, 127);
            this.btnAlBul.Name = "btnAlBul";
            this.btnAlBul.Size = new System.Drawing.Size(75, 23);
            this.btnAlBul.TabIndex = 3;
            this.btnAlBul.Text = "BUL";
            this.btnAlBul.UseVisualStyleBackColor = true;
            this.btnAlBul.Click += new System.EventHandler(this.btnAlBul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gönderen Hesap No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gönderilecek Hesap No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGoruntuleHav
            // 
            this.txtGoruntuleHav.Location = new System.Drawing.Point(266, 21);
            this.txtGoruntuleHav.Multiline = true;
            this.txtGoruntuleHav.Name = "txtGoruntuleHav";
            this.txtGoruntuleHav.Size = new System.Drawing.Size(329, 199);
            this.txtGoruntuleHav.TabIndex = 6;
            this.txtGoruntuleHav.TextChanged += new System.EventHandler(this.txtGoruntuleHav_TextChanged);
            // 
            // txtHavaleTutar
            // 
            this.txtHavaleTutar.Location = new System.Drawing.Point(144, 177);
            this.txtHavaleTutar.Name = "txtHavaleTutar";
            this.txtHavaleTutar.Size = new System.Drawing.Size(100, 20);
            this.txtHavaleTutar.TabIndex = 7;
            // 
            // btnHavaleYap
            // 
            this.btnHavaleYap.Location = new System.Drawing.Point(155, 203);
            this.btnHavaleYap.Name = "btnHavaleYap";
            this.btnHavaleYap.Size = new System.Drawing.Size(76, 35);
            this.btnHavaleYap.TabIndex = 8;
            this.btnHavaleYap.Text = "HAVALE YAP";
            this.btnHavaleYap.UseVisualStyleBackColor = true;
            this.btnHavaleYap.Click += new System.EventHandler(this.btnHavaleYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tutar";
            // 
            // frmHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(636, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHavaleYap);
            this.Controls.Add(this.txtHavaleTutar);
            this.Controls.Add(this.txtGoruntuleHav);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlBul);
            this.Controls.Add(this.btnGonBul);
            this.Controls.Add(this.txtAlHesNo);
            this.Controls.Add(this.txtGonHesNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmHavale";
            this.Text = "Havale";
            this.Load += new System.EventHandler(this.frmHavale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGonHesNo;
        private System.Windows.Forms.TextBox txtAlHesNo;
        private System.Windows.Forms.Button btnGonBul;
        private System.Windows.Forms.Button btnAlBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGoruntuleHav;
        private System.Windows.Forms.TextBox txtHavaleTutar;
        private System.Windows.Forms.Button btnHavaleYap;
        private System.Windows.Forms.Label label3;
    }
}