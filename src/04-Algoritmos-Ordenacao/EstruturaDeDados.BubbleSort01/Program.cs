﻿using EstruturaDeDados.Utilitarios.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Algoritmo de Ordenação Bubble Sort **********");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        Utilitario.LerArray(array, tamanhoDoArray);

        ExecutarBubbleSort(array);

        Console.WriteLine("\n-------- Resultado --------");
        Utilitario.ImprimirArray(array);

        Console.ReadKey();
    }

    private static void ExecutarBubbleSort(int[] array)
    {
        int numero = array.Length;
        bool trocado;

        for (int i = 0; i < numero - 1; i++)
        {
            trocado = false;

            for (int j = 0; j < numero - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    trocado = true;
                }
            }

            if (!trocado)
            {
                break;
            }
        }
    }
}