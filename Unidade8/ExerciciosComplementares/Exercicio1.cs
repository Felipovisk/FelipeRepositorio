using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExerciciosComplementares
{/*Crie um programa em C# que gere dois números aleatórios e exiba o valor desses 
  * números. Além disso, esse programa deve exibir a mensagem “Primeiro > Segundo” 
  * se o primeiro número for maior do que o segundo, a mensagem “Segundo > Primeiro” 
  * se o segundo número for maior do que o primeiro e mensagem “Primeiro = Segundo” 
  * se o primeiro número for igual ao segundo. */
    class Exercicio1
    {
        public static Random Gerador = new Random();
        public static int Numero1 = 0;
        public static int Numero2 = 0;
        public static void Main1(string[] args)
        {
            Numero1 = Gerador.Next(0, 100);
            Numero2 = Gerador.Next(0, 100);

            if (Numero1 > Numero2)
            {
                Console.WriteLine("Primeiro numero é maior que o segundo.");
            }
            else if (Numero1 < Numero2)
            {
                Console.WriteLine("Segundo numero é maior que o primeiro.");
            }
            else if (Numero1 == Numero2)
            {
                Console.WriteLine("Primeiro numero é igual ao segundo.");
            }
            else
            {
                Console.WriteLine("Valores inválidos, inicialize o programa novamente!");
            }
            Console.ReadKey();
        }
    }
}
