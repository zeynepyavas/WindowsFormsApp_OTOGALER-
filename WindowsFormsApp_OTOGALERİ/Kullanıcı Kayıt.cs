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
    public partial class Kullanıcı_Kayıt : Form
    {
        public Kullanıcı_Kayıt()
        {
            InitializeComponent();
        }

        oto_galeriEntities db = new oto_galeriEntities();
        private void button_kaydet_Click(object sender, EventArgs e)
        {
            giris grs = new giris();
            if (textBox_ad.Text == "" || textBox_soy.Text == "" ||
                textBox_kullanıcı.Text == "" || textBox_sifre.Text == ""
                || textBox_sifretekrar.Text == "")
            {
                MessageBox.Show("Boş Alanları Doldurunuz");
            }
            else if (textBox_sifre.Text != textBox_sifretekrar.Text)
            {
                MessageBox.Show("Şifreler uymuyor");
            }
            else
            {
                grs.ad = textBox_ad.Text;
                grs.soyad = textBox_soy.Text;
                grs.kullanıcı_adı = textBox_kullanıcı.Text;
                grs.sifre = textBox_sifre.Text;
                grs.sifre_tekrar = textBox_sifretekrar.Text;
                db.giris.Add(grs);
                db.SaveChanges();
                MessageBox.Show("Kaydedildi.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }





            
        }

        private void Kullanıcı_Kayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
