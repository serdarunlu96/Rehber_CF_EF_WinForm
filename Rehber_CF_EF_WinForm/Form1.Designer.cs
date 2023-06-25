namespace Rehber_CF_EF_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbYeniOlustur = new GroupBox();
            btnEkle = new Button();
            txtTelefon = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grbBul = new GroupBox();
            btnAra = new Button();
            btnGuncelle = new Button();
            txtAdSoyad = new TextBox();
            label6 = new Label();
            label5 = new Label();
            grbRehber = new GroupBox();
            btnSil = new Button();
            dgvRehber = new DataGridView();
            label7 = new Label();
            grbYeniOlustur.SuspendLayout();
            grbBul.SuspendLayout();
            grbRehber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRehber).BeginInit();
            SuspendLayout();
            // 
            // grbYeniOlustur
            // 
            grbYeniOlustur.Controls.Add(btnEkle);
            grbYeniOlustur.Controls.Add(txtTelefon);
            grbYeniOlustur.Controls.Add(txtSoyad);
            grbYeniOlustur.Controls.Add(txtAd);
            grbYeniOlustur.Controls.Add(label4);
            grbYeniOlustur.Controls.Add(label3);
            grbYeniOlustur.Controls.Add(label2);
            grbYeniOlustur.Controls.Add(label1);
            grbYeniOlustur.Location = new Point(25, 16);
            grbYeniOlustur.Name = "grbYeniOlustur";
            grbYeniOlustur.Size = new Size(328, 231);
            grbYeniOlustur.TabIndex = 0;
            grbYeniOlustur.TabStop = false;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(76, 174);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(217, 23);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "REHBERE EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(76, 131);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(217, 23);
            txtTelefon.TabIndex = 8;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(76, 93);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(217, 23);
            txtSoyad.TabIndex = 7;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(76, 57);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(217, 23);
            txtAd.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 134);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 5;
            label4.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 101);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Soyadı: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 65);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Yeni Olustur";
            // 
            // grbBul
            // 
            grbBul.Controls.Add(btnAra);
            grbBul.Controls.Add(btnGuncelle);
            grbBul.Controls.Add(txtAdSoyad);
            grbBul.Controls.Add(label6);
            grbBul.Controls.Add(label5);
            grbBul.Location = new Point(383, 16);
            grbBul.Name = "grbBul";
            grbBul.Size = new Size(328, 231);
            grbBul.TabIndex = 1;
            grbBul.TabStop = false;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(247, 92);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 11;
            btnAra.Text = "Kisi Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(37, 174);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(190, 23);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "GUNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(28, 93);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(199, 23);
            txtAdSoyad.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 60);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 3;
            label6.Text = "Adı veya Soyadı: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 19);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 3;
            label5.Text = "BUL";
            // 
            // grbRehber
            // 
            grbRehber.Controls.Add(btnSil);
            grbRehber.Controls.Add(dgvRehber);
            grbRehber.Controls.Add(label7);
            grbRehber.Location = new Point(25, 262);
            grbRehber.Name = "grbRehber";
            grbRehber.Size = new Size(686, 340);
            grbRehber.TabIndex = 2;
            grbRehber.TabStop = false;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(605, 311);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 3;
            btnSil.Text = "SIL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvRehber
            // 
            dgvRehber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRehber.Location = new Point(1, 57);
            dgvRehber.Name = "dgvRehber";
            dgvRehber.RowTemplate.Height = 25;
            dgvRehber.Size = new Size(685, 233);
            dgvRehber.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 34);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 1;
            label7.Text = "REHBER";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 614);
            Controls.Add(grbRehber);
            Controls.Add(grbBul);
            Controls.Add(grbYeniOlustur);
            Name = "Form1";
            Text = "Form1";
            grbYeniOlustur.ResumeLayout(false);
            grbYeniOlustur.PerformLayout();
            grbBul.ResumeLayout(false);
            grbBul.PerformLayout();
            grbRehber.ResumeLayout(false);
            grbRehber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRehber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbYeniOlustur;
        private Button btnEkle;
        private TextBox txtTelefon;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grbBul;
        private Button btnAra;
        private Button btnGuncelle;
        private TextBox txtAdSoyad;
        private Label label6;
        private Label label5;
        private GroupBox grbRehber;
        private DataGridView dgvRehber;
        private Label label7;
        private Button btnSil;
    }
}