using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementToObject
{
    public class Cat : IActionable
    {
        public string MakeSound()
        {
            return "Meow";
        }
    }
}
