using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar
{/*2)	Faça um algoritmo que leia uma coleção com 80 números decimais e encontre o menor 
  * valor, o maior valor, a média e a soma de todos os valores.*/
    class Exercicio2
    {
        public static List<double> NumerosDecimais = new List<double>();
        public static Random Gerador = new Random();
        

        public static void Main2(string[] args)
        {
            for (int i = 0; i < 80; i++)
            {
                NumerosDecimais.Add(Gerador.NextDouble());
            }
            Console.WriteLine("A média dos numeros é de: " + NumerosDecimais.Average());
            Console.WriteLine("A soma de todos os numeros é de: " + NumerosDecimais.Sum());
            Console.WriteLine("O maior numero é: " + NumerosDecimais.Max());
            Console.WriteLine("O menor numero é: " + NumerosDecimais.Min());
            Console.ReadKey();

            
        }
    }
}
