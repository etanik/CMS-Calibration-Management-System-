namespace CMS__Calibration_Management_System_
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalibrasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKalibrasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sertifikaGörüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.falanFilanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ivmeölçerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column3,
            this.Column10,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Cihaz";
            this.Column1.Name = "Column1";
            this.Column1.Width = 58;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Seri No";
            this.Column9.Name = "Column9";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kapasite (mV/g)";
            this.Column3.Name = "Column3";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Son Kalibrasyon";
            this.Column10.Name = "Column10";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Gelecek Kalibrasyon";
            this.Column2.Name = "Column2";
            this.Column2.Width = 129;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.kalibrasyonToolStripMenuItem,
            this.araKontrolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.yeniToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.dosyaToolStripMenuItem.Text = "Cihaz";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "Aç";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ivmeölçerToolStripMenuItem});
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // kalibrasyonToolStripMenuItem
            // 
            this.kalibrasyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKalibrasyonToolStripMenuItem,
            this.sertifikaGörüntülemeToolStripMenuItem});
            this.kalibrasyonToolStripMenuItem.Name = "kalibrasyonToolStripMenuItem";
            this.kalibrasyonToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.kalibrasyonToolStripMenuItem.Text = "Kalibrasyon";
            // 
            // yeniKalibrasyonToolStripMenuItem
            // 
            this.yeniKalibrasyonToolStripMenuItem.Name = "yeniKalibrasyonToolStripMenuItem";
            this.yeniKalibrasyonToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.yeniKalibrasyonToolStripMenuItem.Text = "Yeni Kalibrasyon";
            // 
            // sertifikaGörüntülemeToolStripMenuItem
            // 
            this.sertifikaGörüntülemeToolStripMenuItem.Name = "sertifikaGörüntülemeToolStripMenuItem";
            this.sertifikaGörüntülemeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sertifikaGörüntülemeToolStripMenuItem.Text = "Sertifika Görüntüleme";
            // 
            // araKontrolToolStripMenuItem
            // 
            this.araKontrolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.falanFilanToolStripMenuItem});
            this.araKontrolToolStripMenuItem.Name = "araKontrolToolStripMenuItem";
            this.araKontrolToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.araKontrolToolStripMenuItem.Text = "Ara Kontrol";
            // 
            // falanFilanToolStripMenuItem
            // 
            this.falanFilanToolStripMenuItem.Name = "falanFilanToolStripMenuItem";
            this.falanFilanToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.falanFilanToolStripMenuItem.Text = "Falan Filan";
            // 
            // ivmeölçerToolStripMenuItem
            // 
            this.ivmeölçerToolStripMenuItem.Name = "ivmeölçerToolStripMenuItem";
            this.ivmeölçerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ivmeölçerToolStripMenuItem.Text = "İvmeölçer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 466);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalibrasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKalibrasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sertifikaGörüntülemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araKontrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem falanFilanToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripMenuItem ivmeölçerToolStripMenuItem;
    }
}

