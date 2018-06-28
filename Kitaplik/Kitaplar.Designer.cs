namespace Kitaplik
{
    partial class Kitaplar
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
            System.Windows.Forms.Label adiLabel;
            System.Windows.Forms.Label yazarLabel;
            System.Windows.Forms.Label basim_YiliLabel;
            System.Windows.Forms.Label yayin_EviLabel;
            System.Windows.Forms.Label turLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitaplar));
            this.button1 = new System.Windows.Forms.Button();
            this.kitapBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deneme1DataSet = new Kitaplik.Deneme1DataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.kitapBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kitapDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiTextBox = new System.Windows.Forms.TextBox();
            this.yazarTextBox = new System.Windows.Forms.TextBox();
            this.basim_YiliTextBox = new System.Windows.Forms.TextBox();
            this.yayin_EviTextBox = new System.Windows.Forms.TextBox();
            this.turTextBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kitapTableAdapter = new Kitaplik.Deneme1DataSetTableAdapters.KitapTableAdapter();
            this.tableAdapterManager = new Kitaplik.Deneme1DataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            adiLabel = new System.Windows.Forms.Label();
            yazarLabel = new System.Windows.Forms.Label();
            basim_YiliLabel = new System.Windows.Forms.Label();
            yayin_EviLabel = new System.Windows.Forms.Label();
            turLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingNavigator)).BeginInit();
            this.kitapBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adiLabel
            // 
            adiLabel.AutoSize = true;
            adiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            adiLabel.Location = new System.Drawing.Point(182, 181);
            adiLabel.Name = "adiLabel";
            adiLabel.Size = new System.Drawing.Size(49, 25);
            adiLabel.TabIndex = 5;
            adiLabel.Text = "Adi:";
            // 
            // yazarLabel
            // 
            yazarLabel.AutoSize = true;
            yazarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            yazarLabel.Location = new System.Drawing.Point(156, 214);
            yazarLabel.Name = "yazarLabel";
            yazarLabel.Size = new System.Drawing.Size(75, 25);
            yazarLabel.TabIndex = 7;
            yazarLabel.Text = "Yazar:";
            // 
            // basim_YiliLabel
            // 
            basim_YiliLabel.AutoSize = true;
            basim_YiliLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            basim_YiliLabel.Location = new System.Drawing.Point(118, 250);
            basim_YiliLabel.Name = "basim_YiliLabel";
            basim_YiliLabel.Size = new System.Drawing.Size(113, 25);
            basim_YiliLabel.TabIndex = 9;
            basim_YiliLabel.Text = "Basim Yili:";
            // 
            // yayin_EviLabel
            // 
            yayin_EviLabel.AutoSize = true;
            yayin_EviLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            yayin_EviLabel.Location = new System.Drawing.Point(395, 181);
            yayin_EviLabel.Name = "yayin_EviLabel";
            yayin_EviLabel.Size = new System.Drawing.Size(109, 25);
            yayin_EviLabel.TabIndex = 11;
            yayin_EviLabel.Text = "Yayin Evi:";
            // 
            // turLabel
            // 
            turLabel.AutoSize = true;
            turLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            turLabel.Location = new System.Drawing.Point(454, 217);
            turLabel.Name = "turLabel";
            turLabel.Size = new System.Drawing.Size(50, 25);
            turLabel.TabIndex = 13;
            turLabel.Text = "Tur:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(645, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vazgec";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kitapBindingNavigator
            // 
            this.kitapBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kitapBindingNavigator.BindingSource = this.kitapBindingSource;
            this.kitapBindingNavigator.CountItem = null;
            this.kitapBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kitapBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kitapBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel2,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.kitapBindingNavigatorSaveItem});
            this.kitapBindingNavigator.Location = new System.Drawing.Point(0, 486);
            this.kitapBindingNavigator.MoveFirstItem = null;
            this.kitapBindingNavigator.MoveLastItem = null;
            this.kitapBindingNavigator.MoveNextItem = null;
            this.kitapBindingNavigator.MovePreviousItem = null;
            this.kitapBindingNavigator.Name = "kitapBindingNavigator";
            this.kitapBindingNavigator.PositionItem = null;
            this.kitapBindingNavigator.Size = new System.Drawing.Size(794, 25);
            this.kitapBindingNavigator.TabIndex = 1;
            this.kitapBindingNavigator.Text = "bindingNavigator1";
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
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.deneme1DataSet;
            // 
            // deneme1DataSet
            // 
            this.deneme1DataSet.DataSetName = "Deneme1DataSet";
            this.deneme1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.toolStripLabel3.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel3.Text = "Kitap Kaydet";
            // 
            // kitapBindingNavigatorSaveItem
            // 
            this.kitapBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kitapBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapBindingNavigatorSaveItem.Image")));
            this.kitapBindingNavigatorSaveItem.Name = "kitapBindingNavigatorSaveItem";
            this.kitapBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kitapBindingNavigatorSaveItem.Text = "Save Data";
            this.kitapBindingNavigatorSaveItem.Click += new System.EventHandler(this.kitapBindingNavigatorSaveItem_Click);
            // 
            // kitapDataGridView
            // 
            this.kitapDataGridView.AutoGenerateColumns = false;
            this.kitapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.kitapDataGridView.DataSource = this.kitapBindingSource;
            this.kitapDataGridView.Location = new System.Drawing.Point(123, 310);
            this.kitapDataGridView.Name = "kitapDataGridView";
            this.kitapDataGridView.Size = new System.Drawing.Size(543, 125);
            this.kitapDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Adi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Adi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Yazar";
            this.dataGridViewTextBoxColumn3.HeaderText = "Yazar";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Basim Yili";
            this.dataGridViewTextBoxColumn4.HeaderText = "Basim Yili";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Yayin Evi";
            this.dataGridViewTextBoxColumn5.HeaderText = "Yayin Evi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tur";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tur";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // adiTextBox
            // 
            this.adiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitapBindingSource, "Adi", true));
            this.adiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adiTextBox.Location = new System.Drawing.Point(237, 178);
            this.adiTextBox.Name = "adiTextBox";
            this.adiTextBox.Size = new System.Drawing.Size(152, 31);
            this.adiTextBox.TabIndex = 6;
            this.adiTextBox.TextChanged += new System.EventHandler(this.adiTextBox_TextChanged);
            // 
            // yazarTextBox
            // 
            this.yazarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitapBindingSource, "Yazar", true));
            this.yazarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazarTextBox.Location = new System.Drawing.Point(237, 214);
            this.yazarTextBox.Name = "yazarTextBox";
            this.yazarTextBox.Size = new System.Drawing.Size(152, 31);
            this.yazarTextBox.TabIndex = 8;
            // 
            // basim_YiliTextBox
            // 
            this.basim_YiliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitapBindingSource, "Basim Yili", true));
            this.basim_YiliTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basim_YiliTextBox.Location = new System.Drawing.Point(237, 247);
            this.basim_YiliTextBox.Name = "basim_YiliTextBox";
            this.basim_YiliTextBox.Size = new System.Drawing.Size(152, 31);
            this.basim_YiliTextBox.TabIndex = 10;
            // 
            // yayin_EviTextBox
            // 
            this.yayin_EviTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitapBindingSource, "Yayin Evi", true));
            this.yayin_EviTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yayin_EviTextBox.Location = new System.Drawing.Point(510, 178);
            this.yayin_EviTextBox.Name = "yayin_EviTextBox";
            this.yayin_EviTextBox.Size = new System.Drawing.Size(155, 31);
            this.yayin_EviTextBox.TabIndex = 12;
            this.yayin_EviTextBox.TextChanged += new System.EventHandler(this.yayin_EviTextBox_TextChanged);
            // 
            // turTextBox
            // 
            this.turTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitapBindingSource, "Tur", true));
            this.turTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turTextBox.Location = new System.Drawing.Point(510, 214);
            this.turTextBox.Name = "turTextBox";
            this.turTextBox.Size = new System.Drawing.Size(155, 31);
            this.turTextBox.TabIndex = 14;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Search.Location = new System.Drawing.Point(424, 250);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(80, 25);
            this.Search.TabIndex = 16;
            this.Search.Text = "Arama:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(510, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 31);
            this.textBox1.TabIndex = 17;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(657, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Yeni bir kitap eklemek için öncelikle \"Satır Ekle\" butonuna tıklayınız.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(71, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(624, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kitap bilgilerini aşağıda bulunan kutucukları doldurduktan sonra ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(71, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(622, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Kayıtlı kitabı veya satırı silmek için \"Satır Sil\" butonuna tıklayınız.";
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DergiTableAdapter = null;
            this.tableAdapterManager.FilmTableAdapter = null;
            this.tableAdapterManager.KitapTableAdapter = this.kitapTableAdapter;
            this.tableAdapterManager.KullaniciTableAdapter = null;
            this.tableAdapterManager.MuzikTableAdapter = null;
            this.tableAdapterManager.PersonelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kitaplik.Deneme1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "\"Kitap Kaydet\" butonuna tıklayınız.";
            // 
            // Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(794, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(adiLabel);
            this.Controls.Add(this.adiTextBox);
            this.Controls.Add(yazarLabel);
            this.Controls.Add(this.yazarTextBox);
            this.Controls.Add(basim_YiliLabel);
            this.Controls.Add(this.basim_YiliTextBox);
            this.Controls.Add(yayin_EviLabel);
            this.Controls.Add(this.yayin_EviTextBox);
            this.Controls.Add(turLabel);
            this.Controls.Add(this.turTextBox);
            this.Controls.Add(this.kitapDataGridView);
            this.Controls.Add(this.kitapBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Kitaplar";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Kitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingNavigator)).EndInit();
            this.kitapBindingNavigator.ResumeLayout(false);
            this.kitapBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Deneme1DataSet deneme1DataSet;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private Deneme1DataSetTableAdapters.KitapTableAdapter kitapTableAdapter;
        private Deneme1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kitapBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kitapBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.DataGridView kitapDataGridView;
        private System.Windows.Forms.TextBox adiTextBox;
        private System.Windows.Forms.TextBox yazarTextBox;
        private System.Windows.Forms.TextBox basim_YiliTextBox;
        private System.Windows.Forms.TextBox yayin_EviTextBox;
        private System.Windows.Forms.TextBox turTextBox;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}