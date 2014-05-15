using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExerciciosSlide.InstrucoesdeRepeticao
{
    class DivideMaiorInteiro
    {
        public static int MaiorInt = 2147483647;
        public static double Resultado = 0;
        public static void Main(String[] Args)
        {
            Resultado = Resultado + (MaiorInt / 2);
            while (Resultado > 99) 
            {
                Resultado = Resultado + (MaiorInt / 2);
                Console.WriteLine(Resultado);
            }
            Console.ReadKey();
        }
    }
}
