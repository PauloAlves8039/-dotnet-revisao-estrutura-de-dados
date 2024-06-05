using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Array(vetor) - Exibir números pares e ímpares **********");

        int tamanhoDoArray = 10;
        int[] array = new int[tamanhoDoArray];
        int numerosPares = 0;
        int numerosImpares = 0;

        Console.WriteLine();

        Utilitario.LerArray(array, tamanhoDoArray);
        ContarParesEImpares(array, ref numerosPares, ref numerosImpares);

        Console.WriteLine("\n-------- Elementos do Array --------");
        Utilitario.ImprimirArray(array);

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine($"Quantidade de números pares: {numerosPares}");
        Console.WriteLine($"Quantidade de números ímpares: {numerosImpares}");

        Console.ReadKey();
    }

    private static void ContarParesEImpares(int[] array, ref int pares, ref int impares)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }
    }
}