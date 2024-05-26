using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Verificar Ordenação de Array **********");

        Console.Write("Informe o tamano do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        Utilitario.LerArray(array, tamanhoDoArray);

        bool ordenacaoDeArray = VerificarOrdenacaoDeArray(array);

        Console.WriteLine("\n-------- Resultado --------");

        if (ordenacaoDeArray)
        {
            Console.WriteLine("O array está ordenado de forma crescente.");
        }
        else 
        {
            Console.WriteLine("O array NÃO está ordenado de forma crescente.");
        }

        Console.ReadKey();
    }

    private static bool VerificarOrdenacaoDeArray(int[] array) 
    {
        for (int i = 1; i < array.Length; i++) 
        {
            if (array[i] < array[i - 1]) 
            {
                return false;
            }
        }

        return true;
    }
}