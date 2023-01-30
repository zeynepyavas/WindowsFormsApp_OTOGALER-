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
    public partial class Seçim_Ekranı : Form
    {
        public Seçim_Ekranı()
        {
            InitializeComponent();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void aRAÇLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MÜŞTERİLER fr = new MÜŞTERİLER();
            fr.Show();
            this.Hide();
        }

        private void şUBELERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ARAÇLAR fr =new ARAÇLAR();
            fr.Show();
            this.Hide();
        }

        private void pERSONELLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ŞUBELER fr = new ŞUBELER();
            fr.Show();
            this.Hide();
        }

        private void rAPORLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PERSONELLER fr = new PERSONELLER();
            fr.Show();
            this.Hide();
        }

        private void rAPORLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAPORLAR fr = new RAPORLAR();
            fr.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MÜŞTERİLER fr = new MÜŞTERİLER();
            fr.Show();
            this.Hide();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ARAÇLAR fr = new ARAÇLAR();
            fr.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PERSONELLER fr = new PERSONELLER();
            fr.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ŞUBELER fr= new ŞUBELER();
            fr.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            RAPORLAR fr = new RAPORLAR();
            fr.Show();
            this.Hide();

        }

        private void sATIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SATIŞ fr= new SATIŞ();
            fr.Show();
            this.Hide();
        }
    }
}
