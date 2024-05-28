namespace EstruturaDeDados.Utilitarios.Utils
{
    public static class Utilitario
    {
        public static void LerArray(int[] array, int tamanhoDoArray)
        {
            for (int i = 0; i < tamanhoDoArray; i++)
            {
                Console.Write($"Elemento [{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void ImprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    Console.Write($"{array[i]} ");
                }
            }

            Console.WriteLine();
        }

        public static int[,] LerMatriz(int linhas, int colunas)
        {
            int[,] matriz = new int[linhas, colunas];

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

        public static void ImprimirMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{matriz[i, j]} \t");
                }

                Console.WriteLine();
            }
        }

        public static void ImprimirMatriz(int[,] matriz, int linhas, int colunas)
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{matriz[i, j]} \t");
                }

                Console.WriteLine();
            }
        }
    }
}
