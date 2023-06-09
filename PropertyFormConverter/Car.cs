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
    }
}
