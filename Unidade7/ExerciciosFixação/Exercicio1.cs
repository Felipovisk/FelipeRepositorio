using System;

namespace Unidade7.ExerciciosFixação
{
    /* Uma empresa de vendas tem três corretores. A empresa paga ao corretor uma
comissão calculada de acordo com o valor de suas vendas. Se o valor da venda
de um corretor for maior que R$ 50.000.00 a comissão será de 12% do valor
vendido. Se o valor da venda do corretor estiver entre R$ 30.000.00 e R$
50.000.00 (incluindo extremos) a comissão será de 9.5%. Em qualquer outro
caso, a comissão será de 7%. Escreva um algoritmo que gere um relatório
contendo nome, valor da venda e comissão de cada um dos corretores. O
relatório deve mostrar também o total de vendas da empresa. */

    internal class Exercicio1
    {
        public static string[] Corretores = new string[3];
        public static double[] ValorVendaCorretores = new double[3];
        public static double[] ComissaoCorretores = new double[3];
        public static double[] TotalVendasCorretor = new double[3];
        public static double TotalVendasEmpresa = 0;

        public static void Main(String[] args)
        {
            GeraRelatorio();

            ImprimeRelatorio();
        }

        private static void ImprimeRelatorio()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Corretor: " + Corretores[i]);
                Console.WriteLine("Total de vendas: " + TotalVendasCorretor[i] + " Reais.");
                Console.WriteLine("Valor da comissão de vendas: " + ComissaoCorretores[i] + " Reais.");
                Console.WriteLine("Valor total de vendas da empresa: " + TotalVendasEmpresa + "Reais.");
                Console.ReadKey();
            }
        }

        private static void GeraRelatorio()
        {
            for (int i = 0; i < 3; i++)
            {
                LeituraDados(i);

                if (ValorVendaCorretores[i] > 50000)
                {
                    ComissaoCorretores[i] = (ValorVendaCorretores[i] * 12) / 100;
                    TotalVendasCorretor[i] = ValorVendaCorretores[i] + ComissaoCorretores[i];
                }
                else if (ValorVendaCorretores[i] >= 30000 & ValorVendaCorretores[i] <= 50000)
                {
                    ComissaoCorretores[i] = (ValorVendaCorretores[i] * 9.5) / 100;
                    TotalVendasCorretor[i] = ValorVendaCorretores[i] + ComissaoCorretores[i];
                }
                else
                {
                    ComissaoCorretores[i] = (ValorVendaCorretores[i] * 7) / 100;
                    TotalVendasCorretor[i] = ValorVendaCorretores[i] + ComissaoCorretores[i];
                }
            }
            TotalVendasEmpresa = ValorVendaCorretores[0] + ValorVendaCorretores[1] + ValorVendaCorretores[2];
        }

        private static void LeituraDados(int i)
        {
            Console.WriteLine("Digite o nome do corretor.");
            Corretores[i] = Console.ReadLine();
            Console.WriteLine("Digite o valor de vendas do corretor.");
            ValorVendaCorretores[i] = double.Parse(Console.ReadLine());
            
        }
    }
}