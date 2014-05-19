using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7.ExerciciosFixação1
{
/* A prefeitura de uma cidade deseja fazer uma pesquisa entre seus habitantes. 
Faça um algoritmos para coletar dados sobre o salário e número de filhos de cada 
habitante e após as leituras, escrever: 
a) Média de salário da população 
b) Média do número de filhos 
c) Maior salário dos habitantes 
d) Percentual de pessoas com salário menor que R$ 150,00 
Obs.: O final da leituras dos dados se dará com a entrada de um “salário negativo” */

    class ExercicioFixacao2
    {
        public static double SalarioCidadao = 0;
        public static int FilhosCidadao = 0;
        public static double MediaSalario = 0;
        public static double MediaFilhos = 0;
        public static int ContSalarioMenor150 = 0;
        public static double PercentualSalario = 0;
        public static double Aux = 0;
        public static void Main(String[] args)
        {
            Console.WriteLine("Digite o salario do cidadão.");
            SalarioCidadao = double.Parse(Console.ReadLine());
            while (SalarioCidadao >= 0)
            {
                
                double cont = 0;
                cont ++;
                Console.WriteLine("Digite quantos filhos o cidadão possui.");
                FilhosCidadao = int.Parse(Console.ReadLine());
                MediaSalario += SalarioCidadao / cont;
                double contfilhos = 0; contfilhos += FilhosCidadao;
                MediaFilhos = contfilhos / cont;
                
                if (SalarioCidadao > Aux)
                {
                    Aux = SalarioCidadao;
                }
                else if (SalarioCidadao < 150)
                {
                    ContSalarioMenor150++;
                    PercentualSalario = (cont * ContSalarioMenor150) / 100;
                }


                Console.WriteLine("Digite o salario do cidadão.");
                SalarioCidadao = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("A media de salario da população é de: " + MediaSalario + " Reais.");
            Console.WriteLine("A media de filhos da população é de: " + MediaFilhos + " filhos por cidadão.");
            Console.WriteLine("O maior salario dos habitantes é de: " + Aux + " Reais.");
            Console.WriteLine("Percentual de cidadões com salário abaixo de R$ 150,00 é de: " + PercentualSalario + " %.");
            Console.ReadKey();
            
        }
    }
}
