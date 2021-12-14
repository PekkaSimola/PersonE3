using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonE3
{
    internal class DivByZeroError : UserError 
    {
        public override string UEMessage() => "Division by zero occured. The results infinity, can't be handled by any type of variable!";
    }
}
