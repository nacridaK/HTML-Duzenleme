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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_Mesaj = new System.Windows.Forms.Label();
            this.button_VeriÇek = new System.Windows.Forms.Button();
            this.dataGridView_Oyuncular = new System.Windows.Forms.DataGridView();
            this.button_PanoyaKopyala = new System.Windows.Forms.Button();
            this.numericUpDown_Mesaj = new System.Windows.Forms.NumericUpDown();
            this.dataGridView_Grup = new System.Windows.Forms.DataGridView();
            this.groupBox_Oyuncular = new System.Windows.Forms.GroupBox();
            this.bindingNavigator_Oyuncular = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigator_Oyuncular_CountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigator_Oyuncular_DeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Oyuncular_MoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Oyuncular_MovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Oyuncular_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator_Oyuncular_PositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigator_Oyuncular_MoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Oyuncular_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator_Oyuncular_MoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Oyuncular_Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator_Oyuncular_AddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Kontrol = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Yenile = new System.Windows.Forms.ToolStripButton();
            this.groupBox_Grup = new System.Windows.Forms.GroupBox();
            this.bindingNavigator_Grup = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigator_Grup_CountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_Grup = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_Grup = new System.Windows.Forms.ToolStripComboBox();
            this.bindingNavigator_Grup_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator_Grup_MoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Grup_MovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Grup_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator_Grup_PositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigator_Grup_Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator_Grup_MoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Grup_MoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Grup_Separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Güncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Sırala = new System.Windows.Forms.ToolStripButton();
            this.groupBox_Ayarlar = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Konu = new System.Windows.Forms.NumericUpDown();
            this.label_Konu = new System.Windows.Forms.Label();
            this.groupBox_Maç = new System.Windows.Forms.GroupBox();
            this.bindingNavigator_Maçlar = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigator_Maçlar_CountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigator_Maçlar_MoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Maçlar_MovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Maçlar_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator_Maçlar_PositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigator_Maçlar_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator_Maçlar_MoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Maçlar_MoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Maçlar_Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Kaydet = new System.Windows.Forms.ToolStripButton();
            this.dataGridView_Maçlar = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn_Hükmen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_Maçlar = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewComboBoxColumn_Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_OynandıMı = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewComboBoxColumn_EvSahibi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_EvSahibiSkor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_KonukSkor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_Konuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_Grup = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewComboBoxColumn_Sıra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_Oyuncu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_Oynanan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_Galibiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_Beraberlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_Mağlubiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_AtılanGol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_YenenGol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_Averaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_Puan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_Oyuncular = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewComboBoxColumn_Rütbe = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn_KullanıcıAdı = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn_SteamAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_PESAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_TakımAdı = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Oyuncular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mesaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Grup)).BeginInit();
            this.groupBox_Oyuncular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Oyuncular)).BeginInit();
            this.bindingNavigator_Oyuncular.SuspendLayout();
            this.groupBox_Grup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Grup)).BeginInit();
            this.bindingNavigator_Grup.SuspendLayout();
            this.groupBox_Ayarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Konu)).BeginInit();
            this.groupBox_Maç.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Maçlar)).BeginInit();
            this.bindingNavigator_Maçlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Maçlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Maçlar)).BeginInit();
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
            this.button_VeriÇek.Location = new System.Drawing.Point(184, 19);
            this.button_VeriÇek.Name = "button_VeriÇek";
            this.button_VeriÇek.Size = new System.Drawing.Size(93, 23);
            this.button_VeriÇek.TabIndex = 4;
            this.button_VeriÇek.Text = "Veri Çek";
            this.button_VeriÇek.UseVisualStyleBackColor = true;
            this.button_VeriÇek.Click += new System.EventHandler(this.button_VeriÇek_Click);
            // 
            // dataGridView_Oyuncular
            // 
            this.dataGridView_Oyuncular.AllowDrop = true;
            this.dataGridView_Oyuncular.AllowUserToResizeColumns = false;
            this.dataGridView_Oyuncular.AllowUserToResizeRows = false;
            this.dataGridView_Oyuncular.AutoGenerateColumns = false;
            this.dataGridView_Oyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Oyuncular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn_Rütbe,
            this.dataGridViewComboBoxColumn_KullanıcıAdı,
            this.dataGridViewTextBoxColumn_SteamAdı,
            this.dataGridViewTextBoxColumn_PESAdı,
            this.dataGridViewComboBoxColumn_TakımAdı});
            this.dataGridView_Oyuncular.DataSource = this.bindingSource_Oyuncular;
            this.dataGridView_Oyuncular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Oyuncular.Location = new System.Drawing.Point(3, 50);
            this.dataGridView_Oyuncular.MultiSelect = false;
            this.dataGridView_Oyuncular.Name = "dataGridView_Oyuncular";
            this.dataGridView_Oyuncular.RowHeadersVisible = false;
            this.dataGridView_Oyuncular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Oyuncular.Size = new System.Drawing.Size(461, 397);
            this.dataGridView_Oyuncular.TabIndex = 5;
            this.dataGridView_Oyuncular.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_Oyuncular_CellBeginEdit);
            this.dataGridView_Oyuncular.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Oyuncular_CellEndEdit);
            // 
            // button_PanoyaKopyala
            // 
            this.button_PanoyaKopyala.Enabled = false;
            this.button_PanoyaKopyala.Location = new System.Drawing.Point(184, 46);
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
            this.dataGridViewComboBoxColumn_Sıra,
            this.dataGridViewComboBoxColumn_Oyuncu,
            this.dataGridViewComboBoxColumn_Oynanan,
            this.dataGridViewComboBoxColumn_Galibiyet,
            this.dataGridViewComboBoxColumn_Beraberlik,
            this.dataGridViewComboBoxColumn_Mağlubiyet,
            this.dataGridViewComboBoxColumn_AtılanGol,
            this.dataGridViewComboBoxColumn_YenenGol,
            this.dataGridViewComboBoxColumn_Averaj,
            this.dataGridViewComboBoxColumn_Puan});
            this.dataGridView_Grup.DataSource = this.bindingSource_Grup;
            this.dataGridView_Grup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Grup.Location = new System.Drawing.Point(3, 44);
            this.dataGridView_Grup.MultiSelect = false;
            this.dataGridView_Grup.Name = "dataGridView_Grup";
            this.dataGridView_Grup.ReadOnly = true;
            this.dataGridView_Grup.RowHeadersVisible = false;
            this.dataGridView_Grup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Grup.Size = new System.Drawing.Size(481, 145);
            this.dataGridView_Grup.TabIndex = 8;
            // 
            // groupBox_Oyuncular
            // 
            this.groupBox_Oyuncular.Controls.Add(this.bindingNavigator_Oyuncular);
            this.groupBox_Oyuncular.Controls.Add(this.dataGridView_Oyuncular);
            this.groupBox_Oyuncular.Location = new System.Drawing.Point(12, 99);
            this.groupBox_Oyuncular.Name = "groupBox_Oyuncular";
            this.groupBox_Oyuncular.Size = new System.Drawing.Size(467, 450);
            this.groupBox_Oyuncular.TabIndex = 10;
            this.groupBox_Oyuncular.TabStop = false;
            this.groupBox_Oyuncular.Text = "Oyuncu Tablosu";
            // 
            // bindingNavigator_Oyuncular
            // 
            this.bindingNavigator_Oyuncular.AddNewItem = this.bindingNavigator_Oyuncular_AddNewItem;
            this.bindingNavigator_Oyuncular.BindingSource = this.bindingSource_Oyuncular;
            this.bindingNavigator_Oyuncular.CountItem = this.bindingNavigator_Oyuncular_CountItem;
            this.bindingNavigator_Oyuncular.DeleteItem = this.bindingNavigator_Oyuncular_DeleteItem;
            this.bindingNavigator_Oyuncular.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigator_Oyuncular_MoveFirstItem,
            this.bindingNavigator_Oyuncular_MovePreviousItem,
            this.bindingNavigator_Oyuncular_Separator1,
            this.bindingNavigator_Oyuncular_PositionItem,
            this.bindingNavigator_Oyuncular_CountItem,
            this.bindingNavigator_Oyuncular_MoveNextItem,
            this.bindingNavigator_Oyuncular_Separator2,
            this.bindingNavigator_Oyuncular_MoveLastItem,
            this.bindingNavigator_Oyuncular_Separator3,
            this.bindingNavigator_Oyuncular_AddNewItem,
            this.bindingNavigator_Oyuncular_DeleteItem,
            this.toolStripButton_Kontrol,
            this.toolStripButton_Yenile});
            this.bindingNavigator_Oyuncular.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator_Oyuncular.MoveFirstItem = this.bindingNavigator_Oyuncular_MoveFirstItem;
            this.bindingNavigator_Oyuncular.MoveLastItem = this.bindingNavigator_Oyuncular_MoveLastItem;
            this.bindingNavigator_Oyuncular.MoveNextItem = this.bindingNavigator_Oyuncular_MoveNextItem;
            this.bindingNavigator_Oyuncular.MovePreviousItem = this.bindingNavigator_Oyuncular_MovePreviousItem;
            this.bindingNavigator_Oyuncular.Name = "bindingNavigator_Oyuncular";
            this.bindingNavigator_Oyuncular.PositionItem = this.bindingNavigator_Oyuncular_PositionItem;
            this.bindingNavigator_Oyuncular.Size = new System.Drawing.Size(461, 25);
            this.bindingNavigator_Oyuncular.TabIndex = 14;
            this.bindingNavigator_Oyuncular.Text = "bindingNavigator1";
            // 
            // bindingNavigator_Oyuncular_CountItem
            // 
            this.bindingNavigator_Oyuncular_CountItem.Name = "bindingNavigator_Oyuncular_CountItem";
            this.bindingNavigator_Oyuncular_CountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigator_Oyuncular_CountItem.Text = "/ {0}";
            this.bindingNavigator_Oyuncular_CountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // bindingNavigator_Oyuncular_DeleteItem
            // 
            this.bindingNavigator_Oyuncular_DeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Oyuncular_DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Oyuncular_DeleteItem.Image")));
            this.bindingNavigator_Oyuncular_DeleteItem.Name = "bindingNavigator_Oyuncular_DeleteItem";
            this.bindingNavigator_Oyuncular_DeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Oyuncular_DeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Oyuncular_DeleteItem.Text = "Sil";
            // 
            // bindingNavigator_Oyuncular_MoveFirstItem
            // 
            this.bindingNavigator_Oyuncular_MoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Oyuncular_MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Oyuncular_MoveFirstItem.Image")));
            this.bindingNavigator_Oyuncular_MoveFirstItem.Name = "bindingNavigator_Oyuncular_MoveFirstItem";
            this.bindingNavigator_Oyuncular_MoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Oyuncular_MoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Oyuncular_MoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigator_Oyuncular_MovePreviousItem
            // 
            this.bindingNavigator_Oyuncular_MovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Oyuncular_MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Oyuncular_MovePreviousItem.Image")));
            this.bindingNavigator_Oyuncular_MovePreviousItem.Name = "bindingNavigator_Oyuncular_MovePreviousItem";
            this.bindingNavigator_Oyuncular_MovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Oyuncular_MovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Oyuncular_MovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigator_Oyuncular_Separator1
            // 
            this.bindingNavigator_Oyuncular_Separator1.Name = "bindingNavigator_Oyuncular_Separator1";
            this.bindingNavigator_Oyuncular_Separator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator_Oyuncular_PositionItem
            // 
            this.bindingNavigator_Oyuncular_PositionItem.AccessibleName = "Konum";
            this.bindingNavigator_Oyuncular_PositionItem.AutoSize = false;
            this.bindingNavigator_Oyuncular_PositionItem.Name = "bindingNavigator_Oyuncular_PositionItem";
            this.bindingNavigator_Oyuncular_PositionItem.Size = new System.Drawing.Size(20, 23);
            this.bindingNavigator_Oyuncular_PositionItem.Text = "0";
            this.bindingNavigator_Oyuncular_PositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigator_Oyuncular_MoveNextItem
            // 
            this.bindingNavigator_Oyuncular_MoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Oyuncular_MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Oyuncular_MoveNextItem.Image")));
            this.bindingNavigator_Oyuncular_MoveNextItem.Name = "bindingNavigator_Oyuncular_MoveNextItem";
            this.bindingNavigator_Oyuncular_MoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Oyuncular_MoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Oyuncular_MoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigator_Oyuncular_Separator2
            // 
            this.bindingNavigator_Oyuncular_Separator2.Name = "bindingNavigator_Oyuncular_Separator2";
            this.bindingNavigator_Oyuncular_Separator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator_Oyuncular_MoveLastItem
            // 
            this.bindingNavigator_Oyuncular_MoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Oyuncular_MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Oyuncular_MoveLastItem.Image")));
            this.bindingNavigator_Oyuncular_MoveLastItem.Name = "bindingNavigator_Oyuncular_MoveLastItem";
            this.bindingNavigator_Oyuncular_MoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Oyuncular_MoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Oyuncular_MoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigator_Oyuncular_Separator3
            // 
            this.bindingNavigator_Oyuncular_Separator3.Name = "bindingNavigator_Oyuncular_Separator3";
            this.bindingNavigator_Oyuncular_Separator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator_Oyuncular_AddNewItem
            // 
            this.bindingNavigator_Oyuncular_AddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Oyuncular_AddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Oyuncular_AddNewItem.Image")));
            this.bindingNavigator_Oyuncular_AddNewItem.Name = "bindingNavigator_Oyuncular_AddNewItem";
            this.bindingNavigator_Oyuncular_AddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Oyuncular_AddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Oyuncular_AddNewItem.Text = "Yeni ekle";
            this.bindingNavigator_Oyuncular_AddNewItem.Visible = false;
            // 
            // toolStripButton_Kontrol
            // 
            this.toolStripButton_Kontrol.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Kontrol.Image")));
            this.toolStripButton_Kontrol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Kontrol.Name = "toolStripButton_Kontrol";
            this.toolStripButton_Kontrol.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton_Kontrol.Text = "Kontrol Et";
            this.toolStripButton_Kontrol.Click += new System.EventHandler(this.toolStripButton_Kontrol_Click);
            // 
            // toolStripButton_Yenile
            // 
            this.toolStripButton_Yenile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Yenile.Image")));
            this.toolStripButton_Yenile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Yenile.Name = "toolStripButton_Yenile";
            this.toolStripButton_Yenile.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton_Yenile.Text = "Yenile";
            this.toolStripButton_Yenile.Click += new System.EventHandler(this.toolStripButton_Yenile_Click);
            // 
            // groupBox_Grup
            // 
            this.groupBox_Grup.Controls.Add(this.bindingNavigator_Grup);
            this.groupBox_Grup.Controls.Add(this.dataGridView_Grup);
            this.groupBox_Grup.Location = new System.Drawing.Point(485, 12);
            this.groupBox_Grup.Name = "groupBox_Grup";
            this.groupBox_Grup.Size = new System.Drawing.Size(487, 192);
            this.groupBox_Grup.TabIndex = 11;
            this.groupBox_Grup.TabStop = false;
            this.groupBox_Grup.Text = "Puan Tablosu";
            // 
            // bindingNavigator_Grup
            // 
            this.bindingNavigator_Grup.AddNewItem = null;
            this.bindingNavigator_Grup.BindingSource = this.bindingSource_Grup;
            this.bindingNavigator_Grup.CountItem = this.bindingNavigator_Grup_CountItem;
            this.bindingNavigator_Grup.DeleteItem = null;
            this.bindingNavigator_Grup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Grup,
            this.toolStripComboBox_Grup,
            this.bindingNavigator_Grup_Separator1,
            this.bindingNavigator_Grup_MoveFirstItem,
            this.bindingNavigator_Grup_MovePreviousItem,
            this.bindingNavigator_Grup_Separator2,
            this.bindingNavigator_Grup_PositionItem,
            this.bindingNavigator_Grup_CountItem,
            this.bindingNavigator_Grup_Separator3,
            this.bindingNavigator_Grup_MoveNextItem,
            this.bindingNavigator_Grup_MoveLastItem,
            this.bindingNavigator_Grup_Separator4,
            this.toolStripButton_Güncelle,
            this.toolStripButton_Sırala});
            this.bindingNavigator_Grup.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator_Grup.MoveFirstItem = this.bindingNavigator_Grup_MoveFirstItem;
            this.bindingNavigator_Grup.MoveLastItem = this.bindingNavigator_Grup_MoveLastItem;
            this.bindingNavigator_Grup.MoveNextItem = this.bindingNavigator_Grup_MoveNextItem;
            this.bindingNavigator_Grup.MovePreviousItem = this.bindingNavigator_Grup_MovePreviousItem;
            this.bindingNavigator_Grup.Name = "bindingNavigator_Grup";
            this.bindingNavigator_Grup.PositionItem = this.bindingNavigator_Grup_PositionItem;
            this.bindingNavigator_Grup.Size = new System.Drawing.Size(481, 25);
            this.bindingNavigator_Grup.TabIndex = 9;
            this.bindingNavigator_Grup.Text = "bindingNavigator1";
            // 
            // bindingNavigator_Grup_CountItem
            // 
            this.bindingNavigator_Grup_CountItem.Name = "bindingNavigator_Grup_CountItem";
            this.bindingNavigator_Grup_CountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigator_Grup_CountItem.Text = "/ {0}";
            this.bindingNavigator_Grup_CountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // toolStripLabel_Grup
            // 
            this.toolStripLabel_Grup.Enabled = false;
            this.toolStripLabel_Grup.Name = "toolStripLabel_Grup";
            this.toolStripLabel_Grup.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel_Grup.Text = "Grup:";
            // 
            // toolStripComboBox_Grup
            // 
            this.toolStripComboBox_Grup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_Grup.Enabled = false;
            this.toolStripComboBox_Grup.Name = "toolStripComboBox_Grup";
            this.toolStripComboBox_Grup.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBox_Grup.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_Grup_SelectedIndexChanged);
            // 
            // bindingNavigator_Grup_Separator1
            // 
            this.bindingNavigator_Grup_Separator1.Name = "bindingNavigator_Grup_Separator1";
            this.bindingNavigator_Grup_Separator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator_Grup_MoveFirstItem
            // 
            this.bindingNavigator_Grup_MoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Grup_MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Grup_MoveFirstItem.Image")));
            this.bindingNavigator_Grup_MoveFirstItem.Name = "bindingNavigator_Grup_MoveFirstItem";
            this.bindingNavigator_Grup_MoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Grup_MoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Grup_MoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigator_Grup_MovePreviousItem
            // 
            this.bindingNavigator_Grup_MovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Grup_MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Grup_MovePreviousItem.Image")));
            this.bindingNavigator_Grup_MovePreviousItem.Name = "bindingNavigator_Grup_MovePreviousItem";
            this.bindingNavigator_Grup_MovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Grup_MovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Grup_MovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigator_Grup_Separator2
            // 
            this.bindingNavigator_Grup_Separator2.Name = "bindingNavigator_Grup_Separator2";
            this.bindingNavigator_Grup_Separator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator_Grup_PositionItem
            // 
            this.bindingNavigator_Grup_PositionItem.AccessibleName = "Konum";
            this.bindingNavigator_Grup_PositionItem.AutoSize = false;
            this.bindingNavigator_Grup_PositionItem.Name = "bindingNavigator_Grup_PositionItem";
            this.bindingNavigator_Grup_PositionItem.Size = new System.Drawing.Size(20, 23);
            this.bindingNavigator_Grup_PositionItem.Text = "0";
            this.bindingNavigator_Grup_PositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigator_Grup_Separator3
            // 
            this.bindingNavigator_Grup_Separator3.Name = "bindingNavigator_Grup_Separator3";
            this.bindingNavigator_Grup_Separator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator_Grup_MoveNextItem
            // 
            this.bindingNavigator_Grup_MoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Grup_MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Grup_MoveNextItem.Image")));
            this.bindingNavigator_Grup_MoveNextItem.Name = "bindingNavigator_Grup_MoveNextItem";
            this.bindingNavigator_Grup_MoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Grup_MoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Grup_MoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigator_Grup_MoveLastItem
            // 
            this.bindingNavigator_Grup_MoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Grup_MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Grup_MoveLastItem.Image")));
            this.bindingNavigator_Grup_MoveLastItem.Name = "bindingNavigator_Grup_MoveLastItem";
            this.bindingNavigator_Grup_MoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Grup_MoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Grup_MoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigator_Grup_Separator4
            // 
            this.bindingNavigator_Grup_Separator4.Name = "bindingNavigator_Grup_Separator4";
            this.bindingNavigator_Grup_Separator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Güncelle
            // 
            this.toolStripButton_Güncelle.Enabled = false;
            this.toolStripButton_Güncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Güncelle.Image")));
            this.toolStripButton_Güncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Güncelle.Name = "toolStripButton_Güncelle";
            this.toolStripButton_Güncelle.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton_Güncelle.Text = "Güncelle";
            this.toolStripButton_Güncelle.Click += new System.EventHandler(this.toolStripButton_Güncelle_Click);
            // 
            // toolStripButton_Sırala
            // 
            this.toolStripButton_Sırala.Enabled = false;
            this.toolStripButton_Sırala.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Sırala.Image")));
            this.toolStripButton_Sırala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Sırala.Name = "toolStripButton_Sırala";
            this.toolStripButton_Sırala.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton_Sırala.Text = "Sırala";
            this.toolStripButton_Sırala.Click += new System.EventHandler(this.toolStripButton_Sırala_Click);
            // 
            // groupBox_Ayarlar
            // 
            this.groupBox_Ayarlar.Controls.Add(this.numericUpDown_Konu);
            this.groupBox_Ayarlar.Controls.Add(this.label_Konu);
            this.groupBox_Ayarlar.Controls.Add(this.button_VeriÇek);
            this.groupBox_Ayarlar.Controls.Add(this.button_PanoyaKopyala);
            this.groupBox_Ayarlar.Controls.Add(this.label_Mesaj);
            this.groupBox_Ayarlar.Controls.Add(this.numericUpDown_Mesaj);
            this.groupBox_Ayarlar.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Ayarlar.Name = "groupBox_Ayarlar";
            this.groupBox_Ayarlar.Size = new System.Drawing.Size(287, 81);
            this.groupBox_Ayarlar.TabIndex = 12;
            this.groupBox_Ayarlar.TabStop = false;
            this.groupBox_Ayarlar.Text = "Ayarlar";
            // 
            // numericUpDown_Konu
            // 
            this.numericUpDown_Konu.Location = new System.Drawing.Point(97, 46);
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
            // label_Konu
            // 
            this.label_Konu.AutoSize = true;
            this.label_Konu.Location = new System.Drawing.Point(3, 48);
            this.label_Konu.Name = "label_Konu";
            this.label_Konu.Size = new System.Drawing.Size(88, 13);
            this.label_Konu.TabIndex = 11;
            this.label_Konu.Text = "Başvuru Konusu:";
            // 
            // groupBox_Maç
            // 
            this.groupBox_Maç.Controls.Add(this.bindingNavigator_Maçlar);
            this.groupBox_Maç.Controls.Add(this.dataGridView_Maçlar);
            this.groupBox_Maç.Location = new System.Drawing.Point(485, 210);
            this.groupBox_Maç.Name = "groupBox_Maç";
            this.groupBox_Maç.Size = new System.Drawing.Size(487, 339);
            this.groupBox_Maç.TabIndex = 13;
            this.groupBox_Maç.TabStop = false;
            this.groupBox_Maç.Text = "Maç Tablosu";
            // 
            // bindingNavigator_Maçlar
            // 
            this.bindingNavigator_Maçlar.AddNewItem = null;
            this.bindingNavigator_Maçlar.BindingSource = this.bindingSource_Maçlar;
            this.bindingNavigator_Maçlar.CountItem = this.bindingNavigator_Maçlar_CountItem;
            this.bindingNavigator_Maçlar.DeleteItem = null;
            this.bindingNavigator_Maçlar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigator_Maçlar_MoveFirstItem,
            this.bindingNavigator_Maçlar_MovePreviousItem,
            this.bindingNavigator_Maçlar_Separator1,
            this.bindingNavigator_Maçlar_PositionItem,
            this.bindingNavigator_Maçlar_CountItem,
            this.bindingNavigator_Maçlar_Separator2,
            this.bindingNavigator_Maçlar_MoveNextItem,
            this.bindingNavigator_Maçlar_MoveLastItem,
            this.bindingNavigator_Maçlar_Separator3,
            this.toolStripButton_Kaydet});
            this.bindingNavigator_Maçlar.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator_Maçlar.MoveFirstItem = this.bindingNavigator_Maçlar_MoveFirstItem;
            this.bindingNavigator_Maçlar.MoveLastItem = this.bindingNavigator_Maçlar_MoveLastItem;
            this.bindingNavigator_Maçlar.MoveNextItem = this.bindingNavigator_Maçlar_MoveNextItem;
            this.bindingNavigator_Maçlar.MovePreviousItem = this.bindingNavigator_Maçlar_MovePreviousItem;
            this.bindingNavigator_Maçlar.Name = "bindingNavigator_Maçlar";
            this.bindingNavigator_Maçlar.PositionItem = this.bindingNavigator_Maçlar_PositionItem;
            this.bindingNavigator_Maçlar.Size = new System.Drawing.Size(481, 25);
            this.bindingNavigator_Maçlar.TabIndex = 1;
            this.bindingNavigator_Maçlar.Text = "bindingNavigator1";
            // 
            // bindingNavigator_Maçlar_CountItem
            // 
            this.bindingNavigator_Maçlar_CountItem.Name = "bindingNavigator_Maçlar_CountItem";
            this.bindingNavigator_Maçlar_CountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigator_Maçlar_CountItem.Text = "/ {0}";
            this.bindingNavigator_Maçlar_CountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // bindingNavigator_Maçlar_MoveFirstItem
            // 
            this.bindingNavigator_Maçlar_MoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Maçlar_MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Maçlar_MoveFirstItem.Image")));
            this.bindingNavigator_Maçlar_MoveFirstItem.Name = "bindingNavigator_Maçlar_MoveFirstItem";
            this.bindingNavigator_Maçlar_MoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Maçlar_MoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Maçlar_MoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigator_Maçlar_MovePreviousItem
            // 
            this.bindingNavigator_Maçlar_MovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Maçlar_MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Maçlar_MovePreviousItem.Image")));
            this.bindingNavigator_Maçlar_MovePreviousItem.Name = "bindingNavigator_Maçlar_MovePreviousItem";
            this.bindingNavigator_Maçlar_MovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Maçlar_MovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Maçlar_MovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigator_Maçlar_Separator1
            // 
            this.bindingNavigator_Maçlar_Separator1.Name = "bindingNavigator_Maçlar_Separator1";
            this.bindingNavigator_Maçlar_Separator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator_Maçlar_PositionItem
            // 
            this.bindingNavigator_Maçlar_PositionItem.AccessibleName = "Konum";
            this.bindingNavigator_Maçlar_PositionItem.AutoSize = false;
            this.bindingNavigator_Maçlar_PositionItem.Name = "bindingNavigator_Maçlar_PositionItem";
            this.bindingNavigator_Maçlar_PositionItem.Size = new System.Drawing.Size(20, 23);
            this.bindingNavigator_Maçlar_PositionItem.Text = "0";
            this.bindingNavigator_Maçlar_PositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigator_Maçlar_Separator2
            // 
            this.bindingNavigator_Maçlar_Separator2.Name = "bindingNavigator_Maçlar_Separator2";
            this.bindingNavigator_Maçlar_Separator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator_Maçlar_MoveNextItem
            // 
            this.bindingNavigator_Maçlar_MoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Maçlar_MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Maçlar_MoveNextItem.Image")));
            this.bindingNavigator_Maçlar_MoveNextItem.Name = "bindingNavigator_Maçlar_MoveNextItem";
            this.bindingNavigator_Maçlar_MoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Maçlar_MoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Maçlar_MoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigator_Maçlar_MoveLastItem
            // 
            this.bindingNavigator_Maçlar_MoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_Maçlar_MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Maçlar_MoveLastItem.Image")));
            this.bindingNavigator_Maçlar_MoveLastItem.Name = "bindingNavigator_Maçlar_MoveLastItem";
            this.bindingNavigator_Maçlar_MoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Maçlar_MoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_Maçlar_MoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigator_Maçlar_Separator3
            // 
            this.bindingNavigator_Maçlar_Separator3.Name = "bindingNavigator_Maçlar_Separator3";
            this.bindingNavigator_Maçlar_Separator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Kaydet
            // 
            this.toolStripButton_Kaydet.Enabled = false;
            this.toolStripButton_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Kaydet.Image")));
            this.toolStripButton_Kaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Kaydet.Name = "toolStripButton_Kaydet";
            this.toolStripButton_Kaydet.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton_Kaydet.Text = "Kaydet";
            this.toolStripButton_Kaydet.Click += new System.EventHandler(this.toolStripButton_Kaydet_Click);
            // 
            // dataGridView_Maçlar
            // 
            this.dataGridView_Maçlar.AllowUserToAddRows = false;
            this.dataGridView_Maçlar.AllowUserToDeleteRows = false;
            this.dataGridView_Maçlar.AllowUserToResizeColumns = false;
            this.dataGridView_Maçlar.AllowUserToResizeRows = false;
            this.dataGridView_Maçlar.AutoGenerateColumns = false;
            this.dataGridView_Maçlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Maçlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn_Kod,
            this.dataGridViewComboBoxColumn_OynandıMı,
            this.dataGridViewComboBoxColumn_Hükmen,
            this.dataGridViewComboBoxColumn_EvSahibi,
            this.dataGridViewComboBoxColumn_EvSahibiSkor,
            this.dataGridViewComboBoxColumn_KonukSkor,
            this.dataGridViewComboBoxColumn_Konuk});
            this.dataGridView_Maçlar.DataSource = this.bindingSource_Maçlar;
            this.dataGridView_Maçlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Maçlar.Location = new System.Drawing.Point(3, 44);
            this.dataGridView_Maçlar.MultiSelect = false;
            this.dataGridView_Maçlar.Name = "dataGridView_Maçlar";
            this.dataGridView_Maçlar.RowHeadersVisible = false;
            this.dataGridView_Maçlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Maçlar.Size = new System.Drawing.Size(481, 292);
            this.dataGridView_Maçlar.TabIndex = 0;
            // 
            // dataGridViewComboBoxColumn_Hükmen
            // 
            this.dataGridViewComboBoxColumn_Hükmen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewComboBoxColumn_Hükmen.DataPropertyName = "Hükmen";
            this.dataGridViewComboBoxColumn_Hükmen.HeaderText = "H";
            this.dataGridViewComboBoxColumn_Hükmen.Name = "dataGridViewComboBoxColumn_Hükmen";
            this.dataGridViewComboBoxColumn_Hükmen.Visible = false;
            this.dataGridViewComboBoxColumn_Hükmen.Width = 40;
            // 
            // bindingSource_Maçlar
            // 
            this.bindingSource_Maçlar.DataSource = typeof(HTML_Veri_Çekme.Maç);
            // 
            // dataGridViewComboBoxColumn_Kod
            // 
            this.dataGridViewComboBoxColumn_Kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewComboBoxColumn_Kod.DataPropertyName = "Kod";
            this.dataGridViewComboBoxColumn_Kod.HeaderText = "Kod";
            this.dataGridViewComboBoxColumn_Kod.Name = "dataGridViewComboBoxColumn_Kod";
            this.dataGridViewComboBoxColumn_Kod.ReadOnly = true;
            this.dataGridViewComboBoxColumn_Kod.Width = 51;
            // 
            // dataGridViewComboBoxColumn_OynandıMı
            // 
            this.dataGridViewComboBoxColumn_OynandıMı.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewComboBoxColumn_OynandıMı.DataPropertyName = "OynandıMı";
            this.dataGridViewComboBoxColumn_OynandıMı.HeaderText = "OY";
            this.dataGridViewComboBoxColumn_OynandıMı.Name = "dataGridViewComboBoxColumn_OynandıMı";
            this.dataGridViewComboBoxColumn_OynandıMı.ReadOnly = true;
            this.dataGridViewComboBoxColumn_OynandıMı.Width = 28;
            // 
            // dataGridViewComboBoxColumn_EvSahibi
            // 
            this.dataGridViewComboBoxColumn_EvSahibi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewComboBoxColumn_EvSahibi.DataPropertyName = "EvSahibi";
            this.dataGridViewComboBoxColumn_EvSahibi.HeaderText = "Ev Sahibi";
            this.dataGridViewComboBoxColumn_EvSahibi.Name = "dataGridViewComboBoxColumn_EvSahibi";
            this.dataGridViewComboBoxColumn_EvSahibi.ReadOnly = true;
            this.dataGridViewComboBoxColumn_EvSahibi.Width = 77;
            // 
            // dataGridViewComboBoxColumn_EvSahibiSkor
            // 
            this.dataGridViewComboBoxColumn_EvSahibiSkor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewComboBoxColumn_EvSahibiSkor.DataPropertyName = "EvSahibiGol";
            this.dataGridViewComboBoxColumn_EvSahibiSkor.HeaderText = "G";
            this.dataGridViewComboBoxColumn_EvSahibiSkor.Name = "dataGridViewComboBoxColumn_EvSahibiSkor";
            this.dataGridViewComboBoxColumn_EvSahibiSkor.Width = 40;
            // 
            // dataGridViewComboBoxColumn_KonukSkor
            // 
            this.dataGridViewComboBoxColumn_KonukSkor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewComboBoxColumn_KonukSkor.DataPropertyName = "KonukGol";
            this.dataGridViewComboBoxColumn_KonukSkor.HeaderText = "G";
            this.dataGridViewComboBoxColumn_KonukSkor.Name = "dataGridViewComboBoxColumn_KonukSkor";
            this.dataGridViewComboBoxColumn_KonukSkor.Width = 40;
            // 
            // dataGridViewComboBoxColumn_Konuk
            // 
            this.dataGridViewComboBoxColumn_Konuk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewComboBoxColumn_Konuk.DataPropertyName = "Konuk";
            this.dataGridViewComboBoxColumn_Konuk.HeaderText = "Konuk";
            this.dataGridViewComboBoxColumn_Konuk.Name = "dataGridViewComboBoxColumn_Konuk";
            this.dataGridViewComboBoxColumn_Konuk.ReadOnly = true;
            this.dataGridViewComboBoxColumn_Konuk.Width = 63;
            // 
            // bindingSource_Grup
            // 
            this.bindingSource_Grup.DataSource = typeof(HTML_Veri_Çekme.GrupOyuncu);
            // 
            // dataGridViewComboBoxColumn_Sıra
            // 
            this.dataGridViewComboBoxColumn_Sıra.DataPropertyName = "Sıra";
            this.dataGridViewComboBoxColumn_Sıra.HeaderText = "#";
            this.dataGridViewComboBoxColumn_Sıra.MaxInputLength = 1;
            this.dataGridViewComboBoxColumn_Sıra.Name = "dataGridViewComboBoxColumn_Sıra";
            this.dataGridViewComboBoxColumn_Sıra.ReadOnly = true;
            this.dataGridViewComboBoxColumn_Sıra.Width = 39;
            // 
            // dataGridViewComboBoxColumn_Oyuncu
            // 
            this.dataGridViewComboBoxColumn_Oyuncu.DataPropertyName = "OyuncuAdı";
            this.dataGridViewComboBoxColumn_Oyuncu.HeaderText = "Oyuncu Adı";
            this.dataGridViewComboBoxColumn_Oyuncu.Name = "dataGridViewComboBoxColumn_Oyuncu";
            this.dataGridViewComboBoxColumn_Oyuncu.ReadOnly = true;
            this.dataGridViewComboBoxColumn_Oyuncu.Width = 87;
            // 
            // dataGridViewComboBoxColumn_Oynanan
            // 
            this.dataGridViewComboBoxColumn_Oynanan.DataPropertyName = "OynananMaç";
            this.dataGridViewComboBoxColumn_Oynanan.HeaderText = "O";
            this.dataGridViewComboBoxColumn_Oynanan.MaxInputLength = 2;
            this.dataGridViewComboBoxColumn_Oynanan.Name = "dataGridViewComboBoxColumn_Oynanan";
            this.dataGridViewComboBoxColumn_Oynanan.ReadOnly = true;
            this.dataGridViewComboBoxColumn_Oynanan.Width = 40;
            // 
            // dataGridViewComboBoxColumn_Galibiyet
            // 
            this.dataGridViewComboBoxColumn_Galibiyet.DataPropertyName = "GalibiyetSayısı";
            this.dataGridViewComboBoxColumn_Galibiyet.HeaderText = "G";
            this.dataGridViewComboBoxColumn_Galibiyet.MaxInputLength = 2;
            this.dataGridViewComboBoxColumn_Galibiyet.Name = "dataGridViewComboBoxColumn_Galibiyet";
            this.dataGridViewComboBoxColumn_Galibiyet.ReadOnly = true;
            this.dataGridViewComboBoxColumn_Galibiyet.Width = 40;
            // 
            // dataGridViewComboBoxColumn_Beraberlik
            // 
            this.dataGridViewComboBoxColumn_Beraberlik.DataPropertyName = "BeraberlikSayısı";
            this.dataGridViewComboBoxColumn_Beraberlik.HeaderText = "B";
            this.dataGridViewComboBoxColumn_Beraberlik.MaxInputLength = 2;
            this.dataGridViewComboBoxColumn_Beraberlik.Name = "dataGridViewComboBoxColumn_Beraberlik";
            this.dataGridViewComboBoxColumn_Beraberlik.ReadOnly = true;
            this.dataGridViewComboBoxColumn_Beraberlik.Width = 39;
            // 
            // dataGridViewComboBoxColumn_Mağlubiyet
            // 
            this.dataGridViewComboBoxColumn_Mağlubiyet.DataPropertyName = "MağlubiyetSayısı";
            this.dataGridViewComboBoxColumn_Mağlubiyet.HeaderText = "M";
            this.dataGridViewComboBoxColumn_Mağlubiyet.MaxInputLength = 2;
            this.dataGridViewComboBoxColumn_Mağlubiyet.Name = "dataGridViewComboBoxColumn_Mağlubiyet";
            this.dataGridViewComboBoxColumn_Mağlubiyet.ReadOnly = true;
            this.dataGridViewComboBoxColumn_Mağlubiyet.Width = 41;
            // 
            // dataGridViewComboBoxColumn_AtılanGol
            // 
            this.dataGridViewComboBoxColumn_AtılanGol.DataPropertyName = "AtılanGol";
            this.dataGridViewComboBoxColumn_AtılanGol.HeaderText = "A";
            this.dataGridViewComboBoxColumn_AtılanGol.MaxInputLength = 2;
            this.dataGridViewComboBoxColumn_AtılanGol.Name = "dataGridViewComboBoxColumn_AtılanGol";
            this.dataGridViewComboBoxColumn_AtılanGol.ReadOnly = true;
            this.dataGridViewComboBoxColumn_AtılanGol.Width = 39;
            // 
            // dataGridViewComboBoxColumn_YenenGol
            // 
            this.dataGridViewComboBoxColumn_YenenGol.DataPropertyName = "YenenGol";
            this.dataGridViewComboBoxColumn_YenenGol.HeaderText = "Y";
            this.dataGridViewComboBoxColumn_YenenGol.MaxInputLength = 2;
            this.dataGridViewComboBoxColumn_YenenGol.Name = "dataGridViewComboBoxColumn_YenenGol";
            this.dataGridViewComboBoxColumn_YenenGol.ReadOnly = true;
            this.dataGridViewComboBoxColumn_YenenGol.Width = 39;
            // 
            // dataGridViewComboBoxColumn_Averaj
            // 
            this.dataGridViewComboBoxColumn_Averaj.DataPropertyName = "Averaj";
            this.dataGridViewComboBoxColumn_Averaj.HeaderText = "AV";
            this.dataGridViewComboBoxColumn_Averaj.MaxInputLength = 3;
            this.dataGridViewComboBoxColumn_Averaj.Name = "dataGridViewComboBoxColumn_Averaj";
            this.dataGridViewComboBoxColumn_Averaj.ReadOnly = true;
            this.dataGridViewComboBoxColumn_Averaj.Width = 46;
            // 
            // dataGridViewComboBoxColumn_Puan
            // 
            this.dataGridViewComboBoxColumn_Puan.DataPropertyName = "Puan";
            this.dataGridViewComboBoxColumn_Puan.HeaderText = "P";
            this.dataGridViewComboBoxColumn_Puan.MaxInputLength = 2;
            this.dataGridViewComboBoxColumn_Puan.Name = "dataGridViewComboBoxColumn_Puan";
            this.dataGridViewComboBoxColumn_Puan.ReadOnly = true;
            this.dataGridViewComboBoxColumn_Puan.Width = 39;
            // 
            // bindingSource_Oyuncular
            // 
            this.bindingSource_Oyuncular.AllowNew = false;
            this.bindingSource_Oyuncular.DataSource = typeof(HTML_Veri_Çekme.Oyuncu);
            this.bindingSource_Oyuncular.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSource_Oyuncular_ListChanged);
            // 
            // dataGridViewComboBoxColumn_Rütbe
            // 
            this.dataGridViewComboBoxColumn_Rütbe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewComboBoxColumn_Rütbe.DataPropertyName = "Rütbe";
            this.dataGridViewComboBoxColumn_Rütbe.HeaderText = "Rütbe";
            this.dataGridViewComboBoxColumn_Rütbe.Name = "dataGridViewComboBoxColumn_Rütbe";
            this.dataGridViewComboBoxColumn_Rütbe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_Rütbe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn_Rütbe.Width = 61;
            // 
            // dataGridViewComboBoxColumn_KullanıcıAdı
            // 
            this.dataGridViewComboBoxColumn_KullanıcıAdı.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewComboBoxColumn_KullanıcıAdı.DataPropertyName = "KullanıcıAdı";
            this.dataGridViewComboBoxColumn_KullanıcıAdı.HeaderText = "Kullanıcı Adı";
            this.dataGridViewComboBoxColumn_KullanıcıAdı.Name = "dataGridViewComboBoxColumn_KullanıcıAdı";
            this.dataGridViewComboBoxColumn_KullanıcıAdı.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_KullanıcıAdı.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn_KullanıcıAdı.Width = 89;
            // 
            // dataGridViewTextBoxColumn_SteamAdı
            // 
            this.dataGridViewTextBoxColumn_SteamAdı.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn_SteamAdı.DataPropertyName = "SteamAdı";
            this.dataGridViewTextBoxColumn_SteamAdı.HeaderText = "Steam Adı";
            this.dataGridViewTextBoxColumn_SteamAdı.Name = "dataGridViewTextBoxColumn_SteamAdı";
            this.dataGridViewTextBoxColumn_SteamAdı.Width = 80;
            // 
            // dataGridViewTextBoxColumn_PESAdı
            // 
            this.dataGridViewTextBoxColumn_PESAdı.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn_PESAdı.DataPropertyName = "PESAdı";
            this.dataGridViewTextBoxColumn_PESAdı.HeaderText = "PES Adı";
            this.dataGridViewTextBoxColumn_PESAdı.Name = "dataGridViewTextBoxColumn_PESAdı";
            this.dataGridViewTextBoxColumn_PESAdı.Width = 71;
            // 
            // dataGridViewComboBoxColumn_TakımAdı
            // 
            this.dataGridViewComboBoxColumn_TakımAdı.DataPropertyName = "TakımAdı";
            this.dataGridViewComboBoxColumn_TakımAdı.HeaderText = "Takım Adı";
            this.dataGridViewComboBoxColumn_TakımAdı.Name = "dataGridViewComboBoxColumn_TakımAdı";
            this.dataGridViewComboBoxColumn_TakımAdı.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_TakımAdı.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_VeriÇek;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox_Maç);
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
            this.groupBox_Oyuncular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Oyuncular)).EndInit();
            this.bindingNavigator_Oyuncular.ResumeLayout(false);
            this.bindingNavigator_Oyuncular.PerformLayout();
            this.groupBox_Grup.ResumeLayout(false);
            this.groupBox_Grup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Grup)).EndInit();
            this.bindingNavigator_Grup.ResumeLayout(false);
            this.bindingNavigator_Grup.PerformLayout();
            this.groupBox_Ayarlar.ResumeLayout(false);
            this.groupBox_Ayarlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Konu)).EndInit();
            this.groupBox_Maç.ResumeLayout(false);
            this.groupBox_Maç.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Maçlar)).EndInit();
            this.bindingNavigator_Maçlar.ResumeLayout(false);
            this.bindingNavigator_Maçlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Maçlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Maçlar)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox_Oyuncular;
        private System.Windows.Forms.GroupBox groupBox_Grup;
        private System.Windows.Forms.GroupBox groupBox_Ayarlar;
        private System.Windows.Forms.Label label_Konu;
        private System.Windows.Forms.NumericUpDown numericUpDown_Konu;
        private System.Windows.Forms.BindingSource bindingSource_Grup;
        private System.Windows.Forms.GroupBox groupBox_Maç;
        private System.Windows.Forms.DataGridView dataGridView_Maçlar;
        private System.Windows.Forms.BindingNavigator bindingNavigator_Oyuncular;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Oyuncular_AddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigator_Oyuncular_CountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Oyuncular_DeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Oyuncular_MoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Oyuncular_MovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigator_Oyuncular_PositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Oyuncular_MoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Oyuncular_MoveLastItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator_Grup;
        private System.Windows.Forms.ToolStripLabel bindingNavigator_Grup_CountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Grup_MoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Grup_MovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_Grup_Separator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigator_Grup_PositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_Grup_Separator1;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Grup_MoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Grup_MoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_Grup_Separator2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Grup;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Grup;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sırala;
        private System.Windows.Forms.ToolStripButton toolStripButton_Güncelle;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_Grup_Separator4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_Oyuncular_Separator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_Oyuncular_Separator2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_Oyuncular_Separator3;
        private System.Windows.Forms.BindingNavigator bindingNavigator_Maçlar;
        private System.Windows.Forms.ToolStripLabel bindingNavigator_Maçlar_CountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Maçlar_MoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Maçlar_MovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_Maçlar_Separator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigator_Maçlar_PositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_Maçlar_Separator2;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Maçlar_MoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Maçlar_MoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_Maçlar_Separator3;
        private System.Windows.Forms.BindingSource bindingSource_Maçlar;
        private System.Windows.Forms.ToolStripButton toolStripButton_Kaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_Sıra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_Oyuncu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_Oynanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_Galibiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_Beraberlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_Mağlubiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_AtılanGol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_YenenGol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_Averaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_Puan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_Kod;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewComboBoxColumn_OynandıMı;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_Hükmen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_EvSahibi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_EvSahibiSkor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_KonukSkor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn_Konuk;
        private System.Windows.Forms.ToolStripButton toolStripButton_Kontrol;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn_Rütbe;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn_KullanıcıAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_SteamAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_PESAdı;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn_TakımAdı;
        private System.Windows.Forms.ToolStripButton toolStripButton_Yenile;
        public System.Windows.Forms.BindingSource bindingSource_Oyuncular;
    }
}