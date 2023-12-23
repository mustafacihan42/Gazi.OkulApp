namespace Gazi.OkulApp
{
    partial class frmOgrKayit
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
            this.grpOgrenci = new System.Windows.Forms.GroupBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpOgrenci.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgrenci
            // 
            this.grpOgrenci.Controls.Add(this.lblAd);
            this.grpOgrenci.Controls.Add(this.txtNumara);
            this.grpOgrenci.Controls.Add(this.lblNumara);
            this.grpOgrenci.Controls.Add(this.txtAd);
            this.grpOgrenci.Controls.Add(this.label2);
            this.grpOgrenci.Controls.Add(this.txtSoyad);
            this.grpOgrenci.Location = new System.Drawing.Point(12, 12);
            this.grpOgrenci.Name = "grpOgrenci";
            this.grpOgrenci.Size = new System.Drawing.Size(338, 274);
            this.grpOgrenci.TabIndex = 0;
            this.grpOgrenci.TabStop = false;
            this.grpOgrenci.Text = "OgrenciBilgileri";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(159, 62);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(159, 137);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(159, 199);
            this.txtNumara.Multiline = true;
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 22);
            this.txtNumara.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(59, 65);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 16);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(59, 199);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(55, 16);
            this.lblNumara.TabIndex = 6;
            this.lblNumara.Text = "Numara";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(133, 340);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpOgrenci);
            this.Name = "frmOgrKayit";
            this.Text = "OgrenciKayıtSistemi";
            this.grpOgrenci.ResumeLayout(false);
            this.grpOgrenci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrenci;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnKaydet;
    }
}

