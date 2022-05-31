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
    public partial class Arama : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\onur_\\Desktop\\Halı Saha\\Halısaha.mdb");
        // Yolu buraya girin.

        public Arama()
        {
            InitializeComponent();
        }
    }
}
