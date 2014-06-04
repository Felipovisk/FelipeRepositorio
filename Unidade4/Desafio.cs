using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{/*Faça um algoritmo que leia dois vetores (A e B) de 50 posições de números inteiros. 
  * O algoritmo deve, então, subtrair o primeiro elemento de A do último de B, 
  * acumulando o valor, subtrair o segundo elemento de A do penúltimo de B, acumulando 
  * o valor, e assim por diante. Mostre o resultado da soma final. */
    class Desafio
    {
        public static int[] PrimeiroVetor = new int[50];
        public static int[] SegundoVetor = new int[50];
        public static int[] TerceiroVetor = new int[50];
        public static Random Gerador = new Random();
        public static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                PrimeiroVetor[i] = Gerador.Next(0, 100);
                SegundoVetor[i] = Gerador.Next(0, 100);
            }
            for (int i = 0; i < 50; i++)
            {
                for (int j = 49; j >= 0; j--)
                {
                    TerceiroVetor[i] = PrimeiroVetor[i] - SegundoVetor[j];
                }
            }
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(TerceiroVetor[i]);
                


            }
            Console.ReadKey();

        }
    }
}
