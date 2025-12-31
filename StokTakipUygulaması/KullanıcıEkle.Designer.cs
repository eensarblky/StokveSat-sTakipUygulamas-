
namespace StokSatisTakip
{
    partial class KullanıcıEkle
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
            txtAdSoyad = new TextBox();
            txtKadi = new TextBox();
            txtSifre = new TextBox();
            cmbRol = new ComboBox();
            btnKaydet = new Button();
            dgvKullanicilar = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(135, 74);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 0;
            // 
            // txtKadi
            // 
            txtKadi.Location = new Point(135, 142);
            txtKadi.Name = "txtKadi";
            txtKadi.Size = new Size(125, 27);
            txtKadi.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(135, 207);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 2;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Yönetici", "Satış Personeli", "Depo Görevlisi" });
            cmbRol.Location = new Point(135, 261);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(151, 28);
            cmbRol.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(156, 364);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click_1;
            // 
            // dgvKullanicilar
            // 
            dgvKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilar.Location = new Point(326, 103);
            dgvKullanicilar.Name = "dgvKullanicilar";
            dgvKullanicilar.RowHeadersWidth = 51;
            dgvKullanicilar.Size = new Size(509, 290);
            dgvKullanicilar.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 81);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 6;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 145);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 7;
            label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 210);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 8;
            label3.Text = "Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 264);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 9;
            label4.Text = "Rol";
            // 
            // KullanıcıEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 485);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvKullanicilar);
            Controls.Add(btnKaydet);
            Controls.Add(cmbRol);
            Controls.Add(txtSifre);
            Controls.Add(txtKadi);
            Controls.Add(txtAdSoyad);
            Name = "KullanıcıEkle";
            Text = "KullanıcıEkle";
            Load += KullanıcıEkle_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void KullanıcıEkle_Load_1(object sender, EventArgs e)
        {
            Listele();

            
            if (cmbRol.Items.Count == 0)
            {
                cmbRol.Items.Add("Yonetici");
                cmbRol.Items.Add("Satis Personeli");
                cmbRol.Items.Add("Depo Gorevlisi");
            }
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "" || txtKadi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir rol (yetki) seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        #endregion

        private TextBox txtAdSoyad;
        private TextBox txtKadi;
        private TextBox txtSifre;
        private ComboBox cmbRol;
        private Button btnKaydet;
        private DataGridView dgvKullanicilar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}