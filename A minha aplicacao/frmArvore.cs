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
    public partial class frmArvore : Form
    {
        public frmArvore()
        {
            InitializeComponent();
        }

        private void frmArvore_Load(object sender, EventArgs e)
        {
            btnLimpar.Enabled = false;
            lblArvore.Visible = false;
            lblArvore.Text = "";

            reajustar();
        }

        private void reajustar()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void btnFazArvore_Click(object sender, EventArgs e)
        {
            lblArvore.Text = "";
            for (int i = 0; i < nudFazArvore.Value; i++)
            {
                for (int j = 0; j < 2*i+1; j++)
                {
                    if (j%2 == 1)
                    {
                        lblArvore.Text += "|";
                    }
                    else
                    {
                        lblArvore.Text += "*";
                    }
                    
                }

                lblArvore.Text += "\n";
            }
            lblArvore.ForeColor = System.Drawing.Color.Brown;
            lblArvore.Text += "||" + "\n" + "||";
            lblArvore.Visible = true;
            btnLimpar.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnLimpar.Enabled = false;
            lblArvore.Visible = false;
            nudFazArvore.Value = 2;

            reajustar();
        }
    }
}
