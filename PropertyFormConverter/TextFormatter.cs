using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PropertyInventoryConverter
{
    internal class TextFormatter
    {
        public static string DeleteLineBreaksInCell(string source)
        {
            source= Regex.Replace(source, "\\n(?=[^\"]*\"(?:[^\"]*\"[^\"]*\")*[^\"]*$)","");
            return Regex.Replace(source, "\"","");
        }
    }
}
