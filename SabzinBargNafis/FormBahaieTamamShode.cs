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
    public partial class FormBahaieTamamShode : Form
    {
        public FormBahaieTamamShode()
        {
            InitializeComponent();
            AttachTextChangedEvents();
        }
        private void AttachTextChangedEvents()
        {
            // ====================================================
            // جعفری (J)
            // ====================================================
            txtJMGHMAD.TextChanged += OnInputChanged;
            txtJNMAD.TextChanged += OnInputChanged;
            txtJMMAD.TextChanged += OnInputChanged;

            txtJMGHKHTDPN.TextChanged += OnInputChanged;
            txtJNKHTDPN.TextChanged += OnInputChanged;
            txtJMKHTDPN.TextChanged += OnInputChanged;

            txtJMGHKHTDPSH.TextChanged += OnInputChanged;
            txtJNKHTDPSH.TextChanged += OnInputChanged;
            txtJMKHTDPSH.TextChanged += OnInputChanged;

            txtJMGHBTSHFSPSH.TextChanged += OnInputChanged;
            txtJNBTSHFSPSH.TextChanged += OnInputChanged;
            txtJMBTSHFSPSH.TextChanged += OnInputChanged;

            txtJMGHMJTMM.TextChanged += OnInputChanged;
            txtJNMJTMM.TextChanged += OnInputChanged;
            txtJMMJTMM.TextChanged += OnInputChanged;

            txtJMGHMJTSM.TextChanged += OnInputChanged;
            txtJNMJTSM.TextChanged += OnInputChanged;
            txtJMMJTSM.TextChanged += OnInputChanged;

            txtJMGHMBATST.TextChanged += OnInputChanged;
            txtJNMBATST.TextChanged += OnInputChanged;
            txtJMMBATST.TextChanged += OnInputChanged;

            txtJMGHMJTSKH.TextChanged += OnInputChanged;
            txtJNMJTSKH.TextChanged += OnInputChanged;
            txtJMMJTSKH.TextChanged += OnInputChanged;

            txtJMGHZA.TextChanged += OnInputChanged;
            txtJNZA.TextChanged += OnInputChanged;
            txtJMZA.TextChanged += OnInputChanged;

            txtJMGHMPD.TextChanged += OnInputChanged;
            txtJNMPD.TextChanged += OnInputChanged;
            txtJMMPD.TextChanged += OnInputChanged;

            txtJMGHZ.TextChanged += OnInputChanged;
            txtJNZ.TextChanged += OnInputChanged;
            txtJMZ.TextChanged += OnInputChanged;

            txtJMGHHDS.TextChanged += OnInputChanged;
            txtJNHDS.TextChanged += OnInputChanged;
            txtJMHDS.TextChanged += OnInputChanged;

            txtJMGHSum.TextChanged += OnInputChanged;
            txtJNSum.TextChanged += OnInputChanged;
            txtJMSum.TextChanged += OnInputChanged;

            // ====================================================
            // تره (T)
            // ====================================================
            txtTMGHMAD.TextChanged += OnInputChanged;
            txtTNMAD.TextChanged += OnInputChanged;
            txtTMMAD.TextChanged += OnInputChanged;

            txtTMGHKHTDPN.TextChanged += OnInputChanged;
            txtTNKHTDPN.TextChanged += OnInputChanged;
            txtTMKHTDPN.TextChanged += OnInputChanged;

            txtTMGHKHTDPSH.TextChanged += OnInputChanged;
            txtTNKHTDPSH.TextChanged += OnInputChanged;
            txtTMKHTDPSH.TextChanged += OnInputChanged;

            txtTMGHBTSHFSPSH.TextChanged += OnInputChanged;
            txtTNBTSHFSPSH.TextChanged += OnInputChanged;
            txtTMBTSHFSPSH.TextChanged += OnInputChanged;

            txtTMGHMJTMM.TextChanged += OnInputChanged;
            txtTNMJTMM.TextChanged += OnInputChanged;
            txtTMMJTMM.TextChanged += OnInputChanged;

            txtTMGHMJTSM.TextChanged += OnInputChanged;
            txtTNMJTSM.TextChanged += OnInputChanged;
            txtTMMJTSM.TextChanged += OnInputChanged;

            txtTMGHMBATST.TextChanged += OnInputChanged;
            txtTNMBATST.TextChanged += OnInputChanged;
            txtTMMBATST.TextChanged += OnInputChanged;

            txtTMGHMJTSKH.TextChanged += OnInputChanged;
            txtTNMJTSKH.TextChanged += OnInputChanged;
            txtTMMJTSKH.TextChanged += OnInputChanged;

            txtTMGHZA.TextChanged += OnInputChanged;
            txtTNZA.TextChanged += OnInputChanged;
            txtTMZA.TextChanged += OnInputChanged;

            txtTMGHMPD.TextChanged += OnInputChanged;
            txtTNMPD.TextChanged += OnInputChanged;
            txtTMMPD.TextChanged += OnInputChanged;

            txtTMGHZ.TextChanged += OnInputChanged;
            txtTNZ.TextChanged += OnInputChanged;
            txtTMZ.TextChanged += OnInputChanged;

            txtTMGHHDS.TextChanged += OnInputChanged;
            txtTNHDS.TextChanged += OnInputChanged;
            txtTMHDS.TextChanged += OnInputChanged;

            txtTMGHSum.TextChanged += OnInputChanged;
            txtTNSum.TextChanged += OnInputChanged;
            txtTMSum.TextChanged += OnInputChanged;

            // ====================================================
            // شنبلیله (SHN)
            // ====================================================
            txtSHNMGHMAD.TextChanged += OnInputChanged;
            txtSHNNMAD.TextChanged += OnInputChanged;
            txtSHNMMAD.TextChanged += OnInputChanged;

            txtSHNMGHKHTDPN.TextChanged += OnInputChanged;
            txtSHNNKHTDPN.TextChanged += OnInputChanged;
            txtSHNMKHTDPN.TextChanged += OnInputChanged;

            txtSHNMGHKHTDPSH.TextChanged += OnInputChanged;
            txtSHNNKHTDPSH.TextChanged += OnInputChanged;
            txtSHNMKHTDPSH.TextChanged += OnInputChanged;

            txtSHNMGHBTSHFSPSH.TextChanged += OnInputChanged;
            txtSHNNBTSHFSPSH.TextChanged += OnInputChanged;
            txtSHNMBTSHFSPSH.TextChanged += OnInputChanged;

            txtSHNMGHMJTMM.TextChanged += OnInputChanged;
            txtSHNNMJTMM.TextChanged += OnInputChanged;
            txtSHNMMJTMM.TextChanged += OnInputChanged;

            txtSHNMGHMJTSM.TextChanged += OnInputChanged;
            txtSHNNMJTSM.TextChanged += OnInputChanged;
            txtSHNMMJTSM.TextChanged += OnInputChanged;

            txtSHNMGHMBATST.TextChanged += OnInputChanged;
            txtSHNNMBATST.TextChanged += OnInputChanged;
            txtSHNMMBATST.TextChanged += OnInputChanged;

            txtSHNMGHMJTSKH.TextChanged += OnInputChanged;
            txtSHNNMJTSKH.TextChanged += OnInputChanged;
            txtSHNMMJTSKH.TextChanged += OnInputChanged;

            txtSHNMGHZA.TextChanged += OnInputChanged;
            txtSHNNZA.TextChanged += OnInputChanged;
            txtSHNMZA.TextChanged += OnInputChanged;

            txtSHNMGHMPD.TextChanged += OnInputChanged;
            txtSHNNMPD.TextChanged += OnInputChanged;
            txtSHNMMPD.TextChanged += OnInputChanged;

            txtSHNMGHZ.TextChanged += OnInputChanged;
            txtSHNNZ.TextChanged += OnInputChanged;
            txtSHNMZ.TextChanged += OnInputChanged;

            txtSHNMGHHDS.TextChanged += OnInputChanged;
            txtSHNNHDS.TextChanged += OnInputChanged;
            txtSHNMHDS.TextChanged += OnInputChanged;

            txtSHNMGHSum.TextChanged += OnInputChanged;
            txtSHNNSum.TextChanged += OnInputChanged;
            txtSHNMSum.TextChanged += OnInputChanged;

            // ====================================================
            // اسفناج (E)
            // ====================================================
            txtEMGHMAD.TextChanged += OnInputChanged;
            txtENMAD.TextChanged += OnInputChanged;
            txtEMMAD.TextChanged += OnInputChanged;

            txtEMGHKHTDPN.TextChanged += OnInputChanged;
            txtENKHTDPN.TextChanged += OnInputChanged;
            txtEMKHTDPN.TextChanged += OnInputChanged;

            txtEMGHKHTDPSH.TextChanged += OnInputChanged;
            txtENKHTDPSH.TextChanged += OnInputChanged;
            txtEMKHTDPSH.TextChanged += OnInputChanged;

            txtEMGHBTSHFSPSH.TextChanged += OnInputChanged;
            txtENBTSHFSPSH.TextChanged += OnInputChanged;
            txtEMBTSHFSPSH.TextChanged += OnInputChanged;

            txtEMGHMJTMM.TextChanged += OnInputChanged;
            txtENMJTMM.TextChanged += OnInputChanged;
            txtEMMJTMM.TextChanged += OnInputChanged;

            txtEMGHMJTSM.TextChanged += OnInputChanged;
            txtENMJTSM.TextChanged += OnInputChanged;
            txtEMMJTSM.TextChanged += OnInputChanged;

            txtEMGHMBATST.TextChanged += OnInputChanged;
            txtENMBATST.TextChanged += OnInputChanged;
            txtEMMBATST.TextChanged += OnInputChanged;

            txtEMGHMJTSKH.TextChanged += OnInputChanged;
            txtENMJTSKH.TextChanged += OnInputChanged;
            txtEMMJTSKH.TextChanged += OnInputChanged;

            txtEMGHZA.TextChanged += OnInputChanged;
            txtENZA.TextChanged += OnInputChanged;
            txtEMZA.TextChanged += OnInputChanged;

            txtEMGHMPD.TextChanged += OnInputChanged;
            txtENMPD.TextChanged += OnInputChanged;
            txtEMMPD.TextChanged += OnInputChanged;

            txtEMGHZ.TextChanged += OnInputChanged;
            txtENZ.TextChanged += OnInputChanged;
            txtEMZ.TextChanged += OnInputChanged;

            txtEMGHHDS.TextChanged += OnInputChanged;
            txtENHDS.TextChanged += OnInputChanged;
            txtEMHDS.TextChanged += OnInputChanged;

            txtEMGHSum.TextChanged += OnInputChanged;
            txtENSum.TextChanged += OnInputChanged;
            txtEMSum.TextChanged += OnInputChanged;

            // ====================================================
            // گشنیز (G)
            // ====================================================
            txtGMGHMAD.TextChanged += OnInputChanged;
            txtGNMAD.TextChanged += OnInputChanged;
            txtGMMAD.TextChanged += OnInputChanged;

            txtGMGHKHTDPN.TextChanged += OnInputChanged;
            txtGNKHTDPN.TextChanged += OnInputChanged;
            txtGMKHTDPN.TextChanged += OnInputChanged;

            txtGMGHKHTDPSH.TextChanged += OnInputChanged;
            txtGNKHTDPSH.TextChanged += OnInputChanged;
            txtGMKHTDPSH.TextChanged += OnInputChanged;

            txtGMGHBTSHFSPSH.TextChanged += OnInputChanged;
            txtGNBTSHFSPSH.TextChanged += OnInputChanged;
            txtGMBTSHFSPSH.TextChanged += OnInputChanged;

            txtGMGHMJTMM.TextChanged += OnInputChanged;
            txtGNMJTMM.TextChanged += OnInputChanged;
            txtGMMJTMM.TextChanged += OnInputChanged;

            txtGMGHMJTSM.TextChanged += OnInputChanged;
            txtGNMJTSM.TextChanged += OnInputChanged;
            txtGMMJTSM.TextChanged += OnInputChanged;

            txtGMGHMBATST.TextChanged += OnInputChanged;
            txtGNMBATST.TextChanged += OnInputChanged;
            txtGMMBATST.TextChanged += OnInputChanged;

            txtGMGHMJTSKH.TextChanged += OnInputChanged;
            txtGNMJTSKH.TextChanged += OnInputChanged;
            txtGMMJTSKH.TextChanged += OnInputChanged;

            txtGMGHZA.TextChanged += OnInputChanged;
            txtGNZA.TextChanged += OnInputChanged;
            txtGMZA.TextChanged += OnInputChanged;

            txtGMGHMPD.TextChanged += OnInputChanged;
            txtGNMPD.TextChanged += OnInputChanged;
            txtGMMPD.TextChanged += OnInputChanged;

            txtGMGHZ.TextChanged += OnInputChanged;
            txtGNZ.TextChanged += OnInputChanged;
            txtGMZ.TextChanged += OnInputChanged;

            txtGMGHHDS.TextChanged += OnInputChanged;
            txtGNHDS.TextChanged += OnInputChanged;
            txtGMHDS.TextChanged += OnInputChanged;

            txtGMGHSum.TextChanged += OnInputChanged;
            txtGNSum.TextChanged += OnInputChanged;
            txtGMSum.TextChanged += OnInputChanged;

            // ====================================================
            // قورمه سبزی (GHM)
            // ====================================================
            txtGHMGHMAD.TextChanged += OnInputChanged;
            txtGHNMAD.TextChanged += OnInputChanged;
            txtGHMMAD.TextChanged += OnInputChanged;

            txtGHMGHKHTDPN.TextChanged += OnInputChanged;
            txtGHNKHTDPN.TextChanged += OnInputChanged;
            txtGHMKHTDPN.TextChanged += OnInputChanged;

            txtGHMGHKHTDPSH.TextChanged += OnInputChanged;
            txtGHNKHTDPSH.TextChanged += OnInputChanged;
            txtGHMKHTDPSH.TextChanged += OnInputChanged;

            txtGHMGHBTSHFSPSH.TextChanged += OnInputChanged;
            txtGHNBTSHFSPSH.TextChanged += OnInputChanged;
            txtGHMBTSHFSPSH.TextChanged += OnInputChanged;

            txtGHMGHMJTMM.TextChanged += OnInputChanged;
            txtGHNMJTMM.TextChanged += OnInputChanged;
            txtGHMMJTMM.TextChanged += OnInputChanged;

            txtGHMGHMJTSM.TextChanged += OnInputChanged;
            txtGHNMJTSM.TextChanged += OnInputChanged;
            txtGHMMJTSM.TextChanged += OnInputChanged;

            txtGHMGHMBATST.TextChanged += OnInputChanged;
            txtGHNMBATST.TextChanged += OnInputChanged;
            txtGHMMBATST.TextChanged += OnInputChanged;

            txtGHMGHMJTSKH.TextChanged += OnInputChanged;
            txtGHNMJTSKH.TextChanged += OnInputChanged;
            txtGHMMJTSKH.TextChanged += OnInputChanged;

            txtGHMGHZA.TextChanged += OnInputChanged;
            txtGHNZA.TextChanged += OnInputChanged;
            txtGHMZA.TextChanged += OnInputChanged;

            txtGHMGHMPD.TextChanged += OnInputChanged;
            txtGHNMPD.TextChanged += OnInputChanged;
            txtGHMMPD.TextChanged += OnInputChanged;

            txtGHMGHZ.TextChanged += OnInputChanged;
            txtGHNZ.TextChanged += OnInputChanged;
            txtGHMZ.TextChanged += OnInputChanged;

            txtGHMGHHDS.TextChanged += OnInputChanged;
            txtGHNHDS.TextChanged += OnInputChanged;
            txtGHMHDS.TextChanged += OnInputChanged;

            txtGHMGHSum.TextChanged += OnInputChanged;
            txtGHNSum.TextChanged += OnInputChanged;
            txtGHMSum.TextChanged += OnInputChanged;

            // ====================================================
            // هویج و پیاز (HP)
            // ====================================================
            txtHPMGHMAD.TextChanged += OnInputChanged;
            txtHPNMAD.TextChanged += OnInputChanged;
            txtHPMMAD.TextChanged += OnInputChanged;

            txtHPMGHKHTDPN.TextChanged += OnInputChanged;
            txtHPNKHTDPN.TextChanged += OnInputChanged;
            txtHPMKHTDPN.TextChanged += OnInputChanged;

            txtHPMGHKHTDPSH.TextChanged += OnInputChanged;
            txtHPNKHTDPSH.TextChanged += OnInputChanged;
            txtHPMKHTDPSH.TextChanged += OnInputChanged;

            txtHPMGHBTSHFSPSH.TextChanged += OnInputChanged;
            txtHPNBTSHFSPSH.TextChanged += OnInputChanged;
            txtHPMBTSHFSPSH.TextChanged += OnInputChanged;

            txtHPMGHMJTMM.TextChanged += OnInputChanged;
            txtHPNMJTMM.TextChanged += OnInputChanged;
            txtHPMMJTMM.TextChanged += OnInputChanged;

            txtHPMGHMJTSM.TextChanged += OnInputChanged;
            txtHPNMJTSM.TextChanged += OnInputChanged;
            txtHPMMJTSM.TextChanged += OnInputChanged;

            txtHPMGHMBATST.TextChanged += OnInputChanged;
            txtHPNMBATST.TextChanged += OnInputChanged;
            txtHPMMBATST.TextChanged += OnInputChanged;

            txtHPMGHMJTSKH.TextChanged += OnInputChanged;
            txtHPNMJTSKH.TextChanged += OnInputChanged;
            txtHPMMJTSKH.TextChanged += OnInputChanged;

            txtHPMGHZA.TextChanged += OnInputChanged;
            txtHPNZA.TextChanged += OnInputChanged;
            txtHPMZA.TextChanged += OnInputChanged;

            txtHPMGHMPD.TextChanged += OnInputChanged;
            txtHPNMPD.TextChanged += OnInputChanged;
            txtHPMMPD.TextChanged += OnInputChanged;

            txtHPMGHZ.TextChanged += OnInputChanged;
            txtHPNZ.TextChanged += OnInputChanged;
            txtHPMZ.TextChanged += OnInputChanged;

            txtHPMGHHDS.TextChanged += OnInputChanged;
            txtHPNHDS.TextChanged += OnInputChanged;
            txtHPMHDS.TextChanged += OnInputChanged;

            txtHPMGHSum.TextChanged += OnInputChanged;
            txtHPNSum.TextChanged += OnInputChanged;
            txtHPMSum.TextChanged += OnInputChanged;

            // ====================================================
            // لوبیا سبز (L)
            // ====================================================
            txtLMGHMAD.TextChanged += OnInputChanged;
            txtLNMAD.TextChanged += OnInputChanged;
            txtLMMAD.TextChanged += OnInputChanged;

            txtLMGHKHTDPN.TextChanged += OnInputChanged;
            txtLNKHTDPN.TextChanged += OnInputChanged;
            txtLMKHTDPN.TextChanged += OnInputChanged;

            txtLMGHKHTDPSH.TextChanged += OnInputChanged;
            txtLNKHTDPSH.TextChanged += OnInputChanged;
            txtLMKHTDPSH.TextChanged += OnInputChanged;

            txtLMGHBTSHFSPSH.TextChanged += OnInputChanged;
            txtLNBTSHFSPSH.TextChanged += OnInputChanged;
            txtLMBTSHFSPSH.TextChanged += OnInputChanged;

            txtLMGHMJTMM.TextChanged += OnInputChanged;
            txtLNMJTMM.TextChanged += OnInputChanged;
            txtLMMJTMM.TextChanged += OnInputChanged;

            txtLMGHMJTSM.TextChanged += OnInputChanged;
            txtLNMJTSM.TextChanged += OnInputChanged;
            txtLMMJTSM.TextChanged += OnInputChanged;

            txtLMGHMBATST.TextChanged += OnInputChanged;
            txtLNMBATST.TextChanged += OnInputChanged;
            txtLMMBATST.TextChanged += OnInputChanged;

            txtLMGHMJTSKH.TextChanged += OnInputChanged;
            txtLNMJTSKH.TextChanged += OnInputChanged;
            txtLMMJTSKH.TextChanged += OnInputChanged;

            txtLMGHZA.TextChanged += OnInputChanged;
            txtLNZA.TextChanged += OnInputChanged;
            txtLMZA.TextChanged += OnInputChanged;

            txtLMGHMPD.TextChanged += OnInputChanged;
            txtLNMPD.TextChanged += OnInputChanged;
            txtLMMPD.TextChanged += OnInputChanged;

            txtLMGHZ.TextChanged += OnInputChanged;
            txtLNZ.TextChanged += OnInputChanged;
            txtLMZ.TextChanged += OnInputChanged;

            txtLMGHHDS.TextChanged += OnInputChanged;
            txtLNHDS.TextChanged += OnInputChanged;
            txtLMHDS.TextChanged += OnInputChanged;

            txtLMGHSum.TextChanged += OnInputChanged;
            txtLNSum.TextChanged += OnInputChanged;
            txtLMSum.TextChanged += OnInputChanged;

            // ====================================================
            // کرفس (K)
            // ====================================================
            txtKMGHMAD.TextChanged += OnInputChanged;
            txtKNMAD.TextChanged += OnInputChanged;
            txtKMMAD.TextChanged += OnInputChanged;

            txtKMGHKHTDPN.TextChanged += OnInputChanged;
            txtKNKHTDPN.TextChanged += OnInputChanged;
            txtKMKHTDPN.TextChanged += OnInputChanged;

            txtKMGHKHTDPSH.TextChanged += OnInputChanged;
            txtKNKHTDPSH.TextChanged += OnInputChanged;
            txtKMKHTDPSH.TextChanged += OnInputChanged;

            txtKMGHBTSHFSPSH.TextChanged += OnInputChanged;
            txtKNBTSHFSPSH.TextChanged += OnInputChanged;
            txtKMBTSHFSPSH.TextChanged += OnInputChanged;

            txtKMGHMJTMM.TextChanged += OnInputChanged;
            txtKNMJTMM.TextChanged += OnInputChanged;
            txtKMMJTMM.TextChanged += OnInputChanged;

            txtKMGHMJTSM.TextChanged += OnInputChanged;
            txtKNMJTSM.TextChanged += OnInputChanged;
            txtKMMJTSM.TextChanged += OnInputChanged;

            txtKMGHMBATST.TextChanged += OnInputChanged;
            txtKNMBATST.TextChanged += OnInputChanged;
            txtKMMBATST.TextChanged += OnInputChanged;

            txtKMGHMJTSKH.TextChanged += OnInputChanged;
            txtKNMJTSKH.TextChanged += OnInputChanged;
            txtKMMJTSKH.TextChanged += OnInputChanged;

            txtKMGHZA.TextChanged += OnInputChanged;
            txtKNZA.TextChanged += OnInputChanged;
            txtKMZA.TextChanged += OnInputChanged;

            txtKMGHMPD.TextChanged += OnInputChanged;
            txtKNMPD.TextChanged += OnInputChanged;
            txtKMMPD.TextChanged += OnInputChanged;

            txtKMGHZ.TextChanged += OnInputChanged;
            txtKNZ.TextChanged += OnInputChanged;
            txtKMZ.TextChanged += OnInputChanged;

            txtKMGHHDS.TextChanged += OnInputChanged;
            txtKNHDS.TextChanged += OnInputChanged;
            txtKMHDS.TextChanged += OnInputChanged;

            txtKMGHSum.TextChanged += OnInputChanged;
            txtKNSum.TextChanged += OnInputChanged;
            txtKMSum.TextChanged += OnInputChanged;

            // ====================================================
            // شوید (SHV)
            // ====================================================
            txtSHVMGHMAD.TextChanged += OnInputChanged;
            txtSHVNMAD.TextChanged += OnInputChanged;
            txtSHVMMAD.TextChanged += OnInputChanged;

            txtSHVMGHKHTDPN.TextChanged += OnInputChanged;
            txtSHVNKHTDPN.TextChanged += OnInputChanged;
            txtSHVMKHTDPN.TextChanged += OnInputChanged;

            txtSHVMGHKHTDPSH.TextChanged += OnInputChanged;
            txtSHVNKHTDPSH.TextChanged += OnInputChanged;
            txtSHVMKHTDPSH.TextChanged += OnInputChanged;

            txtSHVMGHBTSHFSPSH.TextChanged += OnInputChanged;
            txtSHVNBTSHFSPSH.TextChanged += OnInputChanged;
            txtSHVMBTSHFSPSH.TextChanged += OnInputChanged;

            txtSHVMGHMJTMM.TextChanged += OnInputChanged;
            txtSHVNMJTMM.TextChanged += OnInputChanged;
            txtSHVMMJTMM.TextChanged += OnInputChanged;

            txtSHVMGHMJTSM.TextChanged += OnInputChanged;
            txtSHVNMJTSM.TextChanged += OnInputChanged;
            txtSHVMMJTSM.TextChanged += OnInputChanged;

            txtSHVMGHMBATST.TextChanged += OnInputChanged;
            txtSHVNMBATST.TextChanged += OnInputChanged;
            txtSHVMMBATST.TextChanged += OnInputChanged;

            txtSHVMGHMJTSKH.TextChanged += OnInputChanged;
            txtSHVNMJTSKH.TextChanged += OnInputChanged;
            txtSHVMMJTSKH.TextChanged += OnInputChanged;

            txtSHVMGHZA.TextChanged += OnInputChanged;
            txtSHVNZA.TextChanged += OnInputChanged;
            txtSHVMZA.TextChanged += OnInputChanged;

            txtSHVMGHMPD.TextChanged += OnInputChanged;
            txtSHVNMPD.TextChanged += OnInputChanged;
            txtSHVMMPD.TextChanged += OnInputChanged;

            txtSHVMGHZ.TextChanged += OnInputChanged;
            txtSHVNZ.TextChanged += OnInputChanged;
            txtSHVMZ.TextChanged += OnInputChanged;

            txtSHVMGHHDS.TextChanged += OnInputChanged;
            txtSHVNHDS.TextChanged += OnInputChanged;
            txtSHVMHDS.TextChanged += OnInputChanged;

            txtSHVMGHSum.TextChanged += OnInputChanged;
            txtSHVNSum.TextChanged += OnInputChanged;
            txtSHVMSum.TextChanged += OnInputChanged;

            // ====================================================
            // هزینه‌ها (Hazine)
            // ====================================================
            txtHazineAZ.TextChanged += OnInputChanged;
            txtSumHazineHS.TextChanged += OnInputChanged;
            txtHazineMali.TextChanged += OnInputChanged;
            txtHazineOET.TextChanged += OnInputChanged;
            txtHazineTF.TextChanged += OnInputChanged;
            txtHazineBIme23.TextChanged += OnInputChanged;
            txtHazineHD.TextChanged += OnInputChanged;
        }
        private void OnInputChanged(object sender, EventArgs e)
        {
            UpdateAllCalculations();
        }
        private void UpdateAllCalculations()
        {
            try
            {
                BahaieTamamShodeDataManager.GetValuesFromForm(this);
                txtJNKHTDPN.Text = BahaieFormula.Jafari_KharidTeyDorePakNashode_Nerkh().ToString("N0");

            }
            catch 
            {

            }
        }

        private void NumericTextBox_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (decimal.TryParse(txt.Text.Replace(",", ""), out decimal number))
            {
                txt.Text = number.ToString("#,##0.##");
            }
        }
        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
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
    }
}
