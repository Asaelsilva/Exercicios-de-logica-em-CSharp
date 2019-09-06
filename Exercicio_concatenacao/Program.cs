using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_concatenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double media;
            string[] vet;

            Console.WriteLine("Informe o nome e a idade de duas pessoas");
            Console.WriteLine("Exemplo: Asael 26");

            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);

            media = (Double)(idade1 + idade2) / 2;
            Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + "anos!");

            Console.ReadLine();
        }
    }
}
