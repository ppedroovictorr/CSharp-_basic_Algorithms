using System.Collections.Generic;

// criar um objeto "Lista" pré-definida com as propriedades do caracter
namespace BuracoNasLetrasChallenge {
    public static class ListaDeCaracteres {
        //Array para definir caracteres com um buraco
        public static List<string> UmBuraco = new List<string> {
            "Q", "q", "R", "e", "O", "o", "P", "p", "a", "A", "d", "D", "b", "4", "6", "9"
        };


        //Array para definir caracteres com dois buracos
        public static List<string> DoisBuracos = new List<string> {
            "B", "8", "g", "0"                                   // zero foi considerado com dois buracos pela forma que é exibida nesta IDE
        };
       
    }
}
