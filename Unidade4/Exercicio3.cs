using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{/*Faça um programa que leia uma matriz mat 3 x 4 de inteiros, substitua seus elementos 
  * negativos por 0 e imprima a matriz mat original e a modificada.*/
    class Exercicio3
    {
        public static int[,] Elementos = new int[5, 6];
        public static int[,] Elementos2 = new int[3, 4];
        public static Random Gerador = new Random();
        public static void Main1(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    
                    Elementos[i, j] = Gerador.Next(-5, 10);

                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Elementos[i, j] < 0)
                    {
                        Elementos2[i, j] = 0;
                    }

                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(Elementos[i,j]);
                    Console.WriteLine("");
                    Console.WriteLine(Elementos2[i,j]);

                }
            }
            Console.ReadKey();
        }
    }
}
