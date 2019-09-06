using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_base_altura
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, _base, area, perimetro, diagonal;



            _base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            //calculando area
            area = _base * altura;
            //calculando perimetro formula: perimetro = 2 * _base + 2 * altura; ou
            perimetro = 2 * (_base + altura);
            // calculo da diagonal... formula: Diagoal =  raiz quadrada de base ao quadrado +altura ao quadrado
            diagonal = Math.Sqrt(Math.Pow(_base , 2.0) + Math.Pow(altura, 2.0));


            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));


            Console.ReadLine();



        }
    }
}
