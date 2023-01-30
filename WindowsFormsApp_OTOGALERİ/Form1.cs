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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        oto_galeriEntities db = new oto_galeriEntities();

        private void button_GİRİS_Click(object sender, EventArgs e)
        {
            var query = from x in db.giris
                        where x.kullanıcı_adı == textBox1.Text &
                        x.sifre == textBox2.Text
                        select x;
            if (query.Any())
            {
                Seçim_Ekranı fr = new Seçim_Ekranı();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı","UYARI!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanıcı_Kayıt fr = new Kullanıcı_Kayıt();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
