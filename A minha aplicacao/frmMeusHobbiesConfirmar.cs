using System;
using System.Collections;
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
    public partial class frmMeusHobbiesConfirmar : Form
    {


        public frmMeusHobbiesConfirmar()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            
            this.Close();
        }

        private void frmMeusHobbiesConfirmar_Load(object sender, EventArgs e)
        {
            txtHobbies.Text = "";
            foreach (string hob in frmMeusHobbies.hobbies)
            {
                txtHobbies.Text += hob + "\r\n";
            }
        }
    }
}
