using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Exercicios_Complementares
{
    class Exercicio1
    {
        public static int macasCompradas = 0;
        public static double totalMacas = 0;
        public static void Main(String[] args)
        {
            Console.WriteLine("Digite o numero de maçãs compradas.");
            macasCompradas = int.Parse(Console.ReadLine());
            if (macasCompradas < 12) {
                totalMacas = macasCompradas * 0.30;
            }
            else
            {
                totalMacas = macasCompradas * 0.25;
            }
            Console.WriteLine("O valor total da compra foi de: " + totalMacas + " Reais.");
            Console.ReadKey();
        }
    }
}

