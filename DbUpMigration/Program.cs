// See https://aka.ms/new-console-template for more information
// This comment is a link to documentation about the console application template in Visual Studio
using DbUp;

class Program
{
    static void Main()
    {
        Console.WriteLine($"DBUp migration started at {DateTime.UtcNow}");
        // This line writes a message to the console indicating when the migration started, using the current UTC time

        var connectionString = "Server=.\\SQLEXPRESS;Database=CED.Prospect;Trusted_Connection=True;Encrypt=False;Connect Timeout=99999999;";
        // This line sets the connection string for the database being upgraded

        try
        {
            var upgrader = DeployChanges.To.SqlDatabase(connectionString)
                .WithScriptsFromFileSystem(@"../../../../CED.Data/Scripts/")
                .LogToConsole()
                .Build();
            // This block creates an instance of the DbUp upgrader with the specified connection string, file path for migration scripts, and console logging

            var result = upgrader.PerformUpgrade();
            // This line performs the database upgrade and returns the result

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
                // If the upgrade was not successful, this block sets the console text color to red, writes the error message to the console, and resets the color

#if DEBUG
                Console.ReadLine();
#endif
                // If the code is compiled in debug mode, this line waits for user input before closing the console
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success!");
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"An error occurred during the database migration: {ex.Message}");
        }
        finally
        {
            Console.WriteLine($"DBUp migration ended at {DateTime.UtcNow}");
            Console.ResetColor();
            // This block writes the end time of the migration to the console and resets the color
        }

        Console.ReadLine();
        // This line waits for user input before closing the console.
    }
}
