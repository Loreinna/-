namespace Курсовая
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TotalAmountLabel = new Label();
            CashRadioButton = new RadioButton();
            CardRadioButton = new RadioButton();
            BonusRadioButton = new RadioButton();
            PayButton = new Button();
            label2 = new Label();
            BudgetLabel = new Label();
            PayPartRadioButton = new RadioButton();
            CashAmountTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            CardAmountTextBox = new TextBox();
            BonusLabel = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 0;
            label1.Text = "Сумма к оплате";
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TotalAmountLabel.Location = new Point(249, 19);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(78, 32);
            TotalAmountLabel.TabIndex = 1;
            TotalAmountLabel.Text = "label2";
            // 
            // CashRadioButton
            // 
            CashRadioButton.AutoSize = true;
            CashRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CashRadioButton.Location = new Point(63, 171);
            CashRadioButton.Name = "CashRadioButton";
            CashRadioButton.Size = new Size(167, 25);
            CashRadioButton.TabIndex = 2;
            CashRadioButton.TabStop = true;
            CashRadioButton.Text = "Оплата наличными";
            CashRadioButton.UseVisualStyleBackColor = true;
            // 
            // CardRadioButton
            // 
            CardRadioButton.AutoSize = true;
            CardRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CardRadioButton.Location = new Point(63, 211);
            CardRadioButton.Name = "CardRadioButton";
            CardRadioButton.Size = new Size(134, 25);
            CardRadioButton.TabIndex = 3;
            CardRadioButton.TabStop = true;
            CardRadioButton.Text = "Оплата картой";
            CardRadioButton.UseVisualStyleBackColor = true;
            // 
            // BonusRadioButton
            // 
            BonusRadioButton.AutoSize = true;
            BonusRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BonusRadioButton.Location = new Point(63, 250);
            BonusRadioButton.Name = "BonusRadioButton";
            BonusRadioButton.Size = new Size(154, 25);
            BonusRadioButton.TabIndex = 4;
            BonusRadioButton.TabStop = true;
            BonusRadioButton.Text = "Оплата бонусами";
            BonusRadioButton.UseVisualStyleBackColor = true;
            // 
            // PayButton
            // 
            PayButton.Location = new Point(196, 351);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(180, 69);
            PayButton.TabIndex = 5;
            PayButton.Text = "Оплатить";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 69);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 6;
            label2.Text = "Ваш баланс";
            // 
            // BudgetLabel
            // 
            BudgetLabel.AutoSize = true;
            BudgetLabel.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BudgetLabel.Location = new Point(249, 69);
            BudgetLabel.Name = "BudgetLabel";
            BudgetLabel.Size = new Size(78, 32);
            BudgetLabel.TabIndex = 7;
            BudgetLabel.Text = "label3";
            // 
            // PayPartRadioButton
            // 
            PayPartRadioButton.AutoSize = true;
            PayPartRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PayPartRadioButton.Location = new Point(63, 292);
            PayPartRadioButton.Margin = new Padding(3, 2, 3, 2);
            PayPartRadioButton.Name = "PayPartRadioButton";
            PayPartRadioButton.Size = new Size(143, 25);
            PayPartRadioButton.TabIndex = 8;
            PayPartRadioButton.TabStop = true;
            PayPartRadioButton.Text = "Оплата частями";
            PayPartRadioButton.UseVisualStyleBackColor = true;
            // 
            // CashAmountTextBox
            // 
            CashAmountTextBox.Location = new Point(264, 296);
            CashAmountTextBox.Name = "CashAmountTextBox";
            CashAmountTextBox.Size = new Size(100, 23);
            CashAmountTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 272);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 10;
            label3.Text = "Сумма наличными";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 272);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 11;
            label4.Text = "Сумма картой";
            // 
            // CardAmountTextBox
            // 
            CardAmountTextBox.Location = new Point(391, 296);
            CardAmountTextBox.Name = "CardAmountTextBox";
            CardAmountTextBox.Size = new Size(100, 23);
            CardAmountTextBox.TabIndex = 12;
            // 
            // BonusLabel
            // 
            BonusLabel.AutoSize = true;
            BonusLabel.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BonusLabel.Location = new Point(387, 108);
            BonusLabel.Name = "BonusLabel";
            BonusLabel.Size = new Size(78, 32);
            BonusLabel.TabIndex = 13;
            BonusLabel.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 108);
            label6.Name = "label6";
            label6.Size = new Size(343, 32);
            label6.TabIndex = 14;
            label6.Text = "Количество ваших бонусов";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 432);
            Controls.Add(label6);
            Controls.Add(BonusLabel);
            Controls.Add(CardAmountTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CashAmountTextBox);
            Controls.Add(PayPartRadioButton);
            Controls.Add(BudgetLabel);
            Controls.Add(label2);
            Controls.Add(PayButton);
            Controls.Add(BonusRadioButton);
            Controls.Add(CardRadioButton);
            Controls.Add(CashRadioButton);
            Controls.Add(TotalAmountLabel);
            Controls.Add(label1);
            Name = "PaymentForm";
            Text = "PaymentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label TotalAmountLabel;
        private RadioButton CashRadioButton;
        private RadioButton CardRadioButton;
        private RadioButton BonusRadioButton;
        private Button PayButton;
        private Label label2;
        private Label BudgetLabel;
        private RadioButton PayPartRadioButton;
        private TextBox CashAmountTextBox;
        private Label label3;
        private Label label4;
        private TextBox CardAmountTextBox;
        private Label BonusLabel;
        private Label label6;
    }
}