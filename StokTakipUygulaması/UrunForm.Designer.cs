

namespace StokSatisTakip
{
    partial class UrunForm
    {
                                   private System.ComponentModel.IContainer components = null;

                                            protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAd = new TextBox();
            txtBarkod = new TextBox();
            txtFiyat = new TextBox();
            txtStok = new TextBox();
            txtKritik = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            txtFiyatAlis = new TextBox();
            btnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 54);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 100);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Barkod";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 141);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Satış Fiyatı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 49);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 3;
            label4.Text = "Stok Adedi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 96);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 4;
            label5.Text = "Kritik Stok";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(150, 47);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(150, 93);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(125, 27);
            txtBarkod.TabIndex = 6;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(150, 134);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(125, 27);
            txtFiyat.TabIndex = 7;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(417, 45);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(125, 27);
            txtStok.TabIndex = 8;
            // 
            // txtKritik
            // 
            txtKritik.Location = new Point(417, 89);
            txtKritik.Name = "txtKritik";
            txtKritik.Size = new Size(125, 27);
            txtKritik.TabIndex = 9;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(655, 45);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(655, 80);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 11;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(867, 338);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(329, 141);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 13;
            label6.Text = "Alış Fiyatı";
            // 
            // txtFiyatAlis
            // 
            txtFiyatAlis.Location = new Point(417, 134);
            txtFiyatAlis.Name = "txtFiyatAlis";
            txtFiyatAlis.Size = new Size(125, 27);
            txtFiyatAlis.TabIndex = 14;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(657, 122);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 15;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // UrunForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 689);
            Controls.Add(btnGuncelle);
            Controls.Add(txtFiyatAlis);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtKritik);
            Controls.Add(txtStok);
            Controls.Add(txtFiyat);
            Controls.Add(txtBarkod);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UrunForm";
            Text = "Ürün Yönetimi";
            Load += UrunForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAd;
        private TextBox txtBarkod;
        private TextBox txtFiyat;
        private TextBox txtStok;
        private TextBox txtKritik;
        private Button btnEkle;
        private Button btnSil;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox txtFiyatAlis;
        private Button btnGuncelle;
    }
}