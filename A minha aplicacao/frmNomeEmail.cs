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
    public partial class frmNomeEmail : Form
    {
        public frmNomeEmail()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCompleto.Text;

            string[] primeiro;
            primeiro = nome.Split(' '); //divide o a string pelo caracter escolhido

            int i = nome.LastIndexOf(' '); //vai buscar o index do ultimo catacter escolhido
            int t = nome.Length; //vai buscar o numero total de caracteres

            string apelido = nome.Substring(i + 1); //remover caracteres de x index até ao fim
            string primeiraLetra = nome.Substring(0, 1); //remover caracteres de x a y

            lblResultadoNome.Text = primeiro[0].ToUpper() + " " + apelido.ToUpper();
            lblResultadoEmail1.Text = primeiro[0].ToLower() + "." + apelido.ToLower() + "@xpto.pt";
            lblResultadoEmail2.Text = primeiraLetra.ToLower() + apelido.ToLower() + "@xpto.pt";

            lblResultadoEmail1.Visible = true;
            lblResultadoEmail2.Visible = true;
            lblResultadoNome.Visible = true;
            lblEmail1.Visible = true;
            lblEmail2.Visible = true;
            lblNome.Visible = true;
        }

        private void frmNomeEmail_Load(object sender, EventArgs e)
        {
            lblResultadoEmail1.Visible = false;
            lblResultadoEmail2.Visible = false;
            lblResultadoNome.Visible = false;
            lblEmail1.Visible = false;
            lblEmail2.Visible = false;
            lblNome.Visible = false;

        }
    }
}
