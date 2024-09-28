using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criando o dicionário para armazenar os produtos e suas localizações
        Dictionary<string, string> produtos = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("Digite o código de barras do produto (ou 'sair' para encerrar):");
            string codigo = Console.ReadLine();

            if (codigo.ToLower() == "sair")
            {
                break;
            }

            // Verificando se o produto existe no dicionário
            if (produtos.TryGetValue(codigo, out string localizacao))
            {
                Console.WriteLine($"O produto está na prateleira: {localizacao}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado. Deseja adicionar um novo produto? (s/n)");
                string resposta = Console.ReadLine();

                if (resposta.ToLower() == "s")
                {
                    Console.WriteLine("Digite o código do produto:");
                    string codigoNovo = Console.ReadLine();

                    Console.WriteLine("Digite a localização da prateleira:");
                    string localizacaoNova = Console.ReadLine();

                    // Adicionando o novo produto ao dicionário
                    produtos[codigoNovo] = localizacaoNova;
                    Console.WriteLine("Produto adicionado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Produto não adicionado.");
                }
            }
        }
    }
}
