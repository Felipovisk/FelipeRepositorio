using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Exercicios_Complementares
{
    class Exercicio3
    {
        public static double AlturaCidadao = 0;
        public static char SexoCidadao = 'l';
        public static double PesoIdeal = 0;

        private static void MenuSexo()
        {
            Console.WriteLine("Informe seu sexo. Digite '1' para 'feminino' ou '2' para 'masculino'");
            SexoCidadao = char.Parse(Console.ReadLine());
        }

        public static void Main1(String[] args)
        {
            Console.WriteLine("Digite a sua altura.");
            AlturaCidadao = double.Parse(Console.ReadLine());
            MenuSexo();
            CalculaPeso();
            TratamentoInvalido();
            Console.WriteLine("O seu peso ideal é: " + PesoIdeal + "Kg");
            Console.ReadKey();
        }

        private static void TratamentoInvalido()
        {
            if (SexoCidadao != '1' && SexoCidadao != '2')
            {
                Console.WriteLine("Opção de sexo inválida, por favor digite uma das opções mencionadas.");
                MenuSexo();
                CalculaPeso();
            }
            
        }

        private static void CalculaPeso()
        {
            if (SexoCidadao == '1')
            {
                PesoIdeal = ((62.1 * AlturaCidadao) - 44.7);
            }
            if (SexoCidadao == '2')
            {
                PesoIdeal = ((72.7 * AlturaCidadao) - 58);
            }
            TratamentoInvalido();
        }
    }
}

