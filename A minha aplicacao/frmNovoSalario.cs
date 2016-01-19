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
    public partial class frmNovoSalario : Form
    {

        decimal gratificacao;
        public frmNovoSalario()
        {
            InitializeComponent();
        }

        private void frmNovoSalario_Load(object sender, EventArgs e)
        {
            lblNovoSalario.Visible = false;
            btnLimpar.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(Information.IsNumeric(txtSalario.Text) && txtSalario.Text != ""){
                

                if (Convert.ToDecimal(txtSalario.Text) < 500)
                {
                    gratificacao = 15;
                }

                if (Convert.ToDecimal(txtSalario.Text) >= 500 && Convert.ToDecimal(txtSalario.Text) < 750)
                {
                    gratificacao = 10;
                }

                if (Convert.ToDecimal(txtSalario.Text) >= 750 && Convert.ToDecimal(txtSalario.Text) < 1000)
                {
                    gratificacao = 5;
                }

                if (Convert.ToDecimal(txtSalario.Text) >= 1000 && Convert.ToDecimal(txtSalario.Text) < 5000)
                {
                    gratificacao = 1;
                }

                if (Convert.ToDecimal(txtSalario.Text) >= 5000)
                {
                    gratificacao = 0;
                }
                
                lblNovoSalario.Text = (Convert.ToDecimal(txtSalario.Text) + (Convert.ToDecimal(txtSalario.Text)) * (gratificacao/100)).ToString() + " euros";
                lblNovoSalario.Left = this.Width / 2 - lblNovoSalario.Width / 2;
                lblNovoSalario.Visible = true;
                btnCalcular.Enabled = false;
                btnLimpar.Visible = true;
                txtSalario.SelectAll();
            }
            else
            {
                lblNovoSalario.Text = "Insira um valor numérico.";
                lblNovoSalario.Left = this.Width / 2 - lblNovoSalario.Width / 2;
                lblNovoSalario.Visible = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = true;
            lblNovoSalario.Visible = false;
            txtSalario.Clear();
            btnLimpar.Visible = false;
        }
    }
}
