﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1016_Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, tempo;

            distancia = int.Parse(Console.ReadLine());

            tempo = distancia * 2;
            Console.WriteLine(tempo + " minutos");

            Console.ReadLine();
        }
    }
}
