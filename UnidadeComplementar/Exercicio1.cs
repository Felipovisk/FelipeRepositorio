using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar
{/*1)	Faça um algoritmo que adicione 100 números em qualquer coleção que vocês preferir, 
  * ao final imprima esses números decrescente e depois crescente.

*/
    class Exercicio1
    {
        public static List<int> Numero = new List<int>();
        public static Random Gerador = new Random();

        public static void Main2(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Numero.Add(Gerador.Next(0,1001));

            }
            Numero.Sort();
            ImprimeDados();
            Numero.Reverse();
            ImprimeDados();
            Console.ReadKey();

        }

        private static void ImprimeDados()
        {
            foreach (int element in Numero)
            {
                Console.WriteLine(element);
            }
        }

    }
}
