using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{/*Faça um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de 
  * números reais. Se o código for zero, termine o algoritmo. Se o código for 1, mostre 
  * o vetor na ordem direta. Se o código for 2, mostre o vetor na ordem inversa.  */
    class Exercicio5
    {
        public static double[] Elementos = new double[50];
        public static int Numero = 0;

        public static void Main1(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                Elementos[i] = i;
            }
            Console.WriteLine("Digite a opção desejada.");
            Console.WriteLine(" 0 - finalizar o programa, 1 - mostrar o vetor, 2- mostrar o vetor em ordem inversa.");
            Numero = int.Parse(Console.ReadLine());
            if (Numero == 0)
            {
                Environment.Exit(1);
            }
            else if (Numero == 1)
            {
                for (int i = 0; i < 50; i++)
                {
                    
                    Console.WriteLine(Elementos[i]);
                }
            }
            else if (Numero == 2)
            {
                for (int i = 49; i >= 0; i--)
                {
                   
                    Console.WriteLine(Elementos[i]);
                }
            }
            else
            {
                
                Console.WriteLine("Opção inválida.");
            }
            Console.ReadKey();
        }
    }
}
