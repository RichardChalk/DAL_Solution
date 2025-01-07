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

            var table = new Table();
            // Alternativ för tabellutseende
            table.Border(TableBorder.Double); // Dubbelram
            table.BorderColor(Color.Grey); // Sätt en kantfärg
            table.Title("[underline bold green]Project 2:[/] All Products"); // Lägg till en titel

            // Alternativ för Kolumnerna
            table.AddColumn(new TableColumn("[bold red]Id[/]"));
            table.AddColumn(new TableColumn("[bold red]Namn[/]"));
            foreach (Product product in products)
            {
                table.AddRow(
                    $"[blue]{product.ProductId}[/]",
                    $"[bold]{product.ProductName}[/]"
                    );
            }

            AnsiConsole.Write(table);

            AnsiConsole.Markup("[green]Press any key to continue![/]");
            Console.ReadLine();
        }
    }
}
