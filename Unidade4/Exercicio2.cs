using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{/* Faça um programa que leia um vetor de 10 posições e crie um segundo vetor 
  * substituindo os valores negativos por 1. */
    class Exercicio2
    {
        public static int[] Elementos = new int[10];
        public static int[] Elementos2 = new int[10];
        public static Random Gerador = new Random();
        public static void Main1(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Elementos[i] = Gerador.Next(-50, 50);

            }
            for (int i = 0; i < 10; i++)
            {
                if (Elementos[i] > 0)
                {
                    Elementos2[i] = 1;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Elementos[i]);
                Console.WriteLine(Elementos2[i]);

            }
            Console.ReadKey();
        }
    }
}
