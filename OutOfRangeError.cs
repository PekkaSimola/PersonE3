using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonE3
{
    internal class OutOfRangeError : UserError
    {
        public override string UEMessage() => "The input can't fit within the current data type; an OutOfRange-error triggers!";
    }
}
