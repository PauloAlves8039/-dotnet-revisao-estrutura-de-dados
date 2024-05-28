using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Maior Elemento no Array **********");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        Utilitario.LerArray(array, tamanhoDoArray);

        int maiorElementoDoArray = EncontrarMaiorElemento(array);

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine($"O maior elemento do array é: {maiorElementoDoArray}");

        Console.ReadKey();
    }

    private static int EncontrarMaiorElemento(int[] array) 
    {
        int maiorElemento = array[0];

        for (int i = 1; i < array.Length; i++) 
        {
            if (array[i] > maiorElemento) 
            {
                maiorElemento = array[i];
            }
        }

        return maiorElemento;
    }
}