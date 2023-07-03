using PropertyFormConverter.Assets;
using PropertyInventoryConverter;

namespace PropertyFormConverter
{
    public partial class MainForm : Form
    {
        public MainForm(string resultText,string checkedRadioButtonName,string checkBoxState)
        {
            InitializeComponent();
            
            if (checkedRadioButtonName != "")
            {
                var selectedRadioButton = grCopiedDataType.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Name == checkedRadioButtonName);
                selectedRadioButton.Checked = true;
            }
            else
                rbBank.Checked = true;
            
            lblResult.Text = (resultText == "successed") ? "���`�����s���܂����B\n�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B" : "";

            ckNumbering.Checked = (checkBoxState == "" || checkBoxState == "true") ? true : false;
            
        }

        public string Result { get; set; } = "";

        private async void btnExec_Click(object sender, EventArgs e)
        {
            var clipboardText = Clipboard.GetText();

            if (string.IsNullOrEmpty(clipboardText))
            {
                lblResult.Text = "";
                await Task.Delay(100);
                lblResult.Text = "�\���p���Y�ژ^����f�[�^���R�s�[(Ctrl+C)������Ɏ��s���Ă��������B";
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
                //Excel�̃R�s�[��Ԃ��������邽�ߍċN��
                var resultText = "successed";
                var checkBoxState = (ckNumbering.Checked) ? "true" : "false";
                System.Diagnostics.Process.Start(Application.ExecutablePath, resultText + " " + checkedRadioButton.Name + " " +  checkBoxState);
                Application.Exit();
            }
            else
            {
                lblResult.Text = "";
                await Task.Delay(100);
                lblResult.Text = "�\���p���Y�ژ^����f�[�^���R�s�[(Ctrl+C)������Ɏ��s���Ă��������B";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbBank_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "�a�����E�ϗ����ژ^�i�\���p�j�̃f�[�^�̂����A�u���Z�@�ցc�̖��́v�񂩂�u��������z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������܂��B\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbInsurance_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "�ی��ژ^�i�\���p�j�̃f�[�^�̂����A�u�ی���Ж��v�񂩂�u��������z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbRealestate_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "�s���Y�ژ^�i�\���p�j�̃f�[�^�̂����A�u��ށv�񂩂�u��������z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbSecurities_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "�L���،��ژ^�i�\���p�j�̃f�[�^�̂����A�u���Y�̎�ށv�񂩂�u��������z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbCar_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "�����Ԗژ^�i�\���p�j�̃f�[�^�̂����A�u�Ԗ��v�񂩂�u��������z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbDeposit_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "���ؕۏ؋��E�~���ژ^�i�\���p�j�̃f�[�^�̂����A�u���ؕ����v�񂩂�u��������z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbRetirement_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "�ސE���ژ^�i�\���p�j�̃f�[�^�̂����A�u�ٗp��c�v�񂩂�u1/8�����z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbOverpayment_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "�ߕ����ژ^�i�\���p�j�̃f�[�^�̂����A�u������c�v�񂩂�u�����p�T����c���v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "��`�E���؎�ژ^�i�\���p�j�̃f�[�^�̂����A�u�U�o�l�c�v�񂩂�u��������z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbReceivable_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "���|���ژ^�i�\���p�j�̃f�[�^�̂����A�u���ҁc�v�񂩂�u��������z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbLoan_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "�ݕt���ژ^�i�\���p�j�̃f�[�^�̂����A�u���ҁc�v�񂩂�u��������z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbStock_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "�݌ɏ��i�ژ^�i�\���p�j�̃f�[�^�̂����A�u�i���v�񂩂�u��������z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbMachine_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "�@�B�E�H��ޖژ^�i�\���p�j�̃f�[�^�̂����A�u���́v�񂩂�u��������z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbFixtures_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "�Y����i�ژ^�i�\���p�j�̃f�[�^�̂����A�u���́v�񂩂�u��������z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text =
                "���̑��̍��Y�ژ^�i�\���p�j�̃f�[�^�̂����A�u���Y�̎�ށc�v�񂩂�u��������z�v��܂ł�I�����ăR�s�[�iCtrl+C�j���A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" +
                "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B\r\n\r\n" +
                "������̑I�����\�ł��B\r\n\r\n" +
                "���̃E�B���h�E���ċN������ΐ��`�����ł��B\r\n" +
                "�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
            lblResult.Text = "";
        }
    }
}