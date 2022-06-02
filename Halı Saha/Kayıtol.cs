using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Halı_Saha
{
    public partial class Kayıtol : Form
    {
        public Kayıtol()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\onur_\\Documents\\GitHub\\HaliSahaRezervasyonSistemi\\Halı Saha Rezervasyonu\\Halısaha.mdb");

        private void textclear(Control ctl)
        {
            foreach (Control item in ctl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                if (item.Controls.Count > 0)
                {
                    textclear(item);
                }
                if (item is ComboBox)
                {
                    comboBox1.Text = null;
                }
            }
        }

        private int deger;
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            // Bu kaydet butonuna bakılması lazım

            if (maskedTextBox1.Text == "")
                deger++;
            if (maskedTextBox2.Text == "")
                deger++;
            if (maskedTextBox3.Text == "")
                deger++;
            if (maskedTextBox4.Text == "")
                deger++;
            if (maskedTextBox5.Text == "")
                deger++;
            if (maskedTextBox7.Text == "")
                deger++;
            if (maskedTextBox8.Text == "")
                deger++;
            if (maskedTextBox9.Text == "")
                deger++;
            if (maskedTextBox10.Text == "")
                deger++;
            if (maskedTextBox11.Text == "")
                deger++;
            if (comboBox1.Text == "")
                deger++;
            if (deger > 0)
            {
                MessageBox.Show("Boş Alan Bırakılamaz");
            }
            else
            {
                deger = 0;
                MessageBox.Show("Kayıt Başarılı");
            }
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            textclear(this);
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
