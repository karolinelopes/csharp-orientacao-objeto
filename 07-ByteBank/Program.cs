﻿using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Agencia);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        }
    }
}
