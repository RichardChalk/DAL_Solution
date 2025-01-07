using DataAccessLayer;
using DataAccessLayer.Models;
using Spectre.Console;

namespace Project_2;

public class P2Start
{
    public void Run()
    {
        // Jag kan också få tillgång till Northwind genom min DataAccessLayer!
        AccessDatabas accessDatabas = new AccessDatabas();
        using (NorthwindContext context = accessDatabas.GetDbContext())
        {
            // Produkter!
            var products = context.Products.ToList();
            Console.WriteLine("Project 2");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.ProductId}, {p.ProductName}");
            }
            AnsiConsole.Markup("[green]Press any key to continue![/]");
            Console.ReadLine();
        }
    }
}
