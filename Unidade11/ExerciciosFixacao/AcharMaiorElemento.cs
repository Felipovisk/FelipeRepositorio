using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade11.ExerciciosFixacao
{
    internal class AcharMaiorElemento
    {

        public static void Main1(string[] args)
        {
            int[] elementos = new int[] { 34, 65, 12, 9, 54, 93, 116, 345, 744, 754 };
            int maiorElemento = 0;
            int menorElemento = 0;

            maiorElemento = EncontraMaiorElemento(elementos);

            menorElemento = EncontraMenorElemento(elementos);
            Console.ReadKey();
        }

        private static int EncontraMenorElemento(int[] elementos)
        {
            int aux = 0;
            for (int i = 0; i < elementos.Length; i++)
            {
                if (elementos[i] < aux)
                {
                    aux = elementos[i];
                }
            }
            return aux;
        }

        private static int EncontraMaiorElemento(int[] elementos)
        {
            int aux = 0;
            for (int i = 0; i < elementos.Length; i++)
            {
                if (elementos[i] > aux)
                {
                    aux = elementos[i];
                }
            }
            return aux;
        }
    }
}