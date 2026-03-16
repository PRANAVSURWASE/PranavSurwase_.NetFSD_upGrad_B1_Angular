namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<order> orders = new List<order>();
            orders.Add(new StandardOrder { OrderId = 1, OrderAmount = 1000 });
            orders.Add(new ExpressOrder { OrderId = 2, OrderAmount = 2000 });
            orders.Add(new InternationalOrder { OrderId = 3, OrderAmount = 3000 });

            foreach(order o in orders)
            {
                Console.WriteLine("Order ID :" + o.OrderId);
                Console.WriteLine("Order Amount :" + o.OrderAmount);
                Console.WriteLine("shipping Cost :" + o.CalculateShippingCost());
            }


        }
    }
}
