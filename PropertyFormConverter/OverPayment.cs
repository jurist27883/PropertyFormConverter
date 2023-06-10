using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyFormConverter
{
    internal class OverPayment : Claim
    {
        public override int Value { get; } = 4;
        public override int FreeProperty { get; } = 7;
        public override string Remarks { get; } = "請求予定";
    }
}
