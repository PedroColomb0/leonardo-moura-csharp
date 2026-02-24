using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    public class LendoConsole
    {
        public static void Executar()
        {

            // Entrada de dados, para ler o que o usuario digitar no console, a gente utiliza o Console.ReadLine()
            // que retorna uma string,
            // entao se a gente quiser ler um numero por exemplo,
            // a gente tem que converter essa string para o tipo numerico desejado

            Console.Write("Quantas linhas voce deseja extrair dessa tabela: ");
            string entrada = Console.ReadLine();

            Console.WriteLine(entrada.GetType());

            // Calculo para converter a string para inteiro

            Console.Write("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("------------");

            Console.Write($"A soma dos numeros deu {numero1 + numero2}");
        }
    }
}
