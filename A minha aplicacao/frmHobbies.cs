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
    public partial class frmHobbies : Form
    {
        public frmHobbies()
        {
            InitializeComponent();
        }

        public ArrayList hobbies = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            string hobbie = "";
            bool terminar = false;
            hobbies.Clear();

            do
            {
                hobbie = Interaction.InputBox("Insira um hobbie", "Hobbies","Default",0,0);

                if (hobbie == "*")
                {
                    terminar = true;
                }
                else
                {
                    hobbies.Add(hobbie);
                }
            } while (terminar == false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHobbies.Text = "Existem " + hobbies.Count + " hobbies";
            int contar = 0;

            foreach (string hob in hobbies)
            {
               
                foreach (string hob2 in hobbies)
                {
                    
                    if (hob == hob2)
                    {
                        contar++;
                    }
                    
                }
                if (!txtHobbies.Text.Contains(hob))
                {
                    txtHobbies.Text += "\r\n" + hob + " está repetido " + contar + " vez(es)";
                }
                

                contar = 0;
            }

        }


    }
}
