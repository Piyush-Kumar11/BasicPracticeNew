using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class ZeroNotAllowedException: Exception
    {
        public ZeroNotAllowedException(string msg): base(msg) { }

        //can override ToString to provide a simpler or more application-specific message.
        //public override string ToString()
        //{
        //    //Message Property is from Exception base class
        //    return $"Custom Exception: {Message}";
        //}
    }
}
