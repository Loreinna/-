namespace Курсовая
{
    partial class CashForm
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
            AddBillButton = new Button();
            ConfirmButton = new Button();
            DenominationComboBox = new ComboBox();
            InsertedBillsListBox = new ListBox();
            TotalInsertedAmountLabel = new Label();
            TotalLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // AddBillButton
            // 
            AddBillButton.Location = new Point(323, 12);
            AddBillButton.Name = "AddBillButton";
            AddBillButton.Size = new Size(105, 49);
            AddBillButton.TabIndex = 0;
            AddBillButton.Text = "Вставить купюру";
            AddBillButton.UseVisualStyleBackColor = true;
            AddBillButton.Click += AddBillButton_Click;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(161, 290);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(161, 81);
            ConfirmButton.TabIndex = 1;
            ConfirmButton.Text = "Подтвердить оплату";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // DenominationComboBox
            // 
            DenominationComboBox.FormattingEnabled = true;
            DenominationComboBox.Location = new Point(182, 33);
            DenominationComboBox.Name = "DenominationComboBox";
            DenominationComboBox.Size = new Size(121, 23);
            DenominationComboBox.TabIndex = 2;
            // 
            // InsertedBillsListBox
            // 
            InsertedBillsListBox.FormattingEnabled = true;
            InsertedBillsListBox.ItemHeight = 15;
            InsertedBillsListBox.Location = new Point(25, 150);
            InsertedBillsListBox.Name = "InsertedBillsListBox";
            InsertedBillsListBox.Size = new Size(131, 94);
            InsertedBillsListBox.TabIndex = 3;
            // 
            // TotalInsertedAmountLabel
            // 
            TotalInsertedAmountLabel.AutoSize = true;
            TotalInsertedAmountLabel.Location = new Point(30, 257);
            TotalInsertedAmountLabel.Name = "TotalInsertedAmountLabel";
            TotalInsertedAmountLabel.Size = new Size(25, 15);
            TotalInsertedAmountLabel.TabIndex = 4;
            TotalInsertedAmountLabel.Text = "123";
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalLabel.Location = new Point(214, 80);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(52, 21);
            TotalLabel.TabIndex = 5;
            TotalLabel.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 31);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 6;
            label1.Text = "Вставьте купюру";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 121);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 7;
            label2.Text = "Вставленные купюры";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 80);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 8;
            label3.Text = "Сумма к оплате";
            // 
            // CashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 395);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TotalLabel);
            Controls.Add(TotalInsertedAmountLabel);
            Controls.Add(InsertedBillsListBox);
            Controls.Add(DenominationComboBox);
            Controls.Add(ConfirmButton);
            Controls.Add(AddBillButton);
            Name = "CashForm";
            Text = "PaymentFormCash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBillButton;
        private Button ConfirmButton;
        private ComboBox DenominationComboBox;
        private ListBox InsertedBillsListBox;
        private Label TotalInsertedAmountLabel;
        private Label TotalLabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}