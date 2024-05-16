using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KettleApp.Milk
{
    /// <summary>
    /// Represents almond milk.
    /// </summary>
    internal class AlmondMilk : IMilk
    {
        public async Task Add()
        {
            await Console.Out.WriteLineAsync("Pouring almond milk into the tea...");
            await Task.Delay(1000); // Simulate pouring milk
        }
    }
}
