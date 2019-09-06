using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_1010_Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int COD1, COD2, QTD1, QTD2;
            
            double preco1, preco2, valorPago;

            string[] vet = Console.ReadLine().Split(' ');


            COD1 = int.Parse(vet[0]);
            QTD1 = int.Parse(vet[1]);
            preco1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            COD2 = int.Parse(vet[0]);
            QTD2 = int.Parse(vet[1]);
            preco2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            valorPago = QTD1 * preco1 + QTD2 * preco2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorPago.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
