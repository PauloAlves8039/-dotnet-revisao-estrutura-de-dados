internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Estrutura de Dados Fila - Usando a classe Queue **********");

        Queue<int> fila = new Queue<int>();

        Enfileirar(fila, 10);
        Enfileirar(fila, 20);
        Enfileirar(fila, 30);

        VerificarFrente(fila);

        Console.WriteLine("Desenfileirando dois elementos:");
        Desenfileirar(fila);
        Desenfileirar(fila);

        VerificarFrente(fila);

        Enfileirar(fila, 40);
        VerificarFrente(fila);

        Console.WriteLine($"Fila está vazia: {VerificarFilaVazia(fila)}");

        Console.WriteLine("\n-------- Resultado --------");

        Console.WriteLine("Desenfileirando todos os elementos:");
        DesenfileirarTodos(fila);

        Console.WriteLine($"Fila está vazia após desenfileirar todos os elementos: {VerificarFilaVazia(fila)}");

        Console.ReadKey();
    }

    private static void VerificarFrente(Queue<int> fila) 
    {
        if (!VerificarFilaVazia(fila))
        {
            Console.WriteLine($"Elemento na frente: {fila.Peek()}");
        }
        else 
        {
            Console.WriteLine("A fila está vazia.");
        }
    }

    private static void Enfileirar(Queue<int> fila, int item)
    {
        fila.Enqueue(item);
        Console.WriteLine($"Enfileirando: {item}");
    }

    private static void DesenfileirarTodos(Queue<int> fila) 
    {
        while (!VerificarFilaVazia(fila)) 
        {
            Desenfileirar(fila);
        }
    }

    private static void Desenfileirar(Queue<int> fila) 
    {
        if (!VerificarFilaVazia(fila))
        {
            Console.WriteLine($"Desenfileirando: {fila.Dequeue()}");
        }
        else 
        {
            Console.WriteLine("A fila já está vazia.");
        }
    }

    private static bool VerificarFilaVazia(Queue<int> fila)
    {
        return fila.Count == 0;
    }
}