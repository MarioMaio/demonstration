using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_minha_aplicacao
{

    
    class Substituir
    {

        public static string[] letras = { "ã", "à", "á", "â", "é", "ê", "ó", "ô", "õ", "ç"};
        public static string[] substiruir = { "a", "a", "a", "a", "e", "e", "o", "o", "o", "c" };

        public static string substituirLetras(string frase)
        {
            for (int i = 0; i < letras.Length; i++)
            {
                if (frase.Contains(letras[i]))
                {
                    frase = frase.Replace(letras[i], substiruir[i]);
                }
            }

            return frase;

            //Dictionary<string, string> carater = new Dictionary<string,string>; //classe dictionary
            //carater.Add("á","a");
        }
    }
}
