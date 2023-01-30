using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_OTOGALERİ
{
    public partial class MÜŞTERİLER : Form
    {
        public MÜŞTERİLER()
        {
            InitializeComponent();
        }
        oto_galeriEntities db = new oto_galeriEntities();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox4.Text = openFileDialog1.FileName;
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            Müsteri müs = new Müsteri();
            müs.müsteri_adsoy = textBox_adsoy.Text;
            müs.müsteri_mail=textBox_mail.Text+comboBox1.Text;
            müs.müsteri_tc = maskedTextBox_tc.Text;
            müs.müsteri_tel=maskedTextBox_tel.Text;
            müs.müsteri_adres = textBox_adres.Text;
            müs.müsteri_dogumtar = dateTimePicker1.Value;
           
            müs.resim = textBox4.Text;
            db.Müsteri.Add(müs);

            db.SaveChanges();
            MessageBox.Show("Kaydedildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Müsteri.ToList();
            
            textBox_adsoy.Clear();
            textBox_mail.Clear();
            comboBox1.ResetText();
            maskedTextBox_tc.Clear();
            maskedTextBox_tel.Clear();
            textBox_adres.Clear();
 
            textBox4.Clear();


        }

        private void MÜŞTERİLER_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Müsteri.ToList();
        }

        private void button_güncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_no.Text);
            var xgüncel=db.Müsteri.Find(id);

            xgüncel.müsteri_adsoy = textBox_adsoy.Text;
            xgüncel.müsteri_mail = textBox_mail.Text + comboBox1.Text;
            xgüncel.müsteri_tc = maskedTextBox_tc.Text;
            xgüncel.müsteri_tel = maskedTextBox_tel.Text;
            xgüncel.müsteri_adres = textBox_adres.Text;
            xgüncel.müsteri_dogumtar = dateTimePicker1.Value;

            xgüncel.resim = textBox4.Text;

            db.SaveChanges();
            MessageBox.Show("Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Müsteri.ToList();

            textBox_adsoy.Clear();
            textBox_mail.Clear();
            comboBox1.ResetText();
            maskedTextBox_tc.Clear();
            maskedTextBox_tel.Clear();
            textBox_adres.Clear();
           
            textBox4.Clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_no.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_adsoy.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_mail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_tc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox_tel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_adres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
          
            textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Seçim_Ekranı fr=new Seçim_Ekranı();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            if(textBox_no.Text!="")
            {
                id= Convert.ToInt32(textBox_no.Text);
                var xsil = db.Müsteri.Find(id);

                if (xsil != null)
                {
                    db.Müsteri.Remove(xsil);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Silindi", "SİLME BİLGİSİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = db.Müsteri.ToList();
                }
                else
                {
                    MessageBox.Show("Böyle bir kayıt bulunmadı");
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen Alanı Doldurunuz");
            }
            
        }
    }
}
