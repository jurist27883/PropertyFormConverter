using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace PropertyFormConverter.Assets
{
    internal class Bank : Asset
    {
        public override int Value { get; } = 6;
        public override int FreeProperty { get; } = 9;
        int Branch { get; } = 1;
        int Type { get; } = 2;
        int Number { get; } = 3;
        int Offsetting { get; } = 5;


        public override string ArrangeLine1(string[] values)
        {
            var line1 = values[Name];

            //支店
            if (values.Length > Branch)
            {
                var branch = values[Branch];
                if (!(branch == "" || branch[Math.Max(branch.Length - 2, 0)..] == "本店" ||
                    branch[Math.Max(branch.Length - 3, 0)..] == "営業部" ||
                    branch[Math.Max(branch.Length - 2, 0)..] == "支店"))
                {
                    branch += "支店";
                }
                line1 = line1 + " " + branch;
            }


            //備考欄・評価額・拡張額 判定・準備
            var remarks = "解約予定";
            var freePropertyValue = "";

            if (values.Length > Offsetting && values[Offsetting] == "■")
            {
                remarks = "相殺見込み";
                values[Value] = "0";
            }

            if (values.Length > FreeProperty)
            {
                if (values[FreeProperty] == "■")
                {
                    remarks = "拡張予定";
                    freePropertyValue = values[Value];
                    if (values.Length > Value)
                        values[Value] = "0";
                }
                else
                {
                    if (remarks != "相殺見込み")
                        remarks = "解約予定";
                    freePropertyValue = "-";
                }
            }

            //評価額・回収額
            if (values.Length > Value)
                line1 = line1 + "\t" + values[Value] + "\t" + "0";

            //備考欄
            if (values.Length > Value && remarks != "")
                line1 += "\t" + remarks;

            //拡張額
            if (freePropertyValue != "")
                line1 = line1 + "\t■\t" + "=IF(indirect(address(row(),column()-1))=\"□\",\"■\",\"□\")" + "\t" + freePropertyValue;

            return line1;
        }
        public override string ArrangeLine2(string[] values)
        {

            //預金種別
            var line2 = "";

            if (values.Length > Type)
                line2 += values[Type];

            //口座番号
            if (values.Length > Number)
                line2 += values[Number];

            return line2;
        }
    }
}
