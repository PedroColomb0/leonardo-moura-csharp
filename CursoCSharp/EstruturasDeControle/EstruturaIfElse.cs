using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            int idade = 16;

            if (idade >= 18)
            {
                Console.WriteLine("Voce ja pode beber");
            }
            else
            {
                Console.WriteLine("Voce não pode beber");
            }
        }
    }
}
