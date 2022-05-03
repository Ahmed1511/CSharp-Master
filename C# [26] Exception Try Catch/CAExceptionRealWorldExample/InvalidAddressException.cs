using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExceptionRealWorldExample
{
    class InvalidAddressException:Exception
    {
        
        public InvalidAddressException(string address):base(address)
        {
            
        }
    }
}
