using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabzinBargNafis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTarkib_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTarkib formTarkib = new FormTarkib();
            formTarkib.Show();
            formTarkib.FormClosed += (s, args) => this.Close();
        }

        private void btnBahaieTamamshode_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBahaieTamamShode formBahaietamamshode = new FormBahaieTamamShode();
            formBahaietamamshode.Show();
            formBahaietamamshode.FormClosed += (s, args) => this.Close();
        }
    }
}
