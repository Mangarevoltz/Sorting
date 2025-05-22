using System;
using System.Diagnostics;

namespace Sorting.utils
{
    public static class UtilCountingTime
    {
        private static Stopwatch stopwatch = new Stopwatch();

        public static long Comparacoes { get; private set; }
        public static long Trocas { get; private set; }
        public static long Atribuicoes { get; private set; }

        public static void IniciarContagem()
        {
            Comparacoes = 0;
            Trocas = 0;
            Atribuicoes = 0;
            stopwatch.Restart();
        }

        public static void FinalizarContagem()
        {
            stopwatch.Stop();
        }

        public static void ContarComparacao()
        {
            Comparacoes++;
        }

        public static void ContarTroca()
        {
            Trocas++;
        }

        public static void ContarAtribuicao()
        {
            Atribuicoes++;
        }

        public static void ImprimirContagem()
        {
            Console.WriteLine("\n--- Métricas de Execução ---");
            Console.WriteLine($"Tempo de execução: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Comparações: {Comparacoes}");
            Console.WriteLine($"Trocas: {Trocas}");
            Console.WriteLine($"Atribuições: {Atribuicoes}");
            Console.WriteLine("-----------------------------\n");
        }
    }
}
