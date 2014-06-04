using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{/*Escreva um algoritmo que leia e mostre um vetor de 20 elementos inteiros. A 
  * seguir, conte quantos valores pares existem no vetor.*/
    class Exercicio4
    {
        public static int[] Elementos = new int[20];
        public static Random Gerador = new Random();
        public static int Cont = 0;
        public static void Main1(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Elementos[i] = Gerador.Next(0, 100);
                if (Elementos[i] % 2 == 0)
                {
                    Cont++;
                }
            }
            Console.WriteLine("O vetor possui: " + Cont + " numeros pares.");
            Console.ReadKey();
        }
    }
}
