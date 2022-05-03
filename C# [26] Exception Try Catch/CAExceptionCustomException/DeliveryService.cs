using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExceptionRealWorldExample
{
    public class DeliveryService
    {
        private readonly static Random r = new Random();

        public void Start(Delivery delivery)
        {
            try
            {
                Processing(delivery);
                Shipped(delivery);
                Transiant(delivery);
                Delivered(delivery);
            }
            catch(Exception ex)            
            {
                Console.WriteLine($"Deliver Fails due to {ex.Message}");
                delivery.DeliveryStatus = DeliveryStatus.UNKNOWN;
            }
            finally
            {
                Console.WriteLine("End");
            }
            
        }

        private void Processing(Delivery delivery)
        {
            FakeIt("\nProcessing");
            if (r.Next(1,5) == 1)
            {
                throw new InvalidOperationException("unable to process this item.");
            }
            delivery.DeliveryStatus = DeliveryStatus.PROCESSED;   
        }

        private void Shipped(Delivery delivery)
        {
            FakeIt("\nShipped");
            if (r.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("the Shippment is Damaged.");
            }
            delivery.DeliveryStatus = DeliveryStatus.SHIPPED;
        }

        private void Transiant(Delivery delivery)
        {
            FakeIt("\nTransiant");
            if (r.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("the Shipment is in Transiant.");
            }
            delivery.DeliveryStatus = DeliveryStatus.TRANSIANT;
        }

        private void Delivered(Delivery delivery)
        {
            FakeIt("\nDelivering");
            if (r.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("the Shippment is Delivered.");
            }
            delivery.DeliveryStatus = DeliveryStatus.DELIVERED;
        }

        private void FakeIt(string title)
        {
            Console.Write(title);
            System.Threading.Thread.Sleep(300);
            Console.Write(".");

            System.Threading.Thread.Sleep(300);
            Console.Write(".");

            System.Threading.Thread.Sleep(300);
            Console.Write(".");

            System.Threading.Thread.Sleep(300);
            Console.Write(".");

            System.Threading.Thread.Sleep(300);
            Console.Write(".");

        }


        
    }
}
