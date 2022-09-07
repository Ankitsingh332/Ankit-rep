

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th_sep
{
    public delegate int StringLenghtDelegate(string s);
    public class StringLength
    {
        public int len(string s)
        {
            int i = s.Length;
            return i;
        }
    }
}