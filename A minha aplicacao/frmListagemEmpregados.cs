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
    public partial class frmListagemEmpregados : Form
    {
        public frmListagemEmpregados()
        {
            InitializeComponent();
        }

        private void frmListagemEmpregados_Load(object sender, EventArgs e)
        {

            txtListagem.Text = "";
            for (int i = 0; i < frmFormulario.empregados.Count; i+=8)
            {
                txtListagem.Text += "Nome: " + frmFormulario.empregados[i] + "\r\n" + "Morada: " + frmFormulario.empregados[i + 1] + "\r\n" + "Idade: " + frmFormulario.empregados[i + 2] + "\r\n" + "Sexo: " + frmFormulario.empregados[i + 3] + "\r\n" + "Contacto: " + frmFormulario.empregados[i + 4] + "\r\n" + "Email: " + frmFormulario.empregados[i + 5] + "\r\n" + "Nº cartão Cidadão: " + frmFormulario.empregados[i + 6] + "\r\n" + "Nº Contribuinte: " + frmFormulario.empregados[i + 7] + "\r\n" + "\r\n";
            }

            //txtListagem.Text += "Nome: " + frmFormulario.nome + "\r\n" + "Morada: " + frmFormulario.morada + "\r\n" + "Idade: " + frmFormulario.idade + "\r\n";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
