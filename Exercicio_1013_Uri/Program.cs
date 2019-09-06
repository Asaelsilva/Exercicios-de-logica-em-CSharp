using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1013_Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, maiorXY, maior;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            maiorXY = (x + y + Math.Abs(x - y)) / 2;

            maior = (maiorXY + z + Math.Abs(maiorXY - z)) / 2;
            Console.WriteLine(maior + " eh o maior");



            Console.ReadLine();
        }
    }
}
/*Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:



Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

Exemplos de Entrada       	Exemplos de Saída
7 14 106                    106 eh o maior

217 14 6                    217 eh o maior

*/
