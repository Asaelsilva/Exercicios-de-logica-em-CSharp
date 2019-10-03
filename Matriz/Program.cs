using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            int linha, coluna;

            int[,] matriz;

            string[] s1 = Console.ReadLine().Split(' ');
            linha = int.Parse(s1[0]);
            coluna = int.Parse(s1[1]);
            matriz = new int[linha, coluna];


            for (int i = 0; i < linha; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < coluna; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
