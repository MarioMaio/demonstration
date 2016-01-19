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
    public partial class frmMaiorTres : Form
    {

        decimal maior;
        bool igual = false;

        public frmMaiorTres()
        {
            InitializeComponent();
        }

        private void frmMaiorTres_Load(object sender, EventArgs e)
        {
            lblMaior.Visible = false;
            btnNovo.Visible = false;

            reajustar();

            MessageBox.Show("Insere 3 números para veres qual é o maior.");
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            igual = false;
            if (Information.IsNumeric(txtNumero1.Text) && Information.IsNumeric(txtNumero2.Text) && Information.IsNumeric(txtNumero3.Text) && txtNumero1.Text != "" && txtNumero2.Text != "" && txtNumero3.Text != "")
            {
                if (Convert.ToDecimal(txtNumero1.Text) > Convert.ToDecimal(txtNumero2.Text))
                {
                    maior = Convert.ToDecimal(txtNumero1.Text);
                }
                else if (Convert.ToDecimal(txtNumero1.Text) < Convert.ToDecimal(txtNumero2.Text))
                {
                    maior = Convert.ToDecimal(txtNumero2.Text);
                }
                else
                {
                    maior = Convert.ToDecimal(txtNumero1.Text);
                    igual = true;
                }

                if (maior < Convert.ToDecimal(txtNumero3.Text))
                {
                    maior = Convert.ToDecimal(txtNumero3.Text);
                    igual = false;
                }
                else if (maior == Convert.ToDecimal(txtNumero3.Text))
                {
                    igual = true;
                }

                if (igual)
                {
                    lblMaior.Text = "Os 3 números são iguais.";
                }
                else { 
                    lblMaior.Text = "O maior número é o : " + maior.ToString();
                }

                lblMaior.Visible = true;
                btnMaior.Enabled = false;
                btnNovo.Visible = true;

            }
            else
            {
                lblMaior.Text = "Insira os números.";
                lblMaior.Visible = true;
            }

            reajustar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero3.Clear();
            btnNovo.Visible = false;
            lblMaior.Visible = false;
            btnMaior.Enabled = true;

            reajustar();
        }

        private void reajustar()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
