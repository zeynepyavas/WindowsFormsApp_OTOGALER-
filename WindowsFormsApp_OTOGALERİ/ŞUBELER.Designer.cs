namespace WindowsFormsApp_OTOGALERİ
{
    partial class ŞUBELER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ŞUBELER));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_sno = new System.Windows.Forms.TextBox();
            this.textBox_sad = new System.Windows.Forms.TextBox();
            this.richTextBox_adres = new System.Windows.Forms.RichTextBox();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_güncelle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(762, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(804, 103);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ŞUBE NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŞUBE AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "ŞUBE ADRES:";
            // 
            // textBox_sno
            // 
            this.textBox_sno.Enabled = false;
            this.textBox_sno.Location = new System.Drawing.Point(162, 34);
            this.textBox_sno.Name = "textBox_sno";
            this.textBox_sno.Size = new System.Drawing.Size(100, 20);
            this.textBox_sno.TabIndex = 5;
            // 
            // textBox_sad
            // 
            this.textBox_sad.Location = new System.Drawing.Point(162, 66);
            this.textBox_sad.Name = "textBox_sad";
            this.textBox_sad.Size = new System.Drawing.Size(100, 20);
            this.textBox_sad.TabIndex = 6;
            // 
            // richTextBox_adres
            // 
            this.richTextBox_adres.Location = new System.Drawing.Point(162, 100);
            this.richTextBox_adres.Name = "richTextBox_adres";
            this.richTextBox_adres.Size = new System.Drawing.Size(100, 65);
            this.richTextBox_adres.TabIndex = 7;
            this.richTextBox_adres.Text = "";
            // 
            // button_ekle
            // 
            this.button_ekle.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ekle.Location = new System.Drawing.Point(49, 187);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(88, 33);
            this.button_ekle.TabIndex = 8;
            this.button_ekle.Text = "EKLE:";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button_güncelle
            // 
            this.button_güncelle.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_güncelle.Location = new System.Drawing.Point(157, 187);
            this.button_güncelle.Name = "button_güncelle";
            this.button_güncelle.Size = new System.Drawing.Size(105, 33);
            this.button_güncelle.TabIndex = 9;
            this.button_güncelle.Text = "GÜNCELLE:";
            this.button_güncelle.UseVisualStyleBackColor = true;
            this.button_güncelle.Click += new System.EventHandler(this.button_güncelle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sil.Location = new System.Drawing.Point(282, 187);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(88, 33);
            this.button_sil.TabIndex = 10;
            this.button_sil.Text = "SİL:";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // ŞUBELER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_güncelle);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.richTextBox_adres);
            this.Controls.Add(this.textBox_sad);
            this.Controls.Add(this.textBox_sno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "ŞUBELER";
            this.Text = "ŞUBELER";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_sno;
        private System.Windows.Forms.TextBox textBox_sad;
        private System.Windows.Forms.RichTextBox richTextBox_adres;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_güncelle;
        private System.Windows.Forms.Button button_sil;
    }
}