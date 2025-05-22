namespace Sorting.sorting.specials
{
    class RadixSort
    {
        public static int[] Sorting(int[] vet)
        {
            int max = vet[0];
            foreach (int num in vet)
                if (num > max) max = num;

            for (int exp = 1; max / exp > 0; exp *= 10)
                CountingSortByDigit(vet, exp);

            return vet;
        }

        private static void CountingSortByDigit(int[] vet, int exp)
        {
            int n = vet.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
                count[(vet[i] / exp) % 10]++;

            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                int index = (vet[i] / exp) % 10;
                output[count[index] - 1] = vet[i];
                count[index]--;
            }

            for (int i = 0; i < n; i++)
                vet[i] = output[i];
        }
    }
}
