using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExerciciosSlide.InstrucoesdeRepeticao
{
    class Imprime100ExcetoMultiplo3
    {
        public static void Main1(String[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " è multiplo de 3.");
                }
                else if (i % 3 != 0)
                {
                    Console.WriteLine(i + " Não é multiplo de 3.");
                }
                else
                {
                    Console.WriteLine("Indefinido.");
                }
            }
            Console.ReadKey();
        }
    }
}
