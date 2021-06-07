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
    public partial class KitapListesi : MetroFramework.Forms.MetroForm
    {
        DataTable tablo = new DataTable();

        MySqlConnection db;
        MySqlCommand cmd;
        MySqlDataReader dr;


        public KitapListesi()
        {
            InitializeComponent();
            db = new MySqlConnection("Server=localhost;Database=kutuphaneotomasyon;user=root;SslMode=none");
            //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void metroButton3_Click(object sender, EventArgs e)
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

        private void KitapListesi_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Kitap Kodu", typeof(string));
            tablo.Columns.Add("Kitap Adı", typeof(string));
            tablo.Columns.Add("Yazar Adı", typeof(string));
            tablo.Columns.Add("Yayınevi", typeof(string));
            tablo.Columns.Add("Kitap Türü", typeof(string));
            tablo.Columns.Add("Stok Miktarı", typeof(string));
            tablo.Columns.Add("Sayfa sayısı", typeof(string));
            metroGrid1.DataSource = tablo;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            {
                if (metroGrid1.SelectedRows.Count > 0)
                {
                    metroGrid1.Rows.RemoveAt(metroGrid1.SelectedRows[0].Index);
                }
                else
                {
                    MessageBox.Show("Lüffen silinecek satırı seçin.");
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string querywhere = "";
            string kitapadi = "", yazaradi = "", yayinevi = "";

            if (!string.IsNullOrEmpty(textBox1.Text))
            {  
                if(!string.IsNullOrEmpty(textBox1.Text))
                kitapadi = "  kitap_adi LIKE '%" + textBox1.Text + "%'";
                else
                kitapadi = " kitap_adi LIKE '%" + textBox1.Text + "%'";
                querywhere = "where";
            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                if (!string.IsNullOrEmpty(kitapadi))
                    yazaradi = " AND yazar_adi LIKE '%" + textBox2.Text + "%'";
                else
                    yazaradi = " yazar_adi LIKE '%" + textBox2.Text + "%'";
                querywhere = "where";
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                if (!string.IsNullOrEmpty(kitapadi)  || string.IsNullOrEmpty(yazaradi))
                    yayinevi = "  chapter LIKE '%" + textBox3.Text + "%'";
                else
                    yayinevi = " AND chapter LIKE '%" + textBox3.Text + "%'";
                querywhere = "where";
            }

            MySqlConnection con = null;
            MySqlDataReader rdr = null;

            try
            {
                db.Open();

                string stm = "SELECT kitap_kodu,kitap_adi,yazar_adi,yayin_evi,kitap_turu,stok_miktari,sayfa_sayisi FROM books " + querywhere + kitapadi + yazaradi + yayinevi;


                MySqlCommand cmd = new MySqlCommand(stm, db);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    tablo.Rows.Add(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6));
                    metroGrid1.DataSource = tablo;
                }


            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Sorgu hatası " + ex.ToString());
            }
            db.Close();




        }
    }
}
