namespace not_kayit_sistemi
{
    partial class frmogretmendetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.msknumara = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsınav3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsınav1 = new System.Windows.Forms.TextBox();
            this.txtsınav2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblkalansayisi = new System.Windows.Forms.Label();
            this.lblgecensayisi = new System.Windows.Forms.Label();
            this.lblortalama = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrnumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrs1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrs2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrs3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbldersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbnotkayıtDataSet = new not_kayit_sistemi.dbnotkayıtDataSet();
            this.tbldersTableAdapter = new not_kayit_sistemi.dbnotkayıtDataSetTableAdapters.tbldersTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbnotkayıtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.msknumara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci ekle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Öğrençi Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(102, 124);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 31);
            this.txtsoyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(102, 87);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 31);
            this.txtad.TabIndex = 2;
            // 
            // msknumara
            // 
            this.msknumara.Location = new System.Drawing.Point(102, 49);
            this.msknumara.Mask = "00000";
            this.msknumara.Name = "msknumara";
            this.msknumara.Size = new System.Drawing.Size(100, 31);
            this.msknumara.TabIndex = 1;
            this.msknumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtsınav3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtsınav1);
            this.groupBox2.Controls.Add(this.txtsınav2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(253, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Notları";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sınav 3 :";
            // 
            // txtsınav3
            // 
            this.txtsınav3.Location = new System.Drawing.Point(102, 124);
            this.txtsınav3.Name = "txtsınav3";
            this.txtsınav3.Size = new System.Drawing.Size(100, 31);
            this.txtsınav3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sınav 2:";
            // 
            // txtsınav1
            // 
            this.txtsınav1.Location = new System.Drawing.Point(102, 50);
            this.txtsınav1.Name = "txtsınav1";
            this.txtsınav1.Size = new System.Drawing.Size(100, 31);
            this.txtsınav1.TabIndex = 2;
            // 
            // txtsınav2
            // 
            this.txtsınav2.Location = new System.Drawing.Point(102, 87);
            this.txtsınav2.Name = "txtsınav2";
            this.txtsınav2.Size = new System.Drawing.Size(100, 31);
            this.txtsınav2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sınav 1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblkalansayisi);
            this.groupBox3.Controls.Add(this.lblgecensayisi);
            this.groupBox3.Controls.Add(this.lblortalama);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(493, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 215);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınav Notları";
            // 
            // lblkalansayisi
            // 
            this.lblkalansayisi.AutoSize = true;
            this.lblkalansayisi.Location = new System.Drawing.Point(141, 131);
            this.lblkalansayisi.Name = "lblkalansayisi";
            this.lblkalansayisi.Size = new System.Drawing.Size(36, 25);
            this.lblkalansayisi.TabIndex = 8;
            this.lblkalansayisi.Text = "00";
            // 
            // lblgecensayisi
            // 
            this.lblgecensayisi.AutoSize = true;
            this.lblgecensayisi.Location = new System.Drawing.Point(141, 91);
            this.lblgecensayisi.Name = "lblgecensayisi";
            this.lblgecensayisi.Size = new System.Drawing.Size(36, 25);
            this.lblgecensayisi.TabIndex = 7;
            this.lblgecensayisi.Text = "00";
            // 
            // lblortalama
            // 
            this.lblortalama.AutoSize = true;
            this.lblortalama.Location = new System.Drawing.Point(141, 50);
            this.lblortalama.Name = "lblortalama";
            this.lblortalama.Size = new System.Drawing.Size(36, 25);
            this.lblortalama.TabIndex = 6;
            this.lblortalama.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Kalan Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Geçen Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ortalama:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(3, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(728, 218);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrnumaraDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.ogrs1DataGridViewTextBoxColumn,
            this.ogrs2DataGridViewTextBoxColumn,
            this.ogrs3DataGridViewTextBoxColumn,
            this.ortalamaDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tbldersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogrid";
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrnumaraDataGridViewTextBoxColumn
            // 
            this.ogrnumaraDataGridViewTextBoxColumn.DataPropertyName = "ogrnumara";
            this.ogrnumaraDataGridViewTextBoxColumn.HeaderText = "ogrnumara";
            this.ogrnumaraDataGridViewTextBoxColumn.Name = "ogrnumaraDataGridViewTextBoxColumn";
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ograd";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ograd";
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            // 
            // ogrs1DataGridViewTextBoxColumn
            // 
            this.ogrs1DataGridViewTextBoxColumn.DataPropertyName = "ogrs1";
            this.ogrs1DataGridViewTextBoxColumn.HeaderText = "ogrs1";
            this.ogrs1DataGridViewTextBoxColumn.Name = "ogrs1DataGridViewTextBoxColumn";
            // 
            // ogrs2DataGridViewTextBoxColumn
            // 
            this.ogrs2DataGridViewTextBoxColumn.DataPropertyName = "ogrs2";
            this.ogrs2DataGridViewTextBoxColumn.HeaderText = "ogrs2";
            this.ogrs2DataGridViewTextBoxColumn.Name = "ogrs2DataGridViewTextBoxColumn";
            // 
            // ogrs3DataGridViewTextBoxColumn
            // 
            this.ogrs3DataGridViewTextBoxColumn.DataPropertyName = "ogrs3";
            this.ogrs3DataGridViewTextBoxColumn.HeaderText = "ogrs3";
            this.ogrs3DataGridViewTextBoxColumn.Name = "ogrs3DataGridViewTextBoxColumn";
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "ortalama";
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "durum";
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // tbldersBindingSource
            // 
            this.tbldersBindingSource.DataMember = "tblders";
            this.tbldersBindingSource.DataSource = this.dbnotkayıtDataSet;
            // 
            // dbnotkayıtDataSet
            // 
            this.dbnotkayıtDataSet.DataSetName = "dbnotkayıtDataSet";
            this.dbnotkayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbldersTableAdapter
            // 
            this.tbldersTableAdapter.ClearBeforeFill = true;
            // 
            // frmogretmendetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 444);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmogretmendetay";
            this.Text = "frmogretmendetay";
            this.Load += new System.EventHandler(this.frmogretmendetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbnotkayıtDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msknumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsınav3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsınav1;
        private System.Windows.Forms.TextBox txtsınav2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblkalansayisi;
        private System.Windows.Forms.Label lblgecensayisi;
        private System.Windows.Forms.Label lblortalama;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbnotkayıtDataSet dbnotkayıtDataSet;
        private System.Windows.Forms.BindingSource tbldersBindingSource;
        private dbnotkayıtDataSetTableAdapters.tbldersTableAdapter tbldersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrs1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrs2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrs3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
    }
}