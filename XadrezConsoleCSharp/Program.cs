﻿using System;
using tabuleiro;
using Xadrez;

namespace XadrezConsoleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
        }
    }
}
