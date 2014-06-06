using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExerciciosComplementares
{/*Crie um programa em C# que gere e exiba no terminal um número aleatório. Além disso, 
  * esse programa deve contabilizar a quantidade de dígitos “1” do número aleatório e
  * exibir essa quantidade no terminal. Complete o código abaixo.*/
    class Exercicio6
    {
        public static Random Gerador = new Random();
        public static int NumeroAleatorio = 0;
        public static int Cont = 0;
       
        public static void Main(string[] args)
        {
            NumeroAleatorio = Gerador.Next();      
            char[] conversor = NumeroAleatorio.ToString().ToCharArray();
            for (int i = 0; i < conversor.Length; i++)
            {
                if (conversor[i] == '1')
                {
                    Cont++;
                }
            }
            Console.WriteLine("Numero aleatório: {0} ", NumeroAleatorio);
            Console.WriteLine("Quantidade de '1': {0} ", Cont);
            Console.ReadKey();
        }
    }
}
