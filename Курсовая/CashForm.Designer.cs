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
            label1 = new Label();
            SuspendLayout();
            // 
            // AddBillButton
            // 
            AddBillButton.Location = new Point(37, 285);
            AddBillButton.Name = "AddBillButton";
            AddBillButton.Size = new Size(75, 23);
            AddBillButton.TabIndex = 0;
            AddBillButton.Text = "button1";
            AddBillButton.UseVisualStyleBackColor = true;
            AddBillButton.Click += AddBillButton_Click;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(224, 285);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(75, 23);
            ConfirmButton.TabIndex = 1;
            ConfirmButton.Text = "button2";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // DenominationComboBox
            // 
            DenominationComboBox.FormattingEnabled = true;
            DenominationComboBox.Location = new Point(37, 75);
            DenominationComboBox.Name = "DenominationComboBox";
            DenominationComboBox.Size = new Size(121, 23);
            DenominationComboBox.TabIndex = 2;
            // 
            // InsertedBillsListBox
            // 
            InsertedBillsListBox.FormattingEnabled = true;
            InsertedBillsListBox.ItemHeight = 15;
            InsertedBillsListBox.Location = new Point(224, 75);
            InsertedBillsListBox.Name = "InsertedBillsListBox";
            InsertedBillsListBox.Size = new Size(120, 94);
            InsertedBillsListBox.TabIndex = 3;
            // 
            // TotalInsertedAmountLabel
            // 
            TotalInsertedAmountLabel.AutoSize = true;
            TotalInsertedAmountLabel.Location = new Point(37, 195);
            TotalInsertedAmountLabel.Name = "TotalInsertedAmountLabel";
            TotalInsertedAmountLabel.Size = new Size(38, 15);
            TotalInsertedAmountLabel.TabIndex = 4;
            TotalInsertedAmountLabel.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 37);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // CashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
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
        private Label label1;
    }
}