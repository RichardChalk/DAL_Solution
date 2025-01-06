using DataAccessLayer;
using DataAccessLayer.Models;

namespace Project_2;

internal class Program
{
    static void Main(string[] args)
    {
        // Jag kan också få tillgång till Northwind genom min DataAccessLayer!
        AccessDatabas accessDatabas = new AccessDatabas();
        using (NorthwindContext context = accessDatabas.GetDbContext())
        {
            // Produkter!
            var products = context.Products.ToList();
            foreach (var p in products)
            {
                Console.WriteLine($"{p.ProductId}, {p.ProductName}");
            }
        }
    }
}
