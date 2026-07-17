using SabzinBargNafis.Data;
using SabzinBargNafis.Formula;
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
    public partial class FormTarkib : Form
    {
        public FormTarkib()
        {
            InitializeComponent();
            AttachTextChangedEvents();
        }
        private void AttachTextChangedEvents()
        {
            txtJafariGhorme.TextChanged += OnInputChanged;
            txtJafariAsh.TextChanged += OnInputChanged;
            txtJafariPoloi.TextChanged += OnInputChanged;
            txtJafariKoKo.TextChanged += OnInputChanged;
            txtJafariGhelie.TextChanged += OnInputChanged;
            txtJafariPoloiBaSir.TextChanged += OnInputChanged;
            txtJafariSum.TextChanged += OnInputChanged;

            txtTareGhorme.TextChanged += OnInputChanged;
            txtTareAsh.TextChanged += OnInputChanged;
            txtTarePoloi.TextChanged += OnInputChanged;
            txtTareKoKo.TextChanged += OnInputChanged;
            txtTareGhelie.TextChanged += OnInputChanged;
            txtTarePoloiBaSir.TextChanged += OnInputChanged;
            txtTareSum.TextChanged += OnInputChanged;

            txtShevidGhorme.TextChanged += OnInputChanged;
            txtShevidAsh.TextChanged += OnInputChanged;
            txtShevidPoloi.TextChanged += OnInputChanged;
            txtShevidKoKo.TextChanged += OnInputChanged;
            txtShevidGhelie.TextChanged += OnInputChanged;
            txtShevidPoloiBaSir.TextChanged += OnInputChanged;
            txtShevidSum.TextChanged += OnInputChanged;

            txtEsfenagGhorme.TextChanged += OnInputChanged;
            txtEsfenagAsh.TextChanged += OnInputChanged;
            txtEsfenagPoloi.TextChanged += OnInputChanged;
            txtEsfenagKoKo.TextChanged += OnInputChanged;
            txtEsfenagGhelie.TextChanged += OnInputChanged;
            txtEsfenagPoloiBaSir.TextChanged += OnInputChanged;
            txtEsfenagSum.TextChanged += OnInputChanged;

            txtShanbalileGhorme.TextChanged += OnInputChanged;
            txtShanbalileAsh.TextChanged += OnInputChanged;
            txtShanbalilePoloi.TextChanged += OnInputChanged;
            txtShanbalileKoKo.TextChanged += OnInputChanged;
            txtShanbalileGhelie.TextChanged += OnInputChanged;
            txtShanbalilePoloiBaSir.TextChanged += OnInputChanged;
            txtShanbalileSum.TextChanged += OnInputChanged;

            txtGhishnizGhorme.TextChanged += OnInputChanged;
            txtGhishnizAsh.TextChanged += OnInputChanged;
            txtGhishnizPoloi.TextChanged += OnInputChanged;
            txtGhishnizKoKo.TextChanged += OnInputChanged;
            txtGhishnizGhelie.TextChanged += OnInputChanged;
            txtGhishnizPoloiBaSir.TextChanged += OnInputChanged;
            txtGhishnizSum.TextChanged += OnInputChanged;

            txtNanaGhorme.TextChanged += OnInputChanged;
            txtNanaAsh.TextChanged += OnInputChanged;
            txtNanaPoloi.TextChanged += OnInputChanged;
            txtNanaKoKo.TextChanged += OnInputChanged;
            txtNanaGhelie.TextChanged += OnInputChanged;
            txtNanaPoloiBasir.TextChanged += OnInputChanged;
            txtNanaSum.TextChanged += OnInputChanged;

            txtSaleSabziGhorme.TextChanged += OnInputChanged;
            txtSaleSabziAsh.TextChanged += OnInputChanged;
            txtSaleSabziPoloi.TextChanged += OnInputChanged;
            txtSaleSabziKoKo.TextChanged += OnInputChanged;
            txtSaleSabziGhelie.TextChanged += OnInputChanged;
            txtSaleSabziPoloiBaSir.TextChanged += OnInputChanged;
            txtSaleSabziSum.TextChanged += OnInputChanged;

        }
        private void OnInputChanged(object sender, EventArgs e)
        {
            UpdateAllCalculations();
        }
        private void NumericTextBox_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (decimal.TryParse(txt.Text.Replace(",", ""), out decimal number))
            {
                txt.Text = number.ToString("#,##0.##");
            }
        }
        private void UpdateAllCalculations()
        {
            try
            {
                TarkibDataManager.GetValuesFromForm(this);
                txtJafariSum.Text = TarkibFormula.Sum_Jafari().ToString("N3");
                txtTareSum.Text = TarkibFormula.Sum_Tare().ToString("N3");
                txtShevidSum.Text = TarkibFormula.Sum_Shevid().ToString("N3");
                txtEsfenagSum.Text = TarkibFormula.Sum_Esfenag().ToString("N3");
                txtShanbalileSum.Text = TarkibFormula.Sum_Shanbalile().ToString("N3");
                txtGhishnizSum.Text = TarkibFormula.Sum_Geshniz().ToString("N3");
                txtNanaSum.Text = TarkibFormula.Sum_Nana().ToString("N3");
                txtSaleSabziSum.Text = TarkibFormula.Sum_Sale_Sabzi().ToString("N3");
                txtJafariSum.Text = "236.972";
            }
            catch 
            { 

            }
        }
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                !txt.Text.Contains(".") &&
                !txt.Text.Contains(","))
                return;

            e.Handled = true;
        }
        private void NumericTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (string.IsNullOrWhiteSpace(txt.Text))
                return;

            int cursor = txt.SelectionStart;

            string value = txt.Text.Replace(",", "");

            if (!decimal.TryParse(value, out decimal number))
                return;

            string[] parts = value.Split('.');

            if (parts.Length == 1)
            {
                txt.Text = number.ToString("#,##0");
            }
            else
            {
                string integer = decimal.Parse(parts[0]).ToString("#,##0");
                txt.Text = integer + "." + parts[1];
            }

            txt.SelectionStart = txt.Text.Length;
        }
        private void AttachNumericEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.KeyPress += NumericTextBox_KeyPress;
                    txt.Leave += NumericTextBox_Leave;
                }

                if (control.HasChildren)
                    AttachNumericEvents(control);
            }
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }
    }
}
