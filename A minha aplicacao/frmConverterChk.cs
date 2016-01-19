using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace A_minha_aplicacao
{
    public partial class frmConverterChk : Form
    {
        decimal valorConvertido;
        string moeda;
               public frmConverterChk()
        {
            InitializeComponent();
        }

        private void frmConverterChk_Load(object sender, EventArgs e)
        {
            btnCambio.Enabled = false;
            lblConversao.Visible = false;
            lblConversao.Text = "";
        }

        private void cbDollar_CheckedChanged(object sender, EventArgs e)
        {
            btnCambio.Enabled = true;
        }

        private void cbCoroaSueca_CheckedChanged(object sender, EventArgs e)
        {
            btnCambio.Enabled = true;
        }

        private void cbEscudoCaboVerde_CheckedChanged(object sender, EventArgs e)
        {
            btnCambio.Enabled = true;
        }

        private void cbReal_CheckedChanged(object sender, EventArgs e)
        {
            btnCambio.Enabled = true;
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            lblConversao.Text = "";
            if (Information.IsNumeric(txtValor.Text) && txtValor.Text != "")
            {
                if(cbDollar.Checked){
                    valorConvertido = Properties.Settings.Default.valorDollar;
                    moeda = " Dollar";
                    lblConversao.Text = lblConversao.Text + valorConvertido + moeda + "\n";
                }

                if (cbCoroaSueca.Checked)
                {
                    valorConvertido = Properties.Settings.Default.valorCoroaSueca;
                    moeda = " SEK";
                    lblConversao.Text = lblConversao.Text + valorConvertido + moeda + "\n";
                }

                if (cbEscudoCaboVerde.Checked)
                {
                    valorConvertido = Properties.Settings.Default.valorEscudoCaboVerde;
                    moeda = " ECV";
                    lblConversao.Text = lblConversao.Text + valorConvertido + moeda + "\n";
                }

                if (cbReal.Checked)
                {
                    valorConvertido = Properties.Settings.Default.valorReal;
                    moeda = " Real";
                    lblConversao.Text = lblConversao.Text + valorConvertido + moeda + "\n";
                }
                
            }
            else
            {
                lblConversao.Text = "Introduza um valor numérico.";
            }
            lblConversao.Visible = true;
            
        }
    }
}
