using System;

namespace Aula88FuncoesParaString {
    class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG ";

            string s1 = original.ToUpper();                 // deixa todo o texto maiúsculo
            string s2 = original.ToLower();                 // deixa todo texto minúsculo
            string s3 = original.Trim();                    // corta todos os espaços em branco no inicio e no fim da string"texto"
            int n1 = original.IndexOf("bc");                // mostra a primeira posição do valor procurado na string (contagem a partir do 0'zerro'
            int n2 = original.LastIndexOf("bc");            // mostra a útima posição do valor procurado na string (contagem a partir do 0'zerro'
            string s4 = original.Substring(3);              // corta a string a partir do indice pedido (contagem a partir de 0'zero') - primeira sobrecarga
            string s5 = original.Substring(3, 5);           // corta a string a partir do indice pedido com um tamanho definido (contagem a partir de 0'zero') - segunda sobrecarga
            string s6 = original.Replace('a', 'x');         // primeira sobrecarga = substitui todo caracter definido pelo outro desejado string.Replace('caracter escolhido', 'caracter desejado para troca')
            string s7 = original.Replace("abc", "xy");      // segunda sobrecarga = substitui todo caracter definido pelo outro desejado string.Replace('string escolhido', 'string desejado para troca')

            bool b1 = string.IsNullOrEmpty(original);       // testa se o conteúdo de uma string é nulo ou vazio
            bool b2 = string.IsNullOrWhiteSpace(original);  // testa se a variável é nula, um ou vários espaçoes em branco


            
            Console.WriteLine("Original: -" + original+"-");
            Console.WriteLine("ToUpper: -" + s1+"-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4+"-");
            Console.WriteLine("Substring(3,5): -" + s5+"-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);


        }
    }
}
