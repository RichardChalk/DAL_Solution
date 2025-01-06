using DataAccessLayer;
using DataAccessLayer.Models;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jag kan få tillgång till Northwind genom min DataAccessLayer!
            AccessDatabas accessDatabas = new AccessDatabas();
            using (NorthwindContext context = accessDatabas.GetDbContext())
            {
                // Customers
                var customers = context.Customers.ToList();
                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.CustomerId}, {customer.CompanyName}");
                }
            }
        }
    }
}
