using KettleApp.Milk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KettleApp
{
    /// <summary>
    /// Factory class for creating milk instances.
    /// </summary>
    internal class MilkFactory
    {
        /// <summary>
        /// Creates a milk instance based on the specified milk type.
        /// </summary>
        /// <param name="milkType">The type of milk.</param>
        /// <returns>An instance of IMilk representing the specified milk type.</returns>
        public static IMilk CreateMilk(string milkType)
        {
            return milkType.ToLower() switch
            {
                "oat" => new OatMilk(),
                "almond" => new AlmondMilk(),
                "soy" => new SoyMilk(),
                _ => new NoMilk(),
            };
        }
    }
}
