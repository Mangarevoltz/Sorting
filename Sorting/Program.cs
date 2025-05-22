using Sorting.basic_class.@static;
using Sorting.enums;
using manager;
using print;
using reader;
using utils;
using Sorting.manager;
using Sorting.print;
using Sorting.reader;
using Sorting.utils;
using Sorting.basic_class.dynamic;
using Sorting.sorting.simple;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Selecione o arquivo de entrada:");
        Console.WriteLine("1 - 10-aleatorios.txt");
        Console.WriteLine("2 - 100-aleatorios.txt");
        Console.WriteLine("3 - 1000-aleatorios.txt");
        Console.WriteLine("4 - 10000-aleatorios.txt");
        Console.WriteLine("5 - 100000-aleatorios.txt");
        Console.WriteLine("6 - 1000000-aleatorios.txt");
        Console.WriteLine("7 - 1000000-ordenados.txt");

        string[] arquivos = {
            "inputs/10-aleatorios.txt",
            "inputs/100-aleatorios.txt",
            "inputs/1000-aleatorios.txt",
            "inputs/10000-aleatorios.txt",
            "inputs/100000-aleatorios.txt",
            "inputs/1000000-aleatorios.txt",
            "inputs/1000000-ordenados.txt"
        };

        int escolhaArquivo = int.Parse(Console.ReadLine());
        if (escolhaArquivo < 1 || escolhaArquivo > arquivos.Length)
        {
            Console.WriteLine("Arquivo inválido.");
            return;
        }

        string caminho = arquivos[escolhaArquivo - 1];
        int[] vet = ReaderFile.LerArquivo(caminho); // ← leitor já implementado

        Console.WriteLine("Escolha o algoritmo de ordenação:");
        Console.WriteLine("1 - BubbleSort");
        Console.WriteLine("2 - InsertionSort");
        Console.WriteLine("3 - SelectionSort");
        Console.WriteLine("4 - QuickSort");
        Console.WriteLine("5 - MergeSort");
        Console.WriteLine("6 - HeapSort");
        Console.WriteLine("7 - ShellSort");
        Console.WriteLine("8 - CountingSort");
        Console.WriteLine("9 - RadixSort");
        Console.WriteLine("10 - BucketSort");

        int escolhaAlg = int.Parse(Console.ReadLine());
        Sortings algoritmo;

        if (!Enum.IsDefined(typeof(Sortings), escolhaAlg - 1))
        {
            Console.WriteLine("Algoritmo inválido.");
            return;
        }

        algoritmo = (Sortings)(escolhaAlg - 1);

        // Imprime antes da ordenação (opcional para vetores pequenos)
        if (vet.Length <= 100) // evita travar terminal com vetores grandes
        {
            Console.WriteLine("Vetor original:");
            PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, algoritmo);
        }

        ListaDuplamenteEncadeada lista = new ListaDuplamenteEncadeada();

        lista.Inserir(5);
        lista.Inserir(3);
        lista.Inserir(8);
        lista.Inserir(1);

        Console.WriteLine("Lista antes da ordenação:");
        lista.Mostrar();

        lista.BubbleSort();

        Console.WriteLine("Lista após a ordenação:");
        lista.Mostrar();

        // Ordenação com contagem de tempo
        UtilCountingTime.IniciarContagem();
        ManagerFileSorting.Ordenar(algoritmo, vet);
        UtilCountingTime.FinalizarContagem();

        // Imprime depois
        if (vet.Length <= 100)
        {
            Console.WriteLine("Vetor ordenado:");
            PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, algoritmo);
        }

        // Mostra tempo e operações
        UtilCountingTime.ImprimirContagem();

        // QUESTÃO 9 - LISTA ESTÁTICA + ORDENAÇÃO------------------------------------------
        Console.WriteLine("Testando Lista Estática com 1000000 elementos:");

        int[] dados = ReaderFile.LerArquivo("inputs/1000000-aleatorios.txt");

        Lista lista = new Lista(dados.Length);

        foreach (var v in dados)
            lista.InserirFim(v);

        // Clona os dados da lista
        int[] clone = UtilClonar.Clonar(lista.lista);

        // Ordena com BubbleSort e mede tempo/operações
        UtilCountingTime.IniciarContagem();
        BubbleSort.Sorting(clone);
        UtilCountingTime.FinalizarContagem();

        Console.WriteLine("Resultado da ordenação com BubbleSort:");
        UtilCountingTime.ImprimirContagem();

        var filaDinamica = new FilaDynamic();

        filaDinamica.Inserir(10);
        filaDinamica.Inserir(20);
        filaDinamica.Inserir(30);

        filaDinamica.Mostrar(); // Deve mostrar: 10 20 30

        filaDinamica.Remover();
        filaDinamica.Mostrar(); // Deve mostrar: 20 30


        // QUESTÃO 7 - FILA E PILHA ESTÁTICA-------------------------------------------
        Console.WriteLine("Testando Fila e Pilha Estática com 100 elementos:");
        int[] pequenosDados = ReaderFile.LerArquivo("inputs/100-aleatorios.txt");

        // Fila
        Fila fila = new Fila(pequenosDados.Length);
        foreach (var v in pequenosDados)
            fila.Inserir(v);
        fila.Remover(); fila.Remover(); fila.Remover(); // remove 3
        fila.Mostrar();

        // Pilha
        Pilha pilha = new Pilha(pequenosDados.Length);
        foreach (var v in pequenosDados)
            pilha.Inserir(v);
        pilha.Remover(); pilha.Remover(); pilha.Remover();
        pilha.Mostrar();
    }
}
