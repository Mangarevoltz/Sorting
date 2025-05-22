using Sorting.utils;

namespace Sorting.sorting.efficient
{
    class QuickSort
    {
        public static int[] Sorting(int[] vet)
        {
            QuickSortRecursive(vet, 0, vet.Length - 1);
            return vet;
        }

        private static void QuickSortRecursive(int[] vet, int inicio, int fim)
        {
            if (inicio < fim)
            {
                UtilCountingTime.ContarComparacao(); // comparação da condição do if
                int pivo = Particionar(vet, inicio, fim);
                QuickSortRecursive(vet, inicio, pivo - 1);
                QuickSortRecursive(vet, pivo + 1, fim);
            }
        }

        private static int Particionar(int[] vet, int inicio, int fim)
        {
            int pivo = vet[fim];
            UtilCountingTime.ContarAtribuicao();

            int i = inicio - 1;
            UtilCountingTime.ContarAtribuicao();

            for (int j = inicio; j < fim; j++)
            {
                UtilCountingTime.ContarComparacao();
                if (vet[j] <= pivo)
                {
                    i++;
                    UtilCountingTime.ContarAtribuicao();

                    // Troca
                    (vet[i], vet[j]) = (vet[j], vet[i]);
                    UtilCountingTime.ContarTroca();
                }
            }

            (vet[i + 1], vet[fim]) = (vet[fim], vet[i + 1]);
            UtilCountingTime.ContarTroca();

            return i + 1;
        }
    }
}
