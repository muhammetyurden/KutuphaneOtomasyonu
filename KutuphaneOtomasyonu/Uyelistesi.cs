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
    public partial class Uyelistesi : MetroForm
    {
        DataTable tablo = new DataTable();
        List<string> userId = new List<string>();
        string topUser = "";

        MySqlConnection db;
        MySqlCommand cmd;
        MySqlDataReader dr;


        public Uyelistesi()
        {
            InitializeComponent();

            db = new MySqlConnection("Server=localhost;Database=kutuphaneotomasyon;user=root;SslMode=none");
            //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;



            MySqlConnection con = null;
            MySqlDataReader rdr = null;


            try
            {
                db.Open();
                string stm = "select count(*) from users";


                MySqlCommand cmd = new MySqlCommand(stm, db);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    topUser = rdr.GetString(0);
                }

            }
            catch (MySqlException ex)

            {
               
            }
            db.Close();

            toplamuser.Text = topUser;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Uyelistesi_Load(object sender, EventArgs e)
        {

            tablo.Columns.Add("id", typeof(string));
            tablo.Columns.Add("TC kimlik", typeof(string));
            tablo.Columns.Add("Ad Soyad", typeof(string));
            tablo.Columns.Add("Bölümü", typeof(string));
            tablo.Columns.Add("Telefon", typeof(string));
            tablo.Columns.Add("Email", typeof(string));
            tablo.Columns.Add("Adres", typeof(string));
            gridTable.DataSource = tablo;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querywhere = "";
            string tc = "", name = "", bolum = "";

            if (!string.IsNullOrEmpty(textBox1.Text))
            {

                tc = " tc_number LIKE '%" + textBox1.Text + "%'";
                querywhere = "where";

            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {

                if (!string.IsNullOrEmpty(tc))
                    name = " AND name LIKE '%" + textBox2.Text + "%'";
                else
                    name = " name LIKE '%" + textBox2.Text + "%'";
                querywhere = "where";

            }
            if (!string.IsNullOrEmpty(metroComboBox1.Text))
            {
                if (!string.IsNullOrEmpty(tc) || !string.IsNullOrEmpty(name))
                    bolum = "AND chapter LIKE '%" + metroComboBox1.Text + "%'";
                else
                    bolum = " chapter LIKE '%" + metroComboBox1.Text + "%'";
                querywhere = "where";
            }

            MySqlConnection con = null;
            MySqlDataReader rdr = null;



            try
            {
                db.Open();
                string stm = "SELECT id,tc_number,name,chapter,telefon,eposta,adres FROM users " + querywhere + tc + name + bolum;


                MySqlCommand cmd = new MySqlCommand(stm, db);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    userId.Add(rdr.GetString(0));

                    tablo.Rows.Add(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6));
                    gridTable.DataSource = tablo;
                }


            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Sorgu hatası " + ex.ToString());
            }
            db.Close();






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

        private void button3_Click(object sender, EventArgs e)
        {
            {


                if (gridTable.SelectedRows.Count > 0)
                {

                    gridTable.Rows.RemoveAt(gridTable.SelectedRows[0].Index);

                }
                else
                {
                    MessageBox.Show("Lüffen silinecek satırı seçin.");
                }
            }
        }

        private void kitapTur_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GridTable_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            Uyeduzenle = gridTable.Rows[gridTable.CurrentRow.Index].Cells[""].Value.ToString();
                var myform = new Uyeduzenle();
                myform.Show();   


            Uyeduzenle FormUyelistesi = new Uyeduzenle();
            FormUyelistesi.Show();
            */





            if (e.RowIndex >= 0)
            {
                var newform = new Uyeduzenle( userId[e.RowIndex] );
                newform.Show();

            }

        }

        /*  private void duzenle_Click(object sender, EventArgs e)
          {    


              var myForm = new Uyeduzenle();
              myForm.Show();

              duzenle1 = gridTable.CurrentRow.Cells[0].Value.ToString();

      *
      */










    


        }
    }
