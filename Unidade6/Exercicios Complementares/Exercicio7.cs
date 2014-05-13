using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Exercicios_Complementares
{
/*Escreva um programa que leia dados o tipo do funcionário 
(“H” = Horista ou “M” = Mensalista), o salário por hora (horistas) ou por mês 
(mensalistas) e, o número de horas trabalhadas (horistas) ou o valor de faltas 
(mensalistas), calcular o valor do salário bruto.*/
    class Exercicio7
    {
        public static char TipoFuncionario = '0';
        public static double Salario = 0;
        public static int JornadaTrabalho = 0;
        public static double SalarioBruto = 0;
        public static void Main1(String[] args)
        {
            Console.WriteLine("Digite o tipo do funcionário.");
            Console.WriteLine("'M' para mensalista ou 'H' para horista.");
            TipoFuncionario = char.Parse(Console.ReadLine());
            if (TipoFuncionario == 'H' | TipoFuncionario == 'h')
            {
                Console.WriteLine("Digite o valor trabalhado por hora.");
                Salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o numero de horas trabalhadas.");
                JornadaTrabalho = int.Parse(Console.ReadLine());
                SalarioBruto = Salario * JornadaTrabalho;

            }
            else if (TipoFuncionario == 'M' | TipoFuncionario == 'm')
            {
                Console.WriteLine("Digite o valor trabalhado por mês.");
                Salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o numero de faltas no mês.");
                JornadaTrabalho = int.Parse(Console.ReadLine());
                double salarioDia = Salario / 30;
                SalarioBruto = Salario - (salarioDia * JornadaTrabalho);

            }
            else
            {
                Console.WriteLine("Opção de funcionário inválida.");
                
            }
            if (TipoFuncionario == 'H' | TipoFuncionario == 'h')
            {
                Console.WriteLine("Funcionário tipo: Horista.");
                Console.WriteLine("Salário final de: " + SalarioBruto + " Reais.");
                Console.ReadKey();
            }
            else if (TipoFuncionario == 'M' | TipoFuncionario == 'm')
            {
                Console.WriteLine("Funcionário tipo: Mensalista.");
                Console.WriteLine("Salário final de: " + SalarioBruto + " Reais.");
                Console.ReadKey();
            }
            else
            {
                Console.ReadKey();
            }
            
            
        }
    }
}
