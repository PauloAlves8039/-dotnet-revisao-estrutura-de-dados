internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Estrutura de Dados Pilha - Usando a classe Stack **********");

        Stack<int> pilha = new Stack<int>();

        Empilhar(pilha, 10);
        Empilhar(pilha, 20);
        Empilhar(pilha, 30);

        VerificarTopo(pilha);

        Console.WriteLine("Desempilhando dois elementos:");
        Desempilhar(pilha);
        Desempilhar(pilha);

        VerificarTopo(pilha);

        Empilhar(pilha, 40);
        VerificarTopo(pilha);

        Console.WriteLine($"Pilha está vazia: {VerificarPilhaVazia(pilha)}");

        Console.WriteLine("\n-------- Resultado --------");

        Console.WriteLine("Desempilhando todos os elementos:");
        DesempilharTodos(pilha);

        Console.WriteLine($"Pilha está vazia após desempilhar todos os elementos: {VerificarPilhaVazia(pilha)}");

        Console.ReadKey();
    }

    private static void VerificarTopo(Stack<int> pilha)
    {
        if (!VerificarPilhaVazia(pilha))
        {
            Console.WriteLine($"Elemento no topo: {pilha.Peek()}");
        }
        else
        {
            Console.WriteLine("A pilha está vazia.");
        }
    }

    private static bool VerificarPilhaVazia(Stack<int> pilha) 
    {
        return pilha.Count == 0;
    }

    private static void Empilhar(Stack<int> pilha, int item)
    {
        pilha.Push(item);
        Console.WriteLine($"Empilhando: {item}");
    }

    private static void Desempilhar(Stack<int> pilha)
    {
        if (!VerificarPilhaVazia(pilha))
        {
            Console.WriteLine($"Desempilhando: {pilha.Pop()}");
        }
        else
        {
            Console.WriteLine("A pilha já está vazia.");
        }
    }

    private static void DesempilharTodos(Stack<int> pilha)
    {
        while (!VerificarPilhaVazia(pilha))
        {
            Desempilhar(pilha);
        }
    }
}