namespace WindowsFormsApp_OTOGALERİ
{
    partial class PERSONELLER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PERSONELLER));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_pno = new System.Windows.Forms.TextBox();
            this.textBox_padsoy = new System.Windows.Forms.TextBox();
            this.maskedTextBox_yas = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_tc = new System.Windows.Forms.MaskedTextBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.comboBox_mail = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_tel = new System.Windows.Forms.MaskedTextBox();
            this.richTextBox_adres = new System.Windows.Forms.RichTextBox();
            this.comboBox_şno = new System.Windows.Forms.ComboBox();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_güncelle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(763, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERSONEL NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD SOYAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "YAŞ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "TC NO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "TELEFON:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "ADRES:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "ŞUBE NO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "MAİL:";
            // 
            // textBox_pno
            // 
            this.textBox_pno.Enabled = false;
            this.textBox_pno.Location = new System.Drawing.Point(164, 38);
            this.textBox_pno.Name = "textBox_pno";
            this.textBox_pno.Size = new System.Drawing.Size(100, 20);
            this.textBox_pno.TabIndex = 9;
            // 
            // textBox_padsoy
            // 
            this.textBox_padsoy.Location = new System.Drawing.Point(164, 75);
            this.textBox_padsoy.Name = "textBox_padsoy";
            this.textBox_padsoy.Size = new System.Drawing.Size(100, 20);
            this.textBox_padsoy.TabIndex = 10;
            // 
            // maskedTextBox_yas
            // 
            this.maskedTextBox_yas.Location = new System.Drawing.Point(164, 110);
            this.maskedTextBox_yas.Mask = "000";
            this.maskedTextBox_yas.Name = "maskedTextBox_yas";
            this.maskedTextBox_yas.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_yas.TabIndex = 11;
            this.maskedTextBox_yas.ValidatingType = typeof(int);
            // 
            // maskedTextBox_tc
            // 
            this.maskedTextBox_tc.Location = new System.Drawing.Point(164, 141);
            this.maskedTextBox_tc.Mask = "00000000000";
            this.maskedTextBox_tc.Name = "maskedTextBox_tc";
            this.maskedTextBox_tc.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_tc.TabIndex = 12;
            this.maskedTextBox_tc.ValidatingType = typeof(int);
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(164, 167);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(100, 20);
            this.textBox_mail.TabIndex = 13;
            // 
            // comboBox_mail
            // 
            this.comboBox_mail.FormattingEnabled = true;
            this.comboBox_mail.Items.AddRange(new object[] {
            "@gmail.com",
            "@hotmail.com",
            "@yahoo.com"});
            this.comboBox_mail.Location = new System.Drawing.Point(270, 165);
            this.comboBox_mail.Name = "comboBox_mail";
            this.comboBox_mail.Size = new System.Drawing.Size(121, 21);
            this.comboBox_mail.TabIndex = 14;
            // 
            // maskedTextBox_tel
            // 
            this.maskedTextBox_tel.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.maskedTextBox_tel.Location = new System.Drawing.Point(164, 194);
            this.maskedTextBox_tel.Mask = "0000000000";
            this.maskedTextBox_tel.Name = "maskedTextBox_tel";
            this.maskedTextBox_tel.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_tel.TabIndex = 15;
            this.maskedTextBox_tel.ValidatingType = typeof(int);
            // 
            // richTextBox_adres
            // 
            this.richTextBox_adres.Location = new System.Drawing.Point(164, 222);
            this.richTextBox_adres.Name = "richTextBox_adres";
            this.richTextBox_adres.Size = new System.Drawing.Size(162, 37);
            this.richTextBox_adres.TabIndex = 16;
            this.richTextBox_adres.Text = "";
            // 
            // comboBox_şno
            // 
            this.comboBox_şno.FormattingEnabled = true;
            this.comboBox_şno.Location = new System.Drawing.Point(164, 266);
            this.comboBox_şno.Name = "comboBox_şno";
            this.comboBox_şno.Size = new System.Drawing.Size(121, 21);
            this.comboBox_şno.TabIndex = 17;
            // 
            // button_ekle
            // 
            this.button_ekle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ekle.Location = new System.Drawing.Point(60, 305);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(103, 23);
            this.button_ekle.TabIndex = 18;
            this.button_ekle.Text = "EKLE";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button_güncelle
            // 
            this.button_güncelle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_güncelle.Location = new System.Drawing.Point(169, 305);
            this.button_güncelle.Name = "button_güncelle";
            this.button_güncelle.Size = new System.Drawing.Size(103, 23);
            this.button_güncelle.TabIndex = 19;
            this.button_güncelle.Text = "GÜNCELLE";
            this.button_güncelle.UseVisualStyleBackColor = true;
            this.button_güncelle.Click += new System.EventHandler(this.button_güncelle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sil.Location = new System.Drawing.Point(288, 305);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(103, 23);
            this.button_sil.TabIndex = 20;
            this.button_sil.Text = "SİL";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-7, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 150);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PERSONELLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_güncelle);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.comboBox_şno);
            this.Controls.Add(this.richTextBox_adres);
            this.Controls.Add(this.maskedTextBox_tel);
            this.Controls.Add(this.comboBox_mail);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.maskedTextBox_tc);
            this.Controls.Add(this.maskedTextBox_yas);
            this.Controls.Add(this.textBox_padsoy);
            this.Controls.Add(this.textBox_pno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "PERSONELLER";
            this.Text = "PERSONELLER";
            this.Load += new System.EventHandler(this.PERSONELLER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_pno;
        private System.Windows.Forms.TextBox textBox_padsoy;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_yas;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_tc;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.ComboBox comboBox_mail;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_tel;
        private System.Windows.Forms.RichTextBox richTextBox_adres;
        private System.Windows.Forms.ComboBox comboBox_şno;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_güncelle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}