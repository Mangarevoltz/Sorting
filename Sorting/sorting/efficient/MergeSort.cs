namespace Sorting.sorting.efficient
{
    class MergeSort
    {
        public static int[] Sorting(int[] vet)
        {
            if (vet.Length <= 1)
                return vet;

            int meio = vet.Length / 2;
            int[] esquerda = Sorting(vet[..meio]);
            int[] direita = Sorting(vet[meio..]);

            return Merge(esquerda, direita);
        }

        private static int[] Merge(int[] esq, int[] dir)
        {
            int[] resultado = new int[esq.Length + dir.Length];
            int i = 0, j = 0, k = 0;

            while (i < esq.Length && j < dir.Length)
            {
                if (esq[i] < dir[j])
                    resultado[k++] = esq[i++];
                else
                    resultado[k++] = dir[j++];
            }

            while (i < esq.Length)
                resultado[k++] = esq[i++];
            while (j < dir.Length)
                resultado[k++] = dir[j++];

            return resultado;
        }
    }
}
