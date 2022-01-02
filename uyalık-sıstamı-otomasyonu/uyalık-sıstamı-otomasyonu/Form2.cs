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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("İsim", 100);
            listView1.Columns.Add("Soy İsim", 100);
            listView1.Columns.Add("Email", 100);
            listView1.Columns.Add("Tel", 100);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem bilgi in listView1.SelectedItems)
            {
                bilgi.Remove();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string isim = TextBox1.Text;
            string soyisim = guna2TextBox2.Text;
            string email = guna2TextBox3.Text;
            string tel = maskedTextBox1.Text;


            if (isim == "" || isim == null || soyisim == "" || soyisim == null || email == "" || email == null || tel == "" || tel == null)
            {
                MessageBox.Show("Boş Alan Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (email.Length > 16)
            {
                MessageBox.Show("Email 16 Hanenin Üzerine Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] bilgiler = { isim, soyisim, tel, tel };
                listView1.Items.Add(new ListViewItem(bilgiler));
                TextBox1.Clear();
                guna2TextBox2.Clear();
                guna2TextBox3.Clear();
                maskedTextBox1.Clear();

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void guna2TextBox2_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Text = "";
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        private void guna2TextBox3_Click(object sender, EventArgs e)
        {
            guna2TextBox3.Text = "";        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
