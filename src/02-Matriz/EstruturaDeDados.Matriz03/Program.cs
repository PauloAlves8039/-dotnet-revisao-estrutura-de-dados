using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Transpor uma Matriz 3x4 para 4x3 **********");

        int linhas = 3;
        int colunas = 4;

        int[,] matriz3x4 = Utilitario.LerMatriz(linhas, colunas);
        int[,] matriz4x3 = TransporMatriz(matriz3x4);

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine("Matriz 4x3 transposta:");
        Utilitario.ImprimirMatriz(matriz4x3);

        Console.ReadKey();
    }

    private static int[,] TransporMatriz(int[,] matriz) 
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int[,] matrizTransposta = new int[colunas, linhas];

        for (int i = 0; i < linhas; i++) 
        {
            for (int j = 0; j < colunas; j++) 
            {
                matrizTransposta[j, i] = matriz[i, j];
            }
        }

        return matrizTransposta;
    }
}