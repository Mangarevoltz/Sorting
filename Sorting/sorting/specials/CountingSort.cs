namespace Sorting.sorting.specials
{
    class CountingSort
    {
        public static int[] Sorting(int[] vet)
        {
            int max = vet[0];
            int min = vet[0];
            foreach (int num in vet)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            int range = max - min + 1;
            int[] count = new int[range];
            int[] output = new int[vet.Length];

            for (int i = 0; i < vet.Length; i++)
                count[vet[i] - min]++;

            for (int i = 1; i < range; i++)
                count[i] += count[i - 1];

            for (int i = vet.Length - 1; i >= 0; i--)
            {
                output[count[vet[i] - min] - 1] = vet[i];
                count[vet[i] - min]--;
            }

            return output;
        }
    }
}
