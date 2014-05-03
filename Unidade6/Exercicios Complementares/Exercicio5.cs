using System;

namespace Unidade6.Exercicios_Complementares
{
    internal class Exercicio5
    {
        public static double TotalPagamento = 0;
        public static int QuantidadeColheita = 0;
        public static string IdFuncionario = "";
        public static int IdadeFuncionario = 0;
        public static int TotalCaixas = 0;
        public static double AdicionalPagamento = 0;

        public static void Main(String[] args)
        {
            Console.WriteLine("Digite o ID do funcionário.");
            Console.WriteLine("Digite a ideade do funcionário.");
            Console.WriteLine("Digite o numero de caixas de laranjas colhidas por este funcionário.");
            IdFuncionario = Console.ReadLine();
            IdadeFuncionario = int.Parse(Console.ReadLine());
            QuantidadeColheita = int.Parse(Console.ReadLine());


            ValidaIdadeFuncionario();
            CalculaSalario();
            CalculaAdicional();

            ImprimeDados();
        }

        private static void ImprimeDados()
        {
            Console.WriteLine("Funcionário identificador numero: " + IdFuncionario);
            Console.WriteLine("Idade: " + IdadeFuncionario + " anos.");
            Console.WriteLine("Seu Salário final é de: " + TotalPagamento + " Reais com um bônus de: " + AdicionalPagamento + " Reais.");
            Console.ReadKey();
        }

        private static void ValidaIdadeFuncionario()
        {
            if (IdadeFuncionario < 18)
            {
                Console.WriteLine("Pessoa sem idade miníma legal para trabalhar.");
            }
            if (IdadeFuncionario > 65)
            {
                Console.WriteLine("Funcionário aposentado, não pode continuar trabalhando.");
            }
        }

        private static void CalculaAdicional()
        {
            if (IdadeFuncionario > 17 && IdadeFuncionario < 46)
            {
                AdicionalPagamento = (TotalPagamento * 10) / 100;
                TotalPagamento = TotalPagamento + AdicionalPagamento;
            }
            if (IdadeFuncionario > 46 && IdadeFuncionario < 66)
            {
                AdicionalPagamento = (TotalPagamento * 20) / 100;
                TotalPagamento = TotalPagamento + AdicionalPagamento;
            }          
        }

        private static void CalculaSalario()
        {
            if (QuantidadeColheita < 6)
            {
                TotalPagamento = QuantidadeColheita * 2;
            }
            if (QuantidadeColheita > 5 && QuantidadeColheita < 11)
            {
                TotalPagamento = QuantidadeColheita * 2.5;
            }
            if (QuantidadeColheita > 10 && QuantidadeColheita < 21)
            {
                TotalPagamento = QuantidadeColheita * 3.5;
            }
            if (QuantidadeColheita > 21)
            {
                TotalPagamento = QuantidadeColheita * 5;
            }
        }
    }
}