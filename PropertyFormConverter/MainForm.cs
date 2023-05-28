using PropertyInventoryConverter;

namespace PropertyFormConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            rbBank.Checked = true;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            var clipboardText = Clipboard.GetText();

            if (string.IsNullOrEmpty(clipboardText))
            {
                MessageBox.Show("�\���p���Y�ژ^����f�[�^���R�s�[(Ctrl+C)������Ɏ��s���Ă��������B");
                return;
            }
            clipboardText = TextFormatter.DeleteLineBreaksInCell(clipboardText);    

            string formattedText = "";
                        
            DataConverter dataConverter = new DataConverter();

            if (rbBank.Checked)
                formattedText = dataConverter.BankConvert(clipboardText);
            else if (rbInsurance.Checked)
                formattedText = dataConverter.InsuranceConvert(clipboardText);
            else if (rbRealestate.Checked)
                formattedText = dataConverter.RealEsateConvert(clipboardText);
            else if (rbSecurities.Checked)
                formattedText = dataConverter.SecuritiesConvert(clipboardText);
            else if (rbCar.Checked)
                formattedText = dataConverter.CarConvert(clipboardText);
            else if (rbDeposit.Checked)
                formattedText = dataConverter.DepositConvert(clipboardText);
            else if (rbRetirement.Checked)
                formattedText = dataConverter.RetirementConvert(clipboardText);
            else if (rbOverpayment.Checked)
                formattedText = dataConverter.OverPaymentConvert(clipboardText);
            else if (rbCheck.Checked)
                formattedText = dataConverter.CheckConvert(clipboardText);
            else if (rbReceivable.Checked)
                formattedText = dataConverter.ReceivableConvert(clipboardText);
            else if (rbLoan.Checked)
                formattedText = dataConverter.LoanConvert(clipboardText);
            else if (rbStock.Checked)
                formattedText = dataConverter.StockConvert(clipboardText);
            else if (rbMachine.Checked)
                formattedText = dataConverter.MachineConvert(clipboardText);
            else if (rbFixtures.Checked)
                formattedText += dataConverter.FixturesConvert(clipboardText);
            else if (rbOther.Checked)
                formattedText = dataConverter.OtherConvert(clipboardText);
            else
            {
                MessageBox.Show("���`�ł��܂���ł����B\n�ŏ������蒼���Ă��������B");
                return;
            }

            if (this.ckNumbering.Checked)
                formattedText = dataConverter.AddNumber(formattedText);

            if (!string.IsNullOrEmpty(clipboardText))
            {
                try
                {
                    Clipboard.SetText(formattedText);
                    lblResult.Text = "���`�����s���܂����B\n�Ǎ��p�̍��Y�ژ^�̓K�X�̏ꏊ��Ctrl+V�œ\��t���Ă��������B";
                }
                catch (System.ArgumentNullException)
                {
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbBank_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "�a�����E�ϗ����ژ^�i�\���p�j�̃f�[�^�̂����A�u���Z�@�ցc�̖��́v�񂩂�u��������z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B"
                + "\r\n" + "�l�̔j�Y�҂̏ꍇ�A�u���R���Y�g���\���v��܂őI�����ăR�s�[���邱�Ƃ��\�ł��B"
                + "\r\n\r\n" + "�������I�����邱�Ƃ��ł��܂��B";
            lblResult.Text = "";
        }

        private void rbInsurance_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "�ی��ژ^�i�\���p�j�̃f�[�^�̂����A�u�ی���Ж��v�񂩂�u��������z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }

        private void rbRealestate_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "�s���Y�ژ^�i�\���p�j�̃f�[�^�̂����A�u��ށv�񂩂�u��������z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }

        private void rbSecurities_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "�L���،��ژ^�i�\���p�j�̃f�[�^�̂����A�u���Y�̎�ށv�񂩂�u��������z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }

        private void rbCar_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "�����Ԗژ^�i�\���p�j�̃f�[�^�̂����A�u�Ԗ��v�񂩂�u��������z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }

        private void rbDeposit_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "���ؕۏ؋��E�~���ژ^�i�\���p�j�̃f�[�^�̂����A�u���ؕ����v�񂩂�u��������z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }

        private void rbRetirement_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "�ސE���ژ^�i�\���p�j�̃f�[�^�̂����A�u�ٗp��c�v�񂩂�u1/8�����z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }

        private void rbOverpayment_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "�ߕ����ژ^�i�\���p�j�̃f�[�^�̂����A�u������c�v�񂩂�u�����p�T����c���v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }

        private void rbCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "��`�E���؎�ژ^�i�\���p�j�̃f�[�^�̂����A�u�U�o�l�c�v�񂩂�u��������z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }

        private void rbReceivable_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "���|���ژ^�i�\���p�j�̃f�[�^�̂����A�u���ҁc�v�񂩂�u��������z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }

        private void rbLoan_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "�ݕt���ژ^�i�\���p�j�̃f�[�^�̂����A�u���ҁc�v�񂩂�u��������z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }

        private void rbStock_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "�݌ɏ��i�ژ^�i�\���p�j�̃f�[�^�̂����A�u�i���v�񂩂�u��������z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }

        private void rbMachine_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "�@�B�E�H��ޖژ^�i�\���p�j�̃f�[�^�̂����A�u���́v�񂩂�u��������z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }

        private void rbFixtures_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "�Y����i�ژ^�i�\���p�j�̃f�[�^�̂����A�u���́v�񂩂�u��������z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            this.lblProcedure.Text = "���̑��̍��Y�ژ^�i�\���p�j�̃f�[�^�̂����A�u���Y�̎�ށc�v�񂩂�u��������z�v��܂ł�I�����ăR�s�[���iCtrl+C�j�A�u���s�v�{�^���������Ă��������B" + "\r\n\r\n" + "������̑I�����\�ł��B";
            lblResult.Text = "";
        }
    }
}