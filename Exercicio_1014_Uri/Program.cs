using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_1014_Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int Km;
            double Combustivel, KMl;

            Km = int.Parse(Console.ReadLine());
            Combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            KMl = Km / Combustivel;

            Console.WriteLine(KMl.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
            Console.ReadLine();
        }
    }
}
/*Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).

Entrada
O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km),
e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.

Saída
Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".
*/
