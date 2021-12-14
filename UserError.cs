using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonE3
{
    internal abstract class UserError
    {
        public abstract string UEMessage(); // abstract method: Force my wonderful inheritance to all the children, grandchildren, etc.
    }
}
