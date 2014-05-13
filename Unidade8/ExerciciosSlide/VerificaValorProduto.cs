using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExerciciosSlide
{
    class VerificaValorProduto
    {
        public static Random AvaliaValor = new Random();
        public static void Main(String[] args)
        {
            double valorProduto = AvaliaValor.Next(0,100);
            if (valorProduto > 50)
            {
                Console.WriteLine("CARO!");
            }
            else
            {
                Console.WriteLine("BARATO!");
            }
            Console.ReadKey();
        }
    }
}
