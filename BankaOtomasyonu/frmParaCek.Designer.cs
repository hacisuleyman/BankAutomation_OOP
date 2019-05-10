namespace BankaOtomasyonuDeneme
{
    partial class frmParaCek
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
            this.txtTutarPc = new System.Windows.Forms.TextBox();
            this.txtHesNoPc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBulPc = new System.Windows.Forms.Button();
            this.btnCekPc = new System.Windows.Forms.Button();
            this.txtGoruntulePc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTutarPc
            // 
            this.txtTutarPc.Location = new System.Drawing.Point(132, 154);
            this.txtTutarPc.Name = "txtTutarPc";
            this.txtTutarPc.Size = new System.Drawing.Size(100, 20);
            this.txtTutarPc.TabIndex = 0;
            // 
            // txtHesNoPc
            // 
            this.txtHesNoPc.Location = new System.Drawing.Point(132, 19);
            this.txtHesNoPc.Name = "txtHesNoPc";
            this.txtHesNoPc.Size = new System.Drawing.Size(100, 20);
            this.txtHesNoPc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hesap No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tutar";
            // 
            // btnBulPc
            // 
            this.btnBulPc.Location = new System.Drawing.Point(145, 45);
            this.btnBulPc.Name = "btnBulPc";
            this.btnBulPc.Size = new System.Drawing.Size(75, 23);
            this.btnBulPc.TabIndex = 4;
            this.btnBulPc.Text = "BUL";
            this.btnBulPc.UseVisualStyleBackColor = true;
            this.btnBulPc.Click += new System.EventHandler(this.btnBulPc_Click);
            // 
            // btnCekPc
            // 
            this.btnCekPc.Location = new System.Drawing.Point(145, 180);
            this.btnCekPc.Name = "btnCekPc";
            this.btnCekPc.Size = new System.Drawing.Size(75, 23);
            this.btnCekPc.TabIndex = 5;
            this.btnCekPc.Text = "ÇEK";
            this.btnCekPc.UseVisualStyleBackColor = true;
            this.btnCekPc.Click += new System.EventHandler(this.btnCekPc_Click);
            // 
            // txtGoruntulePc
            // 
            this.txtGoruntulePc.Location = new System.Drawing.Point(279, 19);
            this.txtGoruntulePc.Multiline = true;
            this.txtGoruntulePc.Name = "txtGoruntulePc";
            this.txtGoruntulePc.Size = new System.Drawing.Size(296, 155);
            this.txtGoruntulePc.TabIndex = 6;
            this.txtGoruntulePc.TextChanged += new System.EventHandler(this.txtGoruntulePc_TextChanged);
            // 
            // frmParaCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(604, 262);
            this.Controls.Add(this.txtGoruntulePc);
            this.Controls.Add(this.btnCekPc);
            this.Controls.Add(this.btnBulPc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHesNoPc);
            this.Controls.Add(this.txtTutarPc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmParaCek";
            this.Text = "Para Cek";
            this.Load += new System.EventHandler(this.frmParaCek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTutarPc;
        private System.Windows.Forms.TextBox txtHesNoPc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBulPc;
        private System.Windows.Forms.Button btnCekPc;
        private System.Windows.Forms.TextBox txtGoruntulePc;
    }
}