using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Popular uma Matriz 5x5 **********");

        int linhas = 5;
        int colunas = 5;

        int[,] matriz = new int[linhas, colunas];

        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;
        int zeros = 0;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                int numero = int.Parse(Console.ReadLine());
                matriz[i, j] = numero;

                if (VerificarNumeroPar(numero))
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                if (numero > 0)
                {
                    positivos++;
                }
                else if (numero < 0)
                {
                    negativos++;
                }
                else
                {
                    zeros++;
                }
            }
        }

        Console.WriteLine("\n-------- Matriz 5x5 --------");

        Utilitario.ImprimirMatriz(matriz);

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine($"Números pares: {pares}");
        Console.WriteLine($"Números ímpares: {impares}");
        Console.WriteLine($"Números positivos: {positivos}");
        Console.WriteLine($"Números negativos: {negativos}");
        Console.WriteLine($"Zeros: {zeros}");

        Console.ReadKey();
    }

    private static bool VerificarNumeroPar(int numero)
    {
        return numero % 2 == 0;
    }
}