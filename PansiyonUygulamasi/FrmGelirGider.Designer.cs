
namespace PansiyonUygulamasi
{
    partial class FrmGelirGider
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblKasaToplam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPersonelMaas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblAlinanUrunler = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblFaturalar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasadaki Toplam Tutar :";
            // 
            // LblKasaToplam
            // 
            this.LblKasaToplam.AutoSize = true;
            this.LblKasaToplam.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKasaToplam.Location = new System.Drawing.Point(280, 55);
            this.LblKasaToplam.Name = "LblKasaToplam";
            this.LblKasaToplam.Size = new System.Drawing.Size(30, 24);
            this.LblKasaToplam.TabIndex = 1;
            this.LblKasaToplam.Text = "00";
            this.LblKasaToplam.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Maaşları :";
            // 
            // LblPersonelMaas
            // 
            this.LblPersonelMaas.AutoSize = true;
            this.LblPersonelMaas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPersonelMaas.Location = new System.Drawing.Point(280, 102);
            this.LblPersonelMaas.Name = "LblPersonelMaas";
            this.LblPersonelMaas.Size = new System.Drawing.Size(30, 24);
            this.LblPersonelMaas.TabIndex = 3;
            this.LblPersonelMaas.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(40, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alınan Ürünlerin Tutarı :";
            // 
            // LblAlinanUrunler
            // 
            this.LblAlinanUrunler.AutoSize = true;
            this.LblAlinanUrunler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAlinanUrunler.Location = new System.Drawing.Point(280, 151);
            this.LblAlinanUrunler.Name = "LblAlinanUrunler";
            this.LblAlinanUrunler.Size = new System.Drawing.Size(30, 24);
            this.LblAlinanUrunler.TabIndex = 5;
            this.LblAlinanUrunler.Text = "00";
            this.LblAlinanUrunler.Click += new System.EventHandler(this.LblAlinanUrunler_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(158, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Faturalar :";
            // 
            // LblFaturalar
            // 
            this.LblFaturalar.AutoSize = true;
            this.LblFaturalar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFaturalar.Location = new System.Drawing.Point(280, 195);
            this.LblFaturalar.Name = "LblFaturalar";
            this.LblFaturalar.Size = new System.Drawing.Size(30, 24);
            this.LblFaturalar.TabIndex = 7;
            this.LblFaturalar.Text = "00";
            this.LblFaturalar.Click += new System.EventHandler(this.LblFaturalar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(346, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Personel Sayısı :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(502, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 28);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(520, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(183, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Sonuç :";
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSonuc.Location = new System.Drawing.Point(280, 272);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(30, 24);
            this.LblSonuc.TabIndex = 12;
            this.LblSonuc.Text = "00";
            this.LblSonuc.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(3, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(718, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------";
            // 
            // FrmGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(724, 352);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblFaturalar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblAlinanUrunler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblPersonelMaas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblKasaToplam);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGelirGider";
            this.Text = "FrmGelirGider";
            this.Load += new System.EventHandler(this.FrmGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblKasaToplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPersonelMaas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblAlinanUrunler;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblFaturalar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblSonuc;
        private System.Windows.Forms.Label label12;
    }
}