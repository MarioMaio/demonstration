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
    
    
    
    public partial class frmConverterOpt : Form
    {
        decimal valorConvertido;
        string moeda;
        
        public frmConverterOpt()
        {
            InitializeComponent();
        }

        private void frmConverterOpt_Load(object sender, EventArgs e)
        {
            lblConversao.Visible = false;
            btnCambio.Enabled = false;
        }

        private void rbDollar_CheckedChanged(object sender, EventArgs e)
        {
            valorConvertido = Properties.Settings.Default.valorDollar;
            btnCambio.Enabled = true;
            moeda = " Dollar";
        }

        private void rbCoroaSueca_CheckedChanged(object sender, EventArgs e)
        {
            valorConvertido = Properties.Settings.Default.valorCoroaSueca;
            btnCambio.Enabled = true;
            moeda = " SEK";
        }

        private void rbEscudoCaboVerde_CheckedChanged(object sender, EventArgs e)
        {
            valorConvertido = Properties.Settings.Default.valorEscudoCaboVerde;
            btnCambio.Enabled = true;
            moeda = " ECV";
        }

        private void rbReal_CheckedChanged(object sender, EventArgs e)
        {
            valorConvertido = Properties.Settings.Default.valorReal;
            btnCambio.Enabled = true;
            moeda = " Real";
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            if (Information.IsNumeric(txtValor.Text) && txtValor.Text != "")
            {
                lblConversao.Text = (Convert.ToDecimal(txtValor.Text) * valorConvertido).ToString() + moeda;
            }
            else
            {
                lblConversao.Text = "Introduza um valor numérico.";
            }

            lblConversao.Visible = true;
        }
    }
}
