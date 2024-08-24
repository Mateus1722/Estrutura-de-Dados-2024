//comentário de uma linha
/*
    Comentário de 
    Multiplas linhas
*/

//Declarando variáveis
using Aula01;

int number;
//Atribuindo valor
number = 10;

//Declarando constante
const int DAYS_IN_WEEK = 7;


//imprimindo String concatenada
Console.WriteLine($"A semana tem {DAYS_IN_WEEK} dias.");

//new TipoEnumerador() --> invoca o método construtor do objeto
//Toda classe ten o seu construtor padrão implicito sem argumentos/parâmetros
//é possível sobrescrever este método especificando argumentos
//Todavia, se o fizermos, perdemos o original implicito e precisaremos defini-lo explicitamente
TipoEnumerador tipoEnum = new TipoEnumerador();
TipoEnumerador.Language enumEnglish = tipoEnum.GetLanguageEnum("inglês");
Console.WriteLine($"O enum de english é {enumEnglish}");