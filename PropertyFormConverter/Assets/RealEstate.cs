using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyFormConverter.Assets
{
    internal class RealEstate : Asset
    {

        public override int Value { get; } = 5;
        public override int FreeProperty { get; } = 10;
        int Place1 { get; } = 1;
        int Place2 { get; } = 2;
        public override string Remarks { get; } = "売却予定";

        public override string ArrangeLine2(string[] values)
        {
            var line2 = "";
            if (values.Length > Place1 && !string.IsNullOrEmpty(values[Place1]))
                line2 += values[Place1];
            if (values.Length > Place2 && !string.IsNullOrEmpty(values[Place2]))
                line2 += " " + values[Place2];
            return line2;
        }
    }
}
