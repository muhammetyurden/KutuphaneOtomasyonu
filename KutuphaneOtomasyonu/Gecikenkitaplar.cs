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
    public partial class Gecikenkitaplar : MetroForm
    {

        MySqlConnection con ;
        MySqlCommand cmd ;
        MySqlDataReader dr ;



        public Gecikenkitaplar()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=kutuphaneotomasyon;user=root;SslMode=none");

        }
        private void Gecikenkitaplar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void emanetekle_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Random random = new Random();
                int rand = random.Next(10000, 99999);
                string komut = "insert into emanet(id,userid,bookid,veris_date,durum,alis_date) values('" + rand + "','" + userıd.Text + "','" + kitapıd.Text + "','" + vermetarih.Text.ToString() + "','1', '" + almatarih.Text.ToString() + "')";
                MySqlCommand kmt = new MySqlCommand(komut, con);
                kmt.ExecuteNonQuery();

                MessageBox.Show("Kitap Kaydı Başarılı");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
