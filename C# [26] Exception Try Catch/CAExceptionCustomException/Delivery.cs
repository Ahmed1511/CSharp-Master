namespace CAExceptionRealWorldExample
{
    public class Delivery
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }

        public override string ToString()
        {
            return $"{{ \n Id:  {Id} , \nCustomer :  {CustomerName} , \nAddress :  {Address} , \nDeliver Status:  {DeliveryStatus}\n}}";
        }

    }
}
