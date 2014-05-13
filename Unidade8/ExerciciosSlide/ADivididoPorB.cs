using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExerciciosSlide
{
    class ADivididoPorB
    {
        public static Random Divisor = new Random();
        public static Random Dividendo = new Random();
        public static void Main(String[] args)
        {
            if (Divisor.Next(0, 100) % (Dividendo.Next(0, 100)) == 0)
            {
                Console.WriteLine("É divisivel.");
            }
            else if (Divisor.Next(0, 100) % (Dividendo.Next(0, 100)) != 0)
            {
                Console.WriteLine("Não é divisivel.");
            }
            else
            {
                Console.WriteLine("Expressão Inválida.");
            }
            Console.ReadKey();
        }
    }
}
