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
    public partial class frmQueHorasSao : Form
    {
        public frmQueHorasSao()
        {
            InitializeComponent();
        }

        private void frmQueHorasSao_Load(object sender, EventArgs e)
        {
            atualizarHora();

            lblHoraCompleta.Text = DateTime.Today.ToString();

            timerSegundos.Enabled = true;
            timerMinutos.Enabled = true;
            timerHoras.Enabled = true;

            btnAtualizar.Enabled = false;

            rbAutomatico.Select();
            //rbManual.Select();
        }

        private void timerSegundos_Tick(object sender, EventArgs e)
        {
            pbSegundo.PerformStep();
            lblSegundo.Text = pbSegundo.Value.ToString() + " Segundo(s)";
        }

        private void timerMinutos_Tick(object sender, EventArgs e)
        {
            pbMinuto.PerformStep();
            lblMinuto.Text = pbMinuto.Value.ToString() + " Minuto(s)";
        }

        private void timerHoras_Tick(object sender, EventArgs e)
        {
            pbHora.PerformStep();
            lblHora.Text = pbHora.Value.ToString() + " Hora(s)";
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = true;
            timerSegundos.Enabled = false;
            timerMinutos.Enabled = false;
            timerHoras.Enabled = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            atualizarHora();


        }

        private void rbAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = false;

            atualizarHora();

            timerSegundos.Enabled = true;
            timerMinutos.Enabled = true;
            timerHoras.Enabled = true;
        }

        private void atualizarHora()
        {
            lblHora.Text = DateTime.Now.Hour.ToString() + " Hora(s)";
            pbHora.Value = DateTime.Now.Hour;

            lblMinuto.Text = DateTime.Now.Minute.ToString() + " Minuto(s)";
            pbMinuto.Value = DateTime.Now.Minute;

            lblSegundo.Text = DateTime.Now.Second.ToString() + " Segundo(s)";
            pbSegundo.Value = DateTime.Now.Second;
        }
    }
}
