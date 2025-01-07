using DataAccessLayer;
using DataAccessLayer.Models;
using Spectre.Console;

namespace Project1;

public class P1Start
{
    public void Run()
    {
        // Jag kan få tillgång till Northwind genom min DataAccessLayer!
        AccessDatabas accessDatabas = new AccessDatabas();
        using (NorthwindContext context = accessDatabas.GetDbContext())
        {
            // Customers
            var customers = context.Customers.ToList();
            Console.WriteLine("Project 1");
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.CustomerId}, {customer.CompanyName}");
            }
            AnsiConsole.Markup("[green]Press any key to continue![/]");
            Console.ReadLine();
        }
    }
}
