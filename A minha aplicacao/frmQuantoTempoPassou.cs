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
    public partial class frmQuantoTempoPassou : Form
    {
        public frmQuantoTempoPassou()
        {
            InitializeComponent();
        }

        private void frmQuantoTempoPassou_Load(object sender, EventArgs e)
        {
            mocInicial.MaxDate = DateTime.Now.AddDays(-1);
            mocFinal.MinDate = DateTime.Now.AddDays(1);
        }

        private void mudarDados()
        {
            long diasPassados = DateAndTime.DateDiff(DateInterval.Day, mocInicial.SelectionStart, mocFinal.SelectionStart);
            lblDias.Text = diasPassados.ToString() + " Dia(s)";

            long mesesPassados = DateAndTime.DateDiff(DateInterval.Month, mocInicial.SelectionStart, mocFinal.SelectionStart);
            lblMeses.Text = mesesPassados.ToString() + " Mes(es)";

            long anosPassados = DateAndTime.DateDiff(DateInterval.Year, mocInicial.SelectionStart, mocFinal.SelectionStart);
            lblAnos.Text = anosPassados.ToString() + " Ano(s)";
        }

        private void mocInicial_DateChanged(object sender, DateRangeEventArgs e)
        {
            mudarDados();
        }

        private void mocFinal_DateChanged(object sender, DateRangeEventArgs e)
        {
            mudarDados();
        }
    }
}
