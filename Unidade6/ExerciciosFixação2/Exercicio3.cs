using System;

namespace Unidade6.ExerciciosFixação2
{/*Crie um algoritmo que receba o dia, mês e ano de uma data de nascimento (como
  * parâmetros de entrada do método) e imprima a data por extenso no formato: dia de
  * nome_mes de ano.*/

    internal class Exercicio3
    {
        public static void Main1(string[] args)
        {
            int diaNascimento = 0;
            int mesNascimento = 0;
            int anoNascimento = 0;
            LeituraDados(ref diaNascimento, ref mesNascimento, ref anoNascimento);
            ImprimeAniversarioPorExtenso(diaNascimento, mesNascimento, anoNascimento);
        }

        private static void ImprimeAniversarioPorExtenso(int diaNascimento, int mesNascimento, int anoNascimento)
        {
            DateTime DataNascimento = new DateTime(anoNascimento, mesNascimento, diaNascimento);
            Console.WriteLine(DataNascimento.ToLongDateString());
            Console.ReadKey();
        }

        private static void LeituraDados(ref int diaNascimento, ref int mesNascimento, ref int anoNascimento)
        {
            Console.WriteLine("Digite o dia do seu nascimento.");
            diaNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mês do seu nascimento.");
            mesNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano do seu nascimento.");
            anoNascimento = int.Parse(Console.ReadLine());
        }
    }
}