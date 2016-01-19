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
    public partial class frmCumprimentos : Form
    {
        public frmCumprimentos()
        {
            InitializeComponent();
        }

        private void frmCumprimentos_Load(object sender, EventArgs e)
        {
            btnLimpar.Visible = false;
            lblResultado.Visible = false;
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtCumprimento.Text + " " + txtNome.Text;
            btnLimpar.Visible = true;
            lblResultado.Visible = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnLimpar.Visible = false;
            lblResultado.Visible = false;
            txtCumprimento.Clear();
            txtNome.Clear();
        }

    }
}
