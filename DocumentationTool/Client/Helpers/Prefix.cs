using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Helpers
{
    public class Prefix
    {
        private int PrefixMax = 32;
        public double GetAdressCount(int value)
        {
            if (value == PrefixMax)
                return 1;

            return Math.Pow(2, PrefixMax - value);
        }
    }
}
