using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro()
        {

        }
    }


    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "Chevrolet";
            carro1.Modelo = "Corsa";
            carro1.Ano = 2002;

            Console.WriteLine($"{carro1.Fabricante} e {carro1.Modelo} e {carro1.Ano}");

            var carro2 = new Carro("KA", "FORD", 2020);

            Console.WriteLine($"{carro2.Fabricante} e {carro2.Modelo} e {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2010
            };

            Console.WriteLine($"{carro3.Fabricante} e {carro3.Modelo} e {carro3.Ano}");

        }
    }
}
