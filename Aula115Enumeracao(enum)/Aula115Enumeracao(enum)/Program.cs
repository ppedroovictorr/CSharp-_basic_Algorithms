using Aula115Enumeracao_enum_.Entities;
using Aula115Enumeracao_enum_.Entities.Enums;
using System;


namespace Aula115Enumeracao_enum_
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);


            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");


             
            Console.WriteLine(os);
            Console.WriteLine(txt);
           



        }
    }
}
