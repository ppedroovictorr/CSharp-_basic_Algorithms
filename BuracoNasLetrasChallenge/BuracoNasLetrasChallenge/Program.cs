using System;

namespace BuracoNasLetrasChallenge {
    class Program {
        public static void Main(string[] args) {

            string texto;

            Console.WriteLine("Entre com um texto: ");
            texto = Console.ReadLine();
            Console.WriteLine();

            var totalBuracos = 0;
            var totalLetras = 0;
            foreach (var t in texto) {
                totalBuracos += ContadorDeBuracos(t);
                totalLetras++;
            }

            var totalPalavras = ContadorDePalavras(texto);

            Console.WriteLine($"Texto inserido: {texto}");
            Console.WriteLine($"Tamanho do texto: {totalLetras}");
            Console.WriteLine($"Total de palavras: {totalPalavras}");
            Console.WriteLine($"Total de buracos no texto: {totalBuracos}");





        }

        private static int ContadorDePalavras(string text) {
            // Separa todos os " " criando um vetor onde cada posição armazena uma palavra
            var listaDePalavras = text.Split(" ");
            // Retorna tamanho do vetor (como cada posição tem uma palavra, o tamanho do vetor é igual a quantidade de palavras)
            return listaDePalavras.Length;
        }

        private static int ContadorDeBuracos(char caracteres) {
            // Passa variável para string pra viabilizar comparação com CharacterConfig 
            var ConfigCaracter = caracteres.ToString();
            var quantidadeDeBuracos = 0;
            foreach (var c in ListaDeCaracteres.UmBuraco) {
                // Verifica se o caracter está presente na lista de caracteres com um buraco
                if (c.Equals(ConfigCaracter)) {
                    quantidadeDeBuracos = 1;
                }
            }
            foreach (var c in ListaDeCaracteres.DoisBuracos) {
                // Verifica se o caracter está presente na lista de caracteres com dois buracos
                if (c.Equals(ConfigCaracter)) {
                    quantidadeDeBuracos = 2;
                }
            }

            return quantidadeDeBuracos;
        }
    }

}



/*•	A solução deve ser escrita em C#;
•	A solução deve conter um projeto Console que receba um texto qualquer e imprima: 
o	Texto inserido;
o	Tamanho do texto;
o	Total de palavras;
o	Total de buracos no texto.
•	Considere que não haverá acentuação nas palavras;

Dicas
•	Orientação a objetos e testes são sempre bem-vindos;
•	Lembre-se de considerar letras maiúsculas, minúsculas e números;
•	Fique à vontade para deixar comentários no código sempre que achar necessário.
•	Você pode utilizar a Internet à vontade.

*/