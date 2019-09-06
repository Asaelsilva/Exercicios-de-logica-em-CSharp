using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_1009_Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, totalVendas, salarioFinal;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioFinal = (totalVendas * 15 / 100) + salarioFixo;
            Console.WriteLine("TOTAL = R$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
