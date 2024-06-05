using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Contador de Ocorrências **********");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        Utilitario.LerArray(array, tamanhoDoArray);

        Console.Write("Informe o elemento que deseja contar: ");
        int elemento = int.Parse(Console.ReadLine());

        int ocorrencias = ContadorDeOcorrencias(array, elemento);

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine($"O elemento {elemento} aparece {ocorrencias} vezes no array.");

        Console.ReadKey();
    }

    private static int ContadorDeOcorrencias(int[] array, int elemento)
    {
        int contador = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == elemento)
            {
                contador++;
            }
        }

        return contador;
    }
}