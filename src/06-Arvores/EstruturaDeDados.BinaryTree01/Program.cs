using EstruturaDeDados.BinaryTree01.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Estrutura de Dados BinaryTree(Árvore Binária) **********");

        ArvoreBinaria arvoreBinaria = new ArvoreBinaria(10);

        arvoreBinaria.Inserir(1);
        arvoreBinaria.Inserir(2);
        arvoreBinaria.Inserir(3);
        arvoreBinaria.Inserir(4);
        arvoreBinaria.Inserir(5);
        arvoreBinaria.Inserir(6);
        arvoreBinaria.Inserir(7);

        Console.WriteLine("\nPercurso Em Ordem: ");
        arvoreBinaria.ImprimirEmOrdem(0);
        Console.WriteLine();

        Console.WriteLine("\nPercurso Pré-Ordem: ");
        arvoreBinaria.ImprimirPreOrdem(0);
        Console.WriteLine();

        Console.WriteLine("\nPercurso Pós-Ordem: ");
        arvoreBinaria.ImprimirPosOrdem(0);
        Console.WriteLine();

        Console.ReadKey();
    }
}