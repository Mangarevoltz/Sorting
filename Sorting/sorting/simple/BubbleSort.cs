using Sorting.utils;

namespace Sorting.sorting.simple
{
    class BubbleSort
    {
        public static int[] Sorting(int[] vet)
        {
            int n = vet.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    UtilCountingTime.ContarComparacao();
                    if (vet[j] < vet[j - 1])
                    {
                        int tmp = vet[j];
                        UtilCountingTime.ContarAtribuicao();

                        vet[j] = vet[j - 1];
                        UtilCountingTime.ContarAtribuicao();

                        vet[j - 1] = tmp;
                        UtilCountingTime.ContarAtribuicao();

                        UtilCountingTime.ContarTroca();
                    }
                }
            }

            return vet;
        }
    }
}
