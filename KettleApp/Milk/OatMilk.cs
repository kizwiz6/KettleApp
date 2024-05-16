using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KettleApp.Milk
{
    /// <summary>
    /// Represents oat milk.
    /// </summary>
    internal class OatMilk : IMilk
    {
        public async Task Add()
        {
            await Console.Out.WriteLineAsync("Pouring oat milk into the tea...");
            await Task.Delay(1000); // Simulate pouring milk
        }
    }
}
