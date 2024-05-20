namespace Курсовая
{
    partial class CvcVerificationForm
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
            panel1 = new Panel();
            label2 = new Label();
            CvcTextBox = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            ConfirmButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(371, 60);
            label1.TabIndex = 0;
            label1.Text = "Введите последние три цифры \r\nна обратной стороне вашей карты\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CvcTextBox);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 253);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(252, 122);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "CVV/CVC";
            // 
            // CvcTextBox
            // 
            CvcTextBox.BackColor = Color.RosyBrown;
            CvcTextBox.Location = new Point(327, 123);
            CvcTextBox.Name = "CvcTextBox";
            CvcTextBox.Size = new Size(126, 23);
            CvcTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(14, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 54);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(12, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 49);
            panel2.TabIndex = 2;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(178, 367);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(167, 60);
            ConfirmButton.TabIndex = 4;
            ConfirmButton.Text = "Подтвердить";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // CvcVerificationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(524, 439);
            Controls.Add(ConfirmButton);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "CvcVerificationForm";
            Text = "PaymentFormCard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private TextBox CvcTextBox;
        private Label label2;
        private Button ConfirmButton;
    }
}