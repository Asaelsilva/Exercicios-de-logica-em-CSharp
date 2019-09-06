using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1007_Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, diferenca;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            diferenca = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + diferenca);
            Console.ReadLine();
        }
    }
}
