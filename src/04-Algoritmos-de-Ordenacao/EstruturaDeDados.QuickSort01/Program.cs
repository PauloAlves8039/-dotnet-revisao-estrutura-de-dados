using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Algoritmo de Ordenação Quick Sort **********");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        Utilitario.LerArray(array, tamanhoDoArray);

        Console.WriteLine("\n-------- Array original --------");
        Utilitario.ImprimirArrayCompleto(array);

        OrdenarArray(array, 0, tamanhoDoArray - 1);

        Console.WriteLine("\n-------- Array ordenado --------");
        Utilitario.ImprimirArrayCompleto(array);

        Console.ReadKey();
    }

    private static void OrdenarArray(int[] array, int baixo, int alto) 
    {
        if (baixo < alto) 
        {
            int indice = ParticionarUltimoElemento(array, baixo, alto);
            OrdenarArray(array, baixo, indice - 1);
            OrdenarArray(array, indice + 1, alto);
        }
    }

    private static int ParticionarUltimoElemento(int[] array, int baixo, int alto) 
    {
        int pivo = array[alto];
        int i = baixo - 1;

        for (int j = baixo; j < alto; j++) 
        {
            if (array[j] <= pivo) 
            {
                i++;
                SubstituirElemento(array, i, j);
            }
        }

        SubstituirElemento(array, i + 1, alto);

        return i + 1;
    }

    private static void SubstituirElemento(int[] array, int i, int j) 
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}