namespace Kitaplik
{
    partial class KullaniciKayit
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label kullaniciAdiLabel;
            System.Windows.Forms.Label parolaLabel;
            System.Windows.Forms.Label tel_NoLabel;
            System.Windows.Forms.Label mail_AdresiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciKayit));
            this.button1 = new System.Windows.Forms.Button();
            this.deneme1DataSet = new Kitaplik.Deneme1DataSet();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciTableAdapter = new Kitaplik.Deneme1DataSetTableAdapters.KullaniciTableAdapter();
            this.tableAdapterManager = new Kitaplik.Deneme1DataSetTableAdapters.TableAdapterManager();
            this.kullaniciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.kullaniciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.tel_NoTextBox = new System.Windows.Forms.TextBox();
            this.mail_AdresiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            kullaniciAdiLabel = new System.Windows.Forms.Label();
            parolaLabel = new System.Windows.Forms.Label();
            tel_NoLabel = new System.Windows.Forms.Label();
            mail_AdresiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingNavigator)).BeginInit();
            this.kullaniciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            iDLabel.Location = new System.Drawing.Point(212, 386);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(38, 25);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // kullaniciAdiLabel
            // 
            kullaniciAdiLabel.AutoSize = true;
            kullaniciAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            kullaniciAdiLabel.Location = new System.Drawing.Point(1, 300);
            kullaniciAdiLabel.Name = "kullaniciAdiLabel";
            kullaniciAdiLabel.Size = new System.Drawing.Size(136, 25);
            kullaniciAdiLabel.TabIndex = 4;
            kullaniciAdiLabel.Text = "Kullanici Adi:";
            kullaniciAdiLabel.Click += new System.EventHandler(this.kullaniciAdiLabel_Click);
            // 
            // parolaLabel
            // 
            parolaLabel.AutoSize = true;
            parolaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            parolaLabel.Location = new System.Drawing.Point(57, 337);
            parolaLabel.Name = "parolaLabel";
            parolaLabel.Size = new System.Drawing.Size(80, 25);
            parolaLabel.TabIndex = 6;
            parolaLabel.Text = "Parola:";
            // 
            // tel_NoLabel
            // 
            tel_NoLabel.AutoSize = true;
            tel_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            tel_NoLabel.Location = new System.Drawing.Point(354, 299);
            tel_NoLabel.Name = "tel_NoLabel";
            tel_NoLabel.Size = new System.Drawing.Size(81, 25);
            tel_NoLabel.TabIndex = 8;
            tel_NoLabel.Text = "Tel No:";
            // 
            // mail_AdresiLabel
            // 
            mail_AdresiLabel.AutoSize = true;
            mail_AdresiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            mail_AdresiLabel.Location = new System.Drawing.Point(310, 338);
            mail_AdresiLabel.Name = "mail_AdresiLabel";
            mail_AdresiLabel.Size = new System.Drawing.Size(125, 25);
            mail_AdresiLabel.TabIndex = 10;
            mail_AdresiLabel.Text = "Mail Adresi:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Location = new System.Drawing.Point(482, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vazgec";
            this.button1.UseVisualStyleBackColor = false;
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
            this.kullaniciBindingNavigator.DeleteItem = null;
            this.kullaniciBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kullaniciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.kullaniciBindingNavigatorSaveItem});
            this.kullaniciBindingNavigator.Location = new System.Drawing.Point(0, 479);
            this.kullaniciBindingNavigator.MoveFirstItem = null;
            this.kullaniciBindingNavigator.MoveLastItem = null;
            this.kullaniciBindingNavigator.MoveNextItem = null;
            this.kullaniciBindingNavigator.MovePreviousItem = null;
            this.kullaniciBindingNavigator.Name = "kullaniciBindingNavigator";
            this.kullaniciBindingNavigator.PositionItem = null;
            this.kullaniciBindingNavigator.Size = new System.Drawing.Size(634, 25);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "Doldur";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel2.Text = "Kaydet";
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
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(256, 392);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(152, 20);
            this.iDTextBox.TabIndex = 3;
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "KullaniciAdi", true));
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(143, 304);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(152, 20);
            this.kullaniciAdiTextBox.TabIndex = 5;
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "Parola", true));
            this.parolaTextBox.Location = new System.Drawing.Point(143, 343);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.Size = new System.Drawing.Size(152, 20);
            this.parolaTextBox.TabIndex = 7;
            // 
            // tel_NoTextBox
            // 
            this.tel_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "Tel No", true));
            this.tel_NoTextBox.Location = new System.Drawing.Point(441, 305);
            this.tel_NoTextBox.Name = "tel_NoTextBox";
            this.tel_NoTextBox.Size = new System.Drawing.Size(160, 20);
            this.tel_NoTextBox.TabIndex = 9;
            // 
            // mail_AdresiTextBox
            // 
            this.mail_AdresiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "Mail Adresi", true));
            this.mail_AdresiTextBox.Location = new System.Drawing.Point(441, 342);
            this.mail_AdresiTextBox.Name = "mail_AdresiTextBox";
            this.mail_AdresiTextBox.Size = new System.Drawing.Size(160, 20);
            this.mail_AdresiTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kayıt olmak için öncelikle \" Doldur\" butonuna tıklayınız.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bilgilerinizi eksiksiz doldurduktan sonra \"Kaydet\" butonuna ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kitaplik.Properties.Resources.kullanıcıekleme;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(238, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 124);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "tıklayarak kaydınızı tamamlayabilirsiniz.";
            // 
            // KullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(634, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(kullaniciAdiLabel);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(parolaLabel);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(tel_NoLabel);
            this.Controls.Add(this.tel_NoTextBox);
            this.Controls.Add(mail_AdresiLabel);
            this.Controls.Add(this.mail_AdresiTextBox);
            this.Controls.Add(this.kullaniciBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "KullaniciKayit";
            this.Text = "KullaniciKayit";
            this.Load += new System.EventHandler(this.KullaniciKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingNavigator)).EndInit();
            this.kullaniciBindingNavigator.ResumeLayout(false);
            this.kullaniciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripButton kullaniciBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.TextBox tel_NoTextBox;
        private System.Windows.Forms.TextBox mail_AdresiTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}