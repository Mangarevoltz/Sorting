namespace Sorting.basic_class.dynamic
{
        public class ListaDuplamenteEncadeada
        {
            // Classe interna que representa um nó
            private class No
            {
                public int Valor;
                public No Anterior;
                public No Proximo;

                public No(int valor)
                {
                    Valor = valor;
                    Anterior = null;
                    Proximo = null;
                }
            }

            private No inicio;

            public ListaDuplamenteEncadeada()
            {
                inicio = null;
            }

            public void Inserir(int valor)
            {
                No novo = new No(valor);
                if (inicio == null)
                {
                    inicio = novo;
                }
                else
                {
                    No atual = inicio;
                    while (atual.Proximo != null)
                    {
                        atual = atual.Proximo;
                    }
                    atual.Proximo = novo;
                    novo.Anterior = atual;
                }
            }

            public void Mostrar()
            {
                No atual = inicio;
                while (atual != null)
                {
                    Console.Write($"{atual.Valor} ");
                    atual = atual.Proximo;
                }
                Console.WriteLine();
            }

            public void BubbleSort()
            {
                if (inicio == null) return;

                bool trocou;
                do
                {
                    trocou = false;
                    No atual = inicio;

                    while (atual.Proximo != null)
                    {
                        if (atual.Valor > atual.Proximo.Valor)
                        {
                            int temp = atual.Valor;
                            atual.Valor = atual.Proximo.Valor;
                            atual.Proximo.Valor = temp;
                            trocou = true;
                        }
                        atual = atual.Proximo;
                    }
                } while (trocou);
            }
        }
    }


