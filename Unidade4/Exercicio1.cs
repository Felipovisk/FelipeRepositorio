using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{/*Faça um programa que exibe o conteúdo de um vetor tamanho 10 de forma invertida. */
    class Exercicio1
    {
        public static int[] Elementos = new int[10];
        public static Random Gerador = new Random();
        public static void Main1(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                Elementos[i] = Gerador.Next(0, 100);
            }
            for (int i = 9; i > 0; i--)
            {
                Console.WriteLine(Elementos[i]);
            }
            Console.ReadKey();
        }
    }
}
