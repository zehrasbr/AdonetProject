using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdonetProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source= UNKNOWN\\SQLEXPRESS;initial Catalog=CasgemDbMovie;Integrated Security =True");
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            int x, y, z;
            timer1.Enabled = true;
            Random rnd = new Random();
            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);
            this.BackColor = Color.FromArgb(x, y, z);
            timer1.Interval = 500;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y, z;
            timer1.Enabled = true;
            Random rnd = new Random();
            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);
            this.BackColor = Color.FromArgb(x, y, z);
            timer1.Interval = 500;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtKullanıcıAdı.Text;
            string sifre = txtŞifre.Text;

            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblAdmin Where UserName=@p1 and Password=@p2", connection);
            command.Parameters.AddWithValue("@p1", txtKullanıcıAdı);
            command.Parameters.AddWithValue("@p2", txtŞifre);
            SqlDataReader dr = command.ExecuteReader();

            if(dr.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
            }
            
            else
            {
                MessageBox.Show("Giriş yapılamadı!", "İŞLEM BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            connection.Close();
        }
    }
}
