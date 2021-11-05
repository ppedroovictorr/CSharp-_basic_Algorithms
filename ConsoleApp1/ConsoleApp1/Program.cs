using System;
using System.Globalization;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("DIgite um caracter: ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Digite um número decimal: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: " + n1);
            Console.WriteLine("Você digitou a letra: " + "'" + ch + "'");
            Console.WriteLine("Você digitou o número: " + n2.ToString("F2", CultureInfo.InvariantCulture) + ". Só foi apresentado duas casas decimais."); ;
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));





        }
    }
}
