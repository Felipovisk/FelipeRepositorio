using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerciciosFixação2
{
/*Declarar um vetor de 20 números inteiros, em seguida ler os elementos do vetor, 
* e ao final mostrar somente os número positivos, e mostrar ainda a quantidade de 
* positivos, a quantidade de negativos e a quantidade de nulos (0). */
    class Exercicio1
    {
        public static int[] NumerosInteiros = new int[20];
        public static int[] NumerosPositivos;
        public static int[] Contador = new int[3];

        public static void Main(String[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite um numero inteiro.");
                NumerosInteiros[i] = int.Parse(Console.ReadLine());
                if (NumerosInteiros[i] > 0)
                {
                    Contador[0] += 1;
                }
                else if (NumerosInteiros[i] < 0)
                {
                    Contador[1] += 1;
                }
                else if (NumerosInteiros[i] == 0)
                {
                    Contador[2] += 1;
                }
                
            }
            NumerosPositivos = new int[Contador[0]];
            for (int i = 0; i < NumerosPositivos.Length; i++)
            {
                if (NumerosInteiros[i] > 0)
                {
                    NumerosPositivos[i] = NumerosInteiros[i];
                }
                Console.WriteLine("Numeros Positivos: " + NumerosPositivos[i]);
            }
            Console.WriteLine("Total de numeros positivos: " + Contador[0]);
            Console.WriteLine("Total de numeros negativos: " + Contador[1]);
            Console.WriteLine("Total de numeros nulos: " + Contador[2]);
            Console.ReadKey();
            
        }
    }
}
