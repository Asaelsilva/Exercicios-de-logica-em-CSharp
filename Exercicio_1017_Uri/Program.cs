using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Exercicio_1017_Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade, distancia;
     
            double litros;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo * velocidade;
            litros = (double)distancia / 12;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
