namespace Kitaplik
{
    partial class Muzik
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
            System.Windows.Forms.Label album_AdiLabel;
            System.Windows.Forms.Label sanatciLabel;
            System.Windows.Forms.Label turLabel;
            System.Windows.Forms.Label cikis_YiliLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Muzik));
            this.deneme1DataSet = new Kitaplik.Deneme1DataSet();
            this.muzikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muzikTableAdapter = new Kitaplik.Deneme1DataSetTableAdapters.MuzikTableAdapter();
            this.tableAdapterManager = new Kitaplik.Deneme1DataSetTableAdapters.TableAdapterManager();
            this.muzikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.muzikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.muzikDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.album_AdiTextBox = new System.Windows.Forms.TextBox();
            this.sanatciTextBox = new System.Windows.Forms.TextBox();
            this.turTextBox = new System.Windows.Forms.TextBox();
            this.cikis_YiliTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            album_AdiLabel = new System.Windows.Forms.Label();
            sanatciLabel = new System.Windows.Forms.Label();
            turLabel = new System.Windows.Forms.Label();
            cikis_YiliLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzikBindingNavigator)).BeginInit();
            this.muzikBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muzikDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // album_AdiLabel
            // 
            album_AdiLabel.AutoSize = true;
            album_AdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            album_AdiLabel.Location = new System.Drawing.Point(50, 172);
            album_AdiLabel.Name = "album_AdiLabel";
            album_AdiLabel.Size = new System.Drawing.Size(115, 25);
            album_AdiLabel.TabIndex = 5;
            album_AdiLabel.Text = "Album Adi:";
            // 
            // sanatciLabel
            // 
            sanatciLabel.AutoSize = true;
            sanatciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            sanatciLabel.Location = new System.Drawing.Point(75, 222);
            sanatciLabel.Name = "sanatciLabel";
            sanatciLabel.Size = new System.Drawing.Size(90, 25);
            sanatciLabel.TabIndex = 7;
            sanatciLabel.Text = "Sanatci:";
            // 
            // turLabel
            // 
            turLabel.AutoSize = true;
            turLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            turLabel.Location = new System.Drawing.Point(395, 171);
            turLabel.Name = "turLabel";
            turLabel.Size = new System.Drawing.Size(50, 25);
            turLabel.TabIndex = 9;
            turLabel.Text = "Tur:";
            // 
            // cikis_YiliLabel
            // 
            cikis_YiliLabel.AutoSize = true;
            cikis_YiliLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            cikis_YiliLabel.Location = new System.Drawing.Point(344, 221);
            cikis_YiliLabel.Name = "cikis_YiliLabel";
            cikis_YiliLabel.Size = new System.Drawing.Size(101, 25);
            cikis_YiliLabel.TabIndex = 11;
            cikis_YiliLabel.Text = "Cikis Yili:";
            cikis_YiliLabel.Click += new System.EventHandler(this.cikis_YiliLabel_Click);
            // 
            // deneme1DataSet
            // 
            this.deneme1DataSet.DataSetName = "Deneme1DataSet";
            this.deneme1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muzikBindingSource
            // 
            this.muzikBindingSource.DataMember = "Muzik";
            this.muzikBindingSource.DataSource = this.deneme1DataSet;
            // 
            // muzikTableAdapter
            // 
            this.muzikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DergiTableAdapter = null;
            this.tableAdapterManager.FilmTableAdapter = null;
            this.tableAdapterManager.KitapTableAdapter = null;
            this.tableAdapterManager.KullaniciTableAdapter = null;
            this.tableAdapterManager.MuzikTableAdapter = this.muzikTableAdapter;
            this.tableAdapterManager.PersonelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kitaplik.Deneme1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // muzikBindingNavigator
            // 
            this.muzikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.muzikBindingNavigator.BindingSource = this.muzikBindingSource;
            this.muzikBindingNavigator.CountItem = null;
            this.muzikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.muzikBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.muzikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel2,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.muzikBindingNavigatorSaveItem});
            this.muzikBindingNavigator.Location = new System.Drawing.Point(0, 541);
            this.muzikBindingNavigator.MoveFirstItem = null;
            this.muzikBindingNavigator.MoveLastItem = null;
            this.muzikBindingNavigator.MoveNextItem = null;
            this.muzikBindingNavigator.MovePreviousItem = null;
            this.muzikBindingNavigator.Name = "muzikBindingNavigator";
            this.muzikBindingNavigator.PositionItem = null;
            this.muzikBindingNavigator.Size = new System.Drawing.Size(747, 25);
            this.muzikBindingNavigator.TabIndex = 1;
            this.muzikBindingNavigator.Text = "bindingNavigator1";
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
            this.toolStripLabel3.Size = new System.Drawing.Size(82, 22);
            this.toolStripLabel3.Text = "Albüm Kaydet";
            // 
            // muzikBindingNavigatorSaveItem
            // 
            this.muzikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.muzikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("muzikBindingNavigatorSaveItem.Image")));
            this.muzikBindingNavigatorSaveItem.Name = "muzikBindingNavigatorSaveItem";
            this.muzikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.muzikBindingNavigatorSaveItem.Text = "Save Data";
            this.muzikBindingNavigatorSaveItem.Click += new System.EventHandler(this.muzikBindingNavigatorSaveItem_Click);
            // 
            // muzikDataGridView
            // 
            this.muzikDataGridView.AutoGenerateColumns = false;
            this.muzikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.muzikDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.muzikDataGridView.DataSource = this.muzikBindingSource;
            this.muzikDataGridView.Location = new System.Drawing.Point(171, 312);
            this.muzikDataGridView.Name = "muzikDataGridView";
            this.muzikDataGridView.Size = new System.Drawing.Size(444, 154);
            this.muzikDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Album Adi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Album Adi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sanatci";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sanatci";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tur";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tur";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cikis Yili";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cikis Yili";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // album_AdiTextBox
            // 
            this.album_AdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.muzikBindingSource, "Album Adi", true));
            this.album_AdiTextBox.Location = new System.Drawing.Point(171, 177);
            this.album_AdiTextBox.Name = "album_AdiTextBox";
            this.album_AdiTextBox.Size = new System.Drawing.Size(164, 20);
            this.album_AdiTextBox.TabIndex = 6;
            // 
            // sanatciTextBox
            // 
            this.sanatciTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.muzikBindingSource, "Sanatci", true));
            this.sanatciTextBox.Location = new System.Drawing.Point(171, 227);
            this.sanatciTextBox.Name = "sanatciTextBox";
            this.sanatciTextBox.Size = new System.Drawing.Size(164, 20);
            this.sanatciTextBox.TabIndex = 8;
            // 
            // turTextBox
            // 
            this.turTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.muzikBindingSource, "Tur", true));
            this.turTextBox.Location = new System.Drawing.Point(451, 177);
            this.turTextBox.Name = "turTextBox";
            this.turTextBox.Size = new System.Drawing.Size(164, 20);
            this.turTextBox.TabIndex = 10;
            // 
            // cikis_YiliTextBox
            // 
            this.cikis_YiliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.muzikBindingSource, "Cikis Yili", true));
            this.cikis_YiliTextBox.Location = new System.Drawing.Point(451, 227);
            this.cikis_YiliTextBox.Name = "cikis_YiliTextBox";
            this.cikis_YiliTextBox.Size = new System.Drawing.Size(164, 20);
            this.cikis_YiliTextBox.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(91, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(669, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Yeni bir albüm eklemek için öncelikle \"Satır Ekle\" butonuna tıklayınız.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(635, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Albüm bilgilerini aşağıda bulunan kutucukları doldurduktan sonra ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(641, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Kayıtlı albümü veya satırı silmek için \"Satır Sil\" butonuna tıklayınız.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "\"Albüm Kaydet\" butonuna tıklayınız.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(618, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Vazgeç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Muzik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(747, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(album_AdiLabel);
            this.Controls.Add(this.album_AdiTextBox);
            this.Controls.Add(sanatciLabel);
            this.Controls.Add(this.sanatciTextBox);
            this.Controls.Add(turLabel);
            this.Controls.Add(this.turTextBox);
            this.Controls.Add(cikis_YiliLabel);
            this.Controls.Add(this.cikis_YiliTextBox);
            this.Controls.Add(this.muzikDataGridView);
            this.Controls.Add(this.muzikBindingNavigator);
            this.Name = "Muzik";
            this.Text = "Muzik";
            this.Load += new System.EventHandler(this.Muzik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzikBindingNavigator)).EndInit();
            this.muzikBindingNavigator.ResumeLayout(false);
            this.muzikBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muzikDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Deneme1DataSet deneme1DataSet;
        private System.Windows.Forms.BindingSource muzikBindingSource;
        private Deneme1DataSetTableAdapters.MuzikTableAdapter muzikTableAdapter;
        private Deneme1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator muzikBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton muzikBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView muzikDataGridView;
        private System.Windows.Forms.TextBox album_AdiTextBox;
        private System.Windows.Forms.TextBox sanatciTextBox;
        private System.Windows.Forms.TextBox turTextBox;
        private System.Windows.Forms.TextBox cikis_YiliTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}