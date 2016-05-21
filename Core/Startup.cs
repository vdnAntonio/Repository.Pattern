using System;
using System.Linq;
using Core.Entity;

namespace Core
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new PlutoContext()))
            {
                var persone = unitOfWork.People.GetPersonWithOrders(1);

                var orderFrom = unitOfWork.Orders.GetOrdersFromDate(new DateTime(2016, 05, 20, 13, 47, 0));

                var order = unitOfWork.Orders.GetOrderById(100);

                var whoMadeOrder = unitOfWork.People.GetPersonWithOrders(order.PersonId);

                var topProducts = unitOfWork.Products.MostExpensiveProduct(10);

                Console.WriteLine($"Persone with id 1: {persone.FirstName} {persone.LastName}"); 
                Console.WriteLine("");
                Console.WriteLine($"Date order with id 1: : {order.DateTime}");
                Console.WriteLine($"And this order did {whoMadeOrder.FirstName}");
                Console.WriteLine("");
                Console.WriteLine("Top 10 buyer products:");
                topProducts.ToList().ForEach(w => { Console.WriteLine($" - {w.Name}"); });
            }
        }
    }
}
