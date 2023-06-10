using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace PropertyFormConverter
{
    internal abstract class Assets
    {
        public virtual int Name { get; }=0; 
        public virtual int Volume { get; } = 1;
        public virtual int Value { get; }=4;
        public virtual int FreeProperty { get; }=6;
        public virtual string Remarks { get; } = "換価予定";
        public bool IsSucceed { get; protected set; }

        public virtual void Convert(string source,bool hasNumber)
        {
            //クリップボードからコピー
            var clipboardText = Clipboard.GetText();
            if (string.IsNullOrEmpty(clipboardText))
            {
                IsSucceed = false;  
                return;
            }

            //財産目録の変換
            var result = "";
            var no = 1;
            string[] rows = source.Split(Environment.NewLine);
            var numbers = "①②③④⑤⑥⑦⑧⑨⑩⑪⑫⑬⑭⑮⑯⑰⑱⑲⑳㉑㉒㉓㉔㉕㉖㉗㉘㉙㉚";

            foreach (var row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }

                var line = row.Replace(Environment.NewLine, string.Empty);
                string[] values = line.Split('\t');

                //1行目
                var line1 = ArrangeLine1(values);

                //2行目
                var line2 = ArrangeLine2(values);
                
                //冒頭ナンバリング付加
                if (hasNumber)
                {
                    if (no <= 30)
                        line1 = string.Concat(numbers.AsSpan(no - 1, 1), "\t", line1);
                    else
                        line1 = "○\t" + line1;
                    
                    line2 = "\t" + line2;
                }

                //統合
                result += line1 + "\n" + line2 + "\n";
                no++;
            }
            result = result.TrimEnd('\n');

            //クリップボードにコピー
            Clipboard.SetText(result);
            IsSucceed = true;
            
        }

        public virtual string ArrangeLine1(string[] values)
        {
            //1行目整形
            var line1 = values[Name] + "\t";
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
            return line1;
        }

        public virtual string ArrangeLine2(string[] values)
        {
            //2行目整形
            if (values.Length > Volume && !string.IsNullOrEmpty(values[Volume]))
                return values[Volume] + "個";
            else
                return "";
        }
    }
}
