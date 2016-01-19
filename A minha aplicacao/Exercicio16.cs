using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_minha_aplicacao
{
    class Exercicio16
    {

        public static string[] primeiro;
        public static string apelido;

        public static string nomeCurto(string nome)
        {
            separarDados(nome);
            
            return primeiro[0].ToUpper() + " " + apelido.ToUpper();
        }

        public static string email(string nome)
        {
            separarDados(nome);

            return primeiro[0].ToLower() + "." + apelido.ToLower() + "@xpto.pt";
        }

        public static string emailAlternativo(string nome)
        {
            separarDados(nome);
            string primeiraLetra = nome.Substring(0, 1);

            return primeiraLetra.ToLower() + apelido.ToLower() + "@xpto.pt";
        }

        public static void separarDados(string nome)
        {
            primeiro = nome.Split(' '); //divide o a string pelo caracter escolhido
            int i = nome.LastIndexOf(' '); //vai buscar o index do ultimo catacter escolhido
            int t = nome.Length; //vai buscar o numero total de caracteres
            apelido = nome.Substring(i + 1); //remover caracteres de x index até ao fim
        }

        public static string retiraEspacos(string frase)
        {
            string[] fraseDividida = frase.Split(' ');
            string fraseFinal = "";

            foreach (string palavra in fraseDividida)
            {
                if (palavra != "")
                {
                    fraseFinal += palavra + " ";
                }

            }
            string final = fraseFinal.Remove(fraseFinal.Length - 1);

            return final;
        }
    }
}
