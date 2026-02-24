using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int contador = 1;

            while(contador <= 10)
            {
                Console.Write($"{contador} ");
                contador++;
            }
        }
    }
}
