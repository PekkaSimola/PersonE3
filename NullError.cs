using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonE3
{
    internal class NullError : UserError
    {
        public override string UEMessage() => "Null is invalid for the current data type. This triggered a NullError!";
    }
}
