using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    class Skype : Caller
    {
        public int Call(int time)
        {
            return time * 5;
        }
    }
}
