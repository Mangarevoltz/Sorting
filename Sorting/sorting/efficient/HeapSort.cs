namespace Sorting.sorting.efficient
{
    class HeapSort
    {
        public static int[] Sorting(int[] vet)
        {
            int n = vet.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(vet, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                int temp = vet[0];
                vet[0] = vet[i];
                vet[i] = temp;

                Heapify(vet, i, 0);
            }

            return vet;
        }

        private static void Heapify(int[] vet, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && vet[left] > vet[largest])
                largest = left;

            if (right < n && vet[right] > vet[largest])
                largest = right;

            if (largest != i)
            {
                int swap = vet[i];
                vet[i] = vet[largest];
                vet[largest] = swap;

                Heapify(vet, n, largest);
            }
        }
    }
}
