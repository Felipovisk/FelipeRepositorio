using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10
{/*2)	Implemente um método que verifica se uma determinada data é válida ou não. 
  * Lembre-se que Janeiro, Março, Maio, Julho, Agosto, Outubro e Dezembro possuem 31 dias; 
  * Abril, Junho, Setembro e Novembro possuem 30 dias; e Fevereiro possui 28 dias em anos 
  * não bissextos e 29 dias em anos bissextos.*/
    class Exercicio2
    {
        public static string DataVerificacao = "";
        public static DateTime DataAnalise = new DateTime();
        public static void Main2(string[] args)
        {
            VerificaData();
            

          
        }

        private static void VerificaData()
        {
            Console.WriteLine("Digite a data para ser analizada, no formato de DD/MM/AAAA.");
            DataVerificacao = Console.ReadLine();
            if (DateTime.TryParse(DataVerificacao, out DataAnalise))
            {
                Console.WriteLine("A data é consistente.");
            }
            else
            {
                Console.WriteLine("A data não é consistente.");
            }
            Console.ReadKey();
        }
    }
}
