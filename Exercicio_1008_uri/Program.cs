using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_1008_uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int Funcionario, numeroDeHorasTrabalhadas;
            double valorDaHoraTrabalhada, salario;

            Funcionario = int.Parse(Console.ReadLine());
            numeroDeHorasTrabalhadas = int.Parse(Console.ReadLine());
            valorDaHoraTrabalhada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = numeroDeHorasTrabalhadas * valorDaHoraTrabalhada;

            Console.WriteLine("NUMBER = " + Funcionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
