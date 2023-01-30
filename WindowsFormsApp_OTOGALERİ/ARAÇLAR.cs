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
    public partial class ARAÇLAR : Form
    {
        public ARAÇLAR()
        {
            InitializeComponent();
        }

        private void comboBox_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            string[] marka = { "AUDİ", "BMW", "CITROEN", "DACIA", "FERRARİ", "FIAT", "FORD", "KIA", "LAMBORGHİNİ", "LEXUS", "MERCEDES-BENZ", "MITSUBISHI", "NİSSAN", "OPEL", "PEUGEOT", "RENAULT", "SEAT", "SKODA", "TOYOTO", "VOLKSWAGEN", "VOLVO" };
            comboBox_marka.Items.AddRange(marka);

            if (comboBox_marka.Text == "AUDİ")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { " Audi A1 Sportback", "Audi A3 Sportback", "Audi A3 Sedan", " Audi A3 Cabrio", "Audi A4 Sedan", "Audi A4 Avant", "Audi A4 Allroad", " Aud A5 Coupe", "Audi A5 Sportback", "Audi A6 Sedan", " Audi A6 Avant", "Audi A6 Allroad", "Audi A7 Sportback", " Audi A8 Long", "Audi Q2", "Audi Q3", "Audi Q5", " Audi Q7", " Audi Q8", "Audi TTC", "Audi R8" };
                comboBox_model.Items.AddRange(model);
            }
            if (comboBox_marka.Text == "BMW")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "BMW 1 Serisi", "BMW 2 Serisi Active Tourer", "BMW 2 Serisi Gran Coupé", "BMW 3 Serisi Sedan", "BMW 4 Serisi Coupé", "BMW 4 Serisi Cabrio", "BMW M550d xDrive Sedan", "BMW 5 Serisi Sedan", "BMW 6 Serisi Gran Turismo", "BMW 7 Serisi Sedan", "BMW 8 Serisi Coupé", "BMW 8 Serisi Coupé", "BMW X2", "BMW X3", "BMW Z4", "YENİ BMW i4" };

                comboBox_model.Items.AddRange(model);


            }
            if (comboBox_marka.Text == "CITROEN")
            {


                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "AMI.", "C3", "YENİ C5 AIRCROSS SUV", "C-ELYSÉE", "BERLINGO", "JUMPY SPACE & SPACETOURER", "BERLINGO VAN", "JUMPY" };
                comboBox_model.Items.AddRange(model);
            }
            if (comboBox_marka.Text == "DACIA")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "Duster", "Sandero", "Logan MCV", "Dokker", "Lodgy", "Logan", "Solenza", " 1310" };
                comboBox_model.Items.AddRange(model);
            }
            if (comboBox_marka.Text == "FERRARİ")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "FERRARİ 812 GTS","FERRARİ 296 GTS","FERRARİ 296 GTB","FERRARİ SF90 STRADALE","FERRARİ F8 TRİBUTO","FERRARİ ROMA","FERRARİ PORTOFİNO","FERRARİ LAFERRARİ" };
                comboBox_model.Items.AddRange(model);
            }
            if (comboBox_marka.Text == "FIAT")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "Egea Cross","Egea Cross Wagon","Egea Sedan","Egea Hatchback","Egea Statıon Wagon","Fiat Panda Ailesi"};
                comboBox_model.Items.AddRange(model);
            }
            if (comboBox_marka.Text == "FORD")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "Fiesta","Focus","EcoSport","Puma","Kuga","Mondeo","Tourneo Courier","Edge" };
                comboBox_model.Items.AddRange(model);
            }
            if (comboBox_marka.Text == "KIA")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = {"Picanto","Rio","Stonic","Yeni Cerato","Ceed HB","Ceed SW","Yeni XCeed","Yeni Niro Hibrit"};
                comboBox_model.Items.AddRange(model);
            }
            if (comboBox_marka.Text == "LAMBORGHİNİ")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "Urus","Aventador","Diablo","Gallardo","Huracan" };
                comboBox_model.Items.AddRange(model);
            }
            if (comboBox_marka.Text == "LEXUS")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = {"ES.ELEGANT SEDAN","LS.ÜST DÜZEY SEDAN","RX.LÜKS CROSSOVER","RX L.LÜKS CROSSOVER","LC.LÜKS COUPÉ ","LC CONVERTIBLE" };
                comboBox_model.Items.AddRange(model);
            }

            if (comboBox_marka.Text == "MERCEDES-BENZ")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "A Serisi", "B Serisi", "E Serisi", "S Serisi"," C Serisi", "CLA Serisi", "CLS","SLC","GLA","GLC", "GLE", "GLS","GLK","Vito","GL Serisi", "Vaneo","Viano", "Citan"," ML"," SL", "SLK", "190 Serisi", "200 Serisi", "300 Serisi", "500 Serisi"," CL","CLC"," CLK","G Serisi","R Serisi"};
                comboBox_model.Items.AddRange(model);
            }

            if (comboBox_marka.Text == "MITSUBISHI")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = {"Attrage(27)","Colt(231) ","Galant(8)" ,"Lancer(320)", "Lancer Evolution(26)","Carisma(178)","Eclipse(2)", "Grandis(2) "};
                comboBox_model.Items.AddRange(model);
            }

            if (comboBox_marka.Text == "NISSAN")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "Micra", "Qashqai"," X - Trail", "Navara", "Juke", "Pulsar","Almera","Primera" };
                comboBox_model.Items.AddRange(model);
            }
            if (comboBox_marka.Text == "OPEL")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = {"Corsa", "Astra","Insignia","Crossland", "Mokka", "Grandland X"," Combo","Adam"};
                comboBox_model.Items.AddRange(model);
            }

            if (comboBox_marka.Text == "PEUGEOT")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "PEUGEOT 208","Yeni PEUGEOT 308","Yeni e - 2008","PEUGEOT SUV 3008","PEUGEOT SUV 5008","PEUGEOT EXPERT COMBI VAN" };
                comboBox_model.Items.AddRange(model);
            }

            if (comboBox_marka.Text == "RENAULT")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "Captur", "Clio", "Clio Sport Tourer","Fluence","Kadjar","Kangoo Express","Koleos","Megane" };
                comboBox_model.Items.AddRange(model);
            }

            if (comboBox_marka.Text == "SEAT")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "Ibiza","Leon", "Ateca", "Arona", "Tarraco"," Alhambra", "Toledo", "Altea" };
                comboBox_model.Items.AddRange(model);
            }

            if (comboBox_marka.Text == "SKODA")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "Superb", "Karoq", "Kodiaq"," Scala", "Octavia", "Kamiq"," Fabia", "Yeti" };
                comboBox_model.Items.AddRange(model);
            }

            if (comboBox_marka.Text == "TOYOTA")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = {"Yaris", "Corolla", "C - HR","RAV4", "Proace City", "Hilux", "Auris", "Prius" };
                comboBox_model.Items.AddRange(model);
            }

            if (comboBox_marka.Text == "VOLKSWAGEN")
            {

                comboBox_model  .Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "Polo", "Yeni Taigo","T - Cross"," Golf", "Passat", "Passat Variant","Tiguan", "Tiguan Allspace"};
                comboBox_model.Items.AddRange(model);
            }

            if (comboBox_marka.Text == "VOLVO")
            {

                comboBox_model.Items.Clear();
                comboBox_model.ResetText();
                string[] model = { "S90", "XC40","XC60","XC90", "V40", "S60", "V90", "S80" };
                comboBox_model.Items.AddRange(model);
            }






        }
        private void comboBox_model_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Seçim_Ekranı fr= new Seçim_Ekranı();
            fr.Show();
            this.Hide();
        }

        oto_galeriEntities db = new oto_galeriEntities();   

        private void button_ekle_Click(object sender, EventArgs e)
        {
            Araç car = new Araç ();

            car.arac_fiyat = int.Parse(textBox_fiyat.Text);
            car.arac_adet =int.Parse(textBox_adet.Text);
            car.arac_fiyat =int.Parse(textBox_fiyat.Text);
            car.arac_marka = comboBox_marka.Text;
            car.arac_model = comboBox_model.Text;
            car.arac_yıl = int.Parse(maskedTextBox_yıl.Text);
            car.arac_yakıt = comboBox_yakıt.Text;
            car.arac_vites = comboBox_vites.Text;
            car.arac_renk = comboBox_renk.Text;
            car.sube_id =int.Parse( comboBox_şno.SelectedValue.ToString());

            db.Araç.Add(car);

            db.SaveChanges();
            MessageBox.Show("Kaydedildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Araç.ToList();
            textBox_fiyat.Clear();  
            textBox_adet.Clear();
            textBox_fiyat.Clear();
            comboBox_marka.ResetText();
            comboBox_model.ResetText();
            maskedTextBox_yıl.Clear();
            comboBox_yakıt.ResetText();
            comboBox_vites.ResetText();
            comboBox_renk.ResetText();
            comboBox_şno.ResetText();



        }

        private void button_güncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_ano.Text);
            var xgüncel = db.Araç.Find(id);

            xgüncel.arac_fiyat = int.Parse(textBox_fiyat.Text);
            xgüncel.arac_adet = int.Parse(textBox_adet.Text);
            xgüncel.arac_fiyat = int.Parse(textBox_fiyat.Text);
            xgüncel.arac_marka = comboBox_marka.Text;
            xgüncel.arac_model = comboBox_model.Text;
            xgüncel.arac_yıl = int.Parse(maskedTextBox_yıl.Text);
            xgüncel.arac_yakıt = comboBox_yakıt.Text;
            xgüncel.arac_vites = comboBox_vites.Text;
            xgüncel.arac_renk = comboBox_renk.Text;
            xgüncel.sube_id = int.Parse(comboBox_şno.Text);

            db.SaveChanges();
            MessageBox.Show("Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Araç.ToList();
            textBox_fiyat.Clear();
            textBox_adet.Clear();
            textBox_fiyat.Clear();
            comboBox_marka.ResetText();
            comboBox_model.ResetText();
            maskedTextBox_yıl.Clear();
            comboBox_yakıt.ResetText();
            comboBox_vites.ResetText();
            comboBox_renk.ResetText();
            comboBox_şno.ResetText();

        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            int id;
            if (textBox_ano.Text != "")
            {
                id = Convert.ToInt32(textBox_ano.Text);
                var xsil = db.Araç.Find(id);

                if (xsil != null)
                {
                    db.Araç.Remove(xsil);
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

        private void ARAÇLAR_Load(object sender, EventArgs e)
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
            dataGridView1.DataSource=query.ToList();


            using (oto_galeriEntities db= new oto_galeriEntities())
            {
                comboBox_şno.DataSource = db.Sube.ToList();
                comboBox_şno.ValueMember = "sube_id";
                comboBox_şno.DisplayMember = "sube_adı";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }
