using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7.ExerciciosFixação1
{
 /* Uma loja está levantando o valor total de todas as mercadorias em estoque. Escreva 
 um algoritmo que permita a entrada das seguintes informações: 
a) o número total de mercadorias no estoque; 
b) o valor de cada mercadoria. Ao final imprimir o valor total em estoque e a média de 
valor das mercadorias. */
    class Exercicio3
    {        
        public static double[] ValorMercadoria;
        public static double SomaMercadoria = 0;
        public static double MediaMecadoria = 0;
        public static void Main1(String[] args)
        {
            
            Console.WriteLine("Digite a quantidade de produtos em estoque.");
            var quantidadeMercadoria = int.Parse(Console.ReadLine());
            ValorMercadoria = new double[quantidadeMercadoria];
            
            for (int i = 0; i < quantidadeMercadoria; i++)
            {
                Console.WriteLine("Digite o valor do produto.");
                ValorMercadoria[i] = double.Parse(Console.ReadLine());
                SomaMercadoria += ValorMercadoria[i];

            }
            MediaMecadoria = SomaMercadoria / quantidadeMercadoria;
            Console.WriteLine("O valor total de mercadorias em estoque é de: " + SomaMercadoria + " Reais.");
            Console.WriteLine("A média de valor das mercadorias em estoque é de: " + MediaMecadoria + " Reais.");
            Console.ReadKey();

        }
    }
}
