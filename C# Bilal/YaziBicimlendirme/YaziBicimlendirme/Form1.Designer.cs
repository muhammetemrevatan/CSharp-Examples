namespace YaziBicimlendirme
{
    partial class Form1
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
            this.font_arttir = new System.Windows.Forms.Label();
            this.font_azalt = new System.Windows.Forms.Label();
            this.kalin = new System.Windows.Forms.CheckBox();
            this.alti_cizili = new System.Windows.Forms.CheckBox();
            this.italik = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sol = new System.Windows.Forms.RadioButton();
            this.orta = new System.Windows.Forms.RadioButton();
            this.sag = new System.Windows.Forms.RadioButton();
            this.metin_alani = new System.Windows.Forms.TextBox();
            this.kirmizi = new System.Windows.Forms.Button();
            this.mavi = new System.Windows.Forms.Button();
            this.pembe = new System.Windows.Forms.Button();
            this.kopyala = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stil";
            // 
            // font_arttir
            // 
            this.font_arttir.AutoSize = true;
            this.font_arttir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.font_arttir.Location = new System.Drawing.Point(288, 9);
            this.font_arttir.Name = "font_arttir";
            this.font_arttir.Size = new System.Drawing.Size(29, 20);
            this.font_arttir.TabIndex = 1;
            this.font_arttir.Text = "A+";
            this.font_arttir.Click += new System.EventHandler(this.font_arttir_Click);
            // 
            // font_azalt
            // 
            this.font_azalt.AutoSize = true;
            this.font_azalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.font_azalt.Location = new System.Drawing.Point(345, 9);
            this.font_azalt.Name = "font_azalt";
            this.font_azalt.Size = new System.Drawing.Size(25, 20);
            this.font_azalt.TabIndex = 2;
            this.font_azalt.Text = "A-";
            this.font_azalt.Click += new System.EventHandler(this.font_azalt_Click);
            // 
            // kalin
            // 
            this.kalin.AutoSize = true;
            this.kalin.Location = new System.Drawing.Point(13, 46);
            this.kalin.Name = "kalin";
            this.kalin.Size = new System.Drawing.Size(49, 17);
            this.kalin.TabIndex = 3;
            this.kalin.Text = "Kalın";
            this.kalin.UseVisualStyleBackColor = true;
            this.kalin.CheckedChanged += new System.EventHandler(this.kalin_CheckedChanged);
            // 
            // alti_cizili
            // 
            this.alti_cizili.AutoSize = true;
            this.alti_cizili.Location = new System.Drawing.Point(73, 46);
            this.alti_cizili.Name = "alti_cizili";
            this.alti_cizili.Size = new System.Drawing.Size(62, 17);
            this.alti_cizili.TabIndex = 4;
            this.alti_cizili.Text = "Altı çizili";
            this.alti_cizili.UseVisualStyleBackColor = true;
            this.alti_cizili.CheckedChanged += new System.EventHandler(this.alti_cizili_CheckedChanged);
            // 
            // italik
            // 
            this.italik.AutoSize = true;
            this.italik.Location = new System.Drawing.Point(141, 46);
            this.italik.Name = "italik";
            this.italik.Size = new System.Drawing.Size(48, 17);
            this.italik.TabIndex = 5;
            this.italik.Text = "İtalik";
            this.italik.UseVisualStyleBackColor = true;
            this.italik.CheckedChanged += new System.EventHandler(this.italik_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(551, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yön";
            // 
            // sol
            // 
            this.sol.AutoSize = true;
            this.sol.Location = new System.Drawing.Point(481, 46);
            this.sol.Name = "sol";
            this.sol.Size = new System.Drawing.Size(40, 17);
            this.sol.TabIndex = 7;
            this.sol.TabStop = true;
            this.sol.Text = "Sol";
            this.sol.UseVisualStyleBackColor = true;
            this.sol.CheckedChanged += new System.EventHandler(this.sol_CheckedChanged);
            // 
            // orta
            // 
            this.orta.AutoSize = true;
            this.orta.Location = new System.Drawing.Point(549, 46);
            this.orta.Name = "orta";
            this.orta.Size = new System.Drawing.Size(45, 17);
            this.orta.TabIndex = 8;
            this.orta.TabStop = true;
            this.orta.Text = "Orta";
            this.orta.UseVisualStyleBackColor = true;
            this.orta.CheckedChanged += new System.EventHandler(this.orta_CheckedChanged);
            // 
            // sag
            // 
            this.sag.AutoSize = true;
            this.sag.Location = new System.Drawing.Point(616, 46);
            this.sag.Name = "sag";
            this.sag.Size = new System.Drawing.Size(44, 17);
            this.sag.TabIndex = 9;
            this.sag.TabStop = true;
            this.sag.Text = "Sağ";
            this.sag.UseVisualStyleBackColor = true;
            this.sag.CheckedChanged += new System.EventHandler(this.sag_CheckedChanged);
            // 
            // metin_alani
            // 
            this.metin_alani.Location = new System.Drawing.Point(13, 86);
            this.metin_alani.Multiline = true;
            this.metin_alani.Name = "metin_alani";
            this.metin_alani.Size = new System.Drawing.Size(690, 114);
            this.metin_alani.TabIndex = 10;
            // 
            // kirmizi
            // 
            this.kirmizi.BackColor = System.Drawing.Color.Red;
            this.kirmizi.Location = new System.Drawing.Point(13, 207);
            this.kirmizi.Name = "kirmizi";
            this.kirmizi.Size = new System.Drawing.Size(261, 23);
            this.kirmizi.TabIndex = 11;
            this.kirmizi.UseVisualStyleBackColor = false;
            this.kirmizi.Click += new System.EventHandler(this.kirmizi_Click);
            // 
            // mavi
            // 
            this.mavi.BackColor = System.Drawing.Color.Blue;
            this.mavi.Location = new System.Drawing.Point(280, 207);
            this.mavi.Name = "mavi";
            this.mavi.Size = new System.Drawing.Size(228, 23);
            this.mavi.TabIndex = 12;
            this.mavi.UseVisualStyleBackColor = false;
            this.mavi.Click += new System.EventHandler(this.mavi_Click);
            // 
            // pembe
            // 
            this.pembe.BackColor = System.Drawing.Color.Fuchsia;
            this.pembe.Location = new System.Drawing.Point(514, 207);
            this.pembe.Name = "pembe";
            this.pembe.Size = new System.Drawing.Size(189, 23);
            this.pembe.TabIndex = 13;
            this.pembe.UseVisualStyleBackColor = false;
            this.pembe.Click += new System.EventHandler(this.pembe_Click);
            // 
            // kopyala
            // 
            this.kopyala.BackColor = System.Drawing.Color.Lime;
            this.kopyala.Location = new System.Drawing.Point(203, 262);
            this.kopyala.Name = "kopyala";
            this.kopyala.Size = new System.Drawing.Size(151, 34);
            this.kopyala.TabIndex = 14;
            this.kopyala.Text = "Kopyala";
            this.kopyala.UseVisualStyleBackColor = false;
            this.kopyala.Click += new System.EventHandler(this.button1_Click);
            // 
            // temizle
            // 
            this.temizle.BackColor = System.Drawing.Color.Red;
            this.temizle.Location = new System.Drawing.Point(356, 262);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(151, 34);
            this.temizle.TabIndex = 15;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = false;
            this.temizle.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(715, 308);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.kopyala);
            this.Controls.Add(this.pembe);
            this.Controls.Add(this.mavi);
            this.Controls.Add(this.kirmizi);
            this.Controls.Add(this.metin_alani);
            this.Controls.Add(this.sag);
            this.Controls.Add(this.orta);
            this.Controls.Add(this.sol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.italik);
            this.Controls.Add(this.alti_cizili);
            this.Controls.Add(this.kalin);
            this.Controls.Add(this.font_azalt);
            this.Controls.Add(this.font_arttir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label font_arttir;
        private System.Windows.Forms.Label font_azalt;
        private System.Windows.Forms.CheckBox kalin;
        private System.Windows.Forms.CheckBox alti_cizili;
        private System.Windows.Forms.CheckBox italik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton sol;
        private System.Windows.Forms.RadioButton orta;
        private System.Windows.Forms.RadioButton sag;
        private System.Windows.Forms.TextBox metin_alani;
        private System.Windows.Forms.Button kirmizi;
        private System.Windows.Forms.Button mavi;
        private System.Windows.Forms.Button pembe;
        private System.Windows.Forms.Button kopyala;
        private System.Windows.Forms.Button temizle;
    }
}

