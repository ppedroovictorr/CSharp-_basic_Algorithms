using System;
using System.Globalization

namespace curso 
{
    class Program
    {
        static void Main(string[] args)
        {

            double largura, comprimento, valor;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double PrecoMetroQuadrado = area * valor;

            Console.WriteLine("Área do terreno: " + area.ToString("F2"), CultureInfo.InvariantCulture + " m²");
            Console.WriteLine("Valor do terreno: " + PrecoMetroQuadrado.ToString("F2"), CultureInfo.InvariantCulture + " reais.");







        }
    }
}
