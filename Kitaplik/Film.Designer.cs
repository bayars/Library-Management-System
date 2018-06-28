namespace Kitaplik
{
    partial class Film
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
            System.Windows.Forms.Label filmin_AdiLabel;
            System.Windows.Forms.Label yonetmeniLabel;
            System.Windows.Forms.Label iMDBLabel;
            System.Windows.Forms.Label turLabel;
            System.Windows.Forms.Label vizyon_TarihiLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Film));
            this.button1 = new System.Windows.Forms.Button();
            this.deneme1DataSet = new Kitaplik.Deneme1DataSet();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new Kitaplik.Deneme1DataSetTableAdapters.FilmTableAdapter();
            this.tableAdapterManager = new Kitaplik.Deneme1DataSetTableAdapters.TableAdapterManager();
            this.filmBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.filmBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.filmDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmin_AdiTextBox = new System.Windows.Forms.TextBox();
            this.yonetmeniTextBox = new System.Windows.Forms.TextBox();
            this.iMDBTextBox = new System.Windows.Forms.TextBox();
            this.turTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vizyon_TarihiTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            filmin_AdiLabel = new System.Windows.Forms.Label();
            yonetmeniLabel = new System.Windows.Forms.Label();
            iMDBLabel = new System.Windows.Forms.Label();
            turLabel = new System.Windows.Forms.Label();
            vizyon_TarihiLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingNavigator)).BeginInit();
            this.filmBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filmin_AdiLabel
            // 
            filmin_AdiLabel.AutoSize = true;
            filmin_AdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            filmin_AdiLabel.Location = new System.Drawing.Point(116, 159);
            filmin_AdiLabel.Name = "filmin_AdiLabel";
            filmin_AdiLabel.Size = new System.Drawing.Size(112, 25);
            filmin_AdiLabel.TabIndex = 5;
            filmin_AdiLabel.Text = "Filmin Adi:";
            // 
            // yonetmeniLabel
            // 
            yonetmeniLabel.AutoSize = true;
            yonetmeniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            yonetmeniLabel.Location = new System.Drawing.Point(104, 196);
            yonetmeniLabel.Name = "yonetmeniLabel";
            yonetmeniLabel.Size = new System.Drawing.Size(121, 25);
            yonetmeniLabel.TabIndex = 7;
            yonetmeniLabel.Text = "Yonetmeni:";
            // 
            // iMDBLabel
            // 
            iMDBLabel.AutoSize = true;
            iMDBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            iMDBLabel.Location = new System.Drawing.Point(406, 159);
            iMDBLabel.Name = "iMDBLabel";
            iMDBLabel.Size = new System.Drawing.Size(70, 25);
            iMDBLabel.TabIndex = 11;
            iMDBLabel.Text = "IMDB:";
            // 
            // turLabel
            // 
            turLabel.AutoSize = true;
            turLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            turLabel.Location = new System.Drawing.Point(418, 193);
            turLabel.Name = "turLabel";
            turLabel.Size = new System.Drawing.Size(50, 25);
            turLabel.TabIndex = 13;
            turLabel.Text = "Tur:";
            // 
            // vizyon_TarihiLabel1
            // 
            vizyon_TarihiLabel1.AutoSize = true;
            vizyon_TarihiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            vizyon_TarihiLabel1.Location = new System.Drawing.Point(85, 236);
            vizyon_TarihiLabel1.Name = "vizyon_TarihiLabel1";
            vizyon_TarihiLabel1.Size = new System.Drawing.Size(143, 25);
            vizyon_TarihiLabel1.TabIndex = 20;
            vizyon_TarihiLabel1.Text = "Vizyon Tarihi:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Location = new System.Drawing.Point(561, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vazgeç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deneme1DataSet
            // 
            this.deneme1DataSet.DataSetName = "Deneme1DataSet";
            this.deneme1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.deneme1DataSet;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DergiTableAdapter = null;
            this.tableAdapterManager.FilmTableAdapter = this.filmTableAdapter;
            this.tableAdapterManager.KitapTableAdapter = null;
            this.tableAdapterManager.KullaniciTableAdapter = null;
            this.tableAdapterManager.MuzikTableAdapter = null;
            this.tableAdapterManager.PersonelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kitaplik.Deneme1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // filmBindingNavigator
            // 
            this.filmBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.filmBindingNavigator.BindingSource = this.filmBindingSource;
            this.filmBindingNavigator.CountItem = null;
            this.filmBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.filmBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filmBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel2,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.filmBindingNavigatorSaveItem});
            this.filmBindingNavigator.Location = new System.Drawing.Point(0, 506);
            this.filmBindingNavigator.MoveFirstItem = null;
            this.filmBindingNavigator.MoveLastItem = null;
            this.filmBindingNavigator.MoveNextItem = null;
            this.filmBindingNavigator.MovePreviousItem = null;
            this.filmBindingNavigator.Name = "filmBindingNavigator";
            this.filmBindingNavigator.PositionItem = null;
            this.filmBindingNavigator.Size = new System.Drawing.Size(730, 25);
            this.filmBindingNavigator.TabIndex = 1;
            this.filmBindingNavigator.Text = "bindingNavigator1";
            this.filmBindingNavigator.RefreshItems += new System.EventHandler(this.filmBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel1.Text = "Satır Ekle";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel2.Text = "Satır Sil";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel3.Text = "Film Kaydet";
            // 
            // filmBindingNavigatorSaveItem
            // 
            this.filmBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filmBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("filmBindingNavigatorSaveItem.Image")));
            this.filmBindingNavigatorSaveItem.Name = "filmBindingNavigatorSaveItem";
            this.filmBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.filmBindingNavigatorSaveItem.Text = "Save Data";
            this.filmBindingNavigatorSaveItem.Click += new System.EventHandler(this.filmBindingNavigatorSaveItem_Click);
            // 
            // filmDataGridView
            // 
            this.filmDataGridView.AutoGenerateColumns = false;
            this.filmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.filmDataGridView.DataSource = this.filmBindingSource;
            this.filmDataGridView.Location = new System.Drawing.Point(109, 277);
            this.filmDataGridView.Name = "filmDataGridView";
            this.filmDataGridView.Size = new System.Drawing.Size(543, 125);
            this.filmDataGridView.TabIndex = 2;
            this.filmDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Filmin Adi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Filmin Adi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Yonetmeni";
            this.dataGridViewTextBoxColumn3.HeaderText = "Yonetmeni";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vizyon Tarihi";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vizyon Tarihi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IMDB";
            this.dataGridViewTextBoxColumn5.HeaderText = "IMDB";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tur";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tur";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // filmin_AdiTextBox
            // 
            this.filmin_AdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "Filmin Adi", true));
            this.filmin_AdiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmin_AdiTextBox.Location = new System.Drawing.Point(234, 156);
            this.filmin_AdiTextBox.Name = "filmin_AdiTextBox";
            this.filmin_AdiTextBox.Size = new System.Drawing.Size(158, 31);
            this.filmin_AdiTextBox.TabIndex = 6;
            // 
            // yonetmeniTextBox
            // 
            this.yonetmeniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "Yonetmeni", true));
            this.yonetmeniTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetmeniTextBox.Location = new System.Drawing.Point(234, 193);
            this.yonetmeniTextBox.Name = "yonetmeniTextBox";
            this.yonetmeniTextBox.Size = new System.Drawing.Size(158, 31);
            this.yonetmeniTextBox.TabIndex = 8;
            // 
            // iMDBTextBox
            // 
            this.iMDBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "IMDB", true));
            this.iMDBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iMDBTextBox.Location = new System.Drawing.Point(486, 156);
            this.iMDBTextBox.Name = "iMDBTextBox";
            this.iMDBTextBox.Size = new System.Drawing.Size(166, 31);
            this.iMDBTextBox.TabIndex = 12;
            // 
            // turTextBox
            // 
            this.turTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "Tur", true));
            this.turTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turTextBox.Location = new System.Drawing.Point(486, 193);
            this.turTextBox.Name = "turTextBox";
            this.turTextBox.Size = new System.Drawing.Size(166, 31);
            this.turTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(406, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Arama";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(486, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 31);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Yeni bir film eklemek için öncelikle \"Satır Ekle\" butonuna tıklayınız.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(622, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Film bilgilerini aşağıda bulunan kutucuklara doldurduktan sonra ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(66, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(609, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kayıtlı filmi veya satırı silmek için \"Satır Sil\" butonuna tıklayınız.";
            // 
            // vizyon_TarihiTextBox
            // 
            this.vizyon_TarihiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "Vizyon Tarihi", true));
            this.vizyon_TarihiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vizyon_TarihiTextBox.Location = new System.Drawing.Point(234, 230);
            this.vizyon_TarihiTextBox.Name = "vizyon_TarihiTextBox";
            this.vizyon_TarihiTextBox.Size = new System.Drawing.Size(158, 31);
            this.vizyon_TarihiTextBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "\"Film Kaydet\" butonuna tıklayınız.";
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(730, 531);
            this.Controls.Add(this.label4);
            this.Controls.Add(vizyon_TarihiLabel1);
            this.Controls.Add(this.vizyon_TarihiTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(filmin_AdiLabel);
            this.Controls.Add(this.filmin_AdiTextBox);
            this.Controls.Add(yonetmeniLabel);
            this.Controls.Add(this.yonetmeniTextBox);
            this.Controls.Add(iMDBLabel);
            this.Controls.Add(this.iMDBTextBox);
            this.Controls.Add(turLabel);
            this.Controls.Add(this.turTextBox);
            this.Controls.Add(this.filmDataGridView);
            this.Controls.Add(this.filmBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Film";
            this.Text = "Film";
            this.Load += new System.EventHandler(this.Film_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingNavigator)).EndInit();
            this.filmBindingNavigator.ResumeLayout(false);
            this.filmBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Deneme1DataSet deneme1DataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private Deneme1DataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private Deneme1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator filmBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton filmBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView filmDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox filmin_AdiTextBox;
        private System.Windows.Forms.TextBox yonetmeniTextBox;
        private System.Windows.Forms.TextBox iMDBTextBox;
        private System.Windows.Forms.TextBox turTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vizyon_TarihiTextBox;
        private System.Windows.Forms.Label label4;
    }
}