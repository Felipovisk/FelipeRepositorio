using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7.ExerciciosFixação1
{
    /*1) Faça um algoritmo para ler o código e o preço de 15 produtos, calcular e 
    escrever: 
- o maior preço lido 
- a média aritmética dos preços dos produtos.*/

    class Exercicio1
    {
        public static string[] CodigoProduto = new string[15];
        public static double[] PrecoProduto = new double[15];
        public static double Aux = 0;
        public static double MediaProduto = 0;
        public static void Main1(String[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite o código do produto.");
                CodigoProduto[i] = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto.");
                PrecoProduto[i] = double.Parse(Console.ReadLine());
                if (PrecoProduto[i] > Aux)
                {
                    Aux = PrecoProduto[i];
                }
                MediaProduto += PrecoProduto[i] / 15;
            }
            Console.WriteLine("O preço do maior produto é: " + Aux + " Reais.");
            Console.WriteLine("A média dos produtos é de: " + MediaProduto + " Reais.");
            Console.ReadKey();
            
                

        }
    }
}
