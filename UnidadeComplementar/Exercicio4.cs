using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar
{/*4)	Faça 4 listas com diferentes coleções, List, ArrayList, IList, Dictionary. 
  * Adicione dados em cada uma delas e no final liste-os*/
    class Exercicio4
    {
        public static ArrayList Nomes = new ArrayList{"pedro","cesar","clarice","thiago","maicon"};
        public static IList Numeros = new List<int>();
        public static List<double> Decimais = new List<double>();
        public static Dictionary<double, int> Registros = new Dictionary<double, int>();
        public static Random Gerador = new Random();
        public static void Main2(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Numeros.Add(Gerador.Next(0, 100));
                Decimais.Add(Gerador.NextDouble());
                Registros.Add(Gerador.NextDouble(), Gerador.Next(0, 100));
                
            }
            foreach (string element in Nomes)
            {
                Console.WriteLine(element);
            }
            foreach (double element in Decimais)
            {
                Console.WriteLine(element);
            }
            foreach (int element in Numeros)
            {
                Console.WriteLine(element);
            }
            foreach (var element in Registros)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();

        }
    }
}
