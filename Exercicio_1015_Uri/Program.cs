using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_1015_Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1, X2, Y1, Y2, distancia;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            X1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            Y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            X2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            Y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt (Math.Pow (X2 -X1 , 2.0) + Math.Pow(Y2 - Y1, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));


            Console.ReadLine();
        }
    }
}
