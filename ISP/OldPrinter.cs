using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class OldPrinter : IMultiFunctionMachine
    {
        public void Print(Document doc) => Console.WriteLine("Printing...");

        public void Scan(Document doc)
        {
            throw new NotImplementedException(); // این دستگاه اصلاً قابلیت اسکن نداره!
        }

        public void Fax(Document doc)
        {
            throw new NotImplementedException(); // و نه حتی فکس
        }
    }
}
