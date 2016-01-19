using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_minha_aplicacao
{
    public partial class frmTabuada : Form
    {

        public frmTabuada()
        {
            InitializeComponent();
        }

        private void frmTabuada_Load(object sender, EventArgs e)
        {
            lblTabuada.Text = "";
            lblTabuada.Visible = false;
            btnLimpa.Visible = false;

            reajustar();
        }

        private void reajustar()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            lblTabuada.Text = "";

            for (int i = 0; i <= 9; i++)
            {
                int pos = i + 1;
                lblTabuada.Text += pos + " X " + nudValor.Value + " = " + (Convert.ToInt16(nudValor.Value) * pos) + "\n";
            }

            lblTabuada.Visible = true;
            btnLimpa.Visible = true;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            lblTabuada.Visible = false;
            btnLimpa.Visible = false;

            reajustar();
        }
    }
}
