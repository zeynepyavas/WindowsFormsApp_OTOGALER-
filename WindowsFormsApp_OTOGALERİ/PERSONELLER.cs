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
    public partial class PERSONELLER : Form
    {
        public PERSONELLER()
        {
            InitializeComponent();
        }
        oto_galeriEntities db = new oto_galeriEntities();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Seçim_Ekranı fr = new Seçim_Ekranı();
            fr.Show();
            this.Hide();
        }

        private void PERSONELLER_Load(object sender, EventArgs e)
        {
            comboBox_şno.DataSource = db.Sube.ToList();
            comboBox_şno.ValueMember = "sube_id";
            comboBox_şno.DisplayMember = "sube_adı";

            dataGridView1.DataSource = db.Personel.ToList();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.personel_adsoy = textBox_padsoy.Text;
            personel.yas = int.Parse(maskedTextBox_yas.Text);
            personel.tc = maskedTextBox_tc.Text;
            personel.mail = textBox_mail.Text + comboBox_mail.Text;
            personel.telefon = int.Parse(maskedTextBox_tel.Text);
            personel.adres = richTextBox_adres.Text;
            personel.sube_id = int.Parse(comboBox_şno.SelectedValue.ToString());


            db.Personel.Add(personel);

            db.SaveChanges();
            MessageBox.Show("Kaydedildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Personel.ToList();

            textBox_padsoy.Clear();
            maskedTextBox_yas.ResetText();
            maskedTextBox_tc.ResetText();
            textBox_mail.Clear();
            comboBox_mail.ResetText();
            maskedTextBox_tel.ResetText();
            richTextBox_adres.ResetText();
            comboBox_şno.ResetText();
        }

        private void button_güncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_pno.Text);
            var xgüncel = db.Personel.Find(id);

            xgüncel.personel_adsoy = textBox_padsoy.Text;
            xgüncel.yas = int.Parse(maskedTextBox_yas.Text);
            xgüncel.tc = maskedTextBox_tc.Text;
            xgüncel.mail = textBox_mail.Text + comboBox_mail.Text;
            xgüncel.telefon = int.Parse(maskedTextBox_tel.Text);
            xgüncel.adres = richTextBox_adres.Text;
            xgüncel.sube_id = int.Parse(comboBox_şno.Text);

            db.SaveChanges();
            MessageBox.Show("Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Personel.ToList();

            textBox_padsoy.Clear();
            maskedTextBox_yas.ResetText();
            maskedTextBox_tc.ResetText();
            textBox_mail.Clear();
            comboBox_mail.ResetText();
            maskedTextBox_tel.ResetText();
            richTextBox_adres.ResetText();
            comboBox_şno.ResetText();

        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            int id;
            if (textBox_pno.Text != "")
            {
                id = Convert.ToInt32(textBox_pno.Text);
                var xsil = db.Araç.Find(id);

                if (xsil != null)
                {
                    db.Araç.Remove(xsil);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Silindi", "SİLME BİLGİSİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = db.Personel.ToList();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_pno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_padsoy.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox_yas.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_tc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_mail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox_mail.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            maskedTextBox_tel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            richTextBox_adres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox_şno.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString(); 

        }
    }
}