using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Filter : IFilter
    {
        public void Apply()
        {
            Console.WriteLine("Applying " + nameof(Filter)); 
        }
    }
}
