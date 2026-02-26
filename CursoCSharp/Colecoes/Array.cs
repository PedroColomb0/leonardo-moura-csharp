using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Ana";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniel";
            alunos[4] = "Gui";

            foreach(string s in alunos)
            {
                Console.WriteLine(s);
            }

            // Ja podemos inicializar a array com valores

            double somatorio = 0;
            double[] notas = { 9.7, 8.5, 7.1, 6.8 };

            foreach(var nota in notas)
            {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;

            Console.WriteLine(media);
        }
    }
}
