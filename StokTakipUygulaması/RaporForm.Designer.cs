namespace StokSatisTakip
{
    partial class RaporForm
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
            btnKritik = new Button();
            btnKarZarar = new Button();
            dataGridView1 = new DataGridView();
            btnEnCok = new Button();
            btnAylik = new Button();
            btnMusteri = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnKritik
            // 
            btnKritik.Location = new Point(544, 54);
            btnKritik.Name = "btnKritik";
            btnKritik.Size = new Size(107, 72);
            btnKritik.TabIndex = 0;
            btnKritik.Text = "Kritik Stoklu Ürünler";
            btnKritik.UseVisualStyleBackColor = true;
            btnKritik.Click += btnKritik_Click_1;
            // 
            // btnKarZarar
            // 
            btnKarZarar.Location = new Point(544, 164);
            btnKarZarar.Name = "btnKarZarar";
            btnKarZarar.Size = new Size(107, 72);
            btnKarZarar.TabIndex = 1;
            btnKarZarar.Text = "Kar Zarar";
            btnKarZarar.UseVisualStyleBackColor = true;
            btnKarZarar.Click += btnKarZarar_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(432, 342);
            dataGridView1.TabIndex = 2;
            // 
            // btnEnCok
            // 
            btnEnCok.Location = new Point(681, 54);
            btnEnCok.Name = "btnEnCok";
            btnEnCok.Size = new Size(107, 72);
            btnEnCok.TabIndex = 3;
            btnEnCok.Text = "En Çok Satanlar";
            btnEnCok.UseVisualStyleBackColor = true;
            btnEnCok.Click += btnEnCok_Click;
            // 
            // btnAylik
            // 
            btnAylik.Location = new Point(544, 283);
            btnAylik.Name = "btnAylik";
            btnAylik.Size = new Size(107, 72);
            btnAylik.TabIndex = 4;
            btnAylik.Text = "Aylık Satış";
            btnAylik.UseVisualStyleBackColor = true;
            btnAylik.Click += btnAylik_Click;
            // 
            // btnMusteri
            // 
            btnMusteri.Location = new Point(681, 164);
            btnMusteri.Name = "btnMusteri";
            btnMusteri.Size = new Size(107, 72);
            btnMusteri.TabIndex = 5;
            btnMusteri.Text = "Müşteri Raporu";
            btnMusteri.UseVisualStyleBackColor = true;
            btnMusteri.Click += btnMusteri_Click;
            // 
            // RaporForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMusteri);
            Controls.Add(btnAylik);
            Controls.Add(btnEnCok);
            Controls.Add(dataGridView1);
            Controls.Add(btnKarZarar);
            Controls.Add(btnKritik);
            Name = "RaporForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RaporForm";
            Load += RaporForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKritik;
        private Button btnKarZarar;
        private DataGridView dataGridView1;
        private Button btnEnCok;
        private Button btnAylik;
        private Button btnMusteri;
    }
}