using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyFormConverter
{
    internal class Car : Check
    {
        public override int Value { get; } = 5;
        public override int FreeProperty { get; } = 9;
        int Number { get; } = 2;
        public override string Remarks { get; } = "売却予定";

        public override string ArrangeLine2(string[] values)
        {
            //2行目整形
            if (values.Length > Number && !string.IsNullOrEmpty(values[Number]))
                return values[Number];
            else
                return "";
        }
    }
}
