namespace Editor_projesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otsmAc = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eklentilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKizilOtesi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKizilDurum = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.MenuGrup = new System.Windows.Forms.GroupBox();
            this.EkleButton = new System.Windows.Forms.Button();
            this.SilButton = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.ileriButton = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.lvSayfalar = new System.Windows.Forms.ListView();
            this.LvIcerik = new System.Windows.Forms.ListView();
            this.Gbekleme = new System.Windows.Forms.GroupBox();
            this.BtnYaziEkle = new System.Windows.Forms.Button();
            this.BtnCizgiEkle = new System.Windows.Forms.Button();
            this.GbIcerıkMenu = new System.Windows.Forms.GroupBox();
            this.BtnIcerikSil = new System.Windows.Forms.Button();
            this.btnicerikileri = new System.Windows.Forms.Button();
            this.btnicerikgeri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GbOzellik = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRenkSecYazi = new System.Windows.Forms.Button();
            this.btnFontSec = new System.Windows.Forms.Button();
            this.rchYazi = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnYazikaydet = new System.Windows.Forms.Button();
            this.tbYaziy = new System.Windows.Forms.TextBox();
            this.tbYazix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCizgiler = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRenkSecCizgi = new System.Windows.Forms.Button();
            this.tbCizgiKalinlik = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbcizgiy2 = new System.Windows.Forms.TextBox();
            this.tbcizgix2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btCizgiKaydet = new System.Windows.Forms.Button();
            this.tbcizgiy1 = new System.Windows.Forms.TextBox();
            this.tbcizgix1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmsayfalar = new System.Windows.Forms.Timer(this.components);
            this.tmicerikler = new System.Windows.Forms.Timer(this.components);
            this.gbSayfaOzellikler = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRenkSecSayfa = new System.Windows.Forms.Button();
            this.btnSayfaKaydet = new System.Windows.Forms.Button();
            this.acilisBilgisi = new System.Windows.Forms.Label();
            this.umdDinle = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.MenuGrup.SuspendLayout();
            this.Gbekleme.SuspendLayout();
            this.GbIcerıkMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GbOzellik.SuspendLayout();
            this.gbCizgiler.SuspendLayout();
            this.gbSayfaOzellikler.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.eklentilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otsmAc,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "Dosya";
            // 
            // otsmAc
            // 
            this.otsmAc.Name = "otsmAc";
            this.otsmAc.Size = new System.Drawing.Size(110, 22);
            this.otsmAc.Text = "Aç";
            this.otsmAc.Click += new System.EventHandler(this.otsmAc_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.closeToolStripMenuItem.Text = "Kapat";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem1.Text = "Kaydet";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // eklentilerToolStripMenuItem
            // 
            this.eklentilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKizilOtesi,
            this.tsmiKizilDurum});
            this.eklentilerToolStripMenuItem.Name = "eklentilerToolStripMenuItem";
            this.eklentilerToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.eklentilerToolStripMenuItem.Text = "eklentiler";
            // 
            // tsmiKizilOtesi
            // 
            this.tsmiKizilOtesi.Name = "tsmiKizilOtesi";
            this.tsmiKizilOtesi.Size = new System.Drawing.Size(162, 22);
            this.tsmiKizilOtesi.Text = "Kızılötesi Kontrol";
            this.tsmiKizilOtesi.Click += new System.EventHandler(this.tsmiKizilOtesi_Click);
            // 
            // tsmiKizilDurum
            // 
            this.tsmiKizilDurum.CheckOnClick = true;
            this.tsmiKizilDurum.Name = "tsmiKizilDurum";
            this.tsmiKizilDurum.Size = new System.Drawing.Size(162, 22);
            this.tsmiKizilDurum.Text = "Kızılötesi Kullan";
            this.tsmiKizilDurum.Click += new System.EventHandler(this.tsmiKizilDurum_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStatus,
            this.toolStripStatusLabel1,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 670);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openStatus
            // 
            this.openStatus.Name = "openStatus";
            this.openStatus.Size = new System.Drawing.Size(43, 17);
            this.openStatus.Text = "durum";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // MenuGrup
            // 
            this.MenuGrup.Controls.Add(this.EkleButton);
            this.MenuGrup.Controls.Add(this.SilButton);
            this.MenuGrup.Controls.Add(this.geriButton);
            this.MenuGrup.Controls.Add(this.ileriButton);
            this.MenuGrup.Location = new System.Drawing.Point(0, 21);
            this.MenuGrup.Name = "MenuGrup";
            this.MenuGrup.Padding = new System.Windows.Forms.Padding(1);
            this.MenuGrup.Size = new System.Drawing.Size(164, 39);
            this.MenuGrup.TabIndex = 3;
            this.MenuGrup.TabStop = false;
            this.MenuGrup.Text = "Menü";
            // 
            // EkleButton
            // 
            this.EkleButton.BackgroundImage = global::Editor_projesi.Properties.Resources.g004;
            this.EkleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EkleButton.Location = new System.Drawing.Point(96, 14);
            this.EkleButton.Name = "EkleButton";
            this.EkleButton.Size = new System.Drawing.Size(24, 24);
            this.EkleButton.TabIndex = 3;
            this.EkleButton.UseVisualStyleBackColor = true;
            this.EkleButton.Click += new System.EventHandler(this.EkleButton_Click);
            // 
            // SilButton
            // 
            this.SilButton.BackgroundImage = global::Editor_projesi.Properties.Resources.g003;
            this.SilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SilButton.Location = new System.Drawing.Point(66, 15);
            this.SilButton.Name = "SilButton";
            this.SilButton.Size = new System.Drawing.Size(24, 24);
            this.SilButton.TabIndex = 2;
            this.SilButton.UseVisualStyleBackColor = true;
            this.SilButton.Click += new System.EventHandler(this.SilButton_Click);
            // 
            // geriButton
            // 
            this.geriButton.BackgroundImage = global::Editor_projesi.Properties.Resources.g001;
            this.geriButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.geriButton.Location = new System.Drawing.Point(36, 14);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(24, 24);
            this.geriButton.TabIndex = 1;
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // ileriButton
            // 
            this.ileriButton.BackgroundImage = global::Editor_projesi.Properties.Resources.g002;
            this.ileriButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ileriButton.Location = new System.Drawing.Point(9, 14);
            this.ileriButton.Margin = new System.Windows.Forms.Padding(0);
            this.ileriButton.Name = "ileriButton";
            this.ileriButton.Size = new System.Drawing.Size(24, 24);
            this.ileriButton.TabIndex = 0;
            this.ileriButton.TabStop = false;
            this.ileriButton.UseVisualStyleBackColor = true;
            this.ileriButton.Click += new System.EventHandler(this.ileriButton_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTest.Location = new System.Drawing.Point(712, 8);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(65, 16);
            this.labelTest.TabIndex = 5;
            this.labelTest.Text = "labelTest";
            // 
            // lvSayfalar
            // 
            this.lvSayfalar.Location = new System.Drawing.Point(0, 60);
            this.lvSayfalar.Margin = new System.Windows.Forms.Padding(1);
            this.lvSayfalar.Name = "lvSayfalar";
            this.lvSayfalar.Size = new System.Drawing.Size(164, 610);
            this.lvSayfalar.TabIndex = 6;
            this.lvSayfalar.UseCompatibleStateImageBehavior = false;
            this.lvSayfalar.SelectedIndexChanged += new System.EventHandler(this.LvSayfalar_SelectedIndexChanged);
            // 
            // LvIcerik
            // 
            this.LvIcerik.Location = new System.Drawing.Point(857, 60);
            this.LvIcerik.Name = "LvIcerik";
            this.LvIcerik.Size = new System.Drawing.Size(151, 610);
            this.LvIcerik.TabIndex = 8;
            this.LvIcerik.UseCompatibleStateImageBehavior = false;
            this.LvIcerik.SelectedIndexChanged += new System.EventHandler(this.LvIcerik_SelectedIndexChanged);
            // 
            // Gbekleme
            // 
            this.Gbekleme.Controls.Add(this.BtnYaziEkle);
            this.Gbekleme.Controls.Add(this.BtnCizgiEkle);
            this.Gbekleme.Location = new System.Drawing.Point(167, 21);
            this.Gbekleme.Name = "Gbekleme";
            this.Gbekleme.Size = new System.Drawing.Size(681, 38);
            this.Gbekleme.TabIndex = 10;
            this.Gbekleme.TabStop = false;
            this.Gbekleme.Text = "EklemeMenu";
            this.Gbekleme.Enter += new System.EventHandler(this.Gbekleme_Enter);
            // 
            // BtnYaziEkle
            // 
            this.BtnYaziEkle.BackgroundImage = global::Editor_projesi.Properties.Resources.yaziekle;
            this.BtnYaziEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnYaziEkle.Location = new System.Drawing.Point(1, 12);
            this.BtnYaziEkle.Name = "BtnYaziEkle";
            this.BtnYaziEkle.Size = new System.Drawing.Size(24, 24);
            this.BtnYaziEkle.TabIndex = 5;
            this.BtnYaziEkle.UseVisualStyleBackColor = true;
            this.BtnYaziEkle.Click += new System.EventHandler(this.BtnYaziEkle_Click);
            // 
            // BtnCizgiEkle
            // 
            this.BtnCizgiEkle.BackgroundImage = global::Editor_projesi.Properties.Resources.kare;
            this.BtnCizgiEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCizgiEkle.Location = new System.Drawing.Point(26, 12);
            this.BtnCizgiEkle.Name = "BtnCizgiEkle";
            this.BtnCizgiEkle.Size = new System.Drawing.Size(24, 24);
            this.BtnCizgiEkle.TabIndex = 4;
            this.BtnCizgiEkle.Text = "ç";
            this.BtnCizgiEkle.UseVisualStyleBackColor = true;
            this.BtnCizgiEkle.Click += new System.EventHandler(this.BtnCizgiEkle_Click);
            // 
            // GbIcerıkMenu
            // 
            this.GbIcerıkMenu.Controls.Add(this.BtnIcerikSil);
            this.GbIcerıkMenu.Controls.Add(this.btnicerikileri);
            this.GbIcerıkMenu.Controls.Add(this.btnicerikgeri);
            this.GbIcerıkMenu.Location = new System.Drawing.Point(857, 21);
            this.GbIcerıkMenu.Name = "GbIcerıkMenu";
            this.GbIcerıkMenu.Padding = new System.Windows.Forms.Padding(1);
            this.GbIcerıkMenu.Size = new System.Drawing.Size(151, 38);
            this.GbIcerıkMenu.TabIndex = 11;
            this.GbIcerıkMenu.TabStop = false;
            this.GbIcerıkMenu.Text = "Menü";
            // 
            // BtnIcerikSil
            // 
            this.BtnIcerikSil.BackgroundImage = global::Editor_projesi.Properties.Resources.g003;
            this.BtnIcerikSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnIcerikSil.Location = new System.Drawing.Point(66, 15);
            this.BtnIcerikSil.Name = "BtnIcerikSil";
            this.BtnIcerikSil.Size = new System.Drawing.Size(24, 24);
            this.BtnIcerikSil.TabIndex = 2;
            this.BtnIcerikSil.UseVisualStyleBackColor = true;
            this.BtnIcerikSil.Click += new System.EventHandler(this.BtnIcerikSil_Click);
            // 
            // btnicerikileri
            // 
            this.btnicerikileri.BackgroundImage = global::Editor_projesi.Properties.Resources.g002;
            this.btnicerikileri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnicerikileri.Location = new System.Drawing.Point(36, 14);
            this.btnicerikileri.Name = "btnicerikileri";
            this.btnicerikileri.Size = new System.Drawing.Size(24, 24);
            this.btnicerikileri.TabIndex = 1;
            this.btnicerikileri.UseVisualStyleBackColor = true;
            this.btnicerikileri.Click += new System.EventHandler(this.btnicerikileri_Click);
            // 
            // btnicerikgeri
            // 
            this.btnicerikgeri.BackgroundImage = global::Editor_projesi.Properties.Resources.g001;
            this.btnicerikgeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnicerikgeri.Location = new System.Drawing.Point(9, 14);
            this.btnicerikgeri.Margin = new System.Windows.Forms.Padding(0);
            this.btnicerikgeri.Name = "btnicerikgeri";
            this.btnicerikgeri.Size = new System.Drawing.Size(24, 24);
            this.btnicerikgeri.TabIndex = 0;
            this.btnicerikgeri.TabStop = false;
            this.btnicerikgeri.UseVisualStyleBackColor = true;
            this.btnicerikgeri.Click += new System.EventHandler(this.btnicerikgeri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(167, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 466);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // GbOzellik
            // 
            this.GbOzellik.Controls.Add(this.label9);
            this.GbOzellik.Controls.Add(this.btnRenkSecYazi);
            this.GbOzellik.Controls.Add(this.btnFontSec);
            this.GbOzellik.Controls.Add(this.rchYazi);
            this.GbOzellik.Controls.Add(this.label5);
            this.GbOzellik.Controls.Add(this.BtnYazikaydet);
            this.GbOzellik.Controls.Add(this.tbYaziy);
            this.GbOzellik.Controls.Add(this.tbYazix);
            this.GbOzellik.Controls.Add(this.label2);
            this.GbOzellik.Controls.Add(this.label1);
            this.GbOzellik.Location = new System.Drawing.Point(168, 530);
            this.GbOzellik.Name = "GbOzellik";
            this.GbOzellik.Size = new System.Drawing.Size(683, 140);
            this.GbOzellik.TabIndex = 9;
            this.GbOzellik.TabStop = false;
            this.GbOzellik.Text = "Özellikler Yazilar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(516, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Renk seç :";
            // 
            // btnRenkSecYazi
            // 
            this.btnRenkSecYazi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRenkSecYazi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRenkSecYazi.Location = new System.Drawing.Point(591, 83);
            this.btnRenkSecYazi.Name = "btnRenkSecYazi";
            this.btnRenkSecYazi.Size = new System.Drawing.Size(75, 23);
            this.btnRenkSecYazi.TabIndex = 12;
            this.btnRenkSecYazi.UseVisualStyleBackColor = false;
            this.btnRenkSecYazi.Click += new System.EventHandler(this.btnRenkSec_Click);
            // 
            // btnFontSec
            // 
            this.btnFontSec.Location = new System.Drawing.Point(530, 15);
            this.btnFontSec.Name = "btnFontSec";
            this.btnFontSec.Size = new System.Drawing.Size(136, 62);
            this.btnFontSec.TabIndex = 11;
            this.btnFontSec.Text = "font seç";
            this.btnFontSec.UseVisualStyleBackColor = true;
            this.btnFontSec.Click += new System.EventHandler(this.btnFontSec_Click);
            // 
            // rchYazi
            // 
            this.rchYazi.Location = new System.Drawing.Point(303, 17);
            this.rchYazi.Name = "rchYazi";
            this.rchYazi.Size = new System.Drawing.Size(207, 89);
            this.rchYazi.TabIndex = 6;
            this.rchYazi.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yazi = ";
            // 
            // BtnYazikaydet
            // 
            this.BtnYazikaydet.Location = new System.Drawing.Point(28, 101);
            this.BtnYazikaydet.Name = "BtnYazikaydet";
            this.BtnYazikaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnYazikaydet.TabIndex = 4;
            this.BtnYazikaydet.Text = "Kaydet";
            this.BtnYazikaydet.UseVisualStyleBackColor = true;
            this.BtnYazikaydet.Click += new System.EventHandler(this.BtnYazikaydet_Click);
            // 
            // tbYaziy
            // 
            this.tbYaziy.Location = new System.Drawing.Point(90, 40);
            this.tbYaziy.Name = "tbYaziy";
            this.tbYaziy.Size = new System.Drawing.Size(100, 20);
            this.tbYaziy.TabIndex = 3;
            // 
            // tbYazix
            // 
            this.tbYazix.Location = new System.Drawing.Point(90, 17);
            this.tbYazix.Name = "tbYazix";
            this.tbYazix.Size = new System.Drawing.Size(100, 20);
            this.tbYazix.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "YKonum =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "XKonum = ";
            // 
            // gbCizgiler
            // 
            this.gbCizgiler.Controls.Add(this.label10);
            this.gbCizgiler.Controls.Add(this.btnRenkSecCizgi);
            this.gbCizgiler.Controls.Add(this.tbCizgiKalinlik);
            this.gbCizgiler.Controls.Add(this.label8);
            this.gbCizgiler.Controls.Add(this.tbcizgiy2);
            this.gbCizgiler.Controls.Add(this.tbcizgix2);
            this.gbCizgiler.Controls.Add(this.label6);
            this.gbCizgiler.Controls.Add(this.label7);
            this.gbCizgiler.Controls.Add(this.btCizgiKaydet);
            this.gbCizgiler.Controls.Add(this.tbcizgiy1);
            this.gbCizgiler.Controls.Add(this.tbcizgix1);
            this.gbCizgiler.Controls.Add(this.label3);
            this.gbCizgiler.Controls.Add(this.label4);
            this.gbCizgiler.Location = new System.Drawing.Point(167, 391);
            this.gbCizgiler.Name = "gbCizgiler";
            this.gbCizgiler.Size = new System.Drawing.Size(683, 133);
            this.gbCizgiler.TabIndex = 10;
            this.gbCizgiler.TabStop = false;
            this.gbCizgiler.Text = "Özellikler Çizgiler";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Renk seç :";
            // 
            // btnRenkSecCizgi
            // 
            this.btnRenkSecCizgi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRenkSecCizgi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRenkSecCizgi.Location = new System.Drawing.Point(540, 42);
            this.btnRenkSecCizgi.Name = "btnRenkSecCizgi";
            this.btnRenkSecCizgi.Size = new System.Drawing.Size(75, 23);
            this.btnRenkSecCizgi.TabIndex = 14;
            this.btnRenkSecCizgi.UseVisualStyleBackColor = false;
            this.btnRenkSecCizgi.Click += new System.EventHandler(this.btnRenkSecCizgi_Click);
            // 
            // tbCizgiKalinlik
            // 
            this.tbCizgiKalinlik.Location = new System.Drawing.Point(468, 17);
            this.tbCizgiKalinlik.Name = "tbCizgiKalinlik";
            this.tbCizgiKalinlik.Size = new System.Drawing.Size(100, 20);
            this.tbCizgiKalinlik.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kalınlık =";
            // 
            // tbcizgiy2
            // 
            this.tbcizgiy2.Location = new System.Drawing.Point(273, 40);
            this.tbcizgiy2.Name = "tbcizgiy2";
            this.tbcizgiy2.Size = new System.Drawing.Size(100, 20);
            this.tbcizgiy2.TabIndex = 8;
            // 
            // tbcizgix2
            // 
            this.tbcizgix2.Location = new System.Drawing.Point(273, 17);
            this.tbcizgix2.Name = "tbcizgix2";
            this.tbcizgix2.Size = new System.Drawing.Size(100, 20);
            this.tbcizgix2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cizgiy2 =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cizgix2 = ";
            // 
            // btCizgiKaydet
            // 
            this.btCizgiKaydet.Location = new System.Drawing.Point(90, 78);
            this.btCizgiKaydet.Name = "btCizgiKaydet";
            this.btCizgiKaydet.Size = new System.Drawing.Size(75, 23);
            this.btCizgiKaydet.TabIndex = 4;
            this.btCizgiKaydet.Text = "Kaydet";
            this.btCizgiKaydet.UseVisualStyleBackColor = true;
            this.btCizgiKaydet.Click += new System.EventHandler(this.btCizgiKaydet_Click);
            // 
            // tbcizgiy1
            // 
            this.tbcizgiy1.Location = new System.Drawing.Point(90, 40);
            this.tbcizgiy1.Name = "tbcizgiy1";
            this.tbcizgiy1.Size = new System.Drawing.Size(100, 20);
            this.tbcizgiy1.TabIndex = 3;
            // 
            // tbcizgix1
            // 
            this.tbcizgix1.Location = new System.Drawing.Point(90, 17);
            this.tbcizgix1.Name = "tbcizgix1";
            this.tbcizgix1.Size = new System.Drawing.Size(100, 20);
            this.tbcizgix1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cizgiy1 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cizgix1 = ";
            // 
            // tmsayfalar
            // 
            this.tmsayfalar.Tick += new System.EventHandler(this.tmsayfalar_Tick);
            // 
            // tmicerikler
            // 
            this.tmicerikler.Tick += new System.EventHandler(this.tmicerikler_Tick);
            // 
            // gbSayfaOzellikler
            // 
            this.gbSayfaOzellikler.Controls.Add(this.label11);
            this.gbSayfaOzellikler.Controls.Add(this.btnRenkSecSayfa);
            this.gbSayfaOzellikler.Controls.Add(this.btnSayfaKaydet);
            this.gbSayfaOzellikler.Location = new System.Drawing.Point(168, 252);
            this.gbSayfaOzellikler.Name = "gbSayfaOzellikler";
            this.gbSayfaOzellikler.Size = new System.Drawing.Size(683, 133);
            this.gbSayfaOzellikler.TabIndex = 12;
            this.gbSayfaOzellikler.TabStop = false;
            this.gbSayfaOzellikler.Text = "Özellikler Sayfa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Arka plan Renk seç :";
            // 
            // btnRenkSecSayfa
            // 
            this.btnRenkSecSayfa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRenkSecSayfa.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRenkSecSayfa.Location = new System.Drawing.Point(127, 11);
            this.btnRenkSecSayfa.Name = "btnRenkSecSayfa";
            this.btnRenkSecSayfa.Size = new System.Drawing.Size(75, 23);
            this.btnRenkSecSayfa.TabIndex = 14;
            this.btnRenkSecSayfa.UseVisualStyleBackColor = false;
            this.btnRenkSecSayfa.Click += new System.EventHandler(this.btnRenkSecSayfa_Click);
            // 
            // btnSayfaKaydet
            // 
            this.btnSayfaKaydet.Location = new System.Drawing.Point(90, 78);
            this.btnSayfaKaydet.Name = "btnSayfaKaydet";
            this.btnSayfaKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnSayfaKaydet.TabIndex = 4;
            this.btnSayfaKaydet.Text = "Kaydet";
            this.btnSayfaKaydet.UseVisualStyleBackColor = true;
            this.btnSayfaKaydet.Click += new System.EventHandler(this.btnSayfaKaydet_Click);
            // 
            // acilisBilgisi
            // 
            this.acilisBilgisi.AutoSize = true;
            this.acilisBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.acilisBilgisi.Location = new System.Drawing.Point(371, 197);
            this.acilisBilgisi.Name = "acilisBilgisi";
            this.acilisBilgisi.Size = new System.Drawing.Size(203, 42);
            this.acilisBilgisi.TabIndex = 13;
            this.acilisBilgisi.Text = "Yükleniyor";
            // 
            // umdDinle
            // 
            this.umdDinle.Interval = 10;
            this.umdDinle.Tick += new System.EventHandler(this.umdDinle_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 692);
            this.Controls.Add(this.acilisBilgisi);
            this.Controls.Add(this.gbSayfaOzellikler);
            this.Controls.Add(this.gbCizgiler);
            this.Controls.Add(this.GbIcerıkMenu);
            this.Controls.Add(this.Gbekleme);
            this.Controls.Add(this.GbOzellik);
            this.Controls.Add(this.LvIcerik);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvSayfalar);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.MenuGrup);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MenuGrup.ResumeLayout(false);
            this.Gbekleme.ResumeLayout(false);
            this.GbIcerıkMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GbOzellik.ResumeLayout(false);
            this.GbOzellik.PerformLayout();
            this.gbCizgiler.ResumeLayout(false);
            this.gbCizgiler.PerformLayout();
            this.gbSayfaOzellikler.ResumeLayout(false);
            this.gbSayfaOzellikler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otsmAc;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel openStatus;
        private System.Windows.Forms.GroupBox MenuGrup;
        private System.Windows.Forms.Button EkleButton;
        private System.Windows.Forms.Button SilButton;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.Button ileriButton;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.ListView lvSayfalar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView LvIcerik;
        private System.Windows.Forms.GroupBox Gbekleme;
        private System.Windows.Forms.GroupBox GbIcerıkMenu;
        private System.Windows.Forms.Button BtnIcerikSil;
        private System.Windows.Forms.Button btnicerikileri;
        private System.Windows.Forms.Button btnicerikgeri;
        private System.Windows.Forms.Button BtnYaziEkle;
        private System.Windows.Forms.Button BtnCizgiEkle;
        private System.Windows.Forms.GroupBox GbOzellik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnYazikaydet;
        private System.Windows.Forms.TextBox tbYaziy;
        private System.Windows.Forms.TextBox tbYazix;
        private System.Windows.Forms.GroupBox gbCizgiler;
        private System.Windows.Forms.Button btCizgiKaydet;
        private System.Windows.Forms.TextBox tbcizgiy1;
        private System.Windows.Forms.TextBox tbcizgix1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rchYazi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbcizgiy2;
        private System.Windows.Forms.TextBox tbcizgix2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCizgiKalinlik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer tmsayfalar;
        private System.Windows.Forms.Timer tmicerikler;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnFontSec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRenkSecYazi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRenkSecCizgi;
        private System.Windows.Forms.GroupBox gbSayfaOzellikler;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRenkSecSayfa;
        private System.Windows.Forms.Button btnSayfaKaydet;
        private System.Windows.Forms.Label acilisBilgisi;
        private System.Windows.Forms.ToolStripMenuItem eklentilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiKizilOtesi;
        private System.Windows.Forms.Timer umdDinle;
        private System.Windows.Forms.ToolStripMenuItem tsmiKizilDurum;
    }
}

