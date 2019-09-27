namespace CMS__Calibration_Management_System_
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.istek_numarasi = new System.Windows.Forms.Label();
            this.istek = new System.Windows.Forms.TextBox();
            this.cihaz_adi = new System.Windows.Forms.TextBox();
            this.cihaz = new System.Windows.Forms.Label();
            this.marka_ = new System.Windows.Forms.TextBox();
            this.Marka = new System.Windows.Forms.Label();
            this.model_ = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.Label();
            this.serino = new System.Windows.Forms.TextBox();
            this.seri_no = new System.Windows.Forms.Label();
            this.caldate = new System.Windows.Forms.TextBox();
            this.cal_date = new System.Windows.Forms.Label();
            this.cal_comp = new System.Windows.Forms.TextBox();
            this.firma = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.TextBox();
            this.kapasite = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // istek_numarasi
            // 
            this.istek_numarasi.AutoSize = true;
            this.istek_numarasi.Location = new System.Drawing.Point(6, 22);
            this.istek_numarasi.Name = "istek_numarasi";
            this.istek_numarasi.Size = new System.Drawing.Size(77, 13);
            this.istek_numarasi.TabIndex = 0;
            this.istek_numarasi.Text = "İstek Numarası";
            // 
            // istek
            // 
            this.istek.Location = new System.Drawing.Point(109, 19);
            this.istek.Name = "istek";
            this.istek.Size = new System.Drawing.Size(85, 20);
            this.istek.TabIndex = 1;
            this.istek.KeyUp += new System.Windows.Forms.KeyEventHandler(this.İstek_KeyUp);
            // 
            // cihaz_adi
            // 
            this.cihaz_adi.Location = new System.Drawing.Point(109, 45);
            this.cihaz_adi.Name = "cihaz_adi";
            this.cihaz_adi.Size = new System.Drawing.Size(85, 20);
            this.cihaz_adi.TabIndex = 3;
            this.cihaz_adi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Cihaz_adi_KeyUp);
            // 
            // cihaz
            // 
            this.cihaz.AutoSize = true;
            this.cihaz.Location = new System.Drawing.Point(6, 48);
            this.cihaz.Name = "cihaz";
            this.cihaz.Size = new System.Drawing.Size(33, 13);
            this.cihaz.TabIndex = 2;
            this.cihaz.Text = "Cihaz";
            // 
            // marka_
            // 
            this.marka_.Location = new System.Drawing.Point(109, 71);
            this.marka_.Name = "marka_";
            this.marka_.Size = new System.Drawing.Size(85, 20);
            this.marka_.TabIndex = 5;
            this.marka_.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Marka__KeyUp);
            // 
            // Marka
            // 
            this.Marka.AutoSize = true;
            this.Marka.Location = new System.Drawing.Point(6, 74);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(37, 13);
            this.Marka.TabIndex = 4;
            this.Marka.Text = "Marka";
            // 
            // model_
            // 
            this.model_.Location = new System.Drawing.Point(109, 97);
            this.model_.Name = "model_";
            this.model_.Size = new System.Drawing.Size(85, 20);
            this.model_.TabIndex = 7;
            this.model_.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Model__KeyUp);
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(6, 100);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 6;
            this.Model.Text = "Model";
            // 
            // serino
            // 
            this.serino.Location = new System.Drawing.Point(109, 123);
            this.serino.Name = "serino";
            this.serino.Size = new System.Drawing.Size(85, 20);
            this.serino.TabIndex = 15;
            this.serino.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Serino_KeyUp);
            // 
            // seri_no
            // 
            this.seri_no.AutoSize = true;
            this.seri_no.Location = new System.Drawing.Point(6, 126);
            this.seri_no.Name = "seri_no";
            this.seri_no.Size = new System.Drawing.Size(42, 13);
            this.seri_no.TabIndex = 14;
            this.seri_no.Text = "Seri No";
            // 
            // caldate
            // 
            this.caldate.Location = new System.Drawing.Point(109, 149);
            this.caldate.Name = "caldate";
            this.caldate.Size = new System.Drawing.Size(85, 20);
            this.caldate.TabIndex = 13;
            this.caldate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Caldate_KeyUp);
            // 
            // cal_date
            // 
            this.cal_date.AutoSize = true;
            this.cal_date.Location = new System.Drawing.Point(6, 152);
            this.cal_date.Name = "cal_date";
            this.cal_date.Size = new System.Drawing.Size(90, 13);
            this.cal_date.TabIndex = 12;
            this.cal_date.Text = "Kalibrasyon Tarihi";
            // 
            // cal_comp
            // 
            this.cal_comp.Location = new System.Drawing.Point(109, 175);
            this.cal_comp.Name = "cal_comp";
            this.cal_comp.Size = new System.Drawing.Size(85, 20);
            this.cal_comp.TabIndex = 11;
            this.cal_comp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Cal_comp_KeyUp);
            // 
            // firma
            // 
            this.firma.AutoSize = true;
            this.firma.Location = new System.Drawing.Point(6, 178);
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(101, 13);
            this.firma.TabIndex = 10;
            this.firma.Text = "Kalibrasyonu Yapan";
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(109, 201);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(85, 20);
            this.capacity.TabIndex = 9;
            this.capacity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Capacity_KeyUp);
            // 
            // kapasite
            // 
            this.kapasite.AutoSize = true;
            this.kapasite.Location = new System.Drawing.Point(6, 204);
            this.kapasite.Name = "kapasite";
            this.kapasite.Size = new System.Drawing.Size(48, 13);
            this.kapasite.TabIndex = 8;
            this.kapasite.Text = "Kapasite";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.istek_numarasi);
            this.groupBox1.Controls.Add(this.kapasite);
            this.groupBox1.Controls.Add(this.serino);
            this.groupBox1.Controls.Add(this.capacity);
            this.groupBox1.Controls.Add(this.cal_comp);
            this.groupBox1.Controls.Add(this.model_);
            this.groupBox1.Controls.Add(this.firma);
            this.groupBox1.Controls.Add(this.caldate);
            this.groupBox1.Controls.Add(this.cihaz_adi);
            this.groupBox1.Controls.Add(this.Marka);
            this.groupBox1.Controls.Add(this.cal_date);
            this.groupBox1.Controls.Add(this.cihaz);
            this.groupBox1.Controls.Add(this.Model);
            this.groupBox1.Controls.Add(this.istek);
            this.groupBox1.Controls.Add(this.seri_no);
            this.groupBox1.Controls.Add(this.marka_);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 231);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cihaz Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(239, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 323);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Frekans";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Uygulanan İvme";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hassasiyet Katsayısı";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sapma";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Standart Sapma";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Faz Açısı";
            this.Column3.Name = "Column3";
            // 
            // Kaydet
            // 
            this.Kaydet.Enabled = false;
            this.Kaydet.Location = new System.Drawing.Point(239, 342);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(344, 23);
            this.Kaydet.TabIndex = 18;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label istek_numarasi;
        private System.Windows.Forms.TextBox istek;
        private System.Windows.Forms.TextBox cihaz_adi;
        private System.Windows.Forms.Label cihaz;
        private System.Windows.Forms.TextBox marka_;
        private System.Windows.Forms.Label Marka;
        private System.Windows.Forms.TextBox model_;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.TextBox serino;
        private System.Windows.Forms.Label seri_no;
        private System.Windows.Forms.TextBox caldate;
        private System.Windows.Forms.Label cal_date;
        private System.Windows.Forms.TextBox cal_comp;
        private System.Windows.Forms.Label firma;
        private System.Windows.Forms.TextBox capacity;
        private System.Windows.Forms.Label kapasite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}