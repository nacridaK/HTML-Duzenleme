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
            this.label_MesajNumarası = new System.Windows.Forms.Label();
            this.textBox_MesajNumarası = new System.Windows.Forms.TextBox();
            this.button_VeriÇek = new System.Windows.Forms.Button();
            this.dataGridView_Maçlar = new System.Windows.Forms.DataGridView();
            this.button_VeriKaydet = new System.Windows.Forms.Button();
            this.comboBox_Tablo = new System.Windows.Forms.ComboBox();
            this.label_Tablo = new System.Windows.Forms.Label();
            this.oyuncuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Maçlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_MesajNumarası
            // 
            this.label_MesajNumarası.AutoSize = true;
            this.label_MesajNumarası.Location = new System.Drawing.Point(12, 9);
            this.label_MesajNumarası.Name = "label_MesajNumarası";
            this.label_MesajNumarası.Size = new System.Drawing.Size(88, 13);
            this.label_MesajNumarası.TabIndex = 0;
            this.label_MesajNumarası.Text = "Mesaj Numarası :";
            // 
            // textBox_MesajNumarası
            // 
            this.textBox_MesajNumarası.Location = new System.Drawing.Point(106, 6);
            this.textBox_MesajNumarası.Name = "textBox_MesajNumarası";
            this.textBox_MesajNumarası.Size = new System.Drawing.Size(100, 20);
            this.textBox_MesajNumarası.TabIndex = 1;
            this.textBox_MesajNumarası.Text = "2779831";
            // 
            // button_VeriÇek
            // 
            this.button_VeriÇek.Location = new System.Drawing.Point(212, 6);
            this.button_VeriÇek.Name = "button_VeriÇek";
            this.button_VeriÇek.Size = new System.Drawing.Size(75, 23);
            this.button_VeriÇek.TabIndex = 2;
            this.button_VeriÇek.Text = "Veri Çek";
            this.button_VeriÇek.UseVisualStyleBackColor = true;
            this.button_VeriÇek.Click += new System.EventHandler(this.button_VeriÇek_Click);
            // 
            // dataGridView_Maçlar
            // 
            this.dataGridView_Maçlar.AllowUserToAddRows = false;
            this.dataGridView_Maçlar.AllowUserToDeleteRows = false;
            this.dataGridView_Maçlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Maçlar.Location = new System.Drawing.Point(12, 64);
            this.dataGridView_Maçlar.Name = "dataGridView_Maçlar";
            this.dataGridView_Maçlar.Size = new System.Drawing.Size(445, 266);
            this.dataGridView_Maçlar.TabIndex = 5;
            // 
            // button_VeriKaydet
            // 
            this.button_VeriKaydet.Enabled = false;
            this.button_VeriKaydet.Location = new System.Drawing.Point(212, 35);
            this.button_VeriKaydet.Name = "button_VeriKaydet";
            this.button_VeriKaydet.Size = new System.Drawing.Size(75, 23);
            this.button_VeriKaydet.TabIndex = 6;
            this.button_VeriKaydet.Text = "Veri Kaydet";
            this.button_VeriKaydet.UseVisualStyleBackColor = true;
            this.button_VeriKaydet.Click += new System.EventHandler(this.button_VeriKaydet_Click);
            // 
            // comboBox_Tablo
            // 
            this.comboBox_Tablo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Tablo.FormattingEnabled = true;
            this.comboBox_Tablo.Items.AddRange(new object[] {
            "Oyuncular"});
            this.comboBox_Tablo.Location = new System.Drawing.Point(106, 37);
            this.comboBox_Tablo.Name = "comboBox_Tablo";
            this.comboBox_Tablo.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Tablo.TabIndex = 7;
            this.comboBox_Tablo.SelectedIndexChanged += new System.EventHandler(this.comboBox_Tablo_SelectedIndexChanged);
            // 
            // label_Tablo
            // 
            this.label_Tablo.AutoSize = true;
            this.label_Tablo.Location = new System.Drawing.Point(60, 40);
            this.label_Tablo.Name = "label_Tablo";
            this.label_Tablo.Size = new System.Drawing.Size(40, 13);
            this.label_Tablo.TabIndex = 8;
            this.label_Tablo.Text = "Tablo :";
            // 
            // oyuncuBindingSource
            // 
            this.oyuncuBindingSource.DataSource = typeof(HTML_Veri_Çekme.Oyuncu);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_VeriÇek;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 366);
            this.Controls.Add(this.label_Tablo);
            this.Controls.Add(this.comboBox_Tablo);
            this.Controls.Add(this.button_VeriKaydet);
            this.Controls.Add(this.dataGridView_Maçlar);
            this.Controls.Add(this.button_VeriÇek);
            this.Controls.Add(this.textBox_MesajNumarası);
            this.Controls.Add(this.label_MesajNumarası);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HTML Veri Çekme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Maçlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MesajNumarası;
        private System.Windows.Forms.TextBox textBox_MesajNumarası;
        private System.Windows.Forms.Button button_VeriÇek;
        private System.Windows.Forms.DataGridView dataGridView_Maçlar;
        private System.Windows.Forms.Button button_VeriKaydet;
        private System.Windows.Forms.BindingSource oyuncuBindingSource;
        private System.Windows.Forms.ComboBox comboBox_Tablo;
        private System.Windows.Forms.Label label_Tablo;
    }
}

