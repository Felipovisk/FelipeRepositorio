using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoaFebreVI
{
    class Exercicio12
    {
        static public string[] MatriculaAluno = new string[100];
        static public int[] FrenquenciaAluno = new int[100];
        static public double[] NotasAluno1 = new double[100];
        static public double[] NotasAluno2 = new double[100];
        static public double[] NotasAluno3 = new double[100];
        static public double[] NotaFinalAluno = new double[100];
        static public double NotasTurma = 0;
        static public double MediaTurma = 0;
        static public int Cont1 = 0;
        static public int Cont2 = 0;
        static public string Codigo = "";




        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Digite a matricula do aluno.");
                MatriculaAluno[i] = Console.ReadLine();
                Console.WriteLine("Digite quantas aulas o aluno frequentou.");
                FrenquenciaAluno[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite as três notas do aluno.");
                NotasAluno1[i] = double.Parse(Console.ReadLine());
                NotasAluno2[i] = double.Parse(Console.ReadLine());
                NotasAluno3[i] = double.Parse(Console.ReadLine());
                

            }
            for (int i = 0; i < 100; i++)
            {
                NotaFinalAluno[i] = (NotasAluno1[i] + NotasAluno2[i] + NotasAluno3[i]) / 3;
         
             

            }
            for (int i = 0; i < 100; i++)
            {
                NotasTurma += NotaFinalAluno[i];
                MediaTurma = NotasTurma / 100;




            }
            for (int i = 0; i < 100; i++)
            {
                if (FrenquenciaAluno[i] > 39 & NotaFinalAluno[i] >= 6)
                {
                    Codigo = "Aprovado!";
                    Cont1 += 1;

                }
                else if (FrenquenciaAluno[i] < 40 & NotaFinalAluno[i] < 6)
                {
                    Codigo = "Reprovado!";
                    Cont2 += 1;
                }
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Matricula: " + MatriculaAluno[i]);
                Console.WriteLine("Frenquencia : " + FrenquenciaAluno[i] + " aulas comparecidas.");
                Console.WriteLine("Avaliação final: " + Codigo);

            }
            
        }
    }
}
