using System;

class Program
{
    static void Main()
    {
        // Definindo os vetores para armazenar os números
        int[] pares = new int[100];
        int[] impares = new int[100];

        // Preenchendo os vetores
        for (int i = 0; i < 100; i++)
        {
            pares[i] = i * 2;      // Números pares
            impares[i] = i * 2 + 1; // Números ímpares
        }

        // Imprimindo os números pares
        Console.WriteLine("Números Pares:");
        foreach (int num in pares)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Imprimindo os números ímpares
        Console.WriteLine("Números Ímpares:");
        foreach (int num in impares)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
