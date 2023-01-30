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
    public partial class RAPORLAR : Form
    {
        public RAPORLAR()
        {
            InitializeComponent();
        }
        oto_galeriEntities db= new oto_galeriEntities();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Seçim_Ekranı fr = new Seçim_Ekranı();
            fr.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                List<Müsteri> LİST1= db.Müsteri.OrderBy(X=>X.müsteri_adsoy).ToList();
                dataGridView1.DataSource = LİST1;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if( radioButton2.Checked==true)
            {
                List<Araç> LİST2 = db.Araç.OrderBy(X => X.arac_model).ToList();
                dataGridView1.DataSource = LİST2;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked==true)
            {
                List<Araç> LİST3 = db.Araç.OrderBy(X => X.arac_fiyat).ToList();
                dataGridView1.DataSource = LİST3;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked==true)
            {
                MessageBox.Show("Farklı Marka Sayısı" + (from x in db.Araç select x.arac_marka).Distinct().Count().ToString());

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked==true)
            {
                MessageBox.Show("Toplam Personel Sayısı"+db.Personel.GroupBy(p=>p.personel_id).Count().ToString());
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if( radioButton6.Checked==true)
            {
                List<Araç> LİST6 = db.Araç.OrderBy(X => X.arac_marka).ToList();
                dataGridView1.DataSource = LİST6;
            }
        }
    }
}
