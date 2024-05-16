using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KettleApp.Milk
{
    /// <summary>
    /// Represents soy milk.
    /// </summary>
    internal class SoyMilk : IMilk
    {
        public async Task Add()
        {
            await Console.Out.WriteLineAsync("Pouring soy milk into the tea...");
            await Task.Delay(1000); // Simulate pouring milk
        }
    }
}
