using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{/*6)	Faça um espelho de classe. Uma matriz com 14 elementos. Conforme cada lugar dos 
  * companheiros de sala.*/
    class Exercicio6
    {
        public static string[,] EspelhoDeClasse = new string[3, 5];
        public static void Main1(string[] args)
        {
            
                    EspelhoDeClasse[0, 0] = "Giorgi";
                    EspelhoDeClasse[0, 1] = "Lucas";
                    EspelhoDeClasse[0, 2] = "Camila";
                    EspelhoDeClasse[0, 3] = "Greicy";
                    EspelhoDeClasse[0, 4] = "Mateus";
                    EspelhoDeClasse[1, 0] = "Lucas";
                    EspelhoDeClasse[1, 1] = "Guilherme";
                    EspelhoDeClasse[1, 2] = "Arnaldo";
                    EspelhoDeClasse[1, 3] = "Felipe";
                    EspelhoDeClasse[1, 4] = "";
                    EspelhoDeClasse[2, 0] = "Luiz";
                    EspelhoDeClasse[2, 1] = "Aprigio";
                    EspelhoDeClasse[2, 2] = "Raul";
                    EspelhoDeClasse[2, 3] = "Antonio";
                    EspelhoDeClasse[2, 4] = "Rafael";
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.WriteLine(EspelhoDeClasse[i,j]);
                        }
                    }
            Console.ReadKey();
        }
    } 
}
    

