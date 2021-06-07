using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;



namespace KutuphaneOtomasyonu
{
    public partial class Yeniuye : MetroForm 
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        ErrorProvider provider = new ErrorProvider();
        public Yeniuye()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=kutuphaneotomasyon;user=root;SslMode=none");
            //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;

        }

        private void Yeniuye_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tcno.Text == "")
            {
                provider.SetError(tcno, "Bu alan boş geçilemez");
                MessageBox.Show("Boş Alan Bırakmayınız");
                provider.Clear();
            }
            else

           if (adsoyad.Text == "")
            {
                provider.SetError(adsoyad, "Bu alan boş geçilemez");
                MessageBox.Show("Boş Alan Bırakmayınız");
                provider.Clear();
            }
            else
           if (bolum.Text == "")
            {
                provider.SetError(bolum, "Bu alan boş geçilemez");
                MessageBox.Show("Boş Alan Bırakmayınız");
                provider.Clear();
            }
            else
           if (telno.Text == "")
            {
                provider.SetError(telno, "Bu alan boş geçilemez");
                MessageBox.Show("Boş Alan Bırakmayınız");
                provider.Clear();
            }
            else
           if (eposta.Text == "")
            {
                provider.SetError(eposta, "Bu alan boş geçilemez");
                MessageBox.Show("Boş Alan Bırakmayınız");
                provider.Clear();
            }
            else
           if (adres.Text == "")
            {
                provider.SetError(adres, "Bu alan boş geçilemez");
                MessageBox.Show("Boş Alan Bırakmayınız");
                provider.Clear();
            }
            else
            { 

      
                try
            {
                con.Open();
                Random random = new Random();
                int rand = random.Next(10000, 99999);
                string komut = "insert into users(id,name,chapter,tc_number,telefon,eposta,adres) values('" + rand + "','" + adsoyad.Text + "', '" + bolum.Text + "', '" + tcno.Text + "','" + telno.Text + "','" + eposta.Text + "','" + adres.Text + "')";
                MySqlCommand kmt = new MySqlCommand(komut, con);
                kmt.ExecuteNonQuery();

                MessageBox.Show("Kullanıcı kaydı başarılı");

            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı eklenemedi");

            }



            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void bolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void adsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void telno_TextChanged(object sender, EventArgs e)
        {

        }

        private void bolum_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tcno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }

        }
    }
}
