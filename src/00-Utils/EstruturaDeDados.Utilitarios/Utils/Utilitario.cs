namespace EstruturaDeDados.Utilitarios.Utils
{
    public static class Utilitario
    {
        public static void LerArray(int[] vetor, int tamanhoDoVetor)
        {
            for (int i = 0; i < tamanhoDoVetor; i++)
            {
                Console.WriteLine($"Elemento [{i}] = ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void ImprimirArray(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != 0)
                {
                    Console.Write($"{vetor[i]}");
                }
            }

            Console.WriteLine();
        }

        public static int[,] LerMatriz(int linhas, int colunas)
        {
            var matriz = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Informe o valor para a posição ({i + 1}, {j + 1}): ");

                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        matriz[i, j] = valor;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Tente novamente.");
                        j--;
                    }
                }
            }

            return matriz;
        }

        public static void ImprimirMatriz(int[,] matriz, int linhas, int colunas)
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.WriteLine($"{matriz[i, j]} \t");
                }

                Console.WriteLine();
            }
        }
    }
}
