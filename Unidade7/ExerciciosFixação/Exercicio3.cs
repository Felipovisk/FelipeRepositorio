using System;

namespace Unidade7.ExerciciosFixação
{
    /*Uma pessoa comprou quatro artigos em uma loja. Para cada artigo, tem-se
nome, preço e percentual de desconto. Faça um algoritmo que imprima nome,
preço e preço com desconto de cada artigo e o total a pagar.*/

    internal class Exercicio3
    {
        public static string NomeCliente = "";
        public static string[] NomeArtigo = new string[4];
        public static double[] ValorArtigo = new double[4];
        public static int[] PercentualDesconto = new int[4];
        public static double[] ValorDesconto = new double[4];
        public static double TotalaPagar = 0;
        public static double[] TotalCompra = new double[4];

        public static void Main1(String[] args)
        {
            LeituraDados();
            CalculaArtigos();
            ImprimeDados();
        }

        private static void LeituraDados()
        {
            Console.WriteLine("Digite o nome do cliente.");
            NomeCliente = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite o nome do artigo.");
                NomeArtigo[i] = Console.ReadLine();
                Console.WriteLine("Digite o valor do artigo.");
                ValorArtigo[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o percentual de desconto do artigo.");
                PercentualDesconto[i] = int.Parse(Console.ReadLine());
            }
        }

        private static void ImprimeDados()
        {
            Console.WriteLine("Nome do cliente: " + NomeCliente);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Artigo: " + NomeArtigo[i]);
                Console.WriteLine("Valor do artigo: " + ValorArtigo[i] + " Reais.");
                Console.WriteLine("Valor do artigo com desconto: " + TotalCompra[i] + " Reais.");
                Console.WriteLine("Valor total a pagar é: " + TotalaPagar + " Reais.");
            }
            Console.ReadLine();
        }

        private static void CalculaArtigos()
        {
            for (int i = 0; i < 4; i++)
            {
                ValorDesconto[i] = (ValorArtigo[i] * PercentualDesconto[i]) / 100;
                TotalCompra[i] = ValorArtigo[i] - ValorDesconto[i];
                TotalaPagar = TotalaPagar + TotalCompra[i];
            }
            
        }
    }
}