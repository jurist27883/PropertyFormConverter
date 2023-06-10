using PropertyFormConverter.Assets;
using PropertyInventoryConverter;

namespace PropertyFormConverter
{
    public partial class MainForm : Form
    {
        public MainForm(string resultText,string checkedRadioButtonName,string checkBoxState)
        {
            InitializeComponent();
            rbBank.Checked = true;
            lblResult.Text = resultText;
            if (checkedRadioButtonName != "")
            {
                var selectedRadioButton = grCopiedDataType.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Name == checkedRadioButtonName);
                selectedRadioButton.Checked = true;
            }
            if (checkBoxState != "")
            {
                ckNumbering.Checked = (checkBoxState == "true") ? true : false;
            }
            
        }

        public string Result { get; set; } = "";

        private async void btnExec_Click(object sender, EventArgs e)
        {
            var clipboardText = Clipboard.GetText();

            if (string.IsNullOrEmpty(clipboardText))
            {
                lblResult.Text = "";
                await Task.Delay(100);
                lblResult.Text = "申立用財産目録からデータをコピー(Ctrl+C)した後に実行してください。";
                return;
            }

            clipboardText = TextFormatter.DeleteLineBreaksInCell(clipboardText);

            var checkedRadioButton = grCopiedDataType.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked == true);
            Asset assets = checkedRadioButton.Name switch
            {
                "rbBank" => new Bank(),
                "rbInsurance" => new Insurance(),
                "rbRealestate" => new RealEstate(),
                "rbSecurities" => new Securities(),
                "rbCar" => new Car(), 
                "rbRetirement" => new Retirement(),
                "rbOverpayment" => new OverPayment(),
                "rbCheck" => new Check(),
                _ => new Claim()
            };


            assets.Convert(clipboardText, ckNumbering.Checked);

            if (assets.IsSucceed)
            {
                //Excelのコピー状態を解除するため再起動
                var resultText = "成形を実行しました。\n"
                    + "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
                var checkBoxState = (ckNumbering.Checked) ? "true" : "false";
                System.Diagnostics.Process.Start(Application.ExecutablePath, resultText + " " + checkedRadioButton.Name + " " +  checkBoxState);
                Application.Exit();
            }
            else
            {
                lblResult.Text = "";
                await Task.Delay(100);
                lblResult.Text = "申立用財産目録からデータをコピー(Ctrl+C)した後に実行してください。";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbBank_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "預貯金・積立金目録（申立用）のデータのうち、「金融機関…の名称」列から「回収見込額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押します。\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbInsurance_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "保険目録（申立用）のデータのうち、「保険会社名」列から「回収見込額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbRealestate_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "不動産目録（申立用）のデータのうち、「種類」列から「回収見込額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbSecurities_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "有価証券目録（申立用）のデータのうち、「財産の種類」列から「回収見込額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbCar_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "自動車目録（申立用）のデータのうち、「車名」列から「回収見込額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbDeposit_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "賃借保証金・敷金目録（申立用）のデータのうち、「賃借物件」列から「回収見込額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbRetirement_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "退職金目録（申立用）のデータのうち、「雇用主…」列から「1/8相当額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbOverpayment_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "過払金目録（申立用）のデータのうち、「相手方…」列から「回収費用控除後残金」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "手形・小切手目録（申立用）のデータのうち、「振出人…」列から「回収見込額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbReceivable_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "売掛金目録（申立用）のデータのうち、「債務者…」列から「回収見込額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbLoan_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "貸付金目録（申立用）のデータのうち、「債務者…」列から「回収見込額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbStock_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "在庫商品目録（申立用）のデータのうち、「品名」列から「回収見込額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbMachine_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "機械・工具類目録（申立用）のデータのうち、「名称」列から「回収見込額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbFixtures_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "什器備品目録（申立用）のデータのうち、「名称」列から「回収見込額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "その他の財産目録（申立用）のデータのうち、「財産の種類…」列から「回収見込額」列までを選択してコピー（Ctrl+C）し、「実行」ボタンを押してください。" + "\r\n\r\n" +
                "個人の破産者の場合、「自由財産拡張申立」列まで選択してコピーすることも可能です。\r\n\r\n" +
                "複数列の選択も可能です。\r\n\r\n" +
                "このウィンドウが再起動すれば成形成功です。\r\n" +
                "管財用の財産目録の適宜の場所にCtrl+Vで貼り付けてください。";
            lblResult.Text = "";
        }
    }
}