using EstruturaDeDados.Fila01.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Estrutura de Dados Fila **********");

        Fila<int> fila = new Fila<int>(5);

        fila.Enfileirar(10);
        fila.Enfileirar(20);
        fila.Enfileirar(30);

        Console.WriteLine($"Elemento na frente: {fila.Frente()}");

        Console.WriteLine($"Desenfileirando: {fila.Desenfileirar()}");
        Console.WriteLine($"Desenfileirando: {fila.Desenfileirar()}");

        Console.WriteLine($"Elemento na frente: {fila.Frente()}");

        fila.Enfileirar(40);
        Console.WriteLine($"Elemento na frente: {fila.Frente()}");

        while (!fila.EstaVazia())
        {
            Console.WriteLine($"Desenfileirando: {fila.Desenfileirar()}");
        }

        Console.WriteLine("\n-------- Resultado --------");

        Console.WriteLine($"Fila está vazia: {fila.EstaVazia()}");

        Console.ReadKey();
    }
}