﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Raio, Area;
            double n = 3.14159;

            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = n * Raio * Raio;

            Console.WriteLine("A = " + Area.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
/*A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:

- Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

Entrada
A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.

Saída
Apresentar a mensagem "A=" seguido pelo valor da variável area, conforme exemplo abaixo, com 4 casas após o ponto decimal. 
Utilize variáveis de dupla precisão (double). Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado,
caso contrário, você receberá "Presentation Error".*/
