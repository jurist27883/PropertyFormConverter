using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyFormConverter
{
    internal class Claim : Assets
    {
        public override int Value { get; } = 5;
        public override int FreeProperty { get; } = 8;
        public override string ArrangeLine2(string[] values)
        {
            return "";
        }
    }
}
