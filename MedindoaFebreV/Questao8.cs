using System;

namespace MedindoaFebreV
{
    internal class Questao8
    {
        public static int Cont = 0;

        public static void Main1(String[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite SOMENTE a HORA de entrada do cliente.");
                int horario = int.Parse(Console.ReadLine());
                if (horario >= 10 & horario <= 16)
                {
                    Cont++;
                }
                else
                {
                    Console.WriteLine("horario Inválido.");
                }
            }
            Console.WriteLine("Clientes que foram atendidos dentro do horário de funcionamento: " + Cont);
            Console.ReadKey();
        }
    }
}