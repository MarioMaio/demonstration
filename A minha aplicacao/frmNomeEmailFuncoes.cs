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
    public partial class frmNomeEmailFuncoes : Form
    {

        string nome;

        public frmNomeEmailFuncoes()
        {
            InitializeComponent();
        }

        private void frmNomeEmailFuncoes_Load(object sender, EventArgs e)
        {
            
            lblResultadoEmail1.Visible = false;
            lblResultadoEmail2.Visible = false;
            lblResultadoNome.Visible = false;
            lblEmail1.Visible = false;
            lblEmail2.Visible = false;
            lblNome.Visible = false;
            lblSemEspacos.Visible = false;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            nome = txtNomeCompleto.Text;
            
            //nomeCurto();

            //email();

            //emailAlternativo();

            //retiraEspacos(nome);

            lblSemEspacos.Text = HobbiesModa.HobbieModa("Dançar", "Correr", "Pedalar", "Teatro", "Correr", "Boxe");
            //lblSemEspacos.Text = Substituir.substituirLetras(nome);
            //lblSemEspacos.Text = Exercicio16.retiraEspacos(nome);
            lblSemEspacos.Visible = true;
        }

        private void nomeCurto()
        {
            lblResultadoNome.Text = Exercicio16.nomeCurto(nome);

            lblResultadoNome.Visible = true;
            lblNome.Visible = true;
        }

        private void email()
        {
            lblResultadoEmail1.Text = Exercicio16.email(nome);

            lblResultadoEmail1.Visible = true;
            lblEmail1.Visible = true;
        }

        private void emailAlternativo()
        {

            lblResultadoEmail2.Text = Exercicio16.emailAlternativo(nome);

            lblResultadoEmail2.Visible = true;
            lblEmail2.Visible = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultadoEmail1.Visible = false;
            lblResultadoEmail2.Visible = false;
            lblResultadoNome.Visible = false;
            lblEmail1.Visible = false;
            lblEmail2.Visible = false;
            lblNome.Visible = false;
            lblSemEspacos.Visible = false;
            txtNomeCompleto.Text = "";
        }

        
    }
}
