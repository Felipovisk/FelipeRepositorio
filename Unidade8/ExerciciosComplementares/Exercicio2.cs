using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade8.ExerciciosComplementares
{/*Crie um programa em C# que exiba o seguinte padrão no terminal.

**********
 **********
  **********
   **********
    **********
**********
 **********
  **********
   **********
    **********
**********
 **********
  **********
   **********
    **********
*/
    class Exercicio2
    {
        public static int NumeroDeEspacos = 0;
        public static void Main1(string[] args)
        {
            
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 5; j++) 
                {
                    for (int x = 0; x < NumeroDeEspacos; x++)
                    {
                        Console.Write(" ");
                    }
                    for (int y = 0; y < 9; y++) 
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); 
                    NumeroDeEspacos++; 
                }
                NumeroDeEspacos = 0;

            }
            Console.ReadKey();
        }
    }
}
