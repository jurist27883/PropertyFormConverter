using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyFormConverter.Assets
{
    internal class Securities : Asset
    {
        public override int Value { get; } = 6;
        public override int FreeProperty { get; } = 9;
        int Number { get; } = 2;

        public override string ArrangeLine1(string[] values)
        {
            var line1 = values[Name];
            if (values.Length > Number)
            {
                line1 += "(" + values[Number] + ")";
            }
            line1 += "\t";

            if (values.Length > FreeProperty && values[FreeProperty] == "■")
            {
                line1 += "0\t0\t拡張予定\t■\t"
                    + "=IF(indirect(address(row(),column()-1))=\"□\",\"■\",\"□\")"
                    + "\t" + values[Value];
            }
            else
            {
                line1 += values[Value] + "\t0";
            }
            return line1;
        }
        public override string ArrangeLine2(string[] values)
        {
            if (values.Length > Volume && !string.IsNullOrEmpty(values[Volume]))
                return values[Volume];
            else
                return "";
        }
    }
}
