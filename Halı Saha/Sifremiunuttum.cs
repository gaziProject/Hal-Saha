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
    public partial class Sifremiunuttum : Form
    {
        public Sifremiunuttum()
        {
            InitializeComponent();
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
            if (textBox1.Text == textBox2.Text)
            {
                Sifreyenileme yeni = new Sifreyenileme();
                yeni.Show();
                yeni.BringToFront();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ile mail eşleşmiyor!!!");
                textBox1.Text = null;
                textBox2.Text = null;
            }
        }

        private void Sifremiunuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
