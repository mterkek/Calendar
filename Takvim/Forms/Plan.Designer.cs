
namespace Takvim.Forms
{
    partial class Plan
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
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.textBoxTanım = new System.Windows.Forms.TextBox();
            this.textBoxBaslangic = new System.Windows.Forms.TextBox();
            this.textBoxZaman = new System.Windows.Forms.TextBox();
            this.labelSifre = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelKulAd = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxbitis = new System.Windows.Forms.TextBox();
            this.labelBitis = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDetay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTip
            // 
            this.textBoxTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTip.Location = new System.Drawing.Point(454, 438);
            this.textBoxTip.Multiline = true;
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(197, 39);
            this.textBoxTip.TabIndex = 57;
            // 
            // textBoxTanım
            // 
            this.textBoxTanım.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTanım.Location = new System.Drawing.Point(454, 345);
            this.textBoxTanım.Multiline = true;
            this.textBoxTanım.Name = "textBoxTanım";
            this.textBoxTanım.Size = new System.Drawing.Size(197, 39);
            this.textBoxTanım.TabIndex = 56;
            // 
            // textBoxBaslangic
            // 
            this.textBoxBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBaslangic.Location = new System.Drawing.Point(454, 173);
            this.textBoxBaslangic.Multiline = true;
            this.textBoxBaslangic.Name = "textBoxBaslangic";
            this.textBoxBaslangic.Size = new System.Drawing.Size(197, 39);
            this.textBoxBaslangic.TabIndex = 55;
            // 
            // textBoxZaman
            // 
            this.textBoxZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxZaman.Location = new System.Drawing.Point(454, 103);
            this.textBoxZaman.Multiline = true;
            this.textBoxZaman.Name = "textBoxZaman";
            this.textBoxZaman.Size = new System.Drawing.Size(197, 39);
            this.textBoxZaman.TabIndex = 54;
            // 
            // labelSifre
            // 
            this.labelSifre.BackColor = System.Drawing.Color.Transparent;
            this.labelSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.ForeColor = System.Drawing.Color.White;
            this.labelSifre.Location = new System.Drawing.Point(175, 519);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(252, 42);
            this.labelSifre.TabIndex = 53;
            this.labelSifre.Text = "Olayın Detayı";
            this.labelSifre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMail
            // 
            this.labelMail.BackColor = System.Drawing.Color.Transparent;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMail.ForeColor = System.Drawing.Color.White;
            this.labelMail.Location = new System.Drawing.Point(88, 435);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(307, 42);
            this.labelMail.TabIndex = 52;
            this.labelMail.Text = "Olayın Tipi";
            this.labelMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelMail.Click += new System.EventHandler(this.labelMail_Click);
            // 
            // labelKulAd
            // 
            this.labelKulAd.BackColor = System.Drawing.Color.Transparent;
            this.labelKulAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKulAd.ForeColor = System.Drawing.Color.White;
            this.labelKulAd.Location = new System.Drawing.Point(108, 342);
            this.labelKulAd.Name = "labelKulAd";
            this.labelKulAd.Size = new System.Drawing.Size(287, 42);
            this.labelKulAd.TabIndex = 51;
            this.labelKulAd.Text = "Olayın Tanımı";
            this.labelKulAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSoyad
            // 
            this.labelSoyad.BackColor = System.Drawing.Color.Transparent;
            this.labelSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyad.ForeColor = System.Drawing.Color.White;
            this.labelSoyad.Location = new System.Drawing.Point(24, 173);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(413, 42);
            this.labelSoyad.TabIndex = 50;
            this.labelSoyad.Text = "Olayın Başlangıç Zamanı";
            this.labelSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAd
            // 
            this.labelAd.BackColor = System.Drawing.Color.Transparent;
            this.labelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAd.ForeColor = System.Drawing.Color.White;
            this.labelAd.Location = new System.Drawing.Point(161, 103);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(252, 42);
            this.labelAd.TabIndex = 49;
            this.labelAd.Text = "İşlem Zamanı";
            this.labelAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(545, 649);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(106, 71);
            this.buttonOk.TabIndex = 59;
            this.buttonOk.Text = "Olayı Yarat";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click_1);
            // 
            // textBoxbitis
            // 
            this.textBoxbitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxbitis.Location = new System.Drawing.Point(454, 258);
            this.textBoxbitis.Multiline = true;
            this.textBoxbitis.Name = "textBoxbitis";
            this.textBoxbitis.Size = new System.Drawing.Size(197, 39);
            this.textBoxbitis.TabIndex = 61;
            // 
            // labelBitis
            // 
            this.labelBitis.BackColor = System.Drawing.Color.Transparent;
            this.labelBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBitis.ForeColor = System.Drawing.Color.White;
            this.labelBitis.Location = new System.Drawing.Point(72, 258);
            this.labelBitis.Name = "labelBitis";
            this.labelBitis.Size = new System.Drawing.Size(355, 42);
            this.labelBitis.TabIndex = 60;
            this.labelBitis.Text = "Olayın Bitiş Zamanı";
            this.labelBitis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(637, 12);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 62;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 649);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 71);
            this.button1.TabIndex = 63;
            this.button1.Text = "Geriye Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDetay
            // 
            this.textBoxDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDetay.Location = new System.Drawing.Point(454, 522);
            this.textBoxDetay.Multiline = true;
            this.textBoxDetay.Name = "textBoxDetay";
            this.textBoxDetay.Size = new System.Drawing.Size(197, 39);
            this.textBoxDetay.TabIndex = 64;
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 750);
            this.Controls.Add(this.textBoxDetay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.textBoxbitis);
            this.Controls.Add(this.labelBitis);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxTip);
            this.Controls.Add(this.textBoxTanım);
            this.Controls.Add(this.textBoxBaslangic);
            this.Controls.Add(this.textBoxZaman);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelKulAd);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.labelAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Plan";
            this.Text = "Plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.TextBox textBoxTanım;
        private System.Windows.Forms.TextBox textBoxBaslangic;
        private System.Windows.Forms.TextBox textBoxZaman;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelKulAd;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxbitis;
        private System.Windows.Forms.Label labelBitis;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDetay;
    }
}