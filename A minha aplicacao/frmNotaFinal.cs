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
    public partial class frmNotaFinal : Form
    {

        int notasCorretas = 0;

        public frmNotaFinal()
        {
            InitializeComponent();
        }

        private void frmNotaFinal_Load(object sender, EventArgs e)
        {
            lblNotaFinal.Visible = false;
            btnLimpar.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            verificarValorNotas();

            if (notasCorretas == 5) { 
            decimal valor1 = (Properties.Settings.Default.peso1 * (Convert.ToInt16(txtTeste1.Text)+Convert.ToInt16(txtTeste2.Text)))/2;
            decimal valor2 = (Properties.Settings.Default.peso2 * (Convert.ToInt16(txtTrabPratico1.Text)+Convert.ToInt16(txtTrabPratico2.Text)))/2;
            decimal valor3 = Properties.Settings.Default.peso3 * (Convert.ToInt16(txtTrabFinal.Text));
            int resultadoFinal = Convert.ToInt16(valor1 + valor2 + valor3);

            lblNotaFinal.Text = "A nota final é: " + Convert.ToString(resultadoFinal) + " valores.";
            
            }
            else
            {
                lblNotaFinal.Text = "As notas têm que estar entre 0 e 20 e/ou não pode conter letras.";
            }
            lblNotaFinal.Left = this.Width / 2 - lblNotaFinal.Width / 2;
            lblNotaFinal.Visible = true;
            btnLimpar.Visible = true;
            notasCorretas = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblNotaFinal.Visible = false;
            btnLimpar.Visible = false;
            txtTeste1.Clear();
            txtTeste2.Clear();
            txtTrabFinal.Clear();
            txtTrabPratico1.Clear();
            txtTrabPratico2.Clear();
        }

        private void verificarValorNotas()
        {

            if (Information.IsNumeric(txtTeste1.Text) && Convert.ToInt16(txtTeste1.Text) >= 0 && Convert.ToInt16(txtTeste1.Text) <= 20 && txtTeste1.Text != "")
            {
                notasCorretas += 1;
            }

            if (Information.IsNumeric(txtTeste2.Text) && Convert.ToInt16(txtTeste2.Text) >= 0 && Convert.ToInt16(txtTeste2.Text) <= 20 && txtTeste2.Text != "")
            {
                notasCorretas += 1;
            }

            if (Information.IsNumeric(txtTrabPratico1.Text) && Convert.ToInt16(txtTrabPratico1.Text) >= 0 && Convert.ToInt16(txtTrabPratico1.Text) <= 20 && txtTrabPratico1.Text != "")
            {
                notasCorretas += 1;
            }

            if (Information.IsNumeric(txtTrabPratico2.Text) && Convert.ToInt16(txtTrabPratico2.Text) >= 0 && Convert.ToInt16(txtTrabPratico2.Text) <= 20 && txtTrabPratico2.Text != "")
            {
                notasCorretas += 1;
            }

            if (Information.IsNumeric(txtTrabFinal.Text) && Convert.ToInt16(txtTrabFinal.Text) >= 0 && Convert.ToInt16(txtTrabFinal.Text) <= 20 && txtTrabFinal.Text != "")
            {
                notasCorretas += 1;
            }
            
            }
        
    }
}
