namespace PropertyFormConverter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ckNumbering = new CheckBox();
            rbOther = new RadioButton();
            rbFixtures = new RadioButton();
            rbMachine = new RadioButton();
            rbStock = new RadioButton();
            rbLoan = new RadioButton();
            rbReceivable = new RadioButton();
            lblProcedure = new Label();
            groupBox1 = new GroupBox();
            rbBank = new RadioButton();
            rbInsurance = new RadioButton();
            rbCar = new RadioButton();
            rbCheck = new RadioButton();
            rbDeposit = new RadioButton();
            rbSecurities = new RadioButton();
            rbRetirement = new RadioButton();
            rbRealestate = new RadioButton();
            rbOverpayment = new RadioButton();
            btnCancel = new Button();
            btnExec = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            lblResult = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // ckNumbering
            // 
            ckNumbering.AutoSize = true;
            ckNumbering.Checked = true;
            ckNumbering.CheckState = CheckState.Checked;
            ckNumbering.Location = new Point(21, 460);
            ckNumbering.Margin = new Padding(4);
            ckNumbering.Name = "ckNumbering";
            ckNumbering.Size = new Size(135, 19);
            ckNumbering.TabIndex = 19;
            ckNumbering.Text = "冒頭に枝番を付加する";
            ckNumbering.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(301, 133);
            rbOther.Margin = new Padding(4);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(90, 19);
            rbOther.TabIndex = 14;
            rbOther.TabStop = true;
            rbOther.Text = "その他の財産";
            rbOther.UseVisualStyleBackColor = true;
            rbOther.CheckedChanged += rbOther_CheckedChanged;
            // 
            // rbFixtures
            // 
            rbFixtures.AutoSize = true;
            rbFixtures.Location = new Point(301, 106);
            rbFixtures.Margin = new Padding(4);
            rbFixtures.Name = "rbFixtures";
            rbFixtures.Size = new Size(73, 19);
            rbFixtures.TabIndex = 13;
            rbFixtures.TabStop = true;
            rbFixtures.Text = "什器備品";
            rbFixtures.UseVisualStyleBackColor = true;
            rbFixtures.CheckedChanged += rbFixtures_CheckedChanged;
            // 
            // rbMachine
            // 
            rbMachine.AutoSize = true;
            rbMachine.Location = new Point(301, 79);
            rbMachine.Margin = new Padding(4);
            rbMachine.Name = "rbMachine";
            rbMachine.Size = new Size(91, 19);
            rbMachine.TabIndex = 12;
            rbMachine.TabStop = true;
            rbMachine.Text = "機械・工具類";
            rbMachine.UseVisualStyleBackColor = true;
            rbMachine.CheckedChanged += rbMachine_CheckedChanged;
            // 
            // rbStock
            // 
            rbStock.AutoSize = true;
            rbStock.Location = new Point(301, 51);
            rbStock.Margin = new Padding(4);
            rbStock.Name = "rbStock";
            rbStock.Size = new Size(73, 19);
            rbStock.TabIndex = 11;
            rbStock.TabStop = true;
            rbStock.Text = "在庫商品";
            rbStock.UseVisualStyleBackColor = true;
            rbStock.CheckedChanged += rbStock_CheckedChanged;
            // 
            // rbLoan
            // 
            rbLoan.AutoSize = true;
            rbLoan.Location = new Point(301, 23);
            rbLoan.Margin = new Padding(4);
            rbLoan.Name = "rbLoan";
            rbLoan.Size = new Size(61, 19);
            rbLoan.TabIndex = 10;
            rbLoan.TabStop = true;
            rbLoan.Text = "貸付金";
            rbLoan.UseVisualStyleBackColor = true;
            rbLoan.CheckedChanged += rbLoan_CheckedChanged;
            // 
            // rbReceivable
            // 
            rbReceivable.AutoSize = true;
            rbReceivable.Location = new Point(171, 133);
            rbReceivable.Margin = new Padding(4);
            rbReceivable.Name = "rbReceivable";
            rbReceivable.Size = new Size(61, 19);
            rbReceivable.TabIndex = 9;
            rbReceivable.TabStop = true;
            rbReceivable.Text = "売掛金";
            rbReceivable.UseVisualStyleBackColor = true;
            rbReceivable.CheckedChanged += rbReceivable_CheckedChanged;
            // 
            // lblProcedure
            // 
            lblProcedure.AutoEllipsis = true;
            lblProcedure.Location = new Point(8, 19);
            lblProcedure.Margin = new Padding(4, 0, 4, 0);
            lblProcedure.Name = "lblProcedure";
            lblProcedure.Size = new Size(399, 150);
            lblProcedure.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbFixtures);
            groupBox1.Controls.Add(rbMachine);
            groupBox1.Controls.Add(rbStock);
            groupBox1.Controls.Add(rbLoan);
            groupBox1.Controls.Add(rbReceivable);
            groupBox1.Controls.Add(rbBank);
            groupBox1.Controls.Add(rbInsurance);
            groupBox1.Controls.Add(rbCar);
            groupBox1.Controls.Add(rbCheck);
            groupBox1.Controls.Add(rbDeposit);
            groupBox1.Controls.Add(rbSecurities);
            groupBox1.Controls.Add(rbRetirement);
            groupBox1.Controls.Add(rbRealestate);
            groupBox1.Controls.Add(rbOverpayment);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(414, 160);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "コピーしたデータの種類";
            // 
            // rbBank
            // 
            rbBank.AutoSize = true;
            rbBank.Location = new Point(8, 23);
            rbBank.Margin = new Padding(4);
            rbBank.Name = "rbBank";
            rbBank.Size = new Size(103, 19);
            rbBank.TabIndex = 0;
            rbBank.TabStop = true;
            rbBank.Text = "預貯金・積立金";
            rbBank.UseVisualStyleBackColor = true;
            rbBank.CheckedChanged += rbBank_CheckedChanged;
            // 
            // rbInsurance
            // 
            rbInsurance.AutoSize = true;
            rbInsurance.Location = new Point(8, 51);
            rbInsurance.Margin = new Padding(4);
            rbInsurance.Name = "rbInsurance";
            rbInsurance.Size = new Size(49, 19);
            rbInsurance.TabIndex = 1;
            rbInsurance.TabStop = true;
            rbInsurance.Text = "保険";
            rbInsurance.UseVisualStyleBackColor = true;
            rbInsurance.CheckedChanged += rbInsurance_CheckedChanged;
            // 
            // rbCar
            // 
            rbCar.AutoSize = true;
            rbCar.Location = new Point(8, 79);
            rbCar.Margin = new Padding(4);
            rbCar.Name = "rbCar";
            rbCar.Size = new Size(61, 19);
            rbCar.TabIndex = 2;
            rbCar.TabStop = true;
            rbCar.Text = "自動車";
            rbCar.UseVisualStyleBackColor = true;
            rbCar.CheckedChanged += rbCar_CheckedChanged;
            // 
            // rbCheck
            // 
            rbCheck.AutoSize = true;
            rbCheck.Location = new Point(171, 106);
            rbCheck.Margin = new Padding(4);
            rbCheck.Name = "rbCheck";
            rbCheck.Size = new Size(91, 19);
            rbCheck.TabIndex = 8;
            rbCheck.TabStop = true;
            rbCheck.Text = "手形・小切手";
            rbCheck.UseVisualStyleBackColor = true;
            rbCheck.CheckedChanged += rbCheck_CheckedChanged;
            // 
            // rbDeposit
            // 
            rbDeposit.AutoSize = true;
            rbDeposit.Location = new Point(8, 106);
            rbDeposit.Margin = new Padding(4);
            rbDeposit.Name = "rbDeposit";
            rbDeposit.Size = new Size(115, 19);
            rbDeposit.TabIndex = 3;
            rbDeposit.TabStop = true;
            rbDeposit.Text = "賃借保証金・敷金";
            rbDeposit.UseVisualStyleBackColor = true;
            rbDeposit.CheckedChanged += rbDeposit_CheckedChanged;
            // 
            // rbSecurities
            // 
            rbSecurities.AutoSize = true;
            rbSecurities.Location = new Point(171, 79);
            rbSecurities.Margin = new Padding(4);
            rbSecurities.Name = "rbSecurities";
            rbSecurities.Size = new Size(73, 19);
            rbSecurities.TabIndex = 7;
            rbSecurities.TabStop = true;
            rbSecurities.Text = "有価証券";
            rbSecurities.UseVisualStyleBackColor = true;
            rbSecurities.CheckedChanged += rbSecurities_CheckedChanged;
            // 
            // rbRetirement
            // 
            rbRetirement.AutoSize = true;
            rbRetirement.Location = new Point(8, 133);
            rbRetirement.Margin = new Padding(4);
            rbRetirement.Name = "rbRetirement";
            rbRetirement.Size = new Size(61, 19);
            rbRetirement.TabIndex = 4;
            rbRetirement.TabStop = true;
            rbRetirement.Text = "退職金";
            rbRetirement.UseVisualStyleBackColor = true;
            rbRetirement.CheckedChanged += rbRetirement_CheckedChanged;
            // 
            // rbRealestate
            // 
            rbRealestate.AutoSize = true;
            rbRealestate.Location = new Point(171, 51);
            rbRealestate.Margin = new Padding(4);
            rbRealestate.Name = "rbRealestate";
            rbRealestate.Size = new Size(61, 19);
            rbRealestate.TabIndex = 6;
            rbRealestate.TabStop = true;
            rbRealestate.Text = "不動産";
            rbRealestate.UseVisualStyleBackColor = true;
            rbRealestate.CheckedChanged += rbRealestate_CheckedChanged;
            // 
            // rbOverpayment
            // 
            rbOverpayment.AutoSize = true;
            rbOverpayment.Location = new Point(171, 23);
            rbOverpayment.Margin = new Padding(4);
            rbOverpayment.Name = "rbOverpayment";
            rbOverpayment.Size = new Size(61, 19);
            rbOverpayment.TabIndex = 5;
            rbOverpayment.TabStop = true;
            rbOverpayment.Text = "過払金";
            rbOverpayment.UseVisualStyleBackColor = true;
            rbOverpayment.CheckedChanged += rbOverpayment_CheckedChanged;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(319, 451);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 35);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "閉じる";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExec
            // 
            btnExec.Location = new Point(202, 451);
            btnExec.Margin = new Padding(4);
            btnExec.Name = "btnExec";
            btnExec.Size = new Size(111, 35);
            btnExec.TabIndex = 15;
            btnExec.Text = "実行";
            btnExec.UseVisualStyleBackColor = true;
            btnExec.Click += btnExec_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblProcedure);
            groupBox2.Location = new Point(13, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(414, 180);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "操作手順";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblResult);
            groupBox3.Location = new Point(13, 366);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(414, 78);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "結果";
            // 
            // lblResult
            // 
            lblResult.AutoEllipsis = true;
            lblResult.Location = new Point(8, 19);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(399, 56);
            lblResult.TabIndex = 18;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 495);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(ckNumbering);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnExec);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "クリップボードにコピーしたデータの成形";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ckNumbering;
        private RadioButton rbOther;
        private RadioButton rbFixtures;
        private RadioButton rbMachine;
        private RadioButton rbStock;
        private RadioButton rbLoan;
        private RadioButton rbReceivable;
        private Label lblProcedure;
        private GroupBox groupBox1;
        private RadioButton rbBank;
        private RadioButton rbInsurance;
        private RadioButton rbCar;
        private RadioButton rbCheck;
        private RadioButton rbDeposit;
        private RadioButton rbSecurities;
        private RadioButton rbRetirement;
        private RadioButton rbRealestate;
        private RadioButton rbOverpayment;
        private Button btnCancel;
        private Button btnExec;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblResult;
    }
}