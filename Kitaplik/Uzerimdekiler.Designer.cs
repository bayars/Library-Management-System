namespace Kitaplik
{
    partial class Uzerimdekiler
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
            this.uzerimdekilerGrid = new System.Windows.Forms.DataGridView();
            this.eserAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinmaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suresiGectiMi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.uzerimdekilerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uzerimdekilerGrid
            // 
            this.uzerimdekilerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uzerimdekilerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eserAdi,
            this.tur,
            this.alinmaTarihi,
            this.suresiGectiMi});
            this.uzerimdekilerGrid.Location = new System.Drawing.Point(175, 280);
            this.uzerimdekilerGrid.Name = "uzerimdekilerGrid";
            this.uzerimdekilerGrid.Size = new System.Drawing.Size(443, 125);
            this.uzerimdekilerGrid.TabIndex = 0;
            // 
            // eserAdi
            // 
            this.eserAdi.Frozen = true;
            this.eserAdi.HeaderText = "Eser İsmi";
            this.eserAdi.Name = "eserAdi";
            // 
            // tur
            // 
            this.tur.Frozen = true;
            this.tur.HeaderText = "Tür";
            this.tur.Name = "tur";
            this.tur.ReadOnly = true;
            // 
            // alinmaTarihi
            // 
            this.alinmaTarihi.HeaderText = "Alinma Tarihi";
            this.alinmaTarihi.Name = "alinmaTarihi";
            // 
            // suresiGectiMi
            // 
            this.suresiGectiMi.HeaderText = "Gecikme";
            this.suresiGectiMi.Name = "suresiGectiMi";
            this.suresiGectiMi.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(209, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Üzerinizde bulunan eserler aşağıdadır.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(797, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Üzerize kayıtlı kitapları görmek için \"Üzerimdeki Kitaplar\" butonuna tıklayabilir" +
    "siniz.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Kitaplik.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(324, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 125);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Uzerimdekiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(807, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uzerimdekilerGrid);
            this.Name = "Uzerimdekiler";
            this.Text = "Uzerimdekiler";
            ((System.ComponentModel.ISupportInitialize)(this.uzerimdekilerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uzerimdekilerGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eserAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn alinmaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn suresiGectiMi;
    }
}