using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halı_Saha
{
    public partial class Girisyap : Form
    {
        public Girisyap()
        {
            InitializeComponent();
        }

        private void Girisyap_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
            textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style ^ FontStyle.Italic);
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            // giriş için veri tabanından kontrol yapılacak
            // Profil sayfası açılacak
            Profil yeni = new Profil();
            yeni.Show();
            this.Hide();

        }

        private void ıconButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sol taraftaki menüden kaydınızı yaptırınız.");
        }

        private void ıconButton7_Click(object sender, EventArgs e)
        {
            Sifremiunuttum yeni = new Sifremiunuttum();
            yeni.Show();
            yeni.BringToFront();
        }
    }
}
