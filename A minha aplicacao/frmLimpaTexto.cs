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
    public partial class frmLimpaTexto : Form
    {
        public frmLimpaTexto()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control boxes in this.Controls) //control serve para procurar todos os elementos na form
            {
                if (boxes is TextBox)
                {
                    boxes.Text = "";
                }
            }
        }
    }
}
