namespace VitaminDeposuOyunu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Resimler = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Sayaclabeli = new System.Windows.Forms.Label();
            this.SÜRE = new System.Windows.Forms.Label();
            this.baslaButonu = new System.Windows.Forms.Button();
            this.SuluMeyveSikacagiButonu = new System.Windows.Forms.Button();
            this.toplamAVitamini = new System.Windows.Forms.Label();
            this.toplamAVitaminiLabel = new System.Windows.Forms.Label();
            this.toplamSiviAgirlik = new System.Windows.Forms.Label();
            this.toplamSiviAgirlikLabel = new System.Windows.Forms.Label();
            this.KatiMeyveSikacagiButonu = new System.Windows.Forms.Button();
            this.toplamCVitamini = new System.Windows.Forms.Label();
            this.toplamCVitaminiLabel = new System.Windows.Forms.Label();
            this.toplamPüreAgirlik = new System.Windows.Forms.Label();
            this.toplamPureAgirlikLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resimler)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.Resimler);
            this.panel1.Location = new System.Drawing.Point(5, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 245);
            this.panel1.TabIndex = 18;
            // 
            // Resimler
            // 
            this.Resimler.BackColor = System.Drawing.Color.Silver;
            this.Resimler.Location = new System.Drawing.Point(16, 16);
            this.Resimler.Name = "Resimler";
            this.Resimler.Size = new System.Drawing.Size(300, 212);
            this.Resimler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resimler.TabIndex = 3;
            this.Resimler.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.Sayaclabeli);
            this.panel2.Controls.Add(this.SÜRE);
            this.panel2.Controls.Add(this.baslaButonu);
            this.panel2.Location = new System.Drawing.Point(5, 282);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 346);
            this.panel2.TabIndex = 19;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.CadetBlue;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(75, 273);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(6);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 67);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "ÇIKIŞ";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Sayaclabeli
            // 
            this.Sayaclabeli.BackColor = System.Drawing.Color.White;
            this.Sayaclabeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sayaclabeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sayaclabeli.ForeColor = System.Drawing.Color.Teal;
            this.Sayaclabeli.Location = new System.Drawing.Point(40, 137);
            this.Sayaclabeli.Name = "Sayaclabeli";
            this.Sayaclabeli.Size = new System.Drawing.Size(255, 119);
            this.Sayaclabeli.TabIndex = 13;
            this.Sayaclabeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SÜRE
            // 
            this.SÜRE.BackColor = System.Drawing.Color.LightBlue;
            this.SÜRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SÜRE.ForeColor = System.Drawing.Color.White;
            this.SÜRE.Location = new System.Drawing.Point(40, 105);
            this.SÜRE.Name = "SÜRE";
            this.SÜRE.Size = new System.Drawing.Size(255, 32);
            this.SÜRE.TabIndex = 11;
            this.SÜRE.Text = "SÜRE";
            this.SÜRE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baslaButonu
            // 
            this.baslaButonu.BackColor = System.Drawing.Color.CadetBlue;
            this.baslaButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslaButonu.ForeColor = System.Drawing.Color.White;
            this.baslaButonu.Location = new System.Drawing.Point(40, 15);
            this.baslaButonu.Margin = new System.Windows.Forms.Padding(6);
            this.baslaButonu.Name = "baslaButonu";
            this.baslaButonu.Size = new System.Drawing.Size(255, 84);
            this.baslaButonu.TabIndex = 1;
            this.baslaButonu.Text = "BAŞLA";
            this.baslaButonu.UseVisualStyleBackColor = false;
            this.baslaButonu.Click += new System.EventHandler(this.baslaButonu_Click);
            // 
            // SuluMeyveSikacagiButonu
            // 
            this.SuluMeyveSikacagiButonu.BackColor = System.Drawing.Color.LightBlue;
            this.SuluMeyveSikacagiButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SuluMeyveSikacagiButonu.ForeColor = System.Drawing.Color.White;
            this.SuluMeyveSikacagiButonu.Location = new System.Drawing.Point(403, 31);
            this.SuluMeyveSikacagiButonu.Name = "SuluMeyveSikacagiButonu";
            this.SuluMeyveSikacagiButonu.Size = new System.Drawing.Size(275, 137);
            this.SuluMeyveSikacagiButonu.TabIndex = 27;
            this.SuluMeyveSikacagiButonu.Text = "SULU MEYVE SIKACAĞI";
            this.SuluMeyveSikacagiButonu.UseVisualStyleBackColor = false;
            this.SuluMeyveSikacagiButonu.Click += new System.EventHandler(this.SuluMeyveSikacagiButonu_Click);
            // 
            // toplamAVitamini
            // 
            this.toplamAVitamini.BackColor = System.Drawing.Color.Bisque;
            this.toplamAVitamini.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamAVitamini.Location = new System.Drawing.Point(425, 215);
            this.toplamAVitamini.Name = "toplamAVitamini";
            this.toplamAVitamini.Size = new System.Drawing.Size(231, 28);
            this.toplamAVitamini.TabIndex = 28;
            this.toplamAVitamini.Text = "TOPLAM A VİTAMİNİ";
            this.toplamAVitamini.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toplamAVitaminiLabel
            // 
            this.toplamAVitaminiLabel.BackColor = System.Drawing.Color.White;
            this.toplamAVitaminiLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toplamAVitaminiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamAVitaminiLabel.ForeColor = System.Drawing.Color.Teal;
            this.toplamAVitaminiLabel.Location = new System.Drawing.Point(425, 243);
            this.toplamAVitaminiLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.toplamAVitaminiLabel.Name = "toplamAVitaminiLabel";
            this.toplamAVitaminiLabel.Size = new System.Drawing.Size(231, 154);
            this.toplamAVitaminiLabel.TabIndex = 29;
            this.toplamAVitaminiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toplamSiviAgirlik
            // 
            this.toplamSiviAgirlik.BackColor = System.Drawing.Color.Bisque;
            this.toplamSiviAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamSiviAgirlik.Location = new System.Drawing.Point(425, 433);
            this.toplamSiviAgirlik.Name = "toplamSiviAgirlik";
            this.toplamSiviAgirlik.Size = new System.Drawing.Size(231, 28);
            this.toplamSiviAgirlik.TabIndex = 30;
            this.toplamSiviAgirlik.Text = "TOPLAM SIVI AĞIRLIK";
            this.toplamSiviAgirlik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toplamSiviAgirlikLabel
            // 
            this.toplamSiviAgirlikLabel.BackColor = System.Drawing.Color.White;
            this.toplamSiviAgirlikLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toplamSiviAgirlikLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamSiviAgirlikLabel.ForeColor = System.Drawing.Color.Teal;
            this.toplamSiviAgirlikLabel.Location = new System.Drawing.Point(425, 461);
            this.toplamSiviAgirlikLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.toplamSiviAgirlikLabel.Name = "toplamSiviAgirlikLabel";
            this.toplamSiviAgirlikLabel.Size = new System.Drawing.Size(231, 154);
            this.toplamSiviAgirlikLabel.TabIndex = 31;
            this.toplamSiviAgirlikLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KatiMeyveSikacagiButonu
            // 
            this.KatiMeyveSikacagiButonu.BackColor = System.Drawing.Color.LightBlue;
            this.KatiMeyveSikacagiButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KatiMeyveSikacagiButonu.ForeColor = System.Drawing.Color.White;
            this.KatiMeyveSikacagiButonu.Location = new System.Drawing.Point(731, 31);
            this.KatiMeyveSikacagiButonu.Name = "KatiMeyveSikacagiButonu";
            this.KatiMeyveSikacagiButonu.Size = new System.Drawing.Size(275, 137);
            this.KatiMeyveSikacagiButonu.TabIndex = 32;
            this.KatiMeyveSikacagiButonu.Text = "KATI MEYVE SIKACAĞI";
            this.KatiMeyveSikacagiButonu.UseVisualStyleBackColor = false;
            this.KatiMeyveSikacagiButonu.Click += new System.EventHandler(this.KatiMeyveSikacagiButonu_Click);
            // 
            // toplamCVitamini
            // 
            this.toplamCVitamini.BackColor = System.Drawing.Color.Bisque;
            this.toplamCVitamini.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamCVitamini.Location = new System.Drawing.Point(753, 215);
            this.toplamCVitamini.Name = "toplamCVitamini";
            this.toplamCVitamini.Size = new System.Drawing.Size(236, 28);
            this.toplamCVitamini.TabIndex = 33;
            this.toplamCVitamini.Text = "TOPLAM C VİTAMİNİ";
            this.toplamCVitamini.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toplamCVitaminiLabel
            // 
            this.toplamCVitaminiLabel.BackColor = System.Drawing.Color.White;
            this.toplamCVitaminiLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toplamCVitaminiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamCVitaminiLabel.ForeColor = System.Drawing.Color.Teal;
            this.toplamCVitaminiLabel.Location = new System.Drawing.Point(753, 243);
            this.toplamCVitaminiLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.toplamCVitaminiLabel.Name = "toplamCVitaminiLabel";
            this.toplamCVitaminiLabel.Size = new System.Drawing.Size(236, 154);
            this.toplamCVitaminiLabel.TabIndex = 34;
            this.toplamCVitaminiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toplamPüreAgirlik
            // 
            this.toplamPüreAgirlik.BackColor = System.Drawing.Color.Bisque;
            this.toplamPüreAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamPüreAgirlik.Location = new System.Drawing.Point(753, 433);
            this.toplamPüreAgirlik.Name = "toplamPüreAgirlik";
            this.toplamPüreAgirlik.Size = new System.Drawing.Size(236, 28);
            this.toplamPüreAgirlik.TabIndex = 35;
            this.toplamPüreAgirlik.Text = "TOPLAM PÜRE AĞIRLIK";
            this.toplamPüreAgirlik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toplamPureAgirlikLabel
            // 
            this.toplamPureAgirlikLabel.BackColor = System.Drawing.Color.White;
            this.toplamPureAgirlikLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toplamPureAgirlikLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamPureAgirlikLabel.ForeColor = System.Drawing.Color.Teal;
            this.toplamPureAgirlikLabel.Location = new System.Drawing.Point(753, 461);
            this.toplamPureAgirlikLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.toplamPureAgirlikLabel.Name = "toplamPureAgirlikLabel";
            this.toplamPureAgirlikLabel.Size = new System.Drawing.Size(236, 154);
            this.toplamPureAgirlikLabel.TabIndex = 36;
            this.toplamPureAgirlikLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1075, 630);
            this.Controls.Add(this.toplamPureAgirlikLabel);
            this.Controls.Add(this.toplamPüreAgirlik);
            this.Controls.Add(this.toplamCVitaminiLabel);
            this.Controls.Add(this.toplamCVitamini);
            this.Controls.Add(this.KatiMeyveSikacagiButonu);
            this.Controls.Add(this.toplamSiviAgirlikLabel);
            this.Controls.Add(this.toplamSiviAgirlik);
            this.Controls.Add(this.toplamAVitaminiLabel);
            this.Controls.Add(this.toplamAVitamini);
            this.Controls.Add(this.SuluMeyveSikacagiButonu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "VitaminDeposuOyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Resimler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Resimler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label Sayaclabeli;
        private System.Windows.Forms.Label SÜRE;
        private System.Windows.Forms.Button baslaButonu;
        private System.Windows.Forms.Button SuluMeyveSikacagiButonu;
        private System.Windows.Forms.Label toplamAVitamini;
        private System.Windows.Forms.Label toplamAVitaminiLabel;
        private System.Windows.Forms.Label toplamSiviAgirlik;
        private System.Windows.Forms.Label toplamSiviAgirlikLabel;
        private System.Windows.Forms.Button KatiMeyveSikacagiButonu;
        private System.Windows.Forms.Label toplamCVitamini;
        private System.Windows.Forms.Label toplamCVitaminiLabel;
        private System.Windows.Forms.Label toplamPüreAgirlik;
        private System.Windows.Forms.Label toplamPureAgirlikLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

