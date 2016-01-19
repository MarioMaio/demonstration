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
    public partial class frmCelcius : Form
    {
        public frmCelcius()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Information.IsNumeric(txtFarenheit.Text))
            {
                //decimal celcius = 0;
                //celcius = (Convert.ToDecimal(txtFarenheit.Text) - 32) / Convert.ToDecimal(1.8);
                //txtCelcius.Text = Convert.ToString(celcius);
                txtCelcius.Text = ((Convert.ToInt16(txtFarenheit.Text) - 32) / 1.8).ToString();
                btnNovoCalculo.Enabled = true;
            }
            else
            {
                txtCelcius.Text = "Valor numérico.";
            }
        }

        private void frmCelcius_Load(object sender, EventArgs e)
        {
            btnNovoCalculo.Enabled = false;
        }

        private void btnNovoCalculo_Click(object sender, EventArgs e)
        {
            btnNovoCalculo.Enabled = false;
            txtFarenheit.Clear();
            txtCelcius.Clear();
        }
    }
}
