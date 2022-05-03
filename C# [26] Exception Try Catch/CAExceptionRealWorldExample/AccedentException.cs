using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExceptionRealWorldExample
{
    class AccedentException:Exception
    {
        public string Location { get; set; }
        public AccedentException(string location , string message):base(message)
        {
            location = location;
        }
    }
}
