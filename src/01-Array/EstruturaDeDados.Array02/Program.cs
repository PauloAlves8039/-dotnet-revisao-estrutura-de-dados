using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Array(vetor) - Pesquisar Número no Array **********");

        Console.Write("\nDigite o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];

        Console.WriteLine();

        Utilitario.LerArray(array, tamanhoDoArray);

        Console.Write("\nDigite um número para verificar no array: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("\n---------- Resultado ----------");

        Console.WriteLine();

        bool resultadoDaPesquisa = PesquisarNumeroNoArray(array, numero);

        if (resultadoDaPesquisa)
        {
            Console.WriteLine($"O número {numero} foi encontrado no array!");
        }
        else
        {
            Console.WriteLine($"O número {numero} não existe no array!");
        }

        Console.ReadKey();
    }

    private static bool PesquisarNumeroNoArray(int[] array, int numero)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == numero)
            {
                return true;
            }
        }

        return false;
    }
}