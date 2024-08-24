using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;//utilização para multi tarefas

namespace Aula01 //índice da onde está incluso
//NUNCA começa com números, mas pode ser ALFA NUMÉRICOS
{ //definição do escopo do programa... inicio
    public class TipoEnumerador //classe
    {
        public enum Language //acrecentou atributos a classe
        {
            PTBR, EN, RU
        }

        public Language _language = Language.PTBR; //_snake_case aplicado como privado da classe publica... o "=" funciona como comparação Booleano (true or false)
                                                    //Language.PTBR o "." funciona como atribuição

        public TipoEnumerador()
        {
    
        }
        /*
        public TipoEnumerador(TipoEnumerador enum)
        {
            _language = enum;
        }
        */
        public Language GetLanguageEnum(string lang) // () pode ser tratado como uma função... podendo conter ou não argumentos
        {
            switch (lang.ToLower()) //".ToLower" pega o parâmetro e mantém as letras em minusculo para evitar os erros
            {
                case "português" :
                    return Language.PTBR;
                case "inglês" :
                    return Language.EN;
                case "russo" :
                    return Language.RU;
                default :
                    return Language.PTBR;
            }
        }
    }
} //... fim