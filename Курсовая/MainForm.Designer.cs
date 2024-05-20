namespace Курсовая
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
        public void InitializeComponent()
        {
            AddToBasketButton = new Button();
            DeleteFromBasketButton = new Button();
            PayButton = new Button();
            ProductList = new ListBox();
            ShoppingCartList = new ListBox();
            label1 = new Label();
            TotalAmountLabel = new Label();
            label2 = new Label();
            BudgetLabel = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            WeighButton = new Button();
            ProductPictureBox = new PictureBox();
            QuantityNumericUpDown = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            BonusLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // AddToBasketButton
            // 
            AddToBasketButton.Location = new Point(12, 533);
            AddToBasketButton.Name = "AddToBasketButton";
            AddToBasketButton.Size = new Size(160, 67);
            AddToBasketButton.TabIndex = 0;
            AddToBasketButton.Text = "Добавить в корзину";
            AddToBasketButton.UseVisualStyleBackColor = true;
            AddToBasketButton.Click += AddToCartButton_Click;
            // 
            // DeleteFromBasketButton
            // 
            DeleteFromBasketButton.Location = new Point(192, 533);
            DeleteFromBasketButton.Name = "DeleteFromBasketButton";
            DeleteFromBasketButton.Size = new Size(160, 67);
            DeleteFromBasketButton.TabIndex = 1;
            DeleteFromBasketButton.Text = "Удалить из корзины";
            DeleteFromBasketButton.UseVisualStyleBackColor = true;
            DeleteFromBasketButton.Click += RemoveFromCartButton_Click;
            // 
            // PayButton
            // 
            PayButton.Location = new Point(887, 533);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(141, 67);
            PayButton.TabIndex = 2;
            PayButton.Text = "Оплатить";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // ProductList
            // 
            ProductList.FormattingEnabled = true;
            ProductList.ItemHeight = 15;
            ProductList.Location = new Point(13, 87);
            ProductList.Name = "ProductList";
            ProductList.Size = new Size(339, 424);
            ProductList.TabIndex = 3;
            ProductList.SelectedIndexChanged += ProductList_SelectedIndexChanged;
            // 
            // ShoppingCartList
            // 
            ShoppingCartList.FormattingEnabled = true;
            ShoppingCartList.ItemHeight = 15;
            ShoppingCartList.Location = new Point(849, 87);
            ShoppingCartList.Name = "ShoppingCartList";
            ShoppingCartList.SelectionMode = SelectionMode.None;
            ShoppingCartList.Size = new Size(216, 334);
            ShoppingCartList.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(849, 452);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 5;
            label1.Text = "ИТОГО:";
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalAmountLabel.Location = new Point(849, 473);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(135, 21);
            TotalAmountLabel.TabIndex = 6;
            TotalAmountLabel.Text = "TotalAmountLabel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(385, 2);
            label2.Name = "label2";
            label2.Size = new Size(432, 80);
            label2.TabIndex = 8;
            label2.Text = "Best Shop Ever";
            // 
            // BudgetLabel
            // 
            BudgetLabel.AutoSize = true;
            BudgetLabel.Location = new Point(10, 19);
            BudgetLabel.Name = "BudgetLabel";
            BudgetLabel.Size = new Size(31, 15);
            BudgetLabel.TabIndex = 9;
            BudgetLabel.Text = "2344";
            // 
            // button1
            // 
            button1.Location = new Point(207, 12);
            button1.Name = "button1";
            button1.Size = new Size(145, 39);
            button1.TabIndex = 10;
            button1.Text = "Пополнить баланс";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 40);
            label3.Name = "label3";
            label3.Size = new Size(115, 34);
            label3.TabIndex = 11;
            label3.Text = "Products";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(849, 45);
            label4.Name = "label4";
            label4.Size = new Size(79, 29);
            label4.TabIndex = 12;
            label4.Text = "Basket";
            // 
            // WeighButton
            // 
            WeighButton.Location = new Point(374, 533);
            WeighButton.Name = "WeighButton";
            WeighButton.Size = new Size(130, 67);
            WeighButton.TabIndex = 13;
            WeighButton.Text = "Взвесить";
            WeighButton.UseVisualStyleBackColor = true;
            WeighButton.Click += WeighButton_Click;
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.Location = new Point(385, 140);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(321, 371);
            ProductPictureBox.TabIndex = 14;
            ProductPictureBox.TabStop = false;
            // 
            // QuantityNumericUpDown
            // 
            QuantityNumericUpDown.Location = new Point(384, 111);
            QuantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            QuantityNumericUpDown.Size = new Size(120, 23);
            QuantityNumericUpDown.TabIndex = 15;
            QuantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(378, 87);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 16;
            label5.Text = "Количество штук";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(849, 19);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 17;
            label6.Text = "Ваши бонусные баллы";
            // 
            // BonusLabel
            // 
            BonusLabel.AutoSize = true;
            BonusLabel.Location = new Point(1003, 19);
            BonusLabel.Name = "BonusLabel";
            BonusLabel.Size = new Size(37, 15);
            BonusLabel.TabIndex = 18;
            BonusLabel.Text = "42344";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1107, 634);
            Controls.Add(BonusLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(QuantityNumericUpDown);
            Controls.Add(ProductPictureBox);
            Controls.Add(WeighButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(BudgetLabel);
            Controls.Add(label2);
            Controls.Add(TotalAmountLabel);
            Controls.Add(label1);
            Controls.Add(ShoppingCartList);
            Controls.Add(ProductList);
            Controls.Add(PayButton);
            Controls.Add(DeleteFromBasketButton);
            Controls.Add(AddToBasketButton);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddToBasketButton;
        private Button DeleteFromBasketButton;
        private Button PayButton;
        private ListBox ProductList;
        private ListBox ShoppingCartList;
        private Label label1;
        private Label TotalAmountLabel;
        private Label label2;
        private Label BudgetLabel;
        private Button button1;
        private Label label3;
        private Label label4;
        private Button WeighButton;
        private PictureBox ProductPictureBox;
        private NumericUpDown QuantityNumericUpDown;
        private Label label5;
        private Label label6;
        private Label BonusLabel;
    }
}