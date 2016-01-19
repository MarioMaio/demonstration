using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Microsoft.VisualBasic;

namespace A_minha_aplicacao
{
    public partial class frmFicheiros : Form
    {
        public frmFicheiros()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog gravarFicheiroDialog = new SaveFileDialog();
            gravarFicheiroDialog.Filter = "txt files (*.txt)|*.txt";

            switch (tabMenu.SelectedIndex)
            {
                case 0:
                    try
                    {
                        if (gravarFicheiroDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            System.IO.StreamWriter myStreamWriter = new System.IO.StreamWriter(gravarFicheiroDialog.FileName, true);

                            //myStreamWriter.WriteLine();
                            myStreamWriter.Write(txtTextoGuardar.Text);
                            myStreamWriter.Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tem de escolher um ficheiro.");
                        //throw;
                    };
                    break;

                case 1 :
                    try
                    {
                        if (gravarFicheiroDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            File.AppendAllText(gravarFicheiroDialog.FileName, "\r\n" + txtGuardarTextoAppend.Text);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tem de escolher um ficheiro.");
                        //throw;
                    };
                    break;

                case 3:
                    try
                    {
                        if (gravarFicheiroDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            pessoa.nome = txtNome.Text;
                            pessoa.morada = txtMorada.Text;
                            pessoa.dataNascimento = mocDataNascimento.SelectionStart;

                            File.AppendAllText(gravarFicheiroDialog.FileName, pessoa.nome + ";" + pessoa.morada + ";" + pessoa.dataNascimento + ";" + pessoa.idade() + ";" + "\r\n");
                        }

                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tem de escolher um ficheiro.");
                        //throw;
                    };
                    break;
            }

            
        }

        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMenu.SelectedIndex == 0 || tabMenu.SelectedIndex == 1)
            {
                btnGuardar.Enabled = true;
            }

            if (tabMenu.SelectedIndex == 2)
            {
                btnGuardar.Enabled = false;

                OpenFileDialog abreFicheiro = new OpenFileDialog();
                try
                {
                    abreFicheiro.Filter = "txt files (*.txt)|*.txt";
                    abreFicheiro.InitialDirectory = @"c:\";

                    abreFicheiro.ShowDialog();
                    System.IO.StreamReader myStreamReader = new StreamReader(abreFicheiro.FileName);

                    txtLeituraTexto.Text = myStreamReader.ReadToEnd();

                    myStreamReader.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tem de escolher um ficheiro.");
                    //throw;
                }
            }
        }

        public struct pessoa
        {
            public static string nome;
            public static string morada;
            public static DateTime dataNascimento;

            public static byte idade()
            {
                byte anos = Convert.ToByte(DateAndTime.DateDiff(DateInterval.Year, dataNascimento, DateTime.Now));
                return anos;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            OpenFileDialog abreFicheiro = new OpenFileDialog();
            try
            {
                System.IO.StreamReader myStreamReader = new StreamReader(@"C:\Users\acadsoft2015\Desktop\pessoas.txt");

                string[] texto = myStreamReader.ReadToEnd().Split(';');

                for (int i = 0; i < texto.Length; i++)
                {
                    if (texto[i].Contains("\r\n"))
                    {
                        texto[i] = texto[i].Replace("\r\n", "");
                    }
                }

                for (int j = 0; j < texto.Length-1; j+=4)
                {
                    txtResultado.Text += "Nome: " + texto[j] + "\r\n" + "Morada: " + texto[j + 1] + "\r\n" + "Data Nascimento: " + texto[j + 2] + "\r\n" + "Idade: " + texto[j + 3] + "\r\n" + "\r\n";
                }
                

                myStreamReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Tem de escolher um ficheiro.");
                //throw;
            }

            
        }

        
    }
}
