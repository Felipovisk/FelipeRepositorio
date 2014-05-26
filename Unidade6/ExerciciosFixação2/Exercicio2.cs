using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerciciosFixação2
{/*Ler dois vetores A e B de tamanho 10 e 15 elementos respectivamente, em seguida 
  * geram um terceiro vetor C sendo a concatenação (junção) dos vetores: A e B.*/
    class Exercicio2
    {
        public static string[] Element = new string[]{"1","2","3","4","5","6","7","8","9","0"};
        public static string[] Elements = new string[]{"1","2","3","4","5","6","7","8","9","10","11","12","13","14","15"};
        public static string[] Elementos = new string[15];
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Elementos[i] = Element[i];
                
                
            }
            for (int i = 0; i < 15; i++)
            {
                Elementos[i] += Elements[i];
                Console.WriteLine(Elementos[i]);
            }
                Console.ReadKey();
        }
    }
}
