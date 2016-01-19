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
    public partial class frmMeusHobbies : Form
    {

        public static ArrayList hobbies = new ArrayList();
        
        public frmMeusHobbies()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            

            foreach (Control chb in this.Controls)
            {
                if (chb is CheckBox && ((CheckBox) chb).Checked)
                {
                   hobbies.Add(chb.Text);
                }
            }
            frmMeusHobbiesConfirmar frm = new frmMeusHobbiesConfirmar();
            frm.ShowDialog(); //showdialog bloqueia as outras janelas e show deixa mexer em todas
        }
    }
}
