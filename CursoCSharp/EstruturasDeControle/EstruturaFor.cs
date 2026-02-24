using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {

        public static void Executar()
        {
            for (int i = 0; i < 10; i++)
            {
                if(i == 5)
                {
                    continue;
                }
                Console.WriteLine($"O valor de i é {i}");
            }
        }

    }
}
