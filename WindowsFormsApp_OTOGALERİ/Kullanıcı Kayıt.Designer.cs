namespace WindowsFormsApp_OTOGALERİ
{
    partial class Kullanıcı_Kayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanıcı_Kayıt));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_soy = new System.Windows.Forms.TextBox();
            this.textBox_kullanıcı = new System.Windows.Forms.TextBox();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.textBox_sifretekrar = new System.Windows.Forms.TextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "KULLANICI ADI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "ŞİFRE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ŞİFRE TEKRAR:";
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(155, 18);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(100, 20);
            this.textBox_ad.TabIndex = 5;
            // 
            // textBox_soy
            // 
            this.textBox_soy.Location = new System.Drawing.Point(155, 49);
            this.textBox_soy.Name = "textBox_soy";
            this.textBox_soy.Size = new System.Drawing.Size(100, 20);
            this.textBox_soy.TabIndex = 6;
            // 
            // textBox_kullanıcı
            // 
            this.textBox_kullanıcı.Location = new System.Drawing.Point(155, 75);
            this.textBox_kullanıcı.Name = "textBox_kullanıcı";
            this.textBox_kullanıcı.Size = new System.Drawing.Size(100, 20);
            this.textBox_kullanıcı.TabIndex = 7;
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(155, 104);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(100, 20);
            this.textBox_sifre.TabIndex = 8;
            this.textBox_sifre.UseSystemPasswordChar = true;
            // 
            // textBox_sifretekrar
            // 
            this.textBox_sifretekrar.Location = new System.Drawing.Point(155, 134);
            this.textBox_sifretekrar.Name = "textBox_sifretekrar";
            this.textBox_sifretekrar.Size = new System.Drawing.Size(100, 20);
            this.textBox_sifretekrar.TabIndex = 9;
            this.textBox_sifretekrar.UseSystemPasswordChar = true;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(155, 185);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(100, 37);
            this.button_kaydet.TabIndex = 10;
            this.button_kaydet.Text = "KAYDET";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "İPTAL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kullanıcı_Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.textBox_sifretekrar);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.textBox_kullanıcı);
            this.Controls.Add(this.textBox_soy);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kullanıcı_Kayıt";
            this.Text = "Kullanıcı_Kayıt";
            this.Load += new System.EventHandler(this.Kullanıcı_Kayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.TextBox textBox_soy;
        private System.Windows.Forms.TextBox textBox_kullanıcı;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.TextBox textBox_sifretekrar;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button1;
    }
}