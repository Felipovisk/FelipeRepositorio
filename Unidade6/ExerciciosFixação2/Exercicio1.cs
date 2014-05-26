using System;

namespace Unidade6.ExerciciosFixação2
{
    /*Declarar um vetor de 20 números inteiros, em seguida ler os elementos do vetor,
    * e ao final mostrar somente os número positivos, e mostrar ainda a quantidade de
    * positivos, a quantidade de negativos e a quantidade de nulos (0). */

    internal class Exercicio1
    {
        public static int[] NumerosInteiros = new int[20];
        public static int[] NumerosPositivos = new int[20];
        public static int[] Contador = new int[3];

        //FAKE
        //public static int[] NumerosInteiros = new int[]{0,0,0,0,0,0,0,4,4,4,4,4,4,4,-9,-9,-9,-9,-9,-9};
        //public static int[] NumerosPositivos = new int[20];
        //public static int[] Contador = new int[3];

        public static void Main(String[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite um numero inteiro.");
                NumerosInteiros[i] = int.Parse(Console.ReadLine());
                if (NumerosInteiros[i] > 0)
                {
                    Contador[0] += 1;
                    NumerosPositivos[i] = NumerosInteiros[i];
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

            for (int j = 0; j < NumerosPositivos.Length; j++)
            {
                if (NumerosPositivos[j] > 0)
                {
                    Console.WriteLine("Numeros Positivos: " + NumerosPositivos[j]);
                }
                
            }

            Console.WriteLine("Total de numeros positivos: " + Contador[0]);
            Console.WriteLine("Total de numeros negativos: " + Contador[1]);
            Console.WriteLine("Total de numeros nulos: " + Contador[2]);
            Console.ReadKey();
        }
    }
}