using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            string[] jogos = { "Minecraft", "CS", "LOL" };

            foreach (string jogo in jogos)
            {
                Console.WriteLine(jogo);
            }
        }
    }
}
