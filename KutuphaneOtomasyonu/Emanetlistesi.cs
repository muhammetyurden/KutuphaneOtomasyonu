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
    public partial class Emanetlistesi : MetroForm
    {

        DataTable tablo = new DataTable();


        public MySqlConnection db = new MySqlConnection("Server=localhost;Database=kutuphaneotomasyon;user=root;SslMode=none");

        public Emanetlistesi()
        {
            InitializeComponent();
          
        }

        private void Emanetlistesi_Load(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            metroGrid1.ColumnCount = 6;
            metroGrid1.ColumnHeadersVisible = true;
            metroGrid1.Columns[0].Name = "ID ";
            metroGrid1.Columns[1].Name = " Kullanıcı ID";
            metroGrid1.Columns[2].Name = "Kitap ID ";
            metroGrid1.Columns[3].Name = "Veriliş Tarihi ";
            metroGrid1.Columns[4].Name = "Durum ";
            metroGrid1.Columns[5].Name = "Alış Tarihi ";

        }

        private void uyelistele_Click(object sender, EventArgs e)
        {
          
          
            MySqlDataReader rdr = null;


         db.Open();
            string stm = "SELECT id,userid,bookid,veris_date,durum,alis_date FROM emanet ";
            MySqlDataAdapter cmd = new MySqlDataAdapter(stm, db);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            metroGrid1.DataSource = dt;
            db.Close();
          
 /*  
              try
              {
                  db.Open();
                  string stm = "SELECT id,userid,bookid,veris_date,durum,alis_date FROM emanet ";


                  MySqlCommand cmd = new MySqlCommand(stm, db);
                  rdr = cmd.ExecuteReader();

                  while (rdr.Read())
                  {
                      tablo.Rows.Add(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5)   );
                      dataGridView1.DataSource = tablo;
                  }
  

              }
              catch (MySqlException ex)

              {
                  MessageBox.Show("Sorgu hatası " + ex.ToString());
              }
              db.Close();*/
        }
    }
}
