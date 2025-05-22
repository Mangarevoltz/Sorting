namespace Sorting.basic_class.dynamic
{
    class Celula
    {
        public int valor;
        public Celula? prox;

        public Celula(int valor)
        {
            this.valor = valor;
            this.prox = null;
        }
    }

    class FilaDynamic
    {
        private Celula? primeiro;
        private Celula? ultimo;

        public FilaDynamic()
        {
            primeiro = ultimo = null;
        }

        public void Inserir(int item)
        {
            var nova = new Celula(item);
            if (ultimo == null)
            {
                primeiro = nova;
            }
            else
            {
                ultimo.prox = nova;
            }
            ultimo = nova;
        }

        public int Remover()
        {
            if (primeiro == null)
            {
                Console.WriteLine("Fila vazia.");
                return -1;
            }

            int valorRemovido = primeiro.valor;
            primeiro = primeiro.prox;

            if (primeiro == null) ultimo = null;

            return valorRemovido;
        }

        public void Mostrar()
        {
            Console.Write("Fila dinâmica: ");
            for (var atual = primeiro; atual != null; atual = atual.prox)
                Console.Write(atual.valor + " ");
            Console.WriteLine();
        }
    }
}
