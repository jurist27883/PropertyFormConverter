using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyFormConverter
{
    internal class Check : Assets
    {
        public override int Value { get; } = 8;
        public override int FreeProperty { get; } = 10;
        int Number { get; } = 4;
        
        public override string ArrangeLine2(string[] values)
        {
            if (values.Length > Number && !string.IsNullOrEmpty(values[Number]))
                return values[Number];
            else
                return"";
        }
    }
}
