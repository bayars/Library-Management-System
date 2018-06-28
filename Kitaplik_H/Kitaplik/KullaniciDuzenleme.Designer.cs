namespace Kitaplik
{
    partial class KullaniciDuzenleme
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
            System.Windows.Forms.Label kullaniciAdiLabel;
            System.Windows.Forms.Label parolaLabel;
            System.Windows.Forms.Label tel_NoLabel;
            System.Windows.Forms.Label mail_AdresiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciDuzenleme));
            this.button1 = new System.Windows.Forms.Button();
            this.deneme1DataSet = new Kitaplik.Deneme1DataSet();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciTableAdapter = new Kitaplik.Deneme1DataSetTableAdapters.KullaniciTableAdapter();
            this.tableAdapterManager = new Kitaplik.Deneme1DataSetTableAdapters.TableAdapterManager();
            this.kullaniciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.kullaniciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.kullaniciDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.tel_NoTextBox = new System.Windows.Forms.TextBox();
            this.mail_AdresiTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            kullaniciAdiLabel = new System.Windows.Forms.Label();
            parolaLabel = new System.Windows.Forms.Label();
            tel_NoLabel = new System.Windows.Forms.Label();
            mail_AdresiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingNavigator)).BeginInit();
            this.kullaniciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciAdiLabel
            // 
            kullaniciAdiLabel.AutoSize = true;
            kullaniciAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            kullaniciAdiLabel.Location = new System.Drawing.Point(53, 170);
            kullaniciAdiLabel.Name = "kullaniciAdiLabel";
            kullaniciAdiLabel.Size = new System.Drawing.Size(136, 25);
            kullaniciAdiLabel.TabIndex = 5;
            kullaniciAdiLabel.Text = "Kullanici Adi:";
            kullaniciAdiLabel.Click += new System.EventHandler(this.kullaniciAdiLabel_Click);
            // 
            // parolaLabel
            // 
            parolaLabel.AutoSize = true;
            parolaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            parolaLabel.Location = new System.Drawing.Point(109, 215);
            parolaLabel.Name = "parolaLabel";
            parolaLabel.Size = new System.Drawing.Size(80, 25);
            parolaLabel.TabIndex = 7;
            parolaLabel.Text = "Parola:";
            // 
            // tel_NoLabel
            // 
            tel_NoLabel.AutoSize = true;
            tel_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            tel_NoLabel.Location = new System.Drawing.Point(431, 169);
            tel_NoLabel.Name = "tel_NoLabel";
            tel_NoLabel.Size = new System.Drawing.Size(81, 25);
            tel_NoLabel.TabIndex = 9;
            tel_NoLabel.Text = "Tel No:";
            // 
            // mail_AdresiLabel
            // 
            mail_AdresiLabel.AutoSize = true;
            mail_AdresiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            mail_AdresiLabel.Location = new System.Drawing.Point(387, 217);
            mail_AdresiLabel.Name = "mail_AdresiLabel";
            mail_AdresiLabel.Size = new System.Drawing.Size(125, 25);
            mail_AdresiLabel.TabIndex = 11;
            mail_AdresiLabel.Text = "Mail Adresi:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vazgec";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deneme1DataSet
            // 
            this.deneme1DataSet.DataSetName = "Deneme1DataSet";
            this.deneme1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this.deneme1DataSet;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DergiTableAdapter = null;
            this.tableAdapterManager.FilmTableAdapter = null;
            this.tableAdapterManager.KitapTableAdapter = null;
            this.tableAdapterManager.KullaniciTableAdapter = this.kullaniciTableAdapter;
            this.tableAdapterManager.MuzikTableAdapter = null;
            this.tableAdapterManager.PersonelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kitaplik.Deneme1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kullaniciBindingNavigator
            // 
            this.kullaniciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kullaniciBindingNavigator.BindingSource = this.kullaniciBindingSource;
            this.kullaniciBindingNavigator.CountItem = null;
            this.kullaniciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kullaniciBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kullaniciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel2,
            this.bindingNavigatorDeleteItem,
            this.kullaniciBindingNavigatorSaveItem,
            this.toolStripLabel3});
            this.kullaniciBindingNavigator.Location = new System.Drawing.Point(0, 464);
            this.kullaniciBindingNavigator.MoveFirstItem = null;
            this.kullaniciBindingNavigator.MoveLastItem = null;
            this.kullaniciBindingNavigator.MoveNextItem = null;
            this.kullaniciBindingNavigator.MovePreviousItem = null;
            this.kullaniciBindingNavigator.Name = "kullaniciBindingNavigator";
            this.kullaniciBindingNavigator.PositionItem = null;
            this.kullaniciBindingNavigator.Size = new System.Drawing.Size(783, 25);
            this.kullaniciBindingNavigator.TabIndex = 1;
            this.kullaniciBindingNavigator.Text = "bindingNavigator1";
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
            // kullaniciBindingNavigatorSaveItem
            // 
            this.kullaniciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kullaniciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kullaniciBindingNavigatorSaveItem.Image")));
            this.kullaniciBindingNavigatorSaveItem.Name = "kullaniciBindingNavigatorSaveItem";
            this.kullaniciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kullaniciBindingNavigatorSaveItem.Text = "Save Data";
            this.kullaniciBindingNavigatorSaveItem.Click += new System.EventHandler(this.kullaniciBindingNavigatorSaveItem_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel3.Text = "Kullanıcı Kaydet";
            // 
            // kullaniciDataGridView
            // 
            this.kullaniciDataGridView.AutoGenerateColumns = false;
            this.kullaniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullaniciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.kullaniciDataGridView.DataSource = this.kullaniciBindingSource;
            this.kullaniciDataGridView.Location = new System.Drawing.Point(195, 262);
            this.kullaniciDataGridView.Name = "kullaniciDataGridView";
            this.kullaniciDataGridView.Size = new System.Drawing.Size(443, 125);
            this.kullaniciDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KullaniciAdi";
            this.dataGridViewTextBoxColumn2.HeaderText = "KullaniciAdi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Parola";
            this.dataGridViewTextBoxColumn3.HeaderText = "Parola";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tel No";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tel No";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mail Adresi";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mail Adresi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "KullaniciAdi", true));
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(195, 174);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(157, 20);
            this.kullaniciAdiTextBox.TabIndex = 6;
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "Parola", true));
            this.parolaTextBox.Location = new System.Drawing.Point(195, 220);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.Size = new System.Drawing.Size(157, 20);
            this.parolaTextBox.TabIndex = 8;
            // 
            // tel_NoTextBox
            // 
            this.tel_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "Tel No", true));
            this.tel_NoTextBox.Location = new System.Drawing.Point(518, 175);
            this.tel_NoTextBox.Name = "tel_NoTextBox";
            this.tel_NoTextBox.Size = new System.Drawing.Size(157, 20);
            this.tel_NoTextBox.TabIndex = 10;
            this.tel_NoTextBox.TextChanged += new System.EventHandler(this.tel_NoTextBox_TextChanged);
            // 
            // mail_AdresiTextBox
            // 
            this.mail_AdresiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "Mail Adresi", true));
            this.mail_AdresiTextBox.Location = new System.Drawing.Point(518, 222);
            this.mail_AdresiTextBox.Name = "mail_AdresiTextBox";
            this.mail_AdresiTextBox.Size = new System.Drawing.Size(157, 20);
            this.mail_AdresiTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(689, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Yeni bir kullanıcı eklemek için öncelikle \"Satır Ekle\" butonuna tıklayınız.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(656, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kullanıcı bilgilerini aşağıda bulunan kutucukları doldurduktan sonra ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(665, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kayıtlı kullanıcıyı veya satırı silmek için \"Satır Sil\" butonuna tıklayınız.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "\"Kullanıcı Kaydet\" butonuna tıklayınız.";
            // 
            // KullaniciDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(783, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(kullaniciAdiLabel);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(parolaLabel);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(tel_NoLabel);
            this.Controls.Add(this.tel_NoTextBox);
            this.Controls.Add(mail_AdresiLabel);
            this.Controls.Add(this.mail_AdresiTextBox);
            this.Controls.Add(this.kullaniciDataGridView);
            this.Controls.Add(this.kullaniciBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "KullaniciDuzenleme";
            this.Text = "KullaniciDuzenleme";
            this.Load += new System.EventHandler(this.KullaniciDuzenleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingNavigator)).EndInit();
            this.kullaniciBindingNavigator.ResumeLayout(false);
            this.kullaniciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Deneme1DataSet deneme1DataSet;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private Deneme1DataSetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private Deneme1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kullaniciBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kullaniciBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kullaniciDataGridView;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.TextBox tel_NoTextBox;
        private System.Windows.Forms.TextBox mail_AdresiTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
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