namespace Editor_projesi
{
    partial class kontroller
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKontrolSag = new System.Windows.Forms.Button();
            this.btnKontrolSol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGelenDeger = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKontrolAc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKontrolKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSol = new System.Windows.Forms.Label();
            this.lblSag = new System.Windows.Forms.Label();
            this.btnKontrolKaydet = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "lütfen arduino  kumanda kontrollerini yapın";
            // 
            // btnKontrolSag
            // 
            this.btnKontrolSag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrolSag.ForeColor = System.Drawing.Color.Black;
            this.btnKontrolSag.Image = global::Editor_projesi.Properties.Resources.ok_isareti1;
            this.btnKontrolSag.Location = new System.Drawing.Point(209, 93);
            this.btnKontrolSag.Name = "btnKontrolSag";
            this.btnKontrolSag.Size = new System.Drawing.Size(75, 39);
            this.btnKontrolSag.TabIndex = 2;
            this.btnKontrolSag.Text = "SAĞ";
            this.btnKontrolSag.UseVisualStyleBackColor = true;
            this.btnKontrolSag.Click += new System.EventHandler(this.btnKontrolSag_Click);
            // 
            // btnKontrolSol
            // 
            this.btnKontrolSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrolSol.ForeColor = System.Drawing.Color.Black;
            this.btnKontrolSol.Image = global::Editor_projesi.Properties.Resources.sol_ok;
            this.btnKontrolSol.Location = new System.Drawing.Point(50, 93);
            this.btnKontrolSol.Name = "btnKontrolSol";
            this.btnKontrolSol.Size = new System.Drawing.Size(72, 39);
            this.btnKontrolSol.TabIndex = 1;
            this.btnKontrolSol.Text = "SOL";
            this.btnKontrolSol.UseVisualStyleBackColor = true;
            this.btnKontrolSol.Click += new System.EventHandler(this.btnKontrolSol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ayarlamak istediğiniz tuşa basın";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbGelenDeger
            // 
            this.lbGelenDeger.AutoSize = true;
            this.lbGelenDeger.Location = new System.Drawing.Point(13, 224);
            this.lbGelenDeger.Name = "lbGelenDeger";
            this.lbGelenDeger.Size = new System.Drawing.Size(89, 13);
            this.lbGelenDeger.TabIndex = 4;
            this.lbGelenDeger.Text = "Okunan Değer = ";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(366, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // girişToolStripMenuItem
            // 
            this.girişToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKontrolAc,
            this.tsmiKontrolKaydet,
            this.tsmiKapat});
            this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
            this.girişToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.girişToolStripMenuItem.Text = "Giriş";
            // 
            // tsmiKontrolAc
            // 
            this.tsmiKontrolAc.Name = "tsmiKontrolAc";
            this.tsmiKontrolAc.Size = new System.Drawing.Size(109, 22);
            this.tsmiKontrolAc.Text = "Aç";
            this.tsmiKontrolAc.Click += new System.EventHandler(this.tsmiKontrolAc_Click);
            // 
            // tsmiKontrolKaydet
            // 
            this.tsmiKontrolKaydet.Name = "tsmiKontrolKaydet";
            this.tsmiKontrolKaydet.Size = new System.Drawing.Size(109, 22);
            this.tsmiKontrolKaydet.Text = "kaydet";
            this.tsmiKontrolKaydet.Click += new System.EventHandler(this.tsmiKontrolKaydet_Click);
            // 
            // tsmiKapat
            // 
            this.tsmiKapat.Name = "tsmiKapat";
            this.tsmiKapat.Size = new System.Drawing.Size(109, 22);
            this.tsmiKapat.Text = "kapat";
            this.tsmiKapat.Click += new System.EventHandler(this.tsmiKapat_Click);
            // 
            // lblSol
            // 
            this.lblSol.AutoSize = true;
            this.lblSol.Location = new System.Drawing.Point(64, 135);
            this.lblSol.Name = "lblSol";
            this.lblSol.Size = new System.Drawing.Size(53, 13);
            this.lblSol.TabIndex = 6;
            this.lblSol.Text = "atamayok";
            // 
            // lblSag
            // 
            this.lblSag.AutoSize = true;
            this.lblSag.Location = new System.Drawing.Point(219, 135);
            this.lblSag.Name = "lblSag";
            this.lblSag.Size = new System.Drawing.Size(53, 13);
            this.lblSag.TabIndex = 7;
            this.lblSag.Text = "atamayok";
            // 
            // btnKontrolKaydet
            // 
            this.btnKontrolKaydet.Location = new System.Drawing.Point(130, 173);
            this.btnKontrolKaydet.Name = "btnKontrolKaydet";
            this.btnKontrolKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKontrolKaydet.TabIndex = 8;
            this.btnKontrolKaydet.Text = "Kaydet";
            this.btnKontrolKaydet.UseVisualStyleBackColor = true;
            this.btnKontrolKaydet.Click += new System.EventHandler(this.btnKontrolKaydet_Click);
            // 
            // kontroller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 246);
            this.ControlBox = false;
            this.Controls.Add(this.btnKontrolKaydet);
            this.Controls.Add(this.lblSag);
            this.Controls.Add(this.lblSol);
            this.Controls.Add(this.lbGelenDeger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKontrolSag);
            this.Controls.Add(this.btnKontrolSol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "kontroller";
            this.Text = "kontroller";
            this.Load += new System.EventHandler(this.kontroller_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKontrolSol;
        private System.Windows.Forms.Button btnKontrolSag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGelenDeger;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiKontrolAc;
        private System.Windows.Forms.ToolStripMenuItem tsmiKontrolKaydet;
        private System.Windows.Forms.Label lblSol;
        private System.Windows.Forms.Label lblSag;
        private System.Windows.Forms.Button btnKontrolKaydet;
        private System.Windows.Forms.ToolStripMenuItem tsmiKapat;
    }
}