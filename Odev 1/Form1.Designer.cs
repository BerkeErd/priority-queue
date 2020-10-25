namespace Odev_1
{
    partial class Form1
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
            this.txtListe = new System.Windows.Forms.TextBox();
            this.btnSirali = new System.Windows.Forms.Button();
            this.btnOncelikli = new System.Windows.Forms.Button();
            this.btnKiyasla = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.btnAtla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtListe
            // 
            this.txtListe.Location = new System.Drawing.Point(12, 12);
            this.txtListe.Multiline = true;
            this.txtListe.Name = "txtListe";
            this.txtListe.ReadOnly = true;
            this.txtListe.Size = new System.Drawing.Size(289, 376);
            this.txtListe.TabIndex = 0;
            this.txtListe.TextChanged += new System.EventHandler(this.txtListe_TextChanged);
            // 
            // btnSirali
            // 
            this.btnSirali.Location = new System.Drawing.Point(350, 141);
            this.btnSirali.Name = "btnSirali";
            this.btnSirali.Size = new System.Drawing.Size(89, 23);
            this.btnSirali.TabIndex = 1;
            this.btnSirali.Text = "Sıralı Liste";
            this.btnSirali.UseVisualStyleBackColor = true;
            this.btnSirali.Click += new System.EventHandler(this.btnSirali_Click);
            // 
            // btnOncelikli
            // 
            this.btnOncelikli.Location = new System.Drawing.Point(350, 183);
            this.btnOncelikli.Name = "btnOncelikli";
            this.btnOncelikli.Size = new System.Drawing.Size(89, 23);
            this.btnOncelikli.TabIndex = 2;
            this.btnOncelikli.Text = "Öncelikli Liste";
            this.btnOncelikli.UseVisualStyleBackColor = true;
            this.btnOncelikli.Click += new System.EventHandler(this.btnOncelikli_Click);
            // 
            // btnKiyasla
            // 
            this.btnKiyasla.Location = new System.Drawing.Point(350, 226);
            this.btnKiyasla.Name = "btnKiyasla";
            this.btnKiyasla.Size = new System.Drawing.Size(89, 23);
            this.btnKiyasla.TabIndex = 3;
            this.btnKiyasla.Text = "Kıyasla";
            this.btnKiyasla.UseVisualStyleBackColor = true;
            this.btnKiyasla.Click += new System.EventHandler(this.btnKiyasla_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(361, 37);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(67, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(361, 77);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(67, 23);
            this.btnCikar.TabIndex = 5;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Çıkış işlemi süresi :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(453, 303);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(13, 13);
            this.lblSure.TabIndex = 7;
            this.lblSure.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ortalama işlem süresi  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(453, 277);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(13, 13);
            this.lblOrtalama.TabIndex = 9;
            this.lblOrtalama.Text = "0";
            // 
            // btnAtla
            // 
            this.btnAtla.Location = new System.Drawing.Point(336, 341);
            this.btnAtla.Name = "btnAtla";
            this.btnAtla.Size = new System.Drawing.Size(130, 23);
            this.btnAtla.TabIndex = 10;
            this.btnAtla.Text = "Beklemeyi Atla";
            this.btnAtla.UseVisualStyleBackColor = true;
            this.btnAtla.Click += new System.EventHandler(this.btnAtla_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 400);
            this.Controls.Add(this.btnAtla);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnKiyasla);
            this.Controls.Add(this.btnOncelikli);
            this.Controls.Add(this.btnSirali);
            this.Controls.Add(this.txtListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListe;
        private System.Windows.Forms.Button btnSirali;
        private System.Windows.Forms.Button btnOncelikli;
        private System.Windows.Forms.Button btnKiyasla;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Button btnAtla;
        private System.Windows.Forms.Timer timer1;
    }
}

