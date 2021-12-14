using System;

namespace Aula90TimeSpan {  // TimeSpan é muito utilizado para calcular multa e juros
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = new TimeSpan(0, 1, 30);           // hora, minuto, segungo
            TimeSpan t2 = new TimeSpan();                   // padrão ticks (0)
            TimeSpan t3 = new TimeSpan(900000000L);         //ticks, coloca L para indicar long no fnial do numero
            TimeSpan t4 = new TimeSpan(1, 2, 12, 49);           // dia, hora, minuto, segundo
            TimeSpan t5 = new TimeSpan(2, 2, 11, 21, 321);      // dia, hora, minuto, segundo, milisegundo

            TimeSpan t6 = TimeSpan.FromDays(1.5);       // instanciar por meio de FROM (permite conversar na unidade que quiser até mesmo com número fracionado
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);


            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);

        }
    }
}
