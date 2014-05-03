using System;

namespace Unidade6.Exercicios_Complementares
{
    internal class Exercicio4
    {
        public static int GolsGremio = 0;
        public static int GolsInter = 0;

        public static void Main1(String[] args)
        {
            CalculoGolsPartida();
            var inicioJogo = DateTime.Now;
            var finalJogo = inicioJogo.AddMinutes(110);
            DefineVencedor(inicioJogo, finalJogo);

        }

        private static void CalculoGolsPartida()
        {
            Random GolsPartida = new Random();
            GolsInter = GolsPartida.Next(1, 5);
            GolsGremio = GolsPartida.Next(1, 5);
        }

        private static void DefineVencedor(DateTime inicioJogo, DateTime finalJogo)
        {
            if (GolsInter == GolsGremio)
            {
                Console.WriteLine("Empate!");
                Console.WriteLine("Internacional: " + GolsInter + " gols");
                Console.WriteLine("Grêmio: " + GolsGremio + " gols");
                Console.WriteLine("Inicio do jogo: " + inicioJogo);
                Console.WriteLine("Fim do jogo: " + finalJogo);
                Console.ReadKey();
            }
            else if (GolsInter > GolsGremio)
            {
                Console.WriteLine("Vitória do Internacional!");
                Console.WriteLine("Internacional: " + GolsInter + " gols");
                Console.WriteLine("Grêmio: " + GolsGremio + " gols");
                Console.WriteLine("Inicio do jogo: " + inicioJogo);
                Console.WriteLine("Fim do jogo: " + finalJogo);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Vitória do Grêmio!");
                Console.WriteLine("Internacional: " + GolsInter + " gols");
                Console.WriteLine("Grêmio: " + GolsGremio + " gols");
                Console.WriteLine("Inicio do jogo: " + inicioJogo);
                Console.WriteLine("Fim do jogo: " + finalJogo);
                Console.ReadKey();
            }
        }
    }
}