using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linlin_Han_Lab05_Ex02
{
    public class ArgumentException:Exception
    {
        // parameterless constructor
        public ArgumentException() : base("The argument is invalid.") { }

        // one-parameter constructor
        public ArgumentException(string ex)
           : base($"{ex} ") { }

        //// two-parameter constructor
        //public EmptyListException(string exception, Exception inner)
        //   : base(exception, inner) { }
    }
}
