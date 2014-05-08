using System;
using System.Collections;
using System.Collections.Generic;

namespace Unidade6.Exercicios_Complementares
{
    internal class Exercicio6
    {
        public static string NomeCandidata = "";
        public static double AlturaCandidata = 0;
        public static string Opcao = "";
        public static double MaiorAltura = 0;
        public static void Main1(String []args)
        {
            List<string> NomeCandidatas = new List<string>();
            List<double> AlturaCandidatas = new List<double>();
            LeituradeDados(NomeCandidatas, AlturaCandidatas);


            while (Opcao == "1")
            {
                NomeCandidatas.Add(NomeCandidata);
                AlturaCandidatas.Add(AlturaCandidata);
                if (MaiorAltura == 0)
                {
                    MaiorAltura = AlturaCandidata;
                }
                else if (AlturaCandidata > MaiorAltura)
                {
                    MaiorAltura = AlturaCandidata;
                   
                }
               
                
                LeituradeDados(NomeCandidatas,AlturaCandidatas);
            }
            for (int i = 0; i < AlturaCandidatas.Count; i++)
            {
                if (MaiorAltura == AlturaCandidatas[i])
                {
                    Console.WriteLine("A candidata mais alta é: " + NomeCandidatas[i]);
                    Console.WriteLine("Sua altura é: " + MaiorAltura + " Metros.");
                    Console.ReadKey();
                }
            }
        }

        private static void LeituradeDados(List<string> NomeCandidatas, List<double> AlturaCandidatas)
        {

            Console.WriteLine("Selecione a opção desejada. '1' para continuar e '2' para finalizar.");
            Opcao = Console.ReadLine();
            if (Opcao == "1")
            {
                Console.WriteLine("Digite o primeiro nome da candidata.");
                Console.WriteLine("Digite a altura da candidata.");
                NomeCandidata = Console.ReadLine();
                AlturaCandidata = double.Parse(Console.ReadLine());
            }
            else if (Opcao == "2")
            {
                Console.WriteLine("Programa Finalizado!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }            
        }
    }
}