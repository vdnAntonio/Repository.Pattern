using System;
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

                var order = unitOfWork.Orders.GetOrderById(1);

                var topProducts = unitOfWork.Products.MostExpensiveProduct(10);
            }
        }
    }
}
