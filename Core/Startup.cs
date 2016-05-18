using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                var topPrices = unitOfWork.Orders.GetTopPrice(5);

                var order = unitOfWork.Orders.GetOrderById(1);

                var topProducts = unitOfWork.Products.MostExpensiveProduct(10);
            }
        }
    }
}
