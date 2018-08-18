namespace HTML_Veri_Çekme
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
            this.components = new System.ComponentModel.Container();
            this.label_Mesaj = new System.Windows.Forms.Label();
            this.button_VeriÇek = new System.Windows.Forms.Button();
            this.dataGridView_Oyuncular = new System.Windows.Forms.DataGridView();
            this.button_PanoyaKopyala = new System.Windows.Forms.Button();
            this.numericUpDown_Mesaj = new System.Windows.Forms.NumericUpDown();
            this.dataGridView_Grup = new System.Windows.Forms.DataGridView();
            this.comboBox_Grup = new System.Windows.Forms.ComboBox();
            this.groupBox_Oyuncular = new System.Windows.Forms.GroupBox();
            this.groupBox_Grup = new System.Windows.Forms.GroupBox();
            this.groupBox_Ayarlar = new System.Windows.Forms.GroupBox();
            this.button_OyuncuGüncelle = new System.Windows.Forms.Button();
            this.numericUpDown_Konu = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sıraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyuncuAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oynananMaçDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.galibiyetSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beraberlikSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mağlubiyetSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atılanGolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yenenGolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_Grup = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_Oyuncular = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Oyuncular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mesaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Grup)).BeginInit();
            this.groupBox_Oyuncular.SuspendLayout();
            this.groupBox_Grup.SuspendLayout();
            this.groupBox_Ayarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Konu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Grup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Oyuncular)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Mesaj
            // 
            this.label_Mesaj.AutoSize = true;
            this.label_Mesaj.Location = new System.Drawing.Point(8, 22);
            this.label_Mesaj.Name = "label_Mesaj";
            this.label_Mesaj.Size = new System.Drawing.Size(83, 13);
            this.label_Mesaj.TabIndex = 0;
            this.label_Mesaj.Text = "Turnuva Mesajı:";
            // 
            // button_VeriÇek
            // 
            this.button_VeriÇek.Location = new System.Drawing.Point(187, 44);
            this.button_VeriÇek.Name = "button_VeriÇek";
            this.button_VeriÇek.Size = new System.Drawing.Size(73, 23);
            this.button_VeriÇek.TabIndex = 4;
            this.button_VeriÇek.Text = "Veri Çek";
            this.button_VeriÇek.UseVisualStyleBackColor = true;
            this.button_VeriÇek.Click += new System.EventHandler(this.button_VeriÇek_Click);
            // 
            // dataGridView_Oyuncular
            // 
            this.dataGridView_Oyuncular.AllowUserToResizeColumns = false;
            this.dataGridView_Oyuncular.AllowUserToResizeRows = false;
            this.dataGridView_Oyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Oyuncular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Oyuncular.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_Oyuncular.MultiSelect = false;
            this.dataGridView_Oyuncular.Name = "dataGridView_Oyuncular";
            this.dataGridView_Oyuncular.RowHeadersVisible = false;
            this.dataGridView_Oyuncular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Oyuncular.Size = new System.Drawing.Size(466, 425);
            this.dataGridView_Oyuncular.TabIndex = 5;
            this.dataGridView_Oyuncular.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_Oyuncular_CellBeginEdit);
            this.dataGridView_Oyuncular.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Oyuncular_CellEndEdit);
            this.dataGridView_Oyuncular.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_Oyuncular_DefaultValuesNeeded);
            // 
            // button_PanoyaKopyala
            // 
            this.button_PanoyaKopyala.Enabled = false;
            this.button_PanoyaKopyala.Location = new System.Drawing.Point(266, 44);
            this.button_PanoyaKopyala.Name = "button_PanoyaKopyala";
            this.button_PanoyaKopyala.Size = new System.Drawing.Size(93, 23);
            this.button_PanoyaKopyala.TabIndex = 6;
            this.button_PanoyaKopyala.Text = "Panoya Kopyala";
            this.button_PanoyaKopyala.UseVisualStyleBackColor = true;
            this.button_PanoyaKopyala.Click += new System.EventHandler(this.button_PanoyaKopyala_Click);
            // 
            // numericUpDown_Mesaj
            // 
            this.numericUpDown_Mesaj.Location = new System.Drawing.Point(97, 20);
            this.numericUpDown_Mesaj.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.numericUpDown_Mesaj.Name = "numericUpDown_Mesaj";
            this.numericUpDown_Mesaj.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_Mesaj.TabIndex = 7;
            this.numericUpDown_Mesaj.Value = new decimal(new int[] {
            2779831,
            0,
            0,
            0});
            // 
            // dataGridView_Grup
            // 
            this.dataGridView_Grup.AllowUserToAddRows = false;
            this.dataGridView_Grup.AllowUserToDeleteRows = false;
            this.dataGridView_Grup.AllowUserToResizeColumns = false;
            this.dataGridView_Grup.AllowUserToResizeRows = false;
            this.dataGridView_Grup.AutoGenerateColumns = false;
            this.dataGridView_Grup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_Grup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Grup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sıraDataGridViewTextBoxColumn,
            this.oyuncuAdıDataGridViewTextBoxColumn,
            this.oynananMaçDataGridViewTextBoxColumn,
            this.galibiyetSayısıDataGridViewTextBoxColumn,
            this.beraberlikSayısıDataGridViewTextBoxColumn,
            this.mağlubiyetSayısıDataGridViewTextBoxColumn,
            this.atılanGolDataGridViewTextBoxColumn,
            this.yenenGolDataGridViewTextBoxColumn,
            this.averajDataGridViewTextBoxColumn,
            this.puanDataGridViewTextBoxColumn});
            this.dataGridView_Grup.DataSource = this.bindingSource_Grup;
            this.dataGridView_Grup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Grup.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_Grup.MultiSelect = false;
            this.dataGridView_Grup.Name = "dataGridView_Grup";
            this.dataGridView_Grup.ReadOnly = true;
            this.dataGridView_Grup.RowHeadersVisible = false;
            this.dataGridView_Grup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Grup.Size = new System.Drawing.Size(452, 133);
            this.dataGridView_Grup.TabIndex = 8;
            // 
            // comboBox_Grup
            // 
            this.comboBox_Grup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Grup.Enabled = false;
            this.comboBox_Grup.FormattingEnabled = true;
            this.comboBox_Grup.Location = new System.Drawing.Point(97, 46);
            this.comboBox_Grup.Name = "comboBox_Grup";
            this.comboBox_Grup.Size = new System.Drawing.Size(81, 21);
            this.comboBox_Grup.TabIndex = 9;
            this.comboBox_Grup.SelectedIndexChanged += new System.EventHandler(this.comboBox_Grup_SelectedIndexChanged);
            // 
            // groupBox_Oyuncular
            // 
            this.groupBox_Oyuncular.Controls.Add(this.dataGridView_Oyuncular);
            this.groupBox_Oyuncular.Location = new System.Drawing.Point(12, 99);
            this.groupBox_Oyuncular.Name = "groupBox_Oyuncular";
            this.groupBox_Oyuncular.Size = new System.Drawing.Size(472, 444);
            this.groupBox_Oyuncular.TabIndex = 10;
            this.groupBox_Oyuncular.TabStop = false;
            this.groupBox_Oyuncular.Text = "Oyuncu Tablosu";
            // 
            // groupBox_Grup
            // 
            this.groupBox_Grup.Controls.Add(this.dataGridView_Grup);
            this.groupBox_Grup.Location = new System.Drawing.Point(490, 12);
            this.groupBox_Grup.Name = "groupBox_Grup";
            this.groupBox_Grup.Size = new System.Drawing.Size(458, 152);
            this.groupBox_Grup.TabIndex = 11;
            this.groupBox_Grup.TabStop = false;
            this.groupBox_Grup.Text = "Puan Tablosu";
            // 
            // groupBox_Ayarlar
            // 
            this.groupBox_Ayarlar.Controls.Add(this.button_OyuncuGüncelle);
            this.groupBox_Ayarlar.Controls.Add(this.numericUpDown_Konu);
            this.groupBox_Ayarlar.Controls.Add(this.label2);
            this.groupBox_Ayarlar.Controls.Add(this.label1);
            this.groupBox_Ayarlar.Controls.Add(this.button_VeriÇek);
            this.groupBox_Ayarlar.Controls.Add(this.button_PanoyaKopyala);
            this.groupBox_Ayarlar.Controls.Add(this.label_Mesaj);
            this.groupBox_Ayarlar.Controls.Add(this.numericUpDown_Mesaj);
            this.groupBox_Ayarlar.Controls.Add(this.comboBox_Grup);
            this.groupBox_Ayarlar.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Ayarlar.Name = "groupBox_Ayarlar";
            this.groupBox_Ayarlar.Size = new System.Drawing.Size(449, 81);
            this.groupBox_Ayarlar.TabIndex = 12;
            this.groupBox_Ayarlar.TabStop = false;
            this.groupBox_Ayarlar.Text = "Ayarlar";
            // 
            // button_OyuncuGüncelle
            // 
            this.button_OyuncuGüncelle.Enabled = false;
            this.button_OyuncuGüncelle.Location = new System.Drawing.Point(365, 13);
            this.button_OyuncuGüncelle.Name = "button_OyuncuGüncelle";
            this.button_OyuncuGüncelle.Size = new System.Drawing.Size(75, 62);
            this.button_OyuncuGüncelle.TabIndex = 13;
            this.button_OyuncuGüncelle.Text = "Grup Oyuncu Güncelle";
            this.button_OyuncuGüncelle.UseVisualStyleBackColor = true;
            this.button_OyuncuGüncelle.Click += new System.EventHandler(this.button_OyuncuGüncelle_Click);
            // 
            // numericUpDown_Konu
            // 
            this.numericUpDown_Konu.Location = new System.Drawing.Point(278, 20);
            this.numericUpDown_Konu.Maximum = new decimal(new int[] {
            220000,
            0,
            0,
            0});
            this.numericUpDown_Konu.Name = "numericUpDown_Konu";
            this.numericUpDown_Konu.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_Konu.TabIndex = 12;
            this.numericUpDown_Konu.Value = new decimal(new int[] {
            205212,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Başvuru Konusu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seçilen Grup:";
            // 
            // sıraDataGridViewTextBoxColumn
            // 
            this.sıraDataGridViewTextBoxColumn.DataPropertyName = "Sıra";
            this.sıraDataGridViewTextBoxColumn.HeaderText = "#";
            this.sıraDataGridViewTextBoxColumn.MaxInputLength = 1;
            this.sıraDataGridViewTextBoxColumn.Name = "sıraDataGridViewTextBoxColumn";
            this.sıraDataGridViewTextBoxColumn.ReadOnly = true;
            this.sıraDataGridViewTextBoxColumn.Width = 39;
            // 
            // oyuncuAdıDataGridViewTextBoxColumn
            // 
            this.oyuncuAdıDataGridViewTextBoxColumn.DataPropertyName = "OyuncuAdı";
            this.oyuncuAdıDataGridViewTextBoxColumn.HeaderText = "Oyuncu Adı";
            this.oyuncuAdıDataGridViewTextBoxColumn.Name = "oyuncuAdıDataGridViewTextBoxColumn";
            this.oyuncuAdıDataGridViewTextBoxColumn.ReadOnly = true;
            this.oyuncuAdıDataGridViewTextBoxColumn.Width = 87;
            // 
            // oynananMaçDataGridViewTextBoxColumn
            // 
            this.oynananMaçDataGridViewTextBoxColumn.DataPropertyName = "OynananMaç";
            this.oynananMaçDataGridViewTextBoxColumn.HeaderText = "O";
            this.oynananMaçDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.oynananMaçDataGridViewTextBoxColumn.Name = "oynananMaçDataGridViewTextBoxColumn";
            this.oynananMaçDataGridViewTextBoxColumn.ReadOnly = true;
            this.oynananMaçDataGridViewTextBoxColumn.Width = 40;
            // 
            // galibiyetSayısıDataGridViewTextBoxColumn
            // 
            this.galibiyetSayısıDataGridViewTextBoxColumn.DataPropertyName = "GalibiyetSayısı";
            this.galibiyetSayısıDataGridViewTextBoxColumn.HeaderText = "G";
            this.galibiyetSayısıDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.galibiyetSayısıDataGridViewTextBoxColumn.Name = "galibiyetSayısıDataGridViewTextBoxColumn";
            this.galibiyetSayısıDataGridViewTextBoxColumn.ReadOnly = true;
            this.galibiyetSayısıDataGridViewTextBoxColumn.Width = 40;
            // 
            // beraberlikSayısıDataGridViewTextBoxColumn
            // 
            this.beraberlikSayısıDataGridViewTextBoxColumn.DataPropertyName = "BeraberlikSayısı";
            this.beraberlikSayısıDataGridViewTextBoxColumn.HeaderText = "B";
            this.beraberlikSayısıDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.beraberlikSayısıDataGridViewTextBoxColumn.Name = "beraberlikSayısıDataGridViewTextBoxColumn";
            this.beraberlikSayısıDataGridViewTextBoxColumn.ReadOnly = true;
            this.beraberlikSayısıDataGridViewTextBoxColumn.Width = 39;
            // 
            // mağlubiyetSayısıDataGridViewTextBoxColumn
            // 
            this.mağlubiyetSayısıDataGridViewTextBoxColumn.DataPropertyName = "MağlubiyetSayısı";
            this.mağlubiyetSayısıDataGridViewTextBoxColumn.HeaderText = "M";
            this.mağlubiyetSayısıDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.mağlubiyetSayısıDataGridViewTextBoxColumn.Name = "mağlubiyetSayısıDataGridViewTextBoxColumn";
            this.mağlubiyetSayısıDataGridViewTextBoxColumn.ReadOnly = true;
            this.mağlubiyetSayısıDataGridViewTextBoxColumn.Width = 41;
            // 
            // atılanGolDataGridViewTextBoxColumn
            // 
            this.atılanGolDataGridViewTextBoxColumn.DataPropertyName = "AtılanGol";
            this.atılanGolDataGridViewTextBoxColumn.HeaderText = "A";
            this.atılanGolDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.atılanGolDataGridViewTextBoxColumn.Name = "atılanGolDataGridViewTextBoxColumn";
            this.atılanGolDataGridViewTextBoxColumn.ReadOnly = true;
            this.atılanGolDataGridViewTextBoxColumn.Width = 39;
            // 
            // yenenGolDataGridViewTextBoxColumn
            // 
            this.yenenGolDataGridViewTextBoxColumn.DataPropertyName = "YenenGol";
            this.yenenGolDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yenenGolDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.yenenGolDataGridViewTextBoxColumn.Name = "yenenGolDataGridViewTextBoxColumn";
            this.yenenGolDataGridViewTextBoxColumn.ReadOnly = true;
            this.yenenGolDataGridViewTextBoxColumn.Width = 39;
            // 
            // averajDataGridViewTextBoxColumn
            // 
            this.averajDataGridViewTextBoxColumn.DataPropertyName = "Averaj";
            this.averajDataGridViewTextBoxColumn.HeaderText = "AV";
            this.averajDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.averajDataGridViewTextBoxColumn.Name = "averajDataGridViewTextBoxColumn";
            this.averajDataGridViewTextBoxColumn.ReadOnly = true;
            this.averajDataGridViewTextBoxColumn.Width = 46;
            // 
            // puanDataGridViewTextBoxColumn
            // 
            this.puanDataGridViewTextBoxColumn.DataPropertyName = "Puan";
            this.puanDataGridViewTextBoxColumn.HeaderText = "P";
            this.puanDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.puanDataGridViewTextBoxColumn.Name = "puanDataGridViewTextBoxColumn";
            this.puanDataGridViewTextBoxColumn.ReadOnly = true;
            this.puanDataGridViewTextBoxColumn.Width = 39;
            // 
            // bindingSource_Grup
            // 
            this.bindingSource_Grup.DataSource = typeof(HTML_Veri_Çekme.GrupOyuncu);
            // 
            // bindingSource_Oyuncular
            // 
            this.bindingSource_Oyuncular.DataSource = typeof(HTML_Veri_Çekme.Oyuncu);
            this.bindingSource_Oyuncular.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSource_Oyuncular_ListChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_VeriÇek;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 555);
            this.Controls.Add(this.groupBox_Ayarlar);
            this.Controls.Add(this.groupBox_Grup);
            this.Controls.Add(this.groupBox_Oyuncular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSC - \"FairPlay\" Online Turnuvası HTML Düzenleme Yazılımı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Oyuncular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mesaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Grup)).EndInit();
            this.groupBox_Oyuncular.ResumeLayout(false);
            this.groupBox_Grup.ResumeLayout(false);
            this.groupBox_Ayarlar.ResumeLayout(false);
            this.groupBox_Ayarlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Konu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Grup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Oyuncular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Mesaj;
        private System.Windows.Forms.Button button_VeriÇek;
        private System.Windows.Forms.DataGridView dataGridView_Oyuncular;
        private System.Windows.Forms.Button button_PanoyaKopyala;
        private System.Windows.Forms.NumericUpDown numericUpDown_Mesaj;
        private System.Windows.Forms.DataGridView dataGridView_Grup;
        private System.Windows.Forms.ComboBox comboBox_Grup;
        private System.Windows.Forms.GroupBox groupBox_Oyuncular;
        private System.Windows.Forms.GroupBox groupBox_Grup;
        private System.Windows.Forms.GroupBox groupBox_Ayarlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Konu;
        private System.Windows.Forms.Button button_OyuncuGüncelle;
        private System.Windows.Forms.BindingSource bindingSource_Oyuncular;
        private System.Windows.Forms.BindingSource bindingSource_Grup;
        private System.Windows.Forms.DataGridViewTextBoxColumn sıraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyuncuAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oynananMaçDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn galibiyetSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beraberlikSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mağlubiyetSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atılanGolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yenenGolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puanDataGridViewTextBoxColumn;
    }
}