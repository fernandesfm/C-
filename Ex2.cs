﻿using System;

namespace Exercicio2
{
    class Ex2
    {
        static void Main(string[] args)
        {
            float n1 = 109, n2 = 90;

            float soma = n1 + n2;
            float sub = n1 - n2;
            float div = n1 / n2;

            Console.WriteLine("Soma entre " + n1 + " e " + n2 + " eh " + soma);
            Console.WriteLine("Subtracao entre " + n1 + " e " + n2 + " eh " + sub);
            Console.WriteLine("Divisao entre " + n1 + " e " + n2 + " eh " + div);
        }
    }
}
