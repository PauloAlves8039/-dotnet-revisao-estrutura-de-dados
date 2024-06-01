using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Algoritmo de Ordenação Merge Sort **********");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        Utilitario.LerArray(array, tamanhoDoArray);

        Console.WriteLine("\n-------- Array original --------");
        Utilitario.ImprimirArrayCompleto(array);

        ExecutarMergeSort(array);

        Console.WriteLine("\n-------- Array ordenado --------");
        Utilitario.ImprimirArrayCompleto(array);

        Console.ReadKey();
    }

    private static void ExecutarMergeSort(int[] array) 
    {
        int esquerda = 0;
        int direita = array.Length - 1;
        OrdenarArray(array, esquerda, direita);
    }

    private static void OrdenarArray(int[] array, int esquerda, int direita) 
    {
        if (esquerda < direita) 
        {
            int meio = (esquerda + direita) / 2;
            OrdenarArray(array, esquerda, meio);
            OrdenarArray(array, meio + 1, direita);
            MesclarArrays(array, esquerda, meio, direita);
        }
    }

    private static void MesclarArrays(int[] array, int esquerda, int meio, int direita) 
    {
        int numero1 = meio - esquerda + 1;
        int numero2 = direita - meio;

        int[] arrayEsquerdo = new int[numero1];
        int[] arrayDireito = new int[numero2];

        for (int i = 0; i < numero1; i++) 
        {
            arrayEsquerdo[i] = array[esquerda + i];
        }

        for (int j = 0; j < numero2; j++)
        {
            arrayDireito[j] = array[meio + 1 + j];
        }

        int x = 0, y = 0;
        int k = esquerda;

        while (x < numero1 && y < numero2) 
        {
            if (arrayEsquerdo[x] <= arrayDireito[y])
            {
                array[k] = arrayEsquerdo[x];
                x++;
            }
            else 
            {
                array[k] = arrayDireito[y];
                y++;
            }

            k++;
        }

        while (x < numero1) 
        {
            array[k] = arrayEsquerdo[x];
            x++;
            k++;
        }

        while (y < numero2) 
        {
            array[k] = arrayDireito[y];
            y++;
            k++;
        }
    }
}