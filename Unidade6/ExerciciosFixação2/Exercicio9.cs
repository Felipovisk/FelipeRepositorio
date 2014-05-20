using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7.ExerciciosFixação
{
    /*Faça um algoritmo que leia os valores A, B e C. Mostre uma mensagem que 
informe se a soma de A com B é menor, maior ou igual a C. */

    class Exercicio9
    {
        public static int a, b, c = 0;

        public static void Main1(String[] args)
        {
            Console.WriteLine("Digite os valores de 'A', 'B' e 'C'.");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a + b > c)
            {
                Console.WriteLine("A soma de 'A' com 'B' é maior que 'C'.");
                Console.ReadKey();
            }
            else if (a + b < c)
            {
                Console.WriteLine("A soma de 'A' com 'B' é menor que 'C'.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("A soma de 'A' com 'B' é igual ao valor de 'C'.");
                Console.ReadKey();
            }

        }
    }
}
