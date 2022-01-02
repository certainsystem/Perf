using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyalık_sıstamı_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int m = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = TextBox1.Text;
            string sifre = TextBox2.Text;
            if (kullaniciadi == "" || kullaniciadi == null || sifre == "" || sifre == null)
            {
                MessageBox.Show("Boş Alan Olamaz!");
            }
            else if (kullaniciadi == "admin" && sifre == "1234")
            {
                MessageBox.Show("Oturum Açıldı");
                progressBar1.Visible = true;
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifreniz Yalnış");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Interval = 30;
                progressBar1.Value = m++;
                if (progressBar1.Value == 30)
                {
                    timer1.Stop();
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
                }
            }
        }

        private void TextBox2_Click(object sender, System.EventArgs e)
        {
            TextBox2.Text = "";
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
