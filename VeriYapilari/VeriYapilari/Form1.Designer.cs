
namespace VeriYapilari
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMusteriTanimlama = new System.Windows.Forms.TabPage();
            this.txtSiraBildir = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCommercial = new System.Windows.Forms.RadioButton();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.rbIndividual = new System.Windows.Forms.RadioButton();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTicariCagriListele = new System.Windows.Forms.Button();
            this.BekleyenCagriTicari = new System.Windows.Forms.ListBox();
            this.btnBireyselCagriListele = new System.Windows.Forms.Button();
            this.btnGuncelle4 = new System.Windows.Forms.Button();
            this.btnGuncelle3 = new System.Windows.Forms.Button();
            this.btnGuncelle2 = new System.Windows.Forms.Button();
            this.btnGuncelle1 = new System.Windows.Forms.Button();
            this.BekleyenCagriBireysel = new System.Windows.Forms.ListBox();
            this.TicariTemsilci2 = new System.Windows.Forms.ListBox();
            this.TicariTemsilci1 = new System.Windows.Forms.ListBox();
            this.BireyselTemsilci2 = new System.Windows.Forms.ListBox();
            this.BireyselTemsilci1 = new System.Windows.Forms.ListBox();
            this.btnCagriBaslat = new System.Windows.Forms.Button();
            this.btnCagriBitir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpMusteriTanimlama.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMusteriTanimlama);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // tpMusteriTanimlama
            // 
            this.tpMusteriTanimlama.Controls.Add(this.txtSiraBildir);
            this.tpMusteriTanimlama.Controls.Add(this.btnAra);
            this.tpMusteriTanimlama.Controls.Add(this.label1);
            this.tpMusteriTanimlama.Controls.Add(this.rbCommercial);
            this.tpMusteriTanimlama.Controls.Add(this.txtTelNo);
            this.tpMusteriTanimlama.Controls.Add(this.lblTelNo);
            this.tpMusteriTanimlama.Controls.Add(this.txtSoyad);
            this.tpMusteriTanimlama.Controls.Add(this.lblSoyad);
            this.tpMusteriTanimlama.Controls.Add(this.rbIndividual);
            this.tpMusteriTanimlama.Controls.Add(this.txtAd);
            this.tpMusteriTanimlama.Controls.Add(this.lblAd);
            this.tpMusteriTanimlama.Location = new System.Drawing.Point(4, 22);
            this.tpMusteriTanimlama.Name = "tpMusteriTanimlama";
            this.tpMusteriTanimlama.Padding = new System.Windows.Forms.Padding(3);
            this.tpMusteriTanimlama.Size = new System.Drawing.Size(1002, 517);
            this.tpMusteriTanimlama.TabIndex = 0;
            this.tpMusteriTanimlama.Text = "Müşteri Tanımlama";
            this.tpMusteriTanimlama.UseVisualStyleBackColor = true;
            // 
            // txtSiraBildir
            // 
            this.txtSiraBildir.Location = new System.Drawing.Point(43, 333);
            this.txtSiraBildir.Multiline = true;
            this.txtSiraBildir.Name = "txtSiraBildir";
            this.txtSiraBildir.Size = new System.Drawing.Size(274, 66);
            this.txtSiraBildir.TabIndex = 10;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(66, 248);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(143, 29);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tel No:";
            // 
            // rbCommercial
            // 
            this.rbCommercial.AutoSize = true;
            this.rbCommercial.Location = new System.Drawing.Point(158, 184);
            this.rbCommercial.Name = "rbCommercial";
            this.rbCommercial.Size = new System.Drawing.Size(51, 17);
            this.rbCommercial.TabIndex = 7;
            this.rbCommercial.TabStop = true;
            this.rbCommercial.Text = "Ticari";
            this.rbCommercial.UseVisualStyleBackColor = true;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(66, 122);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(143, 20);
            this.txtTelNo.TabIndex = 6;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(21, 125);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(39, 13);
            this.lblTelNo.TabIndex = 5;
            this.lblTelNo.Text = "Tel No";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(66, 77);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(143, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(23, 79);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "Soyad";
            // 
            // rbIndividual
            // 
            this.rbIndividual.AutoSize = true;
            this.rbIndividual.Location = new System.Drawing.Point(80, 184);
            this.rbIndividual.Name = "rbIndividual";
            this.rbIndividual.Size = new System.Drawing.Size(61, 17);
            this.rbIndividual.TabIndex = 2;
            this.rbIndividual.TabStop = true;
            this.rbIndividual.Text = "Bireysel";
            this.rbIndividual.UseVisualStyleBackColor = true;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(66, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(143, 20);
            this.txtAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(40, 35);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTicariCagriListele);
            this.tabPage2.Controls.Add(this.BekleyenCagriTicari);
            this.tabPage2.Controls.Add(this.btnBireyselCagriListele);
            this.tabPage2.Controls.Add(this.btnGuncelle4);
            this.tabPage2.Controls.Add(this.btnGuncelle3);
            this.tabPage2.Controls.Add(this.btnGuncelle2);
            this.tabPage2.Controls.Add(this.btnGuncelle1);
            this.tabPage2.Controls.Add(this.BekleyenCagriBireysel);
            this.tabPage2.Controls.Add(this.TicariTemsilci2);
            this.tabPage2.Controls.Add(this.TicariTemsilci1);
            this.tabPage2.Controls.Add(this.BireyselTemsilci2);
            this.tabPage2.Controls.Add(this.BireyselTemsilci1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1002, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çağrı Başlat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTicariCagriListele
            // 
            this.btnTicariCagriListele.Location = new System.Drawing.Point(643, 474);
            this.btnTicariCagriListele.Name = "btnTicariCagriListele";
            this.btnTicariCagriListele.Size = new System.Drawing.Size(202, 23);
            this.btnTicariCagriListele.TabIndex = 11;
            this.btnTicariCagriListele.Text = "Bekleyen Ticari Çağrıları Listele";
            this.btnTicariCagriListele.UseVisualStyleBackColor = true;
            this.btnTicariCagriListele.Click += new System.EventHandler(this.btnTicariCagriListele_Click);
            // 
            // BekleyenCagriTicari
            // 
            this.BekleyenCagriTicari.FormattingEnabled = true;
            this.BekleyenCagriTicari.Location = new System.Drawing.Point(498, 286);
            this.BekleyenCagriTicari.Name = "BekleyenCagriTicari";
            this.BekleyenCagriTicari.Size = new System.Drawing.Size(464, 173);
            this.BekleyenCagriTicari.TabIndex = 10;
            // 
            // btnBireyselCagriListele
            // 
            this.btnBireyselCagriListele.Location = new System.Drawing.Point(131, 474);
            this.btnBireyselCagriListele.Name = "btnBireyselCagriListele";
            this.btnBireyselCagriListele.Size = new System.Drawing.Size(199, 23);
            this.btnBireyselCagriListele.TabIndex = 9;
            this.btnBireyselCagriListele.Text = "Bekleyen Bireysel Çağrıları Listele";
            this.btnBireyselCagriListele.UseVisualStyleBackColor = true;
            this.btnBireyselCagriListele.Click += new System.EventHandler(this.btnCagriListele_Click);
            // 
            // btnGuncelle4
            // 
            this.btnGuncelle4.Location = new System.Drawing.Point(677, 248);
            this.btnGuncelle4.Name = "btnGuncelle4";
            this.btnGuncelle4.Size = new System.Drawing.Size(103, 23);
            this.btnGuncelle4.TabIndex = 8;
            this.btnGuncelle4.Text = "Güncelle";
            this.btnGuncelle4.UseVisualStyleBackColor = true;
            this.btnGuncelle4.Click += new System.EventHandler(this.btnGuncelle4_Click);
            // 
            // btnGuncelle3
            // 
            this.btnGuncelle3.Location = new System.Drawing.Point(153, 248);
            this.btnGuncelle3.Name = "btnGuncelle3";
            this.btnGuncelle3.Size = new System.Drawing.Size(103, 23);
            this.btnGuncelle3.TabIndex = 7;
            this.btnGuncelle3.Text = "Güncelle";
            this.btnGuncelle3.UseVisualStyleBackColor = true;
            this.btnGuncelle3.Click += new System.EventHandler(this.btnGuncelle3_Click);
            // 
            // btnGuncelle2
            // 
            this.btnGuncelle2.Location = new System.Drawing.Point(677, 119);
            this.btnGuncelle2.Name = "btnGuncelle2";
            this.btnGuncelle2.Size = new System.Drawing.Size(103, 23);
            this.btnGuncelle2.TabIndex = 6;
            this.btnGuncelle2.Text = "Güncelle";
            this.btnGuncelle2.UseVisualStyleBackColor = true;
            this.btnGuncelle2.Click += new System.EventHandler(this.btnGuncelle2_Click);
            // 
            // btnGuncelle1
            // 
            this.btnGuncelle1.Location = new System.Drawing.Point(153, 118);
            this.btnGuncelle1.Name = "btnGuncelle1";
            this.btnGuncelle1.Size = new System.Drawing.Size(103, 23);
            this.btnGuncelle1.TabIndex = 5;
            this.btnGuncelle1.Text = "Güncelle";
            this.btnGuncelle1.UseVisualStyleBackColor = true;
            this.btnGuncelle1.Click += new System.EventHandler(this.btnGuncelle1_Click);
            // 
            // BekleyenCagriBireysel
            // 
            this.BekleyenCagriBireysel.FormattingEnabled = true;
            this.BekleyenCagriBireysel.Location = new System.Drawing.Point(6, 286);
            this.BekleyenCagriBireysel.Name = "BekleyenCagriBireysel";
            this.BekleyenCagriBireysel.Size = new System.Drawing.Size(464, 173);
            this.BekleyenCagriBireysel.TabIndex = 4;
            this.BekleyenCagriBireysel.SelectedIndexChanged += new System.EventHandler(this.btnCagriListele_Click);
            // 
            // TicariTemsilci2
            // 
            this.TicariTemsilci2.FormattingEnabled = true;
            this.TicariTemsilci2.Items.AddRange(new object[] {
            "Ticari Temsilci 2"});
            this.TicariTemsilci2.Location = new System.Drawing.Point(498, 147);
            this.TicariTemsilci2.Name = "TicariTemsilci2";
            this.TicariTemsilci2.Size = new System.Drawing.Size(442, 95);
            this.TicariTemsilci2.TabIndex = 3;
            // 
            // TicariTemsilci1
            // 
            this.TicariTemsilci1.FormattingEnabled = true;
            this.TicariTemsilci1.Items.AddRange(new object[] {
            "Ticari Temsilci 1"});
            this.TicariTemsilci1.Location = new System.Drawing.Point(6, 147);
            this.TicariTemsilci1.Name = "TicariTemsilci1";
            this.TicariTemsilci1.Size = new System.Drawing.Size(464, 95);
            this.TicariTemsilci1.TabIndex = 2;
            // 
            // BireyselTemsilci2
            // 
            this.BireyselTemsilci2.FormattingEnabled = true;
            this.BireyselTemsilci2.Items.AddRange(new object[] {
            "Bireysel Temsilci 2"});
            this.BireyselTemsilci2.Location = new System.Drawing.Point(498, 18);
            this.BireyselTemsilci2.Name = "BireyselTemsilci2";
            this.BireyselTemsilci2.Size = new System.Drawing.Size(442, 95);
            this.BireyselTemsilci2.TabIndex = 1;
            // 
            // BireyselTemsilci1
            // 
            this.BireyselTemsilci1.FormattingEnabled = true;
            this.BireyselTemsilci1.Items.AddRange(new object[] {
            "Bireysel Temsilci 1"});
            this.BireyselTemsilci1.Location = new System.Drawing.Point(6, 18);
            this.BireyselTemsilci1.Name = "BireyselTemsilci1";
            this.BireyselTemsilci1.Size = new System.Drawing.Size(464, 95);
            this.BireyselTemsilci1.TabIndex = 0;
            // 
            // btnCagriBaslat
            // 
            this.btnCagriBaslat.Location = new System.Drawing.Point(1085, 52);
            this.btnCagriBaslat.Name = "btnCagriBaslat";
            this.btnCagriBaslat.Size = new System.Drawing.Size(190, 39);
            this.btnCagriBaslat.TabIndex = 6;
            this.btnCagriBaslat.Text = "Çağrı Başlat";
            this.btnCagriBaslat.UseVisualStyleBackColor = true;
            this.btnCagriBaslat.Click += new System.EventHandler(this.btnCagriBaslat_Click);
            // 
            // btnCagriBitir
            // 
            this.btnCagriBitir.Location = new System.Drawing.Point(1085, 393);
            this.btnCagriBitir.Name = "btnCagriBitir";
            this.btnCagriBitir.Size = new System.Drawing.Size(190, 39);
            this.btnCagriBitir.TabIndex = 7;
            this.btnCagriBitir.Text = "Çağrı Bİtir";
            this.btnCagriBitir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 578);
            this.Controls.Add(this.btnCagriBitir);
            this.Controls.Add(this.btnCagriBaslat);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpMusteriTanimlama.ResumeLayout(false);
            this.tpMusteriTanimlama.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMusteriTanimlama;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.RadioButton rbCommercial;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.RadioButton rbIndividual;
        private System.Windows.Forms.TextBox txtSiraBildir;
        private System.Windows.Forms.ListBox BekleyenCagriBireysel;
        private System.Windows.Forms.ListBox TicariTemsilci2;
        private System.Windows.Forms.ListBox TicariTemsilci1;
        private System.Windows.Forms.ListBox BireyselTemsilci2;
        private System.Windows.Forms.ListBox BireyselTemsilci1;
        private System.Windows.Forms.Button btnGuncelle4;
        private System.Windows.Forms.Button btnGuncelle3;
        private System.Windows.Forms.Button btnGuncelle2;
        private System.Windows.Forms.Button btnGuncelle1;
        private System.Windows.Forms.Button btnBireyselCagriListele;
        private System.Windows.Forms.Button btnTicariCagriListele;
        private System.Windows.Forms.ListBox BekleyenCagriTicari;
        private System.Windows.Forms.Button btnCagriBaslat;
        private System.Windows.Forms.Button btnCagriBitir;
    }
}

