namespace BankaOtomasyonuDeneme
{
    partial class frmHesapKapama
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
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.Location = new System.Drawing.Point(177, 122);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(81, 38);
            this.btnHesapKapat.TabIndex = 2;
            this.btnHesapKapat.Text = "HESABI KAPAT";
            this.btnHesapKapat.UseVisualStyleBackColor = true;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(167, 96);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(100, 20);
            this.txtHesapNo.TabIndex = 3;
            this.txtHesapNo.TextChanged += new System.EventHandler(this.txtHesapNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hesap No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmHesapKapama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(487, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.btnHesapKapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmHesapKapama";
            this.Text = "Hesap Kapama";
            this.Load += new System.EventHandler(this.frmHesapKapama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHesapKapat;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}