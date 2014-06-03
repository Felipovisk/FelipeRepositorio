using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade11.ExerciciosFixacao
{
    class TrocaElementos
    {
        public static void Main(string[] args)
        {
            int[] elementos = new int[] { 34, 65, 12, 9, 54, 93, 116, 345, 744, 754 };
            EfetuaTrocaElementos(elementos);
            
        }

        private static void EfetuaTrocaElementos(int[] elementos)
        {
            for (int i = 0; i < elementos.Length; i++)
            {
                int aux = 0;
                aux = elementos[i];
                for (int j = 10; j > elementos.Length; j--)
                {
                    elementos[j] = aux;
                }

            }
        }
    }
}
