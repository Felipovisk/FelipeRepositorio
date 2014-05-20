using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7.ExerciciosFixação1
{
 /*Faça um programa que simule um lançamento de dados. Lance o dado 100 vezes e 
 * armazene os resultados em um vetor. Depois, mostre quantas vezes cada valor foi 
 * conseguido. Dica: use um vetor de contadores(1-6) e uma função para gerar números
 * aleatórios, simulando os lançamentos dos dados.
 */
    class Exercicio5
    {
        public static int[] RollTheDice = new int[100];
        public static Random Dado = new Random();
        public static int[] Contador = new int[6];
        public static void Main1(String[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                RollTheDice[i] = Dado.Next(1,7);
            }
            for (int i = 0; i < 100; i++)
            {
                if (RollTheDice[i] == 6)
                {
                    Contador[5] += 1;
                }
                if (RollTheDice[i] == 5)
                {
                    Contador[4] += 1;
                }
                if (RollTheDice[i] == 4)
                {
                    Contador[3] += 1;
                }
                if (RollTheDice[i] == 3)
                {
                    Contador[2] += 1;
                }
                if (RollTheDice[i] == 2)
                {
                    Contador[1] += 1;
                }
                if (RollTheDice[i] == 1)
                {
                    Contador[0] += 1;
                }
            }
            Console.WriteLine("O numero 6 foi rolado: " + Contador[5] + " vezes.");
            Console.WriteLine("O numero 5 foi rolado: " + Contador[4] + " vezes.");
            Console.WriteLine("O numero 4 foi rolado: " + Contador[3] + " vezes.");
            Console.WriteLine("O numero 3 foi rolado: " + Contador[2] + " vezes.");
            Console.WriteLine("O numero 2 foi rolado: " + Contador[1] + " vezes.");
            Console.WriteLine("O numero 1 foi rolado: " + Contador[0] + " vezes.");
            Console.ReadKey();
        }
    }
}
