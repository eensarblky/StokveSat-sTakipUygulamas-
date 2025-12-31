
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
            btnMusteriIslem = new Button();
            btnSatisIslem = new Button();
            button4 = new Button();
            btnUrunIslem = new Button();
            panel1 = new Panel();
            btnRapor = new Button();
            label1 = new Label();
            btnKullaniciYonetim = new Button();
            panel1.SuspendLayout();
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
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(901, 531);
            button4.Name = "button4";
            button4.Size = new Size(87, 57);
            button4.TabIndex = 3;
            button4.Text = "Çıkış";
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
            panel1.Controls.Add(btnKullaniciYonetim);
            panel1.Controls.Add(btnRapor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnUrunIslem);
            panel1.Controls.Add(btnMusteriIslem);
            panel1.Controls.Add(btnSatisIslem);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 600);
            panel1.TabIndex = 5;
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
    }
}