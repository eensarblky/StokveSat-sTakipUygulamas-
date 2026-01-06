
namespace StokSatisTakip
{
    partial class AnaMenu
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
            components = new System.ComponentModel.Container();
            btnMusteriIslem = new Button();
            btnSatisIslem = new Button();
            button4 = new Button();
            btnUrunIslem = new Button();
            panel1 = new Panel();
            lblSaat = new Label();
            lblKritikStok = new Label();
            pnlKullanici = new Panel();
            lblRolBilgi = new Label();
            lblAdSoyadBilgi = new Label();
            label2 = new Label();
            btnKullaniciYonetim = new Button();
            btnRapor = new Button();
            label1 = new Label();
            timerSaat = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            pnlKullanici.SuspendLayout();
            SuspendLayout();
            // 
            // btnMusteriIslem
            // 
            btnMusteriIslem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMusteriIslem.Location = new Point(43, 392);
            btnMusteriIslem.Name = "btnMusteriIslem";
            btnMusteriIslem.Size = new Size(139, 92);
            btnMusteriIslem.TabIndex = 1;
            btnMusteriIslem.Text = "Müşteri İşlemleri";
            btnMusteriIslem.UseVisualStyleBackColor = true;
            btnMusteriIslem.Click += btnMusteriIslem_Click;
            // 
            // btnSatisIslem
            // 
            btnSatisIslem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSatisIslem.Location = new Point(43, 105);
            btnSatisIslem.Name = "btnSatisIslem";
            btnSatisIslem.Size = new Size(139, 92);
            btnSatisIslem.TabIndex = 2;
            btnSatisIslem.Text = "Satış\r\nİşlemleri";
            btnSatisIslem.UseVisualStyleBackColor = true;
            btnSatisIslem.Click += btnSatisIslem_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Font = new Font("Segoe UI", 11.2F);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(878, 522);
            button4.Name = "button4";
            button4.Size = new Size(110, 66);
            button4.TabIndex = 3;
            button4.Text = "Oturumu Kapat";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnUrunIslem
            // 
            btnUrunIslem.Font = new Font("Segoe UI", 16.2F);
            btnUrunIslem.Location = new Point(43, 248);
            btnUrunIslem.Name = "btnUrunIslem";
            btnUrunIslem.Size = new Size(139, 92);
            btnUrunIslem.TabIndex = 4;
            btnUrunIslem.Text = "Ürün İşlemleri";
            btnUrunIslem.UseVisualStyleBackColor = true;
            btnUrunIslem.Click += btnUrunIslem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(lblSaat);
            panel1.Controls.Add(lblKritikStok);
            panel1.Controls.Add(pnlKullanici);
            panel1.Controls.Add(btnKullaniciYonetim);
            panel1.Controls.Add(btnRapor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnUrunIslem);
            panel1.Controls.Add(btnMusteriIslem);
            panel1.Controls.Add(btnSatisIslem);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 618);
            panel1.TabIndex = 5;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSaat.ForeColor = Color.White;
            lblSaat.Location = new Point(453, 522);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(94, 28);
            lblSaat.TabIndex = 9;
            lblSaat.Text = "00:00:00";
            // 
            // lblKritikStok
            // 
            lblKritikStok.AutoSize = true;
            lblKritikStok.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblKritikStok.ForeColor = Color.OrangeRed;
            lblKritikStok.Location = new Point(529, 366);
            lblKritikStok.Name = "lblKritikStok";
            lblKritikStok.Size = new Size(249, 28);
            lblKritikStok.TabIndex = 8;
            lblKritikStok.Text = "Kritik Stoktaki Ürünler: 0";
            // 
            // pnlKullanici
            // 
            pnlKullanici.Controls.Add(lblRolBilgi);
            pnlKullanici.Controls.Add(lblAdSoyadBilgi);
            pnlKullanici.Controls.Add(label2);
            pnlKullanici.Location = new Point(520, 67);
            pnlKullanici.Name = "pnlKullanici";
            pnlKullanici.Size = new Size(436, 273);
            pnlKullanici.TabIndex = 7;
            // 
            // lblRolBilgi
            // 
            lblRolBilgi.AutoSize = true;
            lblRolBilgi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblRolBilgi.ForeColor = Color.LightGray;
            lblRolBilgi.Location = new Point(5, 105);
            lblRolBilgi.Margin = new Padding(5);
            lblRolBilgi.Name = "lblRolBilgi";
            lblRolBilgi.Size = new Size(40, 25);
            lblRolBilgi.TabIndex = 2;
            lblRolBilgi.Text = "Rol";
            // 
            // lblAdSoyadBilgi
            // 
            lblAdSoyadBilgi.AutoSize = true;
            lblAdSoyadBilgi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAdSoyadBilgi.ForeColor = Color.White;
            lblAdSoyadBilgi.Location = new Point(177, 50);
            lblAdSoyadBilgi.Margin = new Padding(5);
            lblAdSoyadBilgi.Name = "lblAdSoyadBilgi";
            lblAdSoyadBilgi.Size = new Size(122, 25);
            lblAdSoyadBilgi.TabIndex = 1;
            lblAdSoyadBilgi.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(5, 50);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 0;
            label2.Text = "AKTİF KULLANICI";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnKullaniciYonetim
            // 
            btnKullaniciYonetim.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKullaniciYonetim.Location = new Point(289, 248);
            btnKullaniciYonetim.Name = "btnKullaniciYonetim";
            btnKullaniciYonetim.Size = new Size(139, 92);
            btnKullaniciYonetim.TabIndex = 6;
            btnKullaniciYonetim.Text = "Personel İşlemleri";
            btnKullaniciYonetim.UseVisualStyleBackColor = true;
            btnKullaniciYonetim.Click += btnKullaniciYonetim_Click;
            // 
            // btnRapor
            // 
            btnRapor.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRapor.Location = new Point(289, 105);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(139, 92);
            btnRapor.TabIndex = 5;
            btnRapor.Text = "Rapor İşlemleri";
            btnRapor.UseVisualStyleBackColor = true;
            btnRapor.Click += btnRapor_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(33, 51);
            label1.Name = "label1";
            label1.Size = new Size(164, 37);
            label1.TabIndex = 0;
            label1.Text = "ANA MENÜ";
            // 
            // timerSaat
            // 
            timerSaat.Enabled = true;
            timerSaat.Interval = 1000;
            timerSaat.Tick += timerSaat_Tick;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(button4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaMenu";
            Load += AnaMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlKullanici.ResumeLayout(false);
            pnlKullanici.PerformLayout();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btnMusteriIslem;
        private Button btnSatisIslem;
        private Button button4;
        private Button btnUrunIslem;
        private Panel panel1;
        private Label label1;
        private Button btnRapor;
        private Button btnKullaniciYonetim;
        private Panel pnlKullanici;
        private Label lblAdSoyadBilgi;
        private Label label2;
        private Label lblRolBilgi;
        private Label lblKritikStok;
        private Label lblSaat;
        private System.Windows.Forms.Timer timerSaat;
    }
}