using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerciciosFixação2
{/*Ler um vetor armazenando a temperatura média do dia durante um mês completo. 
  * Ao final calcular a temperatura média no mês, considerando 30 dias, e calcular a 
  * quantidade de dias que a temperatura passou da média de 35 graus no dia.*/
    class Exercicio4
    {
        public static double[] TemperaturaMedia = new double[30];
        public static double MediaTempMensal = 0;
        public static int Cont = 0;
        
        public static void Main1(string[] args)
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Digite a temperatura média do dia: " + i);
                TemperaturaMedia[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 30; i++)
            {
                if (TemperaturaMedia[i] > 35)
                {
                    Cont++;
                }
                MediaTempMensal += TemperaturaMedia[i];
                
            }
            MediaTempMensal /= 30;
            Console.WriteLine("Quantidade de dias que a temperatura média do dia passou de 35 graus foram: " + Cont + " Dias.");
            Console.WriteLine("A temperatura média do mês é de: " + MediaTempMensal + " Graus.");
            Console.ReadKey();
        }
    }
}
