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
    public partial class Sifreyenileme : Form
    {
        public Sifreyenileme()
        {
            InitializeComponent();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
            textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style ^ FontStyle.Italic);
            textBox2.PasswordChar = '*';
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);
            textBox1.PasswordChar = '*';
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            //şifre update
            MessageBox.Show("Şifreniz güncellenmiştir.");
            this.Close();
        }
    }
}
