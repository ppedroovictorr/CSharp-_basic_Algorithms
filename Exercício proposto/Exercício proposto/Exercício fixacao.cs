using System;

namespace Exercício_proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine();
            Console.Write("Quantos quartos à na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço de um produto: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu último nome, idade e altura (na mesma linha).");
            string[] txt = Console.ReadLine().Split(' ');
            string unome = txt[0];
            int idade = int.Parse(txt[1]);
            double altura = double.Parse(txt[2]);

            Console.WriteLine("Seu útimo nome é: " + unome + " !");
            Console.WriteLine("Sua idade é: " + idade + " !");
            Console.WriteLine("Sua altura é: " + altura.ToString("F2") + " !");






            Console.WriteLine("Hello World!");
        }
    }
}
