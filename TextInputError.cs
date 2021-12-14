using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonE3
{
    internal class TextInputError : UserError 
    {
        public override string UEMessage() => "You tried to use a text input in a numeric-only field. Fhis fired an error!";
    }
}
