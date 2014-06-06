using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExerciciosComplementares
{/*Considere um jogo no qual o jogador lança um dado 10 vezes. O jogador ganha se a 
  * soma dos valores obtidos nos lançamentos for ímpar. Se o número 6 for sorteado 2 
  * vezes o jogador perde imediatamente. O número 1 deve ser desconsiderado na 
  * somatória. Implemente um programa em C# para simular a execução desse jogo*/

    class Exercicio5
    {
        public static int[] LancamentoDeDados = new int[10];
        public static Random Gerador = new Random();
        public static int Cont = 0;
        public static int SomaLancamentos = 0;
        public static void Main1(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                LancamentoDeDados[i] = Gerador.Next(0, 7);
                if (LancamentoDeDados[i] == 6)
                {
                    Cont++;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (LancamentoDeDados[i] != 1)
                {
                    SomaLancamentos += LancamentoDeDados[i];
                }                

            }
            if (SomaLancamentos % 2 == 1)
            {
                Console.WriteLine("Parabéns,voce ganhou o jogo!");
            }
            else if (SomaLancamentos % 2 == 0 | Cont >= 2)
            {
                Console.WriteLine("Parabéns, voce perdeu o jogo!");
            }
            Console.ReadKey();
        }
    }
}
