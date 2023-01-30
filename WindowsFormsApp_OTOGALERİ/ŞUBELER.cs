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
    public partial class ŞUBELER : Form
    {
        public ŞUBELER()
        {
            InitializeComponent();
        }

        oto_galeriEntities db=new oto_galeriEntities();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Seçim_Ekranı fr = new Seçim_Ekranı();
            fr.Show();
            this.Hide();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            Sube sb =new Sube();
            sb.sube_adı = textBox_sad.Text;
            sb.sube_adres = richTextBox_adres.Text;

            db.Sube.Add(sb);
            db.SaveChanges();

            MessageBox.Show("Kaydedildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Sube.ToList();

            textBox_sad.Clear();
            richTextBox_adres.ResetText();


        }

        private void button_güncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_sno.Text);
            var xgüncel = db.Sube.Find(id);

            xgüncel.sube_adı=textBox_sad.Text;
            xgüncel.sube_adres = richTextBox_adres.Text;

            db.SaveChanges();
            MessageBox.Show("Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Sube.ToList();

            textBox_sad.Clear();
            richTextBox_adres.ResetText();

        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            int id;
            if (textBox_sno.Text != "")
            {
                id = Convert.ToInt32(textBox_sno.Text);
                var xsil = db.Sube.Find(id);

                if (xsil != null)
                {
                    db.Sube.Remove(xsil);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Silindi", "SİLME BİLGİSİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = db.Sube.ToList();
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
            textBox_sno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_sad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBox_adres.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
