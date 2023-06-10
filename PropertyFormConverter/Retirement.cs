using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyFormConverter
{
    internal class Retirement : Claim
    {
        public override int Value { get; } = 3;
        public override int FreeProperty { get; } = 7;

        public override string Remarks { get; } = "組入放棄予定";

    }
}
