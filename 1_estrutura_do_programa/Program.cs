﻿using System;

namespace _1_estrutura_do_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            var s=new Pilha();

            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);

            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}
