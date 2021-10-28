using System;
using System.Windows.Forms;

namespace AtivCkBx
{
    public partial class frmAmazon : Form
    {
        public frmAmazon()
        {
            InitializeComponent();
        }

        // Criação de uma sub-rotina/método do tipo void:
        void LimparCheckBox()
        {
            cbxEcho.Checked = false;
            cbxSmart.Checked = false;
            cbxKindle.Checked = false;
            cbxLago.Checked = false;
            cbxBichos.Checked = false;
            cbxManha.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Bloqueio de caracteres, símbolos e espaços em brancos no TextBox:
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void frmAmazon_Load(object sender, EventArgs e)
        {
            // Convertendo números para string e atribuindo-os nas TextBox:
            txtEcho.Text = 379.ToString();
            txtSmart.Text = 63.ToString();
            txtKindle.Text = 379.ToString();

            txtLago.Text = 8.ToString();
            txtBichos.Text = 10.ToString();
            txtManha.Text = 19.ToString();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
                txtValor.Text = 0.ToString();
            else
            {
                LimparCheckBox();
                txtTotal.Text = txtValor.Text;
            }
        }

        private void cbxEcho_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEcho.Checked == true)
            {
                txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtEcho.Text)).ToString();
            }
            else
            {
                txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtEcho.Text)).ToString();
            }
        }

        private void cbxSmart_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSmart.Checked)
            {
                txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtSmart.Text)).ToString();
            }
            else
            {
                txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtSmart.Text)).ToString();
            }
        }

        private void cbxKindle_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxKindle.Checked)
            {
                txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtKindle.Text)).ToString();
            }
            else
            {
                txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtKindle.Text)).ToString();
            }
        }

        private void cbxLago_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLago.Checked)
            {
                txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtLago.Text)).ToString();
            }
            else
            {
                txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtLago.Text)).ToString();
            }
        }

        private void cbxBichos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxBichos.Checked == true)
            {
                txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtBichos.Text)).ToString();
            }
            else
            {
                txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtBichos.Text)).ToString();
            }
        }

        private void cbxManha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxManha.Checked == true)
            {
                txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtManha.Text)).ToString();
            }
            else
            {
                txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtManha.Text)).ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCheckBox();

            txtValor.Text = 0.ToString();
            txtTotal.Text = 0.ToString();
        }
    }
}
