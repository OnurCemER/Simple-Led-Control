namespace ChecboxLed
{
    partial class formArduinoLed
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBaglanti = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnYak = new System.Windows.Forms.Button();
            this.btnSondur = new System.Windows.Forms.Button();
            this.checkKirmizi = new System.Windows.Forms.CheckBox();
            this.checkYesil = new System.Windows.Forms.CheckBox();
            this.checkSari = new System.Windows.Forms.CheckBox();
            this.checkMavi = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYenile);
            this.groupBox1.Controls.Add(this.btnBaglanti);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağlantı Seçenekleri";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnBaglanti
            // 
            this.btnBaglanti.Location = new System.Drawing.Point(186, 19);
            this.btnBaglanti.Name = "btnBaglanti";
            this.btnBaglanti.Size = new System.Drawing.Size(125, 32);
            this.btnBaglanti.TabIndex = 1;
            this.btnBaglanti.Text = "Bağlan";
            this.btnBaglanti.UseVisualStyleBackColor = true;
            this.btnBaglanti.Click += new System.EventHandler(this.btnBaglanti_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(186, 57);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(125, 32);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkMavi);
            this.groupBox2.Controls.Add(this.checkSari);
            this.groupBox2.Controls.Add(this.checkYesil);
            this.groupBox2.Controls.Add(this.checkKirmizi);
            this.groupBox2.Controls.Add(this.btnSondur);
            this.groupBox2.Controls.Add(this.btnYak);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Led Kontrolleri";
            // 
            // btnYak
            // 
            this.btnYak.Location = new System.Drawing.Point(150, 67);
            this.btnYak.Name = "btnYak";
            this.btnYak.Size = new System.Drawing.Size(144, 38);
            this.btnYak.TabIndex = 0;
            this.btnYak.Text = "Hepsini Yak";
            this.btnYak.UseVisualStyleBackColor = true;
            this.btnYak.Click += new System.EventHandler(this.btnYak_Click);
            // 
            // btnSondur
            // 
            this.btnSondur.Location = new System.Drawing.Point(150, 19);
            this.btnSondur.Name = "btnSondur";
            this.btnSondur.Size = new System.Drawing.Size(144, 38);
            this.btnSondur.TabIndex = 0;
            this.btnSondur.Text = "Hepsini Söndür";
            this.btnSondur.UseVisualStyleBackColor = true;
            this.btnSondur.Click += new System.EventHandler(this.btnSondur_Click);
            // 
            // checkKirmizi
            // 
            this.checkKirmizi.AutoSize = true;
            this.checkKirmizi.Location = new System.Drawing.Point(14, 36);
            this.checkKirmizi.Name = "checkKirmizi";
            this.checkKirmizi.Size = new System.Drawing.Size(55, 17);
            this.checkKirmizi.TabIndex = 1;
            this.checkKirmizi.Text = "Kırmızı";
            this.checkKirmizi.UseVisualStyleBackColor = true;
            this.checkKirmizi.CheckedChanged += new System.EventHandler(this.checkKirmizi_CheckedChanged);
            // 
            // checkYesil
            // 
            this.checkYesil.AutoSize = true;
            this.checkYesil.Location = new System.Drawing.Point(75, 36);
            this.checkYesil.Name = "checkYesil";
            this.checkYesil.Size = new System.Drawing.Size(48, 17);
            this.checkYesil.TabIndex = 1;
            this.checkYesil.Text = "Yeşil";
            this.checkYesil.UseVisualStyleBackColor = true;
            this.checkYesil.CheckedChanged += new System.EventHandler(this.checkKirmizi_CheckedChanged);
            // 
            // checkSari
            // 
            this.checkSari.AutoSize = true;
            this.checkSari.Location = new System.Drawing.Point(14, 72);
            this.checkSari.Name = "checkSari";
            this.checkSari.Size = new System.Drawing.Size(44, 17);
            this.checkSari.TabIndex = 1;
            this.checkSari.Text = "Sarı";
            this.checkSari.UseVisualStyleBackColor = true;
            this.checkSari.CheckedChanged += new System.EventHandler(this.checkKirmizi_CheckedChanged);
            // 
            // checkMavi
            // 
            this.checkMavi.AutoSize = true;
            this.checkMavi.Location = new System.Drawing.Point(75, 72);
            this.checkMavi.Name = "checkMavi";
            this.checkMavi.Size = new System.Drawing.Size(49, 17);
            this.checkMavi.TabIndex = 1;
            this.checkMavi.Text = "Mavi";
            this.checkMavi.UseVisualStyleBackColor = true;
            this.checkMavi.CheckedChanged += new System.EventHandler(this.checkKirmizi_CheckedChanged);
            // 
            // formArduinoLed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formArduinoLed";
            this.Text = "Arduino Led Kontrolü";
            this.Load += new System.EventHandler(this.formArduinoLed_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnBaglanti;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkMavi;
        private System.Windows.Forms.CheckBox checkSari;
        private System.Windows.Forms.CheckBox checkYesil;
        private System.Windows.Forms.CheckBox checkKirmizi;
        private System.Windows.Forms.Button btnSondur;
        private System.Windows.Forms.Button btnYak;
    }
}

