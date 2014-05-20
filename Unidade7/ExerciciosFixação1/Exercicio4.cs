using System;

namespace Unidade7.ExerciciosFixação1
{
    /* Faça o programa que apresenta a seguinte saída, perguntando ao usuário o número
     * máximo (no exemplo, 9). Este número deve ser sempre ímpar.

 1 2 3 4 5 6 7 8 9
   2 3 4 5 6 7 8
     3 4 5 6 7
       4 5 6
         5
    */

    internal class Exercicio4
    {
        public static int NumeroFinal = 0;
        public static int NumeroEspacos = 0;
        public static int NumeroInicial = 1;

        public static void Main1(String[] args)
        {
            Console.WriteLine("Digite o numero de itens, este numero deve ser ímpar.");
            NumeroFinal = int.Parse(Console.ReadLine());
            if (NumeroFinal % 2 == 1)
            {
                while (NumeroInicial <= NumeroFinal)
                {
                    for (int i = 0; i < NumeroEspacos; i++)
                    {
                        Console.Write("  ");
                    }
                    for (int i = NumeroInicial; i <= NumeroFinal; i++)
                    {
                        Console.Write("{0} ", i);
                    }
                    Console.WriteLine();
                    NumeroEspacos += 1;
                    NumeroFinal -= 1;
                    NumeroInicial += 1;
                }
            }
            else if (NumeroFinal < 0)
            {
                Console.WriteLine("Numero inválido, operação não permitida com numeros negativos ou decimais.");
            }
            else
            {
                Console.WriteLine("Numero Inválido, digite um numero ímpar.");
            }
            Console.ReadKey();
        }
    }
}