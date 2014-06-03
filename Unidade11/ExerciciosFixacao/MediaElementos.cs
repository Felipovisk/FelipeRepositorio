using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade11.ExerciciosFixacao
{
    class MediaElementos
    {
        public static void Main(string[] args)
        {
           int[] elementos = new int[] { 34, 65, 12, 9, 54, 93, 116, 345, 744, 754 };
           
            
            int soma = SomaDeElementos(elementos);
            double mediaSomaDosElementos = MediaDosElementos(elementos, soma);
        }

        private static double MediaDosElementos(int[] elementos, int soma)
        {
            double media = soma / elementos.Length;
            return media;
        }
        private static int SomaDeElementos(int[] elementos)
        {
            int aux = 0;
            for (int i = 0; i < elementos.Length; i++)
            {
                aux += elementos[i];
            }
            return aux;
        }
    }
}
