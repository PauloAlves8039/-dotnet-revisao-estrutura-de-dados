using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Algoritmo de Ordenação Shell Sort **********");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        Utilitario.LerArray(array, tamanhoDoArray);

        Console.WriteLine("\n-------- Array original --------");
        Utilitario.ImprimirArrayCompleto(array);

        ExecutarShellSort(array);

        Console.WriteLine("\n-------- Array original --------");
        Utilitario.ImprimirArrayCompleto(array);

        Console.ReadKey();
    }

    private static void ExecutarShellSort(int[] array) 
    {
        int numero = array.Length;

        for (int intervalo = numero / 2; intervalo > 0; intervalo /= 2) 
        {
            for (int i = intervalo; i < numero; i += 1) 
            {
                int temp = array[i];

                int j;

                for (j = i; j >= intervalo && array[j - intervalo] > temp; j -= intervalo) 
                {
                    array[j] = array[j - intervalo];
                }

                array[j] = temp;
            }
        }
    }
}