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
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.panelForm.Controls.Count > 0)
            {
                this.panelForm.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(f);
            this.panelForm.Tag = f;
            f.Show();
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            loadform(new Arama());
        }
    }
}
