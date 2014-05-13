using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Exercicios_Complementares
{
    /*Quando se lista o nome de autores de livros, artigos e outras publicações 
     é comum que se apresente o nome do autor ou dos autores da seguinte forma: 
     sobrenome do autor em letras maiúsculas, seguido de uma vírgula e da primeira 
     parte do nome apenas com as iniciais maiúsculas.
Por exemplo:
SILVA, Joao
COELHO, Paulo
ARAUJO, Celso de
Seu desafio é fazer um programa que leia um número inteiro correspondendo ao número 
de nomes que será fornecido, e, a seguir, leia estes nomes (que podem estar em qualquer 
tipo de letra) e imprima a versão formatada no estilo exemplificado acima.*/

    class Exercicio8
    {
        public static int QuantidadeNomes = 0 ;
        public static string[] NomesCompletos;
        public static string[] NomesAutores = new string[100];
        public static void Main(String[] args)
        {
            Console.WriteLine("Digite quantos autores serão cadastrados.");
            QuantidadeNomes = int.Parse(Console.ReadLine());
            NomesCompletos = new string[QuantidadeNomes];
            for (int i = 0; i < QuantidadeNomes; i++)
            {
                Console.WriteLine("Digite o nome completo do autor.");
                NomesCompletos[i] = Console.ReadLine();
                string[] arrayNome = NomesCompletos[i].Split(' ');
                int ultimaPosicao = arrayNome.Length - 1;
                NomesAutores[i] = arrayNome[ultimaPosicao].ToUpper() + ", ";
                string primeiroNome = arrayNome[0];
                string segundoNome = arrayNome[1];

            }
        }
    }
}
