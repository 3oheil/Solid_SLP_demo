using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace violation_Example
{
    public class Ostrich : Bird
    {
        public override void Fly()
        {
            throw new NotSupportedException("Ostriches can't fly.");
        }
    }
}
