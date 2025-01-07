using Project1;
using Project_2;
using System.ComponentModel;
using Spectre.Console;

namespace StartUp
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
            }
        }

        private static void ShowMenu()
        {
            Console.Clear();
            var option = AnsiConsole.Prompt(
            new SelectionPrompt<MenuOptions>()
            .Title("Welcome to my Data Access Layer!")
                .UseConverter(option => option.GetDescription()) // Visa beskrivningar istället för enum-namn
                .AddChoices(Enum.GetValues<MenuOptions>()));

            switch (option)
            {
                case MenuOptions.RunProject1:
                    var Project1 = new P1Start();
                    Project1.Run();
                    break;
                case MenuOptions.RunProject2:
                    var Project2 = new P2Start();
                    Project2.Run();
                    break;
                case MenuOptions.Exit:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
