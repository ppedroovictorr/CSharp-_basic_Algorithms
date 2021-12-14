using System;
using System.Globalization;

namespace Aula89DateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = DateTime.Now;
            //agora outras formas de instanciar o DateTime
            DateTime d2 = new DateTime(2021, 12, 13); // começa a contagem a paprtir dessa definição (torna seu ponto de partida)
            DateTime d3 = new DateTime(2021, 12, 13, 15, 07, 10); // formatação padrao
            DateTime d4 = new DateTime(2021, 12, 13, 15, 07, 10, 500);
            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today; // é gerado na data de hoje às zero horas
            DateTime d7 = DateTime.UtcNow; // horario de agora no GNT
            DateTime d8 = DateTime.Parse("2000-08-15"); // c# converte automático em data, alguns banco de dados utilizam esse formato
            DateTime d9 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d10 = DateTime.Parse("15/08/2000");
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture); // vc formata, deve usar cultereinfo
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine("DAteTime.Now: "+d1);
            Console.WriteLine("DAteTime.Now 'ticks': " + d1.Ticks);
            Console.WriteLine("-----");
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine("-----");
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7 + "o GNT é + 3 horas a frente do Brasil");
            Console.WriteLine("-----");
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);



        }
    }
}
