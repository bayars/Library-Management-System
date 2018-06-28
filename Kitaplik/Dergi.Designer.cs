namespace Kitaplik
{
    partial class Dergi
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
            System.Windows.Forms.Label dergi_AdiLabel;
            System.Windows.Forms.Label turLabel;
            System.Windows.Forms.Label basim_SikligiLabel;
            System.Windows.Forms.Label sayiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dergi));
            this.button1 = new System.Windows.Forms.Button();
            this.dergiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.dergiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deneme1DataSet = new Kitaplik.Deneme1DataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dergiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dergiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dergi_AdiTextBox = new System.Windows.Forms.TextBox();
            this.turTextBox = new System.Windows.Forms.TextBox();
            this.basim_SikligiTextBox = new System.Windows.Forms.TextBox();
            this.sayiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dergiTableAdapter = new Kitaplik.Deneme1DataSetTableAdapters.DergiTableAdapter();
            this.tableAdapterManager = new Kitaplik.Deneme1DataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            dergi_AdiLabel = new System.Windows.Forms.Label();
            turLabel = new System.Windows.Forms.Label();
            basim_SikligiLabel = new System.Windows.Forms.Label();
            sayiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dergiBindingNavigator)).BeginInit();
            this.dergiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dergiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dergiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dergi_AdiLabel
            // 
            dergi_AdiLabel.AutoSize = true;
            dergi_AdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dergi_AdiLabel.Location = new System.Drawing.Point(31, 179);
            dergi_AdiLabel.Name = "dergi_AdiLabel";
            dergi_AdiLabel.Size = new System.Drawing.Size(106, 25);
            dergi_AdiLabel.TabIndex = 5;
            dergi_AdiLabel.Text = "Dergi Adı:";
            // 
            // turLabel
            // 
            turLabel.AutoSize = true;
            turLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            turLabel.Location = new System.Drawing.Point(87, 216);
            turLabel.Name = "turLabel";
            turLabel.Size = new System.Drawing.Size(50, 25);
            turLabel.TabIndex = 7;
            turLabel.Text = "Tür:";
            // 
            // basim_SikligiLabel
            // 
            basim_SikligiLabel.AutoSize = true;
            basim_SikligiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            basim_SikligiLabel.Location = new System.Drawing.Point(313, 175);
            basim_SikligiLabel.Name = "basim_SikligiLabel";
            basim_SikligiLabel.Size = new System.Drawing.Size(140, 25);
            basim_SikligiLabel.TabIndex = 9;
            basim_SikligiLabel.Text = "Basım Sıklığı:";
            // 
            // sayiLabel
            // 
            sayiLabel.AutoSize = true;
            sayiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            sayiLabel.Location = new System.Drawing.Point(393, 219);
            sayiLabel.Name = "sayiLabel";
            sayiLabel.Size = new System.Drawing.Size(60, 25);
            sayiLabel.TabIndex = 11;
            sayiLabel.Text = "Sayı:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vazgec";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dergiBindingNavigator
            // 
            this.dergiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dergiBindingNavigator.BindingSource = this.dergiBindingSource;
            this.dergiBindingNavigator.CountItem = null;
            this.dergiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dergiBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dergiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.bindingNavigatorAddNewItem,
            this.toolStripLabel2,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel3,
            this.dergiBindingNavigatorSaveItem});
            this.dergiBindingNavigator.Location = new System.Drawing.Point(0, 495);
            this.dergiBindingNavigator.MoveFirstItem = null;
            this.dergiBindingNavigator.MoveLastItem = null;
            this.dergiBindingNavigator.MoveNextItem = null;
            this.dergiBindingNavigator.MovePreviousItem = null;
            this.dergiBindingNavigator.Name = "dergiBindingNavigator";
            this.dergiBindingNavigator.PositionItem = null;
            this.dergiBindingNavigator.Size = new System.Drawing.Size(732, 25);
            this.dergiBindingNavigator.TabIndex = 1;
            this.dergiBindingNavigator.Text = "bindingNavigator1";
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
            // dergiBindingSource
            // 
            this.dergiBindingSource.DataMember = "Dergi";
            this.dergiBindingSource.DataSource = this.deneme1DataSet;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel2.Text = "Satır Sil";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel3.Text = "Dergi Kaydet";
            // 
            // dergiBindingNavigatorSaveItem
            // 
            this.dergiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dergiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dergiBindingNavigatorSaveItem.Image")));
            this.dergiBindingNavigatorSaveItem.Name = "dergiBindingNavigatorSaveItem";
            this.dergiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dergiBindingNavigatorSaveItem.Text = "Save Data";
            this.dergiBindingNavigatorSaveItem.Click += new System.EventHandler(this.dergiBindingNavigatorSaveItem_Click);
            // 
            // dergiDataGridView
            // 
            this.dergiDataGridView.AutoGenerateColumns = false;
            this.dergiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dergiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dergiDataGridView.DataSource = this.dergiBindingSource;
            this.dergiDataGridView.Location = new System.Drawing.Point(164, 298);
            this.dergiDataGridView.Name = "dergiDataGridView";
            this.dergiDataGridView.Size = new System.Drawing.Size(443, 125);
            this.dergiDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Dergi Adi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dergi Adi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tur";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tur";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Basim Sikligi";
            this.dataGridViewTextBoxColumn4.HeaderText = "Basim Sikligi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sayi";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sayi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dergi_AdiTextBox
            // 
            this.dergi_AdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dergiBindingSource, "Dergi Adi", true));
            this.dergi_AdiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dergi_AdiTextBox.Location = new System.Drawing.Point(162, 178);
            this.dergi_AdiTextBox.Name = "dergi_AdiTextBox";
            this.dergi_AdiTextBox.Size = new System.Drawing.Size(145, 31);
            this.dergi_AdiTextBox.TabIndex = 6;
            // 
            // turTextBox
            // 
            this.turTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dergiBindingSource, "Tur", true));
            this.turTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turTextBox.Location = new System.Drawing.Point(162, 216);
            this.turTextBox.Name = "turTextBox";
            this.turTextBox.Size = new System.Drawing.Size(145, 31);
            this.turTextBox.TabIndex = 8;
            // 
            // basim_SikligiTextBox
            // 
            this.basim_SikligiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dergiBindingSource, "Basim Sikligi", true));
            this.basim_SikligiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basim_SikligiTextBox.Location = new System.Drawing.Point(459, 176);
            this.basim_SikligiTextBox.Name = "basim_SikligiTextBox";
            this.basim_SikligiTextBox.Size = new System.Drawing.Size(149, 31);
            this.basim_SikligiTextBox.TabIndex = 10;
            // 
            // sayiTextBox
            // 
            this.sayiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dergiBindingSource, "Sayi", true));
            this.sayiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayiTextBox.Location = new System.Drawing.Point(459, 219);
            this.sayiTextBox.Name = "sayiTextBox";
            this.sayiTextBox.Size = new System.Drawing.Size(149, 31);
            this.sayiTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(87, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(162, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 31);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dergiTableAdapter
            // 
            this.dergiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DergiTableAdapter = this.dergiTableAdapter;
            this.tableAdapterManager.FilmTableAdapter = null;
            this.tableAdapterManager.KitapTableAdapter = null;
            this.tableAdapterManager.KullaniciTableAdapter = null;
            this.tableAdapterManager.MuzikTableAdapter = null;
            this.tableAdapterManager.PersonelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kitaplik.Deneme1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(659, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Yeni bir dergi eklemek için öncelikle \"Satır Ekle\" butonuna tıklayınız.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(662, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Derginin bilgilerini aşağıda bulunan kutucuklara doldurduktan sonra ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(247, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 18;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(635, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kayıtlı dergiyi veya satırı silmek için \"Satır Sil\" butonuna tıklayınız.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(33, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "\"Dergi Kaydet\" butonuna tıklayınız.";
            // 
            // Dergi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(732, 520);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(dergi_AdiLabel);
            this.Controls.Add(this.dergi_AdiTextBox);
            this.Controls.Add(turLabel);
            this.Controls.Add(this.turTextBox);
            this.Controls.Add(basim_SikligiLabel);
            this.Controls.Add(this.basim_SikligiTextBox);
            this.Controls.Add(sayiLabel);
            this.Controls.Add(this.sayiTextBox);
            this.Controls.Add(this.dergiDataGridView);
            this.Controls.Add(this.dergiBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Dergi";
            this.Text = "Dergi";
            this.Load += new System.EventHandler(this.Dergi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dergiBindingNavigator)).EndInit();
            this.dergiBindingNavigator.ResumeLayout(false);
            this.dergiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dergiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dergiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Deneme1DataSet deneme1DataSet;
        private System.Windows.Forms.BindingSource dergiBindingSource;
        private Deneme1DataSetTableAdapters.DergiTableAdapter dergiTableAdapter;
        private Deneme1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dergiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dergiBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.DataGridView dergiDataGridView;
        private System.Windows.Forms.TextBox dergi_AdiTextBox;
        private System.Windows.Forms.TextBox turTextBox;
        private System.Windows.Forms.TextBox basim_SikligiTextBox;
        private System.Windows.Forms.TextBox sayiTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}