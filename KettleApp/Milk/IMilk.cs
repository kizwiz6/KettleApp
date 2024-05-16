using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KettleApp.Milk
{
    internal interface IMilk
    {
        /// <summary>
        /// Adds the milk to the tea.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task Add();
    }
}
