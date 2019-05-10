namespace BankaOtomasyonuDeneme
{
    partial class frmParaYatir
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
            this.txtHesNoPy = new System.Windows.Forms.TextBox();
            this.txtGoruntulePy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBulPy = new System.Windows.Forms.Button();
            this.txtYatTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYatir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHesNoPy
            // 
            this.txtHesNoPy.Location = new System.Drawing.Point(111, 26);
            this.txtHesNoPy.Multiline = true;
            this.txtHesNoPy.Name = "txtHesNoPy";
            this.txtHesNoPy.Size = new System.Drawing.Size(109, 26);
            this.txtHesNoPy.TabIndex = 0;
            // 
            // txtGoruntulePy
            // 
            this.txtGoruntulePy.Location = new System.Drawing.Point(267, 26);
            this.txtGoruntulePy.Multiline = true;
            this.txtGoruntulePy.Name = "txtGoruntulePy";
            this.txtGoruntulePy.Size = new System.Drawing.Size(306, 126);
            this.txtGoruntulePy.TabIndex = 1;
            this.txtGoruntulePy.TextChanged += new System.EventHandler(this.txtGoruntulePy_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hesap No:";
            // 
            // btnBulPy
            // 
            this.btnBulPy.Location = new System.Drawing.Point(123, 58);
            this.btnBulPy.Name = "btnBulPy";
            this.btnBulPy.Size = new System.Drawing.Size(81, 28);
            this.btnBulPy.TabIndex = 3;
            this.btnBulPy.Text = "BUL";
            this.btnBulPy.UseVisualStyleBackColor = true;
            this.btnBulPy.Click += new System.EventHandler(this.btnBulPy_Click);
            // 
            // txtYatTutar
            // 
            this.txtYatTutar.Location = new System.Drawing.Point(111, 176);
            this.txtYatTutar.Multiline = true;
            this.txtYatTutar.Name = "txtYatTutar";
            this.txtYatTutar.Size = new System.Drawing.Size(109, 26);
            this.txtYatTutar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tutar:";
            // 
            // btnYatir
            // 
            this.btnYatir.Location = new System.Drawing.Point(123, 208);
            this.btnYatir.Name = "btnYatir";
            this.btnYatir.Size = new System.Drawing.Size(81, 29);
            this.btnYatir.TabIndex = 6;
            this.btnYatir.Text = "YATIR";
            this.btnYatir.UseVisualStyleBackColor = true;
            this.btnYatir.Click += new System.EventHandler(this.btnYatir_Click);
            // 
            // frmParaYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(668, 310);
            this.Controls.Add(this.btnYatir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYatTutar);
            this.Controls.Add(this.btnBulPy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGoruntulePy);
            this.Controls.Add(this.txtHesNoPy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmParaYatir";
            this.Text = "Para Yatir";
            this.Load += new System.EventHandler(this.ParaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHesNoPy;
        private System.Windows.Forms.TextBox txtGoruntulePy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBulPy;
        private System.Windows.Forms.TextBox txtYatTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYatir;
    }
}