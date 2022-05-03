using System;

namespace CAExceptionRealWorldExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Delivery delivery = new Delivery
            {
                Id = 1,
                CustomerName = "ahmed",
                Address = "Cairo",
                DeliveryStatus = DeliveryStatus.DELIVERED
            };
            DeliveryService deliveryService = new DeliveryService();
            deliveryService.Start(delivery);
            Console.WriteLine(delivery);
        }
    }
}
