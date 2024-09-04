int[,] number = new int[5,2];

int[,] iniNumbers = new int[,] 
{ 
    {9,15,-9},
    {19,25,-90},
    {29,35,-91},
    {39,45,-92},
    {49,55,-93},
};

// Inicializar variáveis para armazenar o maior número e sua posição
int maiorNumero = int.MinValue; // Inicializa com o menor valor possível para um inteiro
int linhaMaior = 0;
int colunaMaior = 0;

// Iterar sobre todos os elementos da matriz
for (int i = 0; i < iniNumbers.GetLength(0); i++)
{
    for (int j = 0; j < iniNumbers.GetLength(1); j++)
    {
        if (iniNumbers[i, j] > maiorNumero)
        {
            maiorNumero = iniNumbers[i, j];
            linhaMaior = i;
            colunaMaior = j;
        }
    }
}

Console.WriteLine($"O maior número é {maiorNumero} e está na posição ({linhaMaior}, {colunaMaior}).");

