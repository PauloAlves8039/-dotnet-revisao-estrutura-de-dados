using EstruturaDeDados.Pilha01.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Estrutura de Dados Pilha **********");

        Pilha<int> pilha = new Pilha<int>(5);

        pilha.Empilhar(10);
        pilha.Empilhar(20);
        pilha.Empilhar(30);

        Console.WriteLine($"Elemento no topo: {pilha.Topo()}");

        Console.WriteLine($"Desempilhando: {pilha.Desempilhar()}");
        Console.WriteLine($"Desempilhando: {pilha.Desempilhar()}");

        Console.WriteLine($"Elemento no topo: {pilha.Topo()}");

        pilha.Empilhar(40);
        Console.WriteLine($"Elemento no topo: {pilha.Topo()}");

        while (!pilha.EstaVazia())
        {
            Console.WriteLine($"Desempilhando: {pilha.Desempilhar()}");
        }

        Console.WriteLine("\n-------- Resultado --------");

        Console.WriteLine($"Pilha está vazia: {pilha.EstaVazia()}");

        Console.ReadKey();
    }
}