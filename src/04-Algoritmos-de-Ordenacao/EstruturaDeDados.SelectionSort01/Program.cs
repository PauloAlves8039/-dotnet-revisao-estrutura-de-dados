using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Algoritmo de Ordenação Selection Sort **********");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        Utilitario.LerArray(array, tamanhoDoArray);

        ExecutarSelectionSort(array);

        Console.WriteLine("\n-------- Resultado --------");
        Utilitario.ImprimirArrayCompleto(array);

        Console.ReadKey();
    }
    private static void ExecutarSelectionSort(int[] array) 
    {
        int numero = array.Length;

        for (int i = 0; i < numero - 1; i++) 
        {
            int minIndex = i;

            for (int j = i + 1; j < numero; j++) 
            {
                if (array[j] < array[minIndex]) 
                {
                    minIndex = j;
                }
            }

            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }
}