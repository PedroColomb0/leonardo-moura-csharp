using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia Tipos - Fundamentos", InferenciaTipos.Executar},
                {"Interpolacao String - Fundamentos", InterpolacaoString.Executar},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Console - Fundamentos", LendoConsole.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}