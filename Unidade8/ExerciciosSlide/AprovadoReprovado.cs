using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExerciciosSlide
{
    class AprovadoReprovado
    {
        public static Random NotaAluno = new Random();
        public static void Main1(String[] args)
        {
            double notaAluno = NotaAluno.Next(0,10);
            if (notaAluno > 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
            Console.ReadKey();
        }
    }
}
