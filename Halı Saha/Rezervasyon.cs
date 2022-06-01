using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halı_Saha
{
    public partial class Rezervasyon : Form
    {
        public int x;
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\\Users\\onur_\\Documents\\GitHub\\HaliSahaRezervasyonSistemi\\Halı Saha Rezervasyonu\\Halısaha.mdb");
        OleDbCommand komut;
        OleDbDataReader re;

        public void Alert(string msg)
        {
            warning f = new warning();
            f.showalert(msg);
        }

        public Rezervasyon()
        {
            InitializeComponent();
        }
        public Rezervasyon(string no)
        {
            InitializeComponent();
            x = Convert.ToInt32(no);
            acilis(x);
        }

        private void acilis(int x)
        {
            baglanti.Open();
            komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("SELECT Rezervler.[id], Rezervler.[Gun], Rezervler.[Saat], Rezervler.[Halisaha] FROM Rezervler WHERE Halisaha=@no");
            komut.Parameters.AddWithValue("@no", x);
            re = komut.ExecuteReader();
            while (re.Read())
            {
                ArrayList labels = new ArrayList();
                Labels(labels);


                if (re["Saat"].ToString() == cmbsaat.Items[0].ToString())
                {
                    foreach (Label c in labels)
                    {



                        if (c.Name.Equals(re["Gun"].ToString() + 16))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;


                        }

                    }
                }

                else if (re["Saat"].ToString() == cmbsaat.Items[1].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 17))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }

                else if (re["Saat"].ToString() == cmbsaat.Items[2].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 18))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[3].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 19))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[4].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 20))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[5].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 21))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[6].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 22))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[7].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 23))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
            }
            re.Close();
            baglanti.Close();

        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            // yanlışlıkla tıkladım.
        }
    }
}
