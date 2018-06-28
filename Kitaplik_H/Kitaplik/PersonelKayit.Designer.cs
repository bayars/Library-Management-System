namespace Kitaplik
{
    partial class PersonelKayit
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
            System.Windows.Forms.Label personel_AdiLabel;
            System.Windows.Forms.Label tel_NoLabel;
            System.Windows.Forms.Label mail_AdresiLabel;
            System.Windows.Forms.Label parolaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelKayit));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deneme1DataSet = new Kitaplik.Deneme1DataSet();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new Kitaplik.Deneme1DataSetTableAdapters.PersonelTableAdapter();
            this.tableAdapterManager = new Kitaplik.Deneme1DataSetTableAdapters.TableAdapterManager();
            this.personelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.personelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personel_AdiTextBox = new System.Windows.Forms.TextBox();
            this.tel_NoTextBox = new System.Windows.Forms.TextBox();
            this.mail_AdresiTextBox = new System.Windows.Forms.TextBox();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            personel_AdiLabel = new System.Windows.Forms.Label();
            tel_NoLabel = new System.Windows.Forms.Label();
            mail_AdresiLabel = new System.Windows.Forms.Label();
            parolaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingNavigator)).BeginInit();
            this.personelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // personel_AdiLabel
            // 
            personel_AdiLabel.AutoSize = true;
            personel_AdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            personel_AdiLabel.Location = new System.Drawing.Point(36, 270);
            personel_AdiLabel.Name = "personel_AdiLabel";
            personel_AdiLabel.Size = new System.Drawing.Size(134, 25);
            personel_AdiLabel.TabIndex = 20;
            personel_AdiLabel.Text = "PersonelAdi:";
            // 
            // tel_NoLabel
            // 
            tel_NoLabel.AutoSize = true;
            tel_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            tel_NoLabel.Location = new System.Drawing.Point(413, 270);
            tel_NoLabel.Name = "tel_NoLabel";
            tel_NoLabel.Size = new System.Drawing.Size(81, 25);
            tel_NoLabel.TabIndex = 22;
            tel_NoLabel.Text = "Tel No:";
            // 
            // mail_AdresiLabel
            // 
            mail_AdresiLabel.AutoSize = true;
            mail_AdresiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            mail_AdresiLabel.Location = new System.Drawing.Point(369, 322);
            mail_AdresiLabel.Name = "mail_AdresiLabel";
            mail_AdresiLabel.Size = new System.Drawing.Size(125, 25);
            mail_AdresiLabel.TabIndex = 24;
            mail_AdresiLabel.Text = "Mail Adresi:";
            // 
            // parolaLabel
            // 
            parolaLabel.AutoSize = true;
            parolaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            parolaLabel.Location = new System.Drawing.Point(90, 317);
            parolaLabel.Name = "parolaLabel";
            parolaLabel.Size = new System.Drawing.Size(80, 25);
            parolaLabel.TabIndex = 26;
            parolaLabel.Text = "Parola:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Location = new System.Drawing.Point(655, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vazgec";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-4, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(816, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bilgilerinizi eksiksiz doldurduktan sonra \"Kaydet\" butonuna tıklayarak kaydınızı " +
    "tamamlayabilirsiniz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(161, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kayıt olmak için öncelikle \"Doldur\" butonuna tıklayınız.";
            // 
            // deneme1DataSet
            // 
            this.deneme1DataSet.DataSetName = "Deneme1DataSet";
            this.deneme1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.deneme1DataSet;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DergiTableAdapter = null;
            this.tableAdapterManager.FilmTableAdapter = null;
            this.tableAdapterManager.KitapTableAdapter = null;
            this.tableAdapterManager.KullaniciTableAdapter = null;
            this.tableAdapterManager.MuzikTableAdapter = null;
            this.tableAdapterManager.PersonelTableAdapter = this.personelTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kitaplik.Deneme1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personelBindingNavigator
            // 
            this.personelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personelBindingNavigator.BindingSource = this.personelBindingSource;
            this.personelBindingNavigator.CountItem = null;
            this.personelBindingNavigator.DeleteItem = null;
            this.personelBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.personelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.personelBindingNavigatorSaveItem});
            this.personelBindingNavigator.Location = new System.Drawing.Point(0, 486);
            this.personelBindingNavigator.MoveFirstItem = null;
            this.personelBindingNavigator.MoveLastItem = null;
            this.personelBindingNavigator.MoveNextItem = null;
            this.personelBindingNavigator.MovePreviousItem = null;
            this.personelBindingNavigator.Name = "personelBindingNavigator";
            this.personelBindingNavigator.PositionItem = null;
            this.personelBindingNavigator.Size = new System.Drawing.Size(807, 25);
            this.personelBindingNavigator.TabIndex = 18;
            this.personelBindingNavigator.Text = "bindingNavigator1";
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
            // personelBindingNavigatorSaveItem
            // 
            this.personelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personelBindingNavigatorSaveItem.Image")));
            this.personelBindingNavigatorSaveItem.Name = "personelBindingNavigatorSaveItem";
            this.personelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personelBindingNavigatorSaveItem.Text = "Save Data";
            this.personelBindingNavigatorSaveItem.Click += new System.EventHandler(this.personelBindingNavigatorSaveItem_Click);
            // 
            // personel_AdiTextBox
            // 
            this.personel_AdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "PersonelAdi", true));
            this.personel_AdiTextBox.Location = new System.Drawing.Point(176, 276);
            this.personel_AdiTextBox.Name = "personel_AdiTextBox";
            this.personel_AdiTextBox.Size = new System.Drawing.Size(187, 20);
            this.personel_AdiTextBox.TabIndex = 21;
            // 
            // tel_NoTextBox
            // 
            this.tel_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "Tel No", true));
            this.tel_NoTextBox.Location = new System.Drawing.Point(500, 276);
            this.tel_NoTextBox.Name = "tel_NoTextBox";
            this.tel_NoTextBox.Size = new System.Drawing.Size(187, 20);
            this.tel_NoTextBox.TabIndex = 23;
            // 
            // mail_AdresiTextBox
            // 
            this.mail_AdresiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "Mail Adresi", true));
            this.mail_AdresiTextBox.Location = new System.Drawing.Point(500, 328);
            this.mail_AdresiTextBox.Name = "mail_AdresiTextBox";
            this.mail_AdresiTextBox.Size = new System.Drawing.Size(187, 20);
            this.mail_AdresiTextBox.TabIndex = 25;
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "Parola", true));
            this.parolaTextBox.Location = new System.Drawing.Point(176, 322);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.Size = new System.Drawing.Size(187, 20);
            this.parolaTextBox.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kitaplik.Properties.Resources.personel_alımı2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(276, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 163);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // PersonelKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(807, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(personel_AdiLabel);
            this.Controls.Add(this.personel_AdiTextBox);
            this.Controls.Add(tel_NoLabel);
            this.Controls.Add(this.tel_NoTextBox);
            this.Controls.Add(mail_AdresiLabel);
            this.Controls.Add(this.mail_AdresiTextBox);
            this.Controls.Add(parolaLabel);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(this.personelBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "PersonelKayit";
            this.Text = "PersonelKayit";
            this.Load += new System.EventHandler(this.PersonelKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingNavigator)).EndInit();
            this.personelBindingNavigator.ResumeLayout(false);
            this.personelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Deneme1DataSet deneme1DataSet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private Deneme1DataSetTableAdapters.PersonelTableAdapter personelTableAdapter;
        private Deneme1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personelBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton personelBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox personel_AdiTextBox;
        private System.Windows.Forms.TextBox tel_NoTextBox;
        private System.Windows.Forms.TextBox mail_AdresiTextBox;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}