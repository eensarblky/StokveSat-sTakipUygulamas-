namespace StokSatisTakip
{
    partial class SatisForm
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
            cmbMusteri = new ComboBox();
            cmbUrun = new ComboBox();
            txtAdet = new TextBox();
            gridSepet = new DataGridView();
            btnSepetEkle = new Button();
            btnSatisYap = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblToplam = new Label();
            ((System.ComponentModel.ISupportInitialize)gridSepet).BeginInit();
            SuspendLayout();
            // 
            // cmbMusteri
            // 
            cmbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(169, 62);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(151, 28);
            cmbMusteri.TabIndex = 0;
            // 
            // cmbUrun
            // 
            cmbUrun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUrun.FormattingEnabled = true;
            cmbUrun.Location = new Point(169, 109);
            cmbUrun.Name = "cmbUrun";
            cmbUrun.Size = new Size(151, 28);
            cmbUrun.TabIndex = 1;
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(169, 153);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(125, 27);
            txtAdet.TabIndex = 2;
            // 
            // gridSepet
            // 
            gridSepet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridSepet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSepet.Location = new Point(351, 27);
            gridSepet.Name = "gridSepet";
            gridSepet.RowHeadersWidth = 51;
            gridSepet.Size = new Size(453, 211);
            gridSepet.TabIndex = 3;
            // 
            // btnSepetEkle
            // 
            btnSepetEkle.Location = new Point(169, 204);
            btnSepetEkle.Name = "btnSepetEkle";
            btnSepetEkle.Size = new Size(94, 29);
            btnSepetEkle.TabIndex = 4;
            btnSepetEkle.Text = "Sepete Ekle";
            btnSepetEkle.UseVisualStyleBackColor = true;
            btnSepetEkle.Click += btnSepetEkle_Click_1;
            // 
            // btnSatisYap
            // 
            btnSatisYap.BackColor = Color.Tomato;
            btnSatisYap.Location = new Point(883, 204);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(94, 29);
            btnSatisYap.TabIndex = 5;
            btnSatisYap.Text = "Onayla";
            btnSatisYap.UseVisualStyleBackColor = false;
            btnSatisYap.Click += btnSatisYap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 62);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 6;
            label1.Text = "Müşteri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 112);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 7;
            label2.Text = "Ürün";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 155);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 8;
            label3.Text = "Adet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(818, 62);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 9;
            label4.Text = "Toplam Tutar";
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplam.Location = new Point(825, 101);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(90, 31);
            lblToplam.TabIndex = 10;
            lblToplam.Text = "0.00 TL";
            // 
            // SatisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 685);
            Controls.Add(lblToplam);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSatisYap);
            Controls.Add(btnSepetEkle);
            Controls.Add(gridSepet);
            Controls.Add(txtAdet);
            Controls.Add(cmbUrun);
            Controls.Add(cmbMusteri);
            Name = "SatisForm";
            Text = "Satış Ekranı";
            Load += SatisForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)gridSepet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMusteri;
        private ComboBox cmbUrun;
        private TextBox txtAdet;
        private DataGridView gridSepet;
        private Button btnSepetEkle;
        private Button btnSatisYap;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblToplam;
    }
}