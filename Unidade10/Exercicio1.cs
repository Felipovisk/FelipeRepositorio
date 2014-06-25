using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10
{/*1)	Implemente um método que determina seu ano é ou não é bissexto. As regras para 
  * determinar se um ano é bissexto são:
  *1. Anos múltiplos de 4 são bissextos.
  *2. Anos múltiplos de 100 não são bissextos.
  *3. Anos múltiplos de 400 são bissextos.
  *4. As últimas regras prevalecem sobre as primeiras.
*/
    class Exercicio1
    {
        static public int AnoDeAnalise = 0;
        public static void Main2(string[] args)
        {
            VerificaAnoBissexto();
        }

        private static void VerificaAnoBissexto()
        {
            Console.WriteLine("Digite o ano para analise.");
            AnoDeAnalise = int.Parse(Console.ReadLine());
            if (AnoDeAnalise % 4 == 0)
            {
                Console.WriteLine("O ano: " + AnoDeAnalise + " é bissexto.");
            }
            else if (AnoDeAnalise % 400 == 0)
            {
                Console.WriteLine("O ano: " + AnoDeAnalise + " é bissexto.");

            }
            else if (AnoDeAnalise % 100 == 0)
            {
                Console.WriteLine("O ano: " + AnoDeAnalise + " não é bissexto.");
            }
            else
            {
                Console.WriteLine("O ano: " + AnoDeAnalise + " é bissexto.");
            }
            Console.ReadKey();
        }
    }
}
