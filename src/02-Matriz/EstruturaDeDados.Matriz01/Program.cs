using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Exibir Operações em uma Matriz 5x3 **********");

        int linhas = 5;
        int colunas = 3;
        int[,] matriz = new int[linhas, colunas];

        for (int i = 0; i < 5; i++) 
        {
            Console.Write($"Digite o valor para a posição [{i}, 0]: ");
            matriz[i, 0] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n---------- Resultado ----------");
        SomandoValoresDosElementos(matriz);
        DuplicandoValoresDosElementos(matriz);
        Utilitario.ImprimirMatriz(matriz, linhas, colunas);

        Console.ReadKey();
    }

    private static void SomandoValoresDosElementos(int[,] matriz) 
    {
        for (int i = 0; i < 5; i++) 
        {
            matriz[i, 1] = matriz[i, 0] + 10;
        }
    }

    private static void DuplicandoValoresDosElementos(int[,] matriz) 
    {
        for (int i = 0; i < 5; i++) 
        {
            matriz[i, 2] = matriz[i, 0] * 2;
        }
    }
}