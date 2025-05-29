using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correc_example
{
    public class Eagle : Bird, IFyable
    {
        public void Fly()
        {
            Console.WriteLine("The eagle soars high in the sky.");
        }

    }
}
