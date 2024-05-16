namespace KettleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting to make a cup of tea...");

            // Step 1: Boil water
            await BoilWaterASync();
            await Console.Out.WriteLineAsync("Water is boiled.");

            // Step 2: Steep tea
            await SteepTeaAsync();
            await Console.Out.WriteLineAsync("Tea is ready.");

            // Step 3: Ask for milk preference
            Console.WriteLine("Do you want milk in your tea? (Type 'oat', 'almond', 'soy', or 'none'):");
            string milkPreference = Console.ReadLine();

            // Step 4: Add milk based on user preference
            await AddMilkAsync(milkPreference);
            await Console.Out.WriteLineAsync("Milk added.");

            // Step 5: Pour tea into a cup
            PourTea();

            await Console.Out.WriteLineAsync("Your cup of tea is ready. Enjoy!");
            PrintKettle();
        }

        static async Task BoilWaterASync()
        {
            await Console.Out.WriteLineAsync("Turning on the kettle...");
            await Task.Delay(2000);
            await Console.Out.WriteLineAsync("Water is boiling!");
        }

        static async Task SteepTeaAsync()
        {
            await Console.Out.WriteLineAsync("Adding tea leaves to hot water...");
            await Task.Delay(3000); // Simulate steeping process
            await Console.Out.WriteLineAsync("Tea is steeped.");
        }

        static async Task AddMilkAsync(string milkType)
        {
            if (milkType.ToLower() == "none")
            {
                await Console.Out.WriteLineAsync("No milk added.");
            }
            else if (milkType.ToLower() == "cow")
            {
                await Console.Out.WriteLineAsync("Sorry, we're vegans. Not your mum, not your milk!");
            }
            else
            {
                await Console.Out.WriteLineAsync($"Pouring {milkType} milk into the tea...");
                await Task.Delay(1000);
            }
        }

        static void PourTea()
        {
            Console.WriteLine("Pouring tea into a cup...");
        }

        static void PrintKettle()
        {
            Console.WriteLine(@"
       ( (
        ) )
    .........          _______________
   .         .       _|             |_
  /   ( ( ) )  \    |                 |
 /               \  |                 |
| (  (   )   )  ) | |                 |
 \ \____________/ /  |                 |
  \______________/   |                 |
     ________        |                 |
    |        |       |                 |
    |________|       |_________________|
            ");
        }
    }
}
