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
    public partial class SATIŞ : Form
    {
        public SATIŞ()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        oto_galeriEntities db = new oto_galeriEntities();

        public void musteriler()
        {
            var query = from x in db.Müsteri
                        select new
                        {
                            x.müsteri_id,
                            x.müsteri_adsoy,
                            x.müsteri_tc,
                            x.müsteri_tel,
                        };
            dataGridView2.DataSource = query.ToList();
        }

        public void araclar()
        {
            var query = from x1 in db.Araç
                        join x2 in db.Sube
                        on x1.sube_id equals x2.sube_id
                       
                        select new
                        {
                            x1.arac_id,
                            x1.arac_fiyat,
                            x1.arac_adet,
                            x1.arac_marka,
                            x1.arac_model,
                            x1.arac_yıl,
                            x1.arac_yakıt,
                            x1.arac_vites,
                            x1.arac_renk,
                            x2.sube_adı,
                        };
            dataGridView1.DataSource = query.ToList();
        }
        private void SATIŞ_Load(object sender, EventArgs e)
        {
            araclar();
            musteriler();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_no.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_adsoy.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox_tc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_tel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
