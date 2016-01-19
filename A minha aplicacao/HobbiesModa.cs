using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_minha_aplicacao
{
    class HobbiesModa
    {

        public static string hobbieModa = "";
        public static int maiorHobbie;

        public static string HobbieModa(params string[] hobbies)
        {
            int contar = 0;

            foreach (string hob in hobbies)
            {

                foreach (string hob2 in hobbies)
                {

                    if (hob == hob2)
                    {
                        contar++;
                    }

                    if (hobbieModa != "")
                    {
                        if (contar > maiorHobbie)
                        {
                            hobbieModa = hob;
                            maiorHobbie = contar;
                        }

                    }
                    else
                    {
                        hobbieModa = hob;
                        maiorHobbie = contar;
                    }

                }


                contar = 0;
            } 

            return hobbieModa;
        }
    }
}
