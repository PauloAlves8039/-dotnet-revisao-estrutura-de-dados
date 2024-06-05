using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Algoritmo de Ordenação Insertion Sort **********");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        Utilitario.LerArray(array, tamanhoDoArray);

        Console.WriteLine("\n-------- Array original --------");
        Utilitario.ImprimirArray(array);

        ExecutarInsertionSort(array);

        Console.WriteLine("\n-------- Array ordenado --------");
        Utilitario.ImprimirArray(array);

        Console.ReadKey();
    }

    private static void ExecutarInsertionSort(int[] array)
    {
        int numero = array.Length;

        for (int i = 1; i < numero; i++)
        {
            int chave = array[i];
            int j;

            for (j = i - 1; j >= 0 && array[j] > chave; j--)
            {
                array[j + 1] = array[j];
            }

            array[j + 1] = chave;
        }
    }
}