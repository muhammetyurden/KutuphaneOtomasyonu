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
    public partial class Emanetbilgi : MetroForm
    {
        public Emanetbilgi()
        {
            InitializeComponent();
        }

        private void Emanetbilgi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
