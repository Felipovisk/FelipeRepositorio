using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10
{/*4)	Faça um método chamado tabuada que passa por parâmetro o número da tabuada. 
  * Por exemplo se passar 4 por parâmetro ela deve retornar a tabuada completa do 4.*/
    class Exercicio4
    {
        public static void Main(string[] args)
        {
            int tabuada = 4;

            TabuadaPorParametro(tabuada);
            Console.ReadKey();
        }

        private static void TabuadaPorParametro(int tabuada)
        {
            for (int i = 1; i < 11; i++)
            {
                int result = tabuada * i;
                Console.WriteLine(result);
            }
        }
    }
}
