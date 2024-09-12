using System;
using System.Collections.Generic;

namespace PalindromoComPilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine().ToLower(); // Convertemos para minúsculas para ignorar maiúsculas e minúsculas

            // Criamos uma pilha de caracteres
            Stack<char> pilha = new Stack<char>();

            // Empilhamos cada caractere da palavra
            foreach (char caractere in palavra)
            {
                pilha.Push(caractere); // Adiciona um caractere ao topo da pilha
            }

            // Comparamos cada caractere da palavra com o topo da pilha
            bool ehPalindromo = true;
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] != pilha.Pop()) // Remove e retorna o elemento do topo da pilha
                {
                    ehPalindromo = false;
                    break;
                }
            }

            if (ehPalindromo)
            {
                Console.WriteLine("A palavra é um palíndromo!");
            }
            else
            {
                Console.WriteLine("A palavra não é um palíndromo.");
            }
        }
    }
}