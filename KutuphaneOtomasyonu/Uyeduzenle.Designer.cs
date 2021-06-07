namespace KutuphaneOtomasyonu
{
    partial class Uyeduzenle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adsoyad = new System.Windows.Forms.TextBox();
            this.epostaa = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.telno = new System.Windows.Forms.MaskedTextBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.iptal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(162, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(165, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(168, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-posta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(171, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres :";
            // 
            // adsoyad
            // 
            this.adsoyad.Location = new System.Drawing.Point(268, 120);
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(220, 22);
            this.adsoyad.TabIndex = 4;
            this.adsoyad.TextChanged += new System.EventHandler(this.adsoyad_TextChanged);
            // 
            // epostaa
            // 
            this.epostaa.Location = new System.Drawing.Point(268, 243);
            this.epostaa.Name = "epostaa";
            this.epostaa.Size = new System.Drawing.Size(220, 22);
            this.epostaa.TabIndex = 5;
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(268, 314);
            this.adress.Multiline = true;
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(220, 125);
            this.adress.TabIndex = 6;
            // 
            // telno
            // 
            this.telno.Location = new System.Drawing.Point(268, 178);
            this.telno.Mask = "(999) 000-0000";
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(220, 22);
            this.telno.TabIndex = 7;
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.Color.Lime;
            this.kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet.Location = new System.Drawing.Point(413, 464);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(123, 54);
            this.kaydet.TabIndex = 8;
            this.kaydet.Text = "KAYDET";
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Red;
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.Location = new System.Drawing.Point(256, 464);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(123, 54);
            this.sil.TabIndex = 9;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.Cyan;
            this.iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptal.Location = new System.Drawing.Point(46, 464);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(123, 54);
            this.iptal.TabIndex = 10;
            this.iptal.Text = "GERİ";
            this.iptal.UseVisualStyleBackColor = false;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(189, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID :";
            // 
            // idd
            // 
            this.idd.AutoSize = true;
            this.idd.Location = new System.Drawing.Point(265, 78);
            this.idd.Name = "idd";
            this.idd.Size = new System.Drawing.Size(0, 17);
            this.idd.TabIndex = 12;
            // 
            // Uyeduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 586);
            this.Controls.Add(this.idd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.telno);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.epostaa);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Uyeduzenle";
            this.Text = "ÜYE DÜZENLE";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Uyeduzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adsoyad;
        private System.Windows.Forms.TextBox epostaa;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.MaskedTextBox telno;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label idd;
    }
}