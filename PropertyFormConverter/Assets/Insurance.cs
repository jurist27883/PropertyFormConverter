using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyFormConverter.Assets
{
    internal class Insurance : Asset
    {
        public override int FreeProperty { get; } = 7;
        int Type { get; } = 1;
        int Number { get; } = 2;
        public override string Remarks { get; } = "解約予定";

        public override string ArrangeLine1(string[] values)
        {
            var line1 = values[Type] + "(" + values[Name] + ")\t";

            if (values.Length > FreeProperty)
            {
                if (values[FreeProperty] == "■")
                {
                    line1 += "0\t0\t拡張予定\t■\t"
                        + "=IF(indirect(address(row(),column()-1))=\"□\",\"■\",\"□\")"
                        + "\t" + values[Value];
                }
                else
                {
                    line1 += values[Value] + "\t0\t" + Remarks + "\t■\t"
                        + "=IF(indirect(address(row(),column()-1))=\"□\",\"■\",\"□\")"
                        + "\t-";
                }
            }
            else
            {
                line1 += values[Value] + "\t0\t" + Remarks + "\t■\t"
                    + "=IF(indirect(address(row(),column()-1))=\"□\",\"■\",\"□\")";
            }
            return line1;
        }
        public override string ArrangeLine2(string[] values)
        {
            if (values.Length > Number && !string.IsNullOrEmpty(values[Number]))
                return values[Number];
            else
                return "";
        }
    }
}
