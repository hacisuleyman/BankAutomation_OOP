namespace BankaOtomasyonuDeneme
{
    partial class frmHesapOzet
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHesNoho = new System.Windows.Forms.TextBox();
            this.btnOzet = new System.Windows.Forms.Button();
            this.txtozetliste = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No:";
            // 
            // txtHesNoho
            // 
            this.txtHesNoho.Location = new System.Drawing.Point(181, 48);
            this.txtHesNoho.Name = "txtHesNoho";
            this.txtHesNoho.Size = new System.Drawing.Size(133, 20);
            this.txtHesNoho.TabIndex = 1;
            // 
            // btnOzet
            // 
            this.btnOzet.BackColor = System.Drawing.SystemColors.Control;
            this.btnOzet.Location = new System.Drawing.Point(196, 74);
            this.btnOzet.Name = "btnOzet";
            this.btnOzet.Size = new System.Drawing.Size(106, 35);
            this.btnOzet.TabIndex = 2;
            this.btnOzet.Text = "GÖRÜNTÜLE";
            this.btnOzet.UseVisualStyleBackColor = false;
            this.btnOzet.Click += new System.EventHandler(this.btnOzet_Click);
            // 
            // txtozetliste
            // 
            this.txtozetliste.Location = new System.Drawing.Point(28, 115);
            this.txtozetliste.Multiline = true;
            this.txtozetliste.Name = "txtozetliste";
            this.txtozetliste.Size = new System.Drawing.Size(431, 203);
            this.txtozetliste.TabIndex = 3;
            // 
            // frmHesapOzet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(485, 342);
            this.Controls.Add(this.txtozetliste);
            this.Controls.Add(this.btnOzet);
            this.Controls.Add(this.txtHesNoho);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHesapOzet";
            this.Text = "Hesap Özeti";
            this.Load += new System.EventHandler(this.frmHesapOzet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHesNoho;
        private System.Windows.Forms.Button btnOzet;
        private System.Windows.Forms.TextBox txtozetliste;
    }
}