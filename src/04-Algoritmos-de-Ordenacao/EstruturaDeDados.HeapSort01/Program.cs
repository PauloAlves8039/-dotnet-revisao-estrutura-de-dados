using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Algoritmo de Ordenação Heap Sort **********");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        Utilitario.LerArray(array, tamanhoDoArray);

        OrdenarArray(array);

        Console.WriteLine("\n-------- Array ordenado --------");
        Utilitario.ImprimirArray(array);

        Console.ReadKey();
    }

    private static void OrdenarArray(int[] array)
    {
        int numero = array.Length;

        for (int i = numero / 2 - 1; i >= 0; i--)
        {
            ExecutarHeapSort(array, numero, i);
        }

        for (int i = numero - 1; i > 0; i--)
        {
            int temp = array[0];
            array[0] = array[i];
            array[i] = temp;

            ExecutarHeapSort(array, i, 0);
        }
    }

    private static void ExecutarHeapSort(int[] array, int numero, int indice)
    {
        int maior = indice;
        int esquerda = 2 * indice + 1;
        int direita = 2 * indice + 2;

        if (esquerda < numero && array[esquerda] > array[maior])
        {
            maior = esquerda;
        }

        if (direita < numero && array[direita] > array[maior])
        {
            maior = direita;
        }

        if (maior != indice)
        {
            int troca = array[indice];
            array[indice] = array[maior];
            array[maior] = troca;

            ExecutarHeapSort(array, numero, maior);
        }
    }
}