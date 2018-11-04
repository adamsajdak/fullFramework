using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFramework
{
    public class Generator
    {
        private Random _r = new Random();
        public string Generate()
        {
            return _r.Next().ToString();
        }
    }
}
