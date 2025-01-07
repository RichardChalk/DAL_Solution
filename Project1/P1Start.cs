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

            var table = new Table();
            // Alternativ för tabellutseende
            table.Border(TableBorder.Double); // Dubbelram
            table.BorderColor(Color.Grey); // Sätt en kantfärg
            table.Title("[underline bold green]Project 1:[/] All Customers"); // Lägg till en titel

            // Alternativ för Kolumnerna
            table.AddColumn(new TableColumn("[bold red]Id[/]"));
            table.AddColumn(new TableColumn("[bold red]Namn[/]"));
            foreach (Customer customer in customers)
            {
                table.AddRow(
                    $"[blue]{customer.CustomerId}[/]",
                    $"[bold]{customer.CompanyName}[/]"
                    );
            }

            AnsiConsole.Write(table);

            AnsiConsole.Markup("[green]Press any key to continue![/]");
            Console.ReadLine();
        }
    }
}
