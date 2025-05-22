namespace Sorting.sorting.efficient
{
    class ShellSort
    {
        public static int[] Sorting(int[] vet)
        {
            int n = vet.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = vet[i];
                    int j;
                    for (j = i; j >= gap && vet[j - gap] > temp; j -= gap)
                    {
                        vet[j] = vet[j - gap];
                    }
                    vet[j] = temp;
                }
            }

            return vet;
        }
    }
}
