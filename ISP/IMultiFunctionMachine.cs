using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public  interface IMultiFunctionMachine
    {
        void Print(Document doc);
        void Scan(Document doc);
        void Fax(Document doc);
    }
}
