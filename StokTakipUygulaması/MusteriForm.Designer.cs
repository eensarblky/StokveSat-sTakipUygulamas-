namespace StokSatisTakip
{
    partial class MusteriForm
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
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            cmbTur = new ComboBox();
            btnEkle = new Button();
            btnSil = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
                                                   label1.AutoSize = true;
            label1.Location = new Point(29, 65);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Adı Soyadı";
                                                   label2.AutoSize = true;
            label2.Location = new Point(52, 98);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefon";
                                                   label3.AutoSize = true;
            label3.Location = new Point(19, 129);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Müşteri Türü";
                                                   txtAdSoyad.Location = new Point(123, 58);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 3;
                                                   txtTelefon.Location = new Point(123, 91);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 4;
                                                   cmbTur.FormattingEnabled = true;
            cmbTur.Items.AddRange(new object[] { "Perakende", "Toptan" });
            cmbTur.Location = new Point(123, 124);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(151, 28);
            cmbTur.TabIndex = 5;
                                                   btnEkle.Location = new Point(336, 61);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click_1;
                                                   btnSil.Location = new Point(336, 120);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click_1;
                                                   dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(627, 235);
            dataGridView1.TabIndex = 8;
                                                   AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(cmbTur);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MusteriForm";
            Text = "Müşteri Ekle";
            Load += MusteriForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private ComboBox cmbTur;
        private Button btnEkle;
        private Button btnSil;
        private DataGridView dataGridView1;
    }
}