using System;

namespace MedindoAFebreUnidadesIXeX
{
    internal class Exercicio13
    {
        public static int[] Idade = new int[50];
        public static string[] Nome = new string[50];
        public static char[] Sexo = new char[50];
        public static double[] Altura = new double[50];
        public static bool[] Adulto = new bool[50];
        public static Random GeradorDeDados = new Random();
        public static int ContFeminino = 0;
        public static int ContMasculino = 0;
        public static int ContMaiorDeIdade = 0;
        public static int ContMenorDeIdade = 0;
        public static int ContMaioresDeAltura = 0;
        public static int ContMenoresDeAltura = 0;

        public static void Main(string[] args)
        {
            IniciaVariaveis();
            ContagemDeVariaveis();
            int auxPercentualAdultos;
            int auxPercentualNaoAdultos;
            int auxPercentualFeminino;
            int auxPercentualMasculino;
            int auxPercuntualMaisAltos;
            CalculoPercentual(out auxPercentualAdultos, out auxPercentualNaoAdultos, out auxPercentualFeminino, out auxPercentualMasculino, out auxPercuntualMaisAltos);
            Console.WriteLine("O Percentual de adultos é de: " + auxPercentualAdultos + "%");
            Console.WriteLine("O Percentual de não adultos é de: " + auxPercentualNaoAdultos + "%");
            Console.WriteLine("O Percentual de Homens é de: " + auxPercentualMasculino + "%");
            Console.WriteLine("O Percentual de Mulheres é de: " + auxPercentualFeminino + "%");
            Console.WriteLine("O Percentual de pessoass maiores que 1,70 é de: " + auxPercuntualMaisAltos + "%");
            double auxMaisAlto;
            string auxNomeMaisAlto;
            double auxMaisBaixo;
            string auxNomeMaisBaixo;
            CalculaMaisAltoEMaisBaixo(out auxMaisAlto, out auxNomeMaisAlto, out auxMaisBaixo, out auxNomeMaisBaixo);

            int auxMaisVelho;
            string auxNomeMaisVelho;
            int auxMaisNovo;
            string auxNomeMaisNovo;
            CalculaMaisNovoEMaisVelho(out auxMaisVelho, out auxNomeMaisVelho, out auxMaisNovo, out auxNomeMaisNovo);
            Console.WriteLine("O Cidadão mais alto é: " + auxNomeMaisAlto);
            Console.WriteLine("Com : " + auxMaisAlto.ToString("##.##") + " Metros de altura.");
            Console.WriteLine("O Cidadão mais baixo é: " + auxNomeMaisBaixo);
            Console.WriteLine("Com : " + auxMaisBaixo.ToString("##.##") + " Metros de altura.");
            Console.WriteLine("O Cidadão mais velho é: " + auxNomeMaisVelho);
            Console.WriteLine("Com : " + auxMaisVelho + " anos de idade.");
            Console.WriteLine("O Cidadão mais novo é: " + auxNomeMaisNovo);
            Console.WriteLine("Com : " + auxMaisNovo + " anos de idade.");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Nome: " + Nome[i]);
                Console.WriteLine("Idade: " + Idade[i]);
                Console.WriteLine("Sexo: " + Sexo[i]);
                Console.WriteLine("Altura: " + Altura[i].ToString("##.##") + " Metros de altura.");
                Console.WriteLine("Adulto: " + Adulto[i]);
            }
            Console.ReadKey();
        }

        private static void CalculaMaisNovoEMaisVelho(out int auxMaisVelho, out string auxNomeMaisVelho, out int auxMaisNovo, out string auxNomeMaisNovo)
        {
            auxMaisVelho = 0;
            auxNomeMaisVelho = "";
            auxMaisNovo = 18;
            auxNomeMaisNovo = "";
            for (int i = 0; i < 50; i++)
            {
                if (Idade[i] > auxMaisVelho)
                {
                    auxMaisVelho = Idade[i];
                    auxNomeMaisVelho = Nome[i];
                }
                else if (Idade[i] < auxMaisNovo)
                {
                    auxMaisNovo = Idade[i];
                    auxNomeMaisNovo = Nome[i];
                }
            }
        }

        private static void CalculaMaisAltoEMaisBaixo(out double auxMaisAlto, out string auxNomeMaisAlto, out double auxMaisBaixo, out string auxNomeMaisBaixo)
        {
            auxMaisAlto = 0;
            auxNomeMaisAlto = "";
            auxMaisBaixo = 3;
            auxNomeMaisBaixo = "";
            for (int i = 0; i < 50; i++)
            {
                if (Altura[i] > auxMaisAlto)
                {
                    auxMaisAlto = Altura[i];
                    auxNomeMaisAlto = Nome[i];
                }
                if (Altura[i] < auxMaisBaixo)
                {
                    auxMaisBaixo = Altura[i];
                    auxNomeMaisBaixo = Nome[i];
                }
            }
        }

        private static void CalculoPercentual(out int auxPercentualAdultos, out int auxPercentualNaoAdultos, out int auxPercentualFeminino, out int auxPercentualMasculino, out int auxPercuntualMaisAltos)
        {
            auxPercentualAdultos = 0;
            auxPercentualNaoAdultos = 0;
            auxPercentualFeminino = 0;
            auxPercentualMasculino = 0;
            auxPercuntualMaisAltos = 0;
            auxPercentualAdultos = ContMaiorDeIdade * 100 / 50;
            auxPercentualNaoAdultos = ContMenorDeIdade * 100 / 50;
            auxPercentualFeminino = ContFeminino * 100 / 50;
            auxPercentualMasculino = ContMasculino * 100 / 50;
            auxPercuntualMaisAltos = ContMaioresDeAltura * 100 / 50;
        }

        private static void ContagemDeVariaveis()
        {
            for (int i = 0; i < 50; i++)
            {
                if (Sexo[i] == 'f')
                {
                    ContFeminino += 1;
                }
                else
                {
                    ContMasculino += 1;
                }
                if (Adulto[i] == true)
                {
                    ContMaiorDeIdade += 1;
                }
                else
                {
                    ContMenorDeIdade += 1;
                }
                if (Altura[i] > 1.70)
                {
                    ContMaioresDeAltura += 1;
                }
                else
                {
                    ContMenoresDeAltura += 1;
                }
            }
        }

        private static void IniciaVariaveis()
        {
            for (int i = 0; i < 50; i++)
            {
                Nome[i] = "Nome" + i;
                Idade[i] = GeradorDeDados.Next(1, 101);
                if (Idade[i] >= 18)
                {
                    Adulto[i] = true;
                }
                else
                {
                    Adulto[i] = false;
                }
                Altura[i] = GeradorDeDados.NextDouble() + 1;
                int numero = GeradorDeDados.Next(0, 2);
                if (numero == 0)
                {
                    Sexo[i] = 'f';
                }
                else
                {
                    Sexo[i] = 'm';
                }
            }
        }
    }
}