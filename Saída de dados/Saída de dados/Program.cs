using System;

namespace Saída_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {


            double x = 16.8965475;
            Console.Write("Seu número decimal é: ");
            Console.WriteLine(x);
            Console.WriteLine("Arredondamento para duas casas decimais: " + x.ToString("F2"));
            Console.WriteLine("Arredondamento para três casas decimais: " + x.ToString("F3"));
            Console.WriteLine("Arredondamento para quatro casas decimais: " + x.ToString("F4") + " Obrigado por rodar esse pgrm!" );


        }
    }
}
