using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operation
    {
        public string[] Screen;
        public bool Mode;

        public Operation(string[] screen, bool mode)
        {
            Screen = screen;
            Mode = mode;
        }
    }
}
