using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_1012_Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            double TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;
            double pi = 3.14159;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            A = Double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            TRIANGULO = A * C / 2;
            CIRCULO = pi * Math.Pow(C, 2.0);
            TRAPEZIO = (A + B) * C / 2 ;
            QUADRADO = Math.Pow(B, 2.0);
            RETANGULO = A * B;

            Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
/*
 Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre: 
a) a área do triângulo retângulo que tem A por base e C por altura. 
b) a área do círculo de raio C. (pi = 3.14159) 
c) a área do trapézio que tem A e B por bases e C por altura. 
d) a área do quadrado que tem lado B. 
e) a área do retângulo que tem lados A e B. 
Entrada
O arquivo de entrada contém três valores com um dígito após o ponto decimal.

Saída
O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.


Exemplos de Entrada	        Exemplos de Saída    
    
3.0 4.0 5.2                 TRIANGULO: 7.800
                            CIRCULO: 84.949
                            TRAPEZIO: 18.200
                            QUADRADO: 16.000
                            RETANGULO: 12.000


12.7 10.4 15.2              TRIANGULO: 96.520
                            CIRCULO: 725.833
                            TRAPEZIO: 175.560
                            QUADRADO: 108.160
                            RETANGULO: 132.080

*/
