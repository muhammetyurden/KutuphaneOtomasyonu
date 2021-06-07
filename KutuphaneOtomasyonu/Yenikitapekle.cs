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
    public partial class Yenikitapekle : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        ErrorProvider provider = new ErrorProvider();

        public Yenikitapekle()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=kutuphaneotomasyon;user=root;SslMode=none");
            //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Yenikitapekle_Load(object sender, EventArgs e)
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

        private void sayfasayisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void sayfa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void yayinevi_TextChanged(object sender, EventArgs e)
        {

        }

        private void kitapKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (kitapKod.Text == "")
            {
                provider.SetError(kitapKod, "Bu alan boş geçilemez");
                MessageBox.Show("Boş Alan Bırakmayınız");
                provider.Clear();
            }
             else

            if (kitapAd.Text == "")
            {
                provider.SetError(kitapAd, "Bu alan boş geçilemez");
                MessageBox.Show("Boş Alan Bırakmayınız");
                provider.Clear();
            }
              else
            if (yazarAd.Text == "")
            {
                provider.SetError(yazarAd, "Bu alan boş geçilemez");
                MessageBox.Show("Boş Alan Bırakmayınız");
                provider.Clear();
            }
            else
            if (yayinevi.Text == "")
            {
                provider.SetError(yayinevi, "Bu alan boş geçilemez");
                MessageBox.Show("Boş Alan Bırakmayınız");
                provider.Clear();
            }
            else
            if (kitapTur.Text == "")
            {
                provider.SetError(kitapTur, "Bu alan boş geçilemez");
                MessageBox.Show("Boş Alan Bırakmayınız");
                provider.Clear();
            }
            else
            if (stok.Text == "")
            {
                provider.SetError(stok, "Bu alan boş geçilemez");
                MessageBox.Show("Boş Alan Bırakmayınız");
                provider.Clear();
            }
            else
            if (sayfa.Text == "")
            {
                provider.SetError(sayfa, "Bu alan boş geçilemez");
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
                    string komut = "insert into books(kitap_kodu,kitap_adi,yazar_adi,yayin_evi,kitap_turu,stok_miktari,sayfa_sayisi) values('" + kitapKod.Text + "','" + kitapAd.Text + "', '" + yazarAd.Text + "', '" + yayinevi.Text + "','" + kitapTur.Text + "','" + stok.Text + "','" + sayfa.Text + "')";
                    MySqlCommand kmt = new MySqlCommand(komut, con);
                    kmt.ExecuteNonQuery();

                    MessageBox.Show("Kitap Kaydı Başarılı");
                    con.Close();
                    }
                catch (Exception)
                    {
                    MessageBox.Show("Kitap Eklenemedi");

                    }
                
                    
              
            }











        }

        private void kitapTur_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void stok_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

