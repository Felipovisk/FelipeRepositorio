using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10
{/*3)	Implemente um método que verifique a idade de 20 pessoas, um para comparar a maior 
  * idade, um para menor idade, outro para fazer a média de todas as 20 idades e por fim 
  * imprimir todos esses dados. (5 métodos)*/
    class Exercicio3
    {
        public static Random GeradorIdade = new Random();
        public static int[] Idade = new int[20];
        public static int AuxMaiorIdade = 0;
        public static int AuxMenorIdade = 100;
        public static double MediaIdade = 0;
        public static int AuxMediaIdade = 0;
        public static void Main2(string[] args)
        {
            LeituraDeDados();
            VerificaMaiorIdade();
            VerificaMenorIdade();
            CalculaMediaIdade();

            ImprimeDados();
        }

        private static void ImprimeDados()
        {
            Console.WriteLine("A maior idade é: " + AuxMaiorIdade);
            Console.WriteLine("A menor idade é: " + AuxMenorIdade);
            Console.WriteLine("A media de idades é de: " +  MediaIdade);
            Console.ReadKey();
        }

        private static void CalculaMediaIdade()
        {
            for (int i = 0; i < 20; i++)
            {
                AuxMediaIdade += Idade[i];
            }
            MediaIdade = AuxMediaIdade / Idade.Length;
        }

        private static void VerificaMenorIdade()
        {
            for (int i = 0; i < 20; i++)
            {
                if (Idade[i] < AuxMenorIdade)
                {
                    AuxMenorIdade = Idade[i];
                }
            }
        }

        private static void VerificaMaiorIdade()
        {
            for (int i = 0; i < 20; i++)
            {
                if (Idade[i] > AuxMaiorIdade)
                {
                    AuxMaiorIdade = Idade[i];
                }
            }
        }

        private static void LeituraDeDados()
        {
            for (int i = 0; i < 20; i++)
            {
                Idade[i] = GeradorIdade.Next(0, 101);
            }
        }
    }
}
