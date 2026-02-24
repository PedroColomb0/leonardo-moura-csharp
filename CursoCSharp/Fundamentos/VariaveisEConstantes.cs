using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // Variaveis Declaração Explicita
            int idade = 32;
            double altura = 1.75;
            string nome = "Gustavo";
            bool estaAprovado = true;
            char letra = 'A';

            // Inferencia de Tipo (Var)
            // A gnt define um valor para a variavel e o compilador infere o tipo dela
            var cidade = "Porto Velho";

            // Constante - variavel cujo valor não pode ser alterado

            const double Pi = 3.14;
            const string Empresa = "Microsoft";


            Console.WriteLine(idade);
            Console.WriteLine(cidade);
            Console.WriteLine(Empresa);
        }
    }
}
