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
    public partial class Form1 : MetroForm
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        
        


        public Form1()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=kutuphaneotomasyon;user=root;SslMode=none");
            //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void new_book(object sender, EventArgs e)
        {

            var myForm = new Yenikitapekle();
            myForm.Show();
         
        }

        private void new_user(object sender, EventArgs e)
        {
            var myForm = new Yeniuye();
            myForm.Show();
        }

        private void chapter_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new KitapListesi();
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myForm = new Uyelistesi();
            myForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var myForm = new Emanetlistesi();
            myForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var myForm = new Gecikenkitaplar();
            myForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tcNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var myForm = new Uyeduzenle("0");
            myForm.Show();
        }

        private void emanetbilgi_Click(object sender, EventArgs e)
        {
            var myForm = new Emanetbilgi();
            myForm.Show();
        }
    }
}

