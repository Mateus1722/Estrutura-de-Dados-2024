using System;
using System.Collections.Generic;

class SistemaDeSenhas
{
    private Stack<int> filaDeSenhas = new Stack<int>(); // Nossa fila de senhas
    private int proximaSenha = 100; // Número da próxima senha

    public void NovaSenha()
    {
        filaDeSenhas.Push(proximaSenha); // Adiciona uma nova senha na fila
        Console.WriteLine($"Sua senha é: {proximaSenha}");
        proximaSenha+=100; // Prepara a próxima senha
    }

    public void AtenderProximo()
    {
        if (filaDeSenhas.Count == 0)
        {
            Console.WriteLine("Não há mais ninguém na fila.");
        }
        else
        {
            Console.WriteLine($"Próximo: {filaDeSenhas.Pop()}");
        }
    }

    static void Main()
    {
        SistemaDeSenhas sistema = new SistemaDeSenhas();

        // Simulando 5 pessoas chegando e sendo atendidas
        for (int i = 0; i < 10; i++)
        {
            sistema.NovaSenha();
            sistema.AtenderProximo();
        }
    }
}