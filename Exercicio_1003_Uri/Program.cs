using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1003_Uri
{
    class Program
    {
        //teste
        static void Main(string[] args)
        {
            int A, B, soma;

            Console.Write("Digite um valor inteiro: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor inteiro: ");
            B = int.Parse(Console.ReadLine());

            soma = A + B;
            Console.WriteLine();
            Console.WriteLine("A soma dos valores digitado é = " + soma);
            Console.ReadLine();
        }
    }
}
/*Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA. 
 A seguir escrever o valor desta variável.

Entrada
O arquivo de entrada contém 2 valores inteiros.

Saída
Imprima a variável SOMA com todas as letras maiúsculas, com um espaço em branco antes e depois da igualdade seguido pelo valor 
correspondente à soma de A e B. Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, 
você receberá "Presentation Error".
*/
