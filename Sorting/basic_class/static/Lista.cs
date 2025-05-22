namespace Sorting.basic_class.@static
{
    class Lista
    {
        public int[] lista;
        public int cont;

        public Lista(int n)
        {
            lista = new int[n];
            cont = 0;
        }

        public bool InserirFim(int item)
        {
            if (cont < lista.Length)
            {
                lista[cont++] = item;
                return true;
            }
            Console.WriteLine("Lista cheia");
            return false;
        }

        public bool InserirInicio(int item)
        {
            if (cont >= lista.Length) return false;
            for (int i = cont; i > 0; i--)
                lista[i] = lista[i - 1];
            lista[0] = item;
            cont++;
            return true;
        }

        public bool InserirPosicao(int pos, int item)
        {
            if (cont >= lista.Length || pos < 0 || pos > cont) return false;
            for (int i = cont; i > pos; i--)
                lista[i] = lista[i - 1];
            lista[pos] = item;
            cont++;
            return true;
        }

        public int RemoverFim()
        {
            if (cont == 0) return -1;
            return lista[--cont];
        }

        public int RemoverInicio()
        {
            if (cont == 0) return -1;
            int tmp = lista[0];
            for (int i = 0; i < cont - 1; i++)
                lista[i] = lista[i + 1];
            cont--;
            return tmp;
        }

        public int RemoverPosicao(int pos)
        {
            if (cont == 0 || pos < 0 || pos >= cont) return -1;
            int tmp = lista[pos];
            for (int i = pos; i < cont - 1; i++)
                lista[i] = lista[i + 1];
            cont--;
            return tmp;
        }
    }
}
