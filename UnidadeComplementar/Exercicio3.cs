using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar
{/*3)	Faça um programa que leia n nomes inserindo-os em uma lista de forma ordenada 
  * utilizando a ideia do algoritmo da inserção. No final, o programa deve mostrar todos 
  * os nomes ordenados alfabeticamente. */
    class Exercicio3
    {
        public static List<string> Nomes = new List<string>();
        public static string Nome = "";
        public static void Main2(string[] args)
        {
            Console.WriteLine("Digite o nome do cidadão, se quiser sair do programa digite 'FIM'.");
            Nome = Console.ReadLine();
            while (Nome != "FIM")
            {
                Nomes.Add(Nome);
                Console.WriteLine("Digite o nome do cidadão, se quiser sair do programa digite 'FIM'.");
                Nome = Console.ReadLine();
            }
            Nomes.Sort();
            Console.Clear();
            foreach (string element in Nomes)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
