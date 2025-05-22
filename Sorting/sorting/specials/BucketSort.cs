using System.Collections.Generic;
namespace Sorting.sorting.specials
{
    class BucketSort
    {
        public static int[] Sorting(int[] vet)
        {
            int n = vet.Length;
            if (n <= 0) return vet;

            int max = vet[0], min = vet[0];
            foreach (int num in vet)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            int bucketCount = 10;
            List<int>[] buckets = new List<int>[bucketCount];
            for (int i = 0; i < bucketCount; i++)
                buckets[i] = new List<int>();

            foreach (int num in vet)
            {
                int index = (num - min) * (bucketCount - 1) / (max - min + 1);
                buckets[index].Add(num);
            }

            int k = 0;
            foreach (var bucket in buckets)
            {
                bucket.Sort();
                foreach (int num in bucket)
                    vet[k++] = num;
            }

            return vet;
        }
    }
}
