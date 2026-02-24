using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class InterpolacaoString
    {
        public static void Executar()
        {
            // Interpolacao seria concatenacao, seria para juntarmos os textos fazer tipo a concatenacao

            var nome = "Pedro";
            var linguagem = "C#";
            var horas = 16.5;

            // modo da concatenacao(Modo antigo)
            var frase1 = "Olá, me chamo " + nome + " e estudo " + linguagem + " por " + horas + " horas";

            // Interpolacao modo mais utilizado
            var frase2 = $"Olá, me chamo {nome} e estudo {linguagem} por {horas} horas";

            // podemos fazer operacoes também dentro das chaves
            var preco = 50.0;
            var desconto = 10.0;

            var aviso = $"O valor final a pagar é {preco - desconto}";

            Console.WriteLine(frase2);

            Console.WriteLine(aviso);
        }
    }
}
