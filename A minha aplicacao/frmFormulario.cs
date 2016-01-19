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
using System.Collections;

namespace A_minha_aplicacao
{
    public partial class frmFormulario : Form
    {

        public static string nome;
        public static string morada;
        public static long idade;
        public static string sexo;
        public static Int32 contacto;
        public static string emailEmpregado;
        public static Int32 cartaoCidadao;
        public static Int32 contribuinte;
        public static decimal salario;

        public static ArrayList empregados = new ArrayList();
        
        public frmFormulario()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            

            if (txtNome.Text != "")
            {
                //nome = txtNome.Text;
                if (txtMorada.Text != "")
                {
                    //morada = txtMorada.Text;
                    if (DateAndTime.DateDiff(DateInterval.Year, mocCalendario.SelectionStart, DateTime.Now) > 17)
                    {
                        if (rabMasculino.Checked || rabFeminino.Checked )
                        {
                            if (Information.IsNumeric(txtContacto.Text) && txtContacto.Text.Length == 9)
                            {
                                if (txtEmail.Text != "")
                                {
                                    if (testarEmail(txtEmail.Text))
                                    {
                                        if (Information.IsNumeric(txtCartaoCidadao.Text))
                                        {
                                            if (Information.IsNumeric(txtContribuinte.Text))
                                            {
                                                if (txtSalario.Text != "")
                                                {
                                                    //salario = pontoParaVirgula();
                                                    if (Information.IsNumeric(txtSalario.Text))
                                                    {
                                                        nome = txtNome.Text;
                                                        morada = txtMorada.Text;
                                                        idade = DateAndTime.DateDiff(DateInterval.Year, mocCalendario.SelectionStart, DateTime.Now);
                                                        contacto = Convert.ToInt32(txtContacto.Text);
                                                        emailEmpregado = txtEmail.Text;
                                                        cartaoCidadao = Convert.ToInt32(txtCartaoCidadao.Text);
                                                        contribuinte = Convert.ToInt32(txtContribuinte.Text);

                                                        txtNome.Text = "";
                                                        txtMorada.Text = "";
                                                        mocCalendario.SetDate(DateTime.Now);
                                                        rabMasculino.Select();
                                                        txtContacto.Text = "";
                                                        txtEmail.Text = "";
                                                        txtCartaoCidadao.Text = "";
                                                        txtContribuinte.Text = "";

                                                        empregados.Add(nome);
                                                        empregados.Add(morada);
                                                        empregados.Add(idade);
                                                        empregados.Add(sexo);
                                                        empregados.Add(contacto);
                                                        empregados.Add(emailEmpregado);
                                                        empregados.Add(cartaoCidadao);
                                                        empregados.Add(contribuinte);

                                                        MessageBox.Show("Dados inseridos com sucesso.");
                                                    }
                                                    
                                                }
                                                
                                            }else
	                                        {
                                                MessageBox.Show("O número de contribuinte está errado.");
                                                txtContribuinte.Focus();
	                                        }
                                        }
                                        else
                                        {
                                            MessageBox.Show("O número do cartão de cidadão está errado.");
                                            txtCartaoCidadao.Focus();
                                        }
                                        
                                    }
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Insira um email.");
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Insira um contacto válido.");
                                txtContacto.Focus();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Escolha um sexo.");
                            rabMasculino.Focus();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Tem de ter mais de 18 anos.");
                        mocCalendario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Insira uma morada.");
                    txtMorada.Focus();
                }
            }
            else
            {
                MessageBox.Show("Insira um nome.");
                txtNome.Focus();
            }


            
            
        }

        private void btnVerRegistos_Click(object sender, EventArgs e)
        {
            frmListagemEmpregados frm = new frmListagemEmpregados();
            frm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rabMasculino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Masculino";
        }

        private void rabFeminino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Feminino";
        }

        private bool testarEmail(string email)
        {
            string ponto;
            bool confirmarEmail = false;
            
            int position = email.IndexOf("@");
            if (position == -1)
            {
                MessageBox.Show("Falta o @ no email.");
                txtEmail.Focus();
            }
            else
            {
                int duplicado = email.IndexOf("@", position + 1);
                if (duplicado == -1)
                {
                    ponto = email.Substring(position + 1);
                    bool confirmar = ponto.Contains(".");
                    if (confirmar)
                    {
                        confirmarEmail = true;
                    }
                    else
                    {
                        MessageBox.Show("Falta o . após o @.");
                        txtEmail.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("O email contem 2 @");
                }
            }

            return confirmarEmail;
            
        }

        /*public decimal pontoParaVirgula(decimal testarSalario)
        {

            return;
        }*/
    }
}
