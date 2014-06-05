using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerciciosFixação2
{/*Escreva um algoritmo que receba um ano como parâmetro, e determine se é ou não 
  * bissexto. Nota: são bissextos os anos múltiplos de 4 que não são múltiplos de 100 
  * e ainda os anos múltiplos de 400. Exemplo:  1996 e 2000 são bissextos, enquanto 
  * 1998 e 1900 são comuns.*/
    class Exercicio5
    {
        public static int Ano = 0;
        public static void Main1(string[] args)
        {
            Console.WriteLine("Digite o ano: ");
            Ano = int.Parse(Console.ReadLine());
            if (Ano % 4 == 0 & Ano % 100 != 0 | Ano % 400 == 0)
            {
                Console.WriteLine("Ano digitado é bissexto.");
            }
            else
            {
                Console.WriteLine("Ano Digitado é convencional.");
            }
            Console.ReadKey();
        }
    }
}
