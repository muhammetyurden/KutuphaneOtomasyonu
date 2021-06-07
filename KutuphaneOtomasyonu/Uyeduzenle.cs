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
    public partial class Uyeduzenle : MetroForm 
    {
        MySqlConnection db;
        MySqlCommand cmd;
        MySqlDataReader dr;
        string id = "";
        string username = "";
        string phone = "";
        string adres = "";
        string eposta = "";

        public Uyeduzenle(string userId)
        {
            InitializeComponent();
            db = new MySqlConnection("Server=localhost;Database=kutuphaneotomasyon;user=root;SslMode=none");
            id = userId;

            MySqlConnection con = null;
            MySqlDataReader rdr = null;


            try
            {
                db.Open();
                string stm = "SELECT name,telefon,eposta,adres FROM users  where id=" + id;


                MySqlCommand cmd = new MySqlCommand(stm, db);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                  
                    username = rdr.GetString(0);
                    phone = rdr.GetString(1);
                    eposta = rdr.GetString(2);
                    adres = rdr.GetString(3);

                }


                idd.Text = id;
                adsoyad.Text = username;
                telno.Text = phone;
                epostaa.Text = eposta;
                adress.Text = adres;
            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Kullanıcı bulunamadı !");
            }
            db.Close();





        }
        
        
        private void Uyeduzenle_Load(object sender, EventArgs e)
        {
          
        }

        private void adsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void kaydet_Click(object sender, EventArgs e)
        {

            MySqlConnection con = null;
            MySqlDataReader rdr = null;


            try
            {
                db.Open();
                string stm = "update users set name='"+adsoyad.Text+"',telefon='"+telno.Text+"',eposta='"+epostaa.Text+"',adres='"+adress.Text+"'  where id=" + id;
               

                MySqlCommand cmd = new MySqlCommand(stm, db);
                rdr = cmd.ExecuteReader();

                MessageBox.Show("Veri Güncellendi !");

            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Veri değiştirilemedi");
            }
            db.Close();

        }

        private void iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            MySqlConnection con = null;
            MySqlDataReader rdr = null;


            try
            {
                db.Open();
                string stm = "delete from users where id=" + id;


                MySqlCommand cmd = new MySqlCommand(stm, db);
                rdr = cmd.ExecuteReader();

                MessageBox.Show("Kullanıcı Silindi !");

            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Veri değiştirilemedi");
            }
            db.Close();
        }
    }
}
