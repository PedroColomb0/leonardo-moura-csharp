using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {

            int diaDaSemana = 5;

            switch(diaDaSemana)
            {
                case 1:
                    Console.WriteLine("Segunda");
                    break;
                case 2:
                    Console.WriteLine("Terça");
                    break;
                case 3:
                    Console.WriteLine("Quarta");
                    break;
                case 4:
                    Console.WriteLine("Quinta");
                    break;
                case 5:
                    Console.WriteLine("Sexta");
                    break;
                default:
                    Console.WriteLine("Fim de semana");
                    break;
            }
        }
    }
}
