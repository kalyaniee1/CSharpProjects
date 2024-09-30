using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppDLL1.Exceptions
{
    [Serializable]
    public class ListFullException:Exception
    {
        public ListFullException(string message):base(message) { }
    }
}
