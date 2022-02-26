namespace SekillerDunyasi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tbSaydamlik = new System.Windows.Forms.TrackBar();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbSekilSec = new System.Windows.Forms.ComboBox();
            this.pbRenk = new System.Windows.Forms.PictureBox();
            this.nudYuk = new System.Windows.Forms.NumericUpDown();
            this.nudGen = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cdirenk = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstSekiller = new System.Windows.Forms.ListBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.pnlCizim = new System.Windows.Forms.Panel();
            this.btnPaneliTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaydamlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRenk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.tbSaydamlik);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.cmbSekilSec);
            this.groupBox1.Controls.Add(this.pbRenk);
            this.groupBox1.Controls.Add(this.nudYuk);
            this.groupBox1.Controls.Add(this.nudGen);
            this.groupBox1.Controls.Add(this.nudY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(328, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Şekil";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(37, 72);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(139, 72);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(95, 23);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbSaydamlik
            // 
            this.tbSaydamlik.AutoSize = false;
            this.tbSaydamlik.Location = new System.Drawing.Point(243, 44);
            this.tbSaydamlik.Maximum = 255;
            this.tbSaydamlik.Name = "tbSaydamlik";
            this.tbSaydamlik.Size = new System.Drawing.Size(95, 21);
            this.tbSaydamlik.TabIndex = 5;
            this.tbSaydamlik.Value = 255;
            this.tbSaydamlik.Scroll += new System.EventHandler(this.tbSaydamlik_Scroll);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(243, 72);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(95, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbSekilSec
            // 
            this.cmbSekilSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSekilSec.FormattingEnabled = true;
            this.cmbSekilSec.Items.AddRange(new object[] {
            "Dikdörtgen",
            "Elips"});
            this.cmbSekilSec.Location = new System.Drawing.Point(217, 20);
            this.cmbSekilSec.Name = "cmbSekilSec";
            this.cmbSekilSec.Size = new System.Drawing.Size(121, 21);
            this.cmbSekilSec.TabIndex = 3;
            // 
            // pbRenk
            // 
            this.pbRenk.BackColor = System.Drawing.Color.Black;
            this.pbRenk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRenk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRenk.Location = new System.Drawing.Point(217, 45);
            this.pbRenk.Name = "pbRenk";
            this.pbRenk.Size = new System.Drawing.Size(20, 20);
            this.pbRenk.TabIndex = 2;
            this.pbRenk.TabStop = false;
            this.pbRenk.Click += new System.EventHandler(this.pbRenk_Click);
            // 
            // nudYuk
            // 
            this.nudYuk.Location = new System.Drawing.Point(142, 45);
            this.nudYuk.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudYuk.Name = "nudYuk";
            this.nudYuk.Size = new System.Drawing.Size(69, 20);
            this.nudYuk.TabIndex = 1;
            this.nudYuk.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudGen
            // 
            this.nudGen.Location = new System.Drawing.Point(37, 46);
            this.nudGen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudGen.Name = "nudGen";
            this.nudGen.Size = new System.Drawing.Size(69, 20);
            this.nudGen.TabIndex = 1;
            this.nudGen.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(142, 20);
            this.nudY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(69, 20);
            this.nudY.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yük : ";
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(37, 20);
            this.nudX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(69, 20);
            this.nudX.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gen : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstSekiller);
            this.groupBox2.Controls.Add(this.btnDown);
            this.groupBox2.Controls.Add(this.btnUp);
            this.groupBox2.Location = new System.Drawing.Point(328, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şekiller";
            // 
            // lstSekiller
            // 
            this.lstSekiller.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstSekiller.FormattingEnabled = true;
            this.lstSekiller.Location = new System.Drawing.Point(3, 16);
            this.lstSekiller.Name = "lstSekiller";
            this.lstSekiller.Size = new System.Drawing.Size(303, 282);
            this.lstSekiller.TabIndex = 0;
            this.lstSekiller.SelectedIndexChanged += new System.EventHandler(this.lstSekiller_SelectedIndexChanged);
            this.lstSekiller.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSekiller_KeyDown);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDown.BackgroundImage = global::SekillerDunyasi.Properties.Resources.down;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Location = new System.Drawing.Point(312, 168);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(33, 37);
            this.btnDown.TabIndex = 3;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.BackgroundImage = global::SekillerDunyasi.Properties.Resources.up;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Location = new System.Drawing.Point(312, 125);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(33, 37);
            this.btnUp.TabIndex = 3;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // pnlCizim
            // 
            this.pnlCizim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCizim.BackColor = System.Drawing.Color.White;
            this.pnlCizim.Location = new System.Drawing.Point(13, 13);
            this.pnlCizim.Name = "pnlCizim";
            this.pnlCizim.Size = new System.Drawing.Size(309, 380);
            this.pnlCizim.TabIndex = 2;
            this.pnlCizim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCizim_Paint);
            this.pnlCizim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCizim_MouseClick);
            // 
            // btnPaneliTemizle
            // 
            this.btnPaneliTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPaneliTemizle.Location = new System.Drawing.Point(13, 399);
            this.btnPaneliTemizle.Name = "btnPaneliTemizle";
            this.btnPaneliTemizle.Size = new System.Drawing.Size(309, 23);
            this.btnPaneliTemizle.TabIndex = 4;
            this.btnPaneliTemizle.Text = "Paneli Temizle";
            this.btnPaneliTemizle.UseVisualStyleBackColor = true;
            this.btnPaneliTemizle.Click += new System.EventHandler(this.btnPaneliTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 437);
            this.Controls.Add(this.btnPaneliTemizle);
            this.Controls.Add(this.pnlCizim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(707, 476);
            this.Name = "Form1";
            this.Text = "Şekiller Dünyası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaydamlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRenk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbSekilSec;
        private System.Windows.Forms.PictureBox pbRenk;
        private System.Windows.Forms.NumericUpDown nudYuk;
        private System.Windows.Forms.NumericUpDown nudGen;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog cdirenk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstSekiller;
        private System.Windows.Forms.Panel pnlCizim;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnPaneliTemizle;
        private System.Windows.Forms.TrackBar tbSaydamlik;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

