﻿namespace KutuphaneTakipUygulaması
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnEmanetIslem = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnOkuyucuEkle = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgEmanetler = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgMevcutKitaplar = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgOkuyucular = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanetler)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutKitaplar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmanetIslem
            // 
            this.btnEmanetIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetIslem.Image = ((System.Drawing.Image)(resources.GetObject("btnEmanetIslem.Image")));
            this.btnEmanetIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmanetIslem.Location = new System.Drawing.Point(26, 25);
            this.btnEmanetIslem.Name = "btnEmanetIslem";
            this.btnEmanetIslem.Size = new System.Drawing.Size(120, 75);
            this.btnEmanetIslem.TabIndex = 0;
            this.btnEmanetIslem.Text = "Emanet İşlemler";
            this.btnEmanetIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmanetIslem.UseVisualStyleBackColor = true;
            this.btnEmanetIslem.Click += new System.EventHandler(this.btnEmanetIslem_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapEkle.Image")));
            this.btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitapEkle.Location = new System.Drawing.Point(147, 25);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(120, 75);
            this.btnKitapEkle.TabIndex = 1;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnOkuyucuEkle
            // 
            this.btnOkuyucuEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnOkuyucuEkle.Image")));
            this.btnOkuyucuEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOkuyucuEkle.Location = new System.Drawing.Point(267, 25);
            this.btnOkuyucuEkle.Name = "btnOkuyucuEkle";
            this.btnOkuyucuEkle.Size = new System.Drawing.Size(120, 75);
            this.btnOkuyucuEkle.TabIndex = 2;
            this.btnOkuyucuEkle.Text = "Okuyucu Ekle";
            this.btnOkuyucuEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOkuyucuEkle.UseVisualStyleBackColor = true;
            this.btnOkuyucuEkle.Click += new System.EventHandler(this.btnOkuyucuEkle_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Image = ((System.Drawing.Image)(resources.GetObject("btnIstatistik.Image")));
            this.btnIstatistik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIstatistik.Location = new System.Drawing.Point(388, 25);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(120, 75);
            this.btnIstatistik.TabIndex = 3;
            this.btnIstatistik.Text = "İstatistik";
            this.btnIstatistik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.Image")));
            this.btnAyarlar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAyarlar.Location = new System.Drawing.Point(509, 25);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(120, 75);
            this.btnAyarlar.TabIndex = 4;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.Location = new System.Drawing.Point(750, 25);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(120, 75);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(26, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 324);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgEmanetler);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Emanet Edilen Kitaplar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgEmanetler
            // 
            this.dgEmanetler.AllowUserToAddRows = false;
            this.dgEmanetler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmanetler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgEmanetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmanetler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEmanetler.Location = new System.Drawing.Point(3, 3);
            this.dgEmanetler.MultiSelect = false;
            this.dgEmanetler.Name = "dgEmanetler";
            this.dgEmanetler.ReadOnly = true;
            this.dgEmanetler.RowHeadersVisible = false;
            this.dgEmanetler.RowHeadersWidth = 51;
            this.dgEmanetler.RowTemplate.Height = 24;
            this.dgEmanetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmanetler.Size = new System.Drawing.Size(830, 289);
            this.dgEmanetler.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgMevcutKitaplar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mevcut Kitaplar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgMevcutKitaplar
            // 
            this.dgMevcutKitaplar.AllowUserToAddRows = false;
            this.dgMevcutKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMevcutKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgMevcutKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMevcutKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMevcutKitaplar.Location = new System.Drawing.Point(3, 3);
            this.dgMevcutKitaplar.MultiSelect = false;
            this.dgMevcutKitaplar.Name = "dgMevcutKitaplar";
            this.dgMevcutKitaplar.ReadOnly = true;
            this.dgMevcutKitaplar.RowHeadersVisible = false;
            this.dgMevcutKitaplar.RowHeadersWidth = 51;
            this.dgMevcutKitaplar.RowTemplate.Height = 24;
            this.dgMevcutKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMevcutKitaplar.Size = new System.Drawing.Size(830, 289);
            this.dgMevcutKitaplar.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgOkuyucular);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(836, 295);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Okuyucular";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgOkuyucular
            // 
            this.dgOkuyucular.AllowUserToAddRows = false;
            this.dgOkuyucular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOkuyucular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgOkuyucular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOkuyucular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOkuyucular.Location = new System.Drawing.Point(3, 3);
            this.dgOkuyucular.MultiSelect = false;
            this.dgOkuyucular.Name = "dgOkuyucular";
            this.dgOkuyucular.ReadOnly = true;
            this.dgOkuyucular.RowHeadersWidth = 51;
            this.dgOkuyucular.RowTemplate.Height = 24;
            this.dgOkuyucular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOkuyucular.Size = new System.Drawing.Size(830, 289);
            this.dgOkuyucular.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnOkuyucuEkle);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.btnEmanetIslem);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menüler";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanetler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutKitaplar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmanetIslem;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnOkuyucuEkle;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgOkuyucular;
        private System.Windows.Forms.DataGridView dgEmanetler;
        private System.Windows.Forms.DataGridView dgMevcutKitaplar;
    }
}