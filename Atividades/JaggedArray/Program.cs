//JegueArray é o array do Ceará
//JaggedArray é tambem conhecido como um vetor de vetores
using System.Formats.Asn1;

int[][] numbers = new int[5][];
//Neste caso [][] indica que é um vetor vetor, neste exmeplo um vetor de 4 posiçoes contendo um tam. indefinido
numbers[0] = new int[] {1, 2, 3};
numbers[1] = new int[] {4, 3, 2, 1, 0}; 
numbers[2] = new int[] {1, 2, 0};
numbers[3] = new int[] {57};
numbers[4] = null!;

//para obter valor de jeggedArray
int valor = numbers[0][2];
Console.WriteLine(valor);

//para atribuir valor em um jeggedArray
Console.WriteLine(numbers[1][2]);

