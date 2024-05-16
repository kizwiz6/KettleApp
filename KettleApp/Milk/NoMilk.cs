using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace KettleApp.Milk
{
    /// <summary>
    /// Represents no milk.
    /// </summary>
    internal class NoMilk : IMilk
    {
        public async Task Add()
        {
            await Console.Out.WriteLineAsync("No milk added.");
        }
    }
}
