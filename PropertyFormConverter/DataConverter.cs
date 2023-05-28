using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyInventoryConverter
{
    internal class DataConverter
    {
        public string AddNumber(string source)
        {
            //冒頭ナンバリング付加
            string result = "";
            string numbers = "①②③④⑤⑥⑦⑧⑨⑩⑪⑫⑬⑭⑮⑯⑰⑱⑲⑳㉑㉒㉓㉔㉕㉖㉗㉘㉙㉚";
            StringReader stringReader = new StringReader(source);

            bool isHeadline = true;
            int number = 1;

            while (stringReader.Peek() > -1)
            {
                var line=stringReader.ReadLine();
                if (number > 30)
                {
                    break;
                }

                if (isHeadline)
                {
                    result = result + numbers.Substring(number - 1, 1) + "\t" + line + "\n";
                    number++;
                }
                else
                {
                    result = result + "\t" + line + "\n";
                }
                isHeadline = !isHeadline;

            }

            result =result.TrimEnd('\n');
            return result;
        }

        public string BankConvert(string source)
        {
            //預貯金・積立金の変換
            string result ="";
            StringReader stringReader = new StringReader(source);

            while (stringReader.Peek() > -1) {
                var line = stringReader.ReadLine();
                string[] values = line.Split('\t');
                
                var line1 = values[0];
                var line2 = "";
                var remarks ="解約予定";
                var freeProperty = "";

                //備考欄・評価額・拡張額 判定・準備
                if (values.Length >= 6 && values[5] == "■")
                {
                    remarks = "相殺見込み";
                }
                if (values.Length >= 10 )
                {
                    if(values[9] == "■")
                    {
                        remarks = "拡張予定";
                        freeProperty = values[6];
                        values[6] = "0";
                    }
                    else
                    {
                        freeProperty = "-";
                    }
                }

                //金融機関・支店
                if (values.Length >= 2)
                {
                    var branch = values[1];
                    if (!(branch == "" || branch.Substring(Math.Max(branch.Length-2,0))=="本店" || 
                        branch.Substring(Math.Max(branch.Length - 3, 0)) == "営業部")){
                        branch = branch + "支店";
                    }
                    line1 = line1 + " " + branch;
                }

                //評価額・回収額
                if (values.Length >= 7)
                {
                    line1 = line1 + "\t" + values[6] + "\t" + "0";
                }

                //預金種別
                if(values.Length >= 3)
                {
                    line2 = values[2];
                }

                //口座番号
                if (values.Length >= 4)
                {
                    line2 = line2 + values[3];
                }

                //備考欄付加
                if (values.Length >= 7 && remarks != "")
                {
                    line1 = line1 + "\t" + remarks;  
                }

                //拡張額付加
                if(freeProperty != "")
                {
                    line1 = line1 + "\t■\t" + "=IF(indirect(address(row(),column()-1))=\"□\",\"■\",\"□\")" + "\t" + freeProperty;
                }

                result = result + line1 + "\n" + line2 +"\n";    

            }
           
            result = result.TrimEnd('\n');
            return result;
        }
        public string InsuranceConvert(string source)
        {
            //保険の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[1] + "(" + values[0] + ")" + "\t"
                    + values[4] + "\t" + "0"
                    + "\n" + values[2] + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }
        public string RealEsateConvert(string source)
        {
            //不動産の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[0] + "\t" + values[5] + "\t" + "0"
                    + "\n" + values[1] + values[2] + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }
        public string SecuritiesConvert(string source)
        {
            //有価証券の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[0] + "()" + values[1] + "\t"
                    + values[6] + "\t" + "0"
                    + "\n" + values[1]  + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }
        public string CarConvert(string source)
        {
            //自動車の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[0] + "\t"
                    + values[5] + "\t" + "0"
                    + "\n" + values[2] + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }
        public string DepositConvert(string source)
        {
            //敷金の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[0] + "\t"
                    + values[5] + "\t" + "0"
                    + "\n" + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }
        public string RetirementConvert(string source)
        {
            //退職金の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[0] + "\t"
                    + values[3] + "\t" + "0"
                    + "\n" + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }
        public string OverPaymentConvert(string source)
        {
            //過払金の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[0] + "\t"
                    + values[4] + "\t" + "0"
                    + "\n" + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }
        public string CheckConvert(string source)
        {
            //手形・小切手の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[0] + "\t"
                    + values[8] + "\t" + "0"
                    + "\n" + values[4] + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }
        public string ReceivableConvert(string source)
        {
            //売掛金の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[0] + "\t"
                    + values[5] + "\t" + "0"
                    + "\n" + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }
        public string LoanConvert(string source)
        {
            //貸付金の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[0] + "\t"
                    + values[5] + "\t" + "0"
                    + "\n" + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }
        public string StockConvert(string source)
        {
            //在庫の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[0] + "\t"
                    + values[4] + "\t" + "0"
                    + "\n" + values[1] + "個" + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }
        public string MachineConvert(string source)
        {
            //機械・工具の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[0] + "\t"
                    + values[4] + "\t" + "0"
                    + "\n" + values[1] + "個" + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }
        public string FixturesConvert(string source)
        {
            //什器備品の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[0] + "\t"
                    + values[4] + "\t" + "0"
                    + "\n" + values[1] + "個" + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }
        public string OtherConvert(string source)
        {
            //その他財産の変換
            string result = "";
            string[] rows = source.Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                //string line = row.Replace(Environment.NewLine, string.Empty);
                string line = row.Replace("\n", string.Empty);
                line = line.Replace("\r", string.Empty);

                string[] values = line.Split('\t');
                result = result + values[0] + "\t"
                    + values[4] + "\t" + "0"
                    + "\n" + values[1] + "個" + "\n";
            }
            result = result.TrimEnd('\n');
            return result;
        }

    }
}
