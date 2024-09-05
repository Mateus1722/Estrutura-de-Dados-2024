using System.Collections;

//Utilizando a Lista Simples
ArrayList arrList = new();
arrList.Add(5);
arrList.Add("Mateus");
//É possivel adcionar um conjunto de valores de uma so vez
arrList.AddRange(new int[] {1,2,3});
//O metodo .Add() insere o valor ao final do vetor 
arrList.Insert(1, 15);
//Ja o metodo Insert, me permite incluir o valor desejada na posição especificada do primeiro parâmetro; 

//Lendo valores da lista
Object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

//Percorrendo a lista com foreach
foreach(object obj in arrList)
{
    Console.Write($" | {obj}");
}

//obtendo o tamanho total da lista 
int tamanho = arrList.Count;
//obter a capacidade 
//Quantos elementos tem 
int capacidade = arrList.Count;
//obter a capacidade 
//quantos podem ser armazenados
int capacidade = arrList.Capacity;

//percorrendo no modo classico
for(int i = 0; i < arrList.Count; i++)
{
    Console.Write($" | {arrList[i]}" );
}

//Recursos importantes da lista
//Verificar se um valor é contido na lista
bool contemNome = arrList.Contains("Mateus");
if(!contemNome)

     Console.WriteLine("Nome Mateus não encontrado");   


//Para saber o indice que contem o valor buscado 
//Neste caso se o valor existir na lista ele retona o indice (numeor inteiro) caso o valor não exista na lsita retorna -1
int indiceDoValor = arrList.IndexOf("Mateus");
if(indiceDoValor >= 0)
    Console.WriteLine($"Mateus esta em [{indiceDoValor}]");
else
   Console.WriteLine("É, realmente não tem.");

//É possivel tambem remover  itens da lista
arrList.Remove("Mateus");//Remove pelo valor
arrList.RemoveAt(4);//Remove no indice
arrList.RemoveRange(0,20);//O primeiro parametro é o indice e o segundo é quantas casas apos o indice 

