using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaElseIf
    {
        public static void Executar()
        {
            int idade = 18;
            bool bebeu = true;

            if (idade >= 18 && !bebeu)
            {
                Console.WriteLine("Voce ja pode beber");
            }
            else if (idade >= 18 && bebeu)
            {
                Console.WriteLine("Voce não pode dirigir");
            }
            else {
                Console.WriteLine("Voce não pode dirigir");
            }
        }
    }
}
