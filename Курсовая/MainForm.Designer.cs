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
            ProductInfoTextBox = new TextBox();
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
            AddToBasketButton.Location = new Point(14, 711);
            AddToBasketButton.Margin = new Padding(3, 4, 3, 4);
            AddToBasketButton.Name = "AddToBasketButton";
            AddToBasketButton.Size = new Size(183, 89);
            AddToBasketButton.TabIndex = 0;
            AddToBasketButton.Text = "Добавить в корзину";
            AddToBasketButton.UseVisualStyleBackColor = true;
            AddToBasketButton.Click += AddToCartButton_Click;
            // 
            // DeleteFromBasketButton
            // 
            DeleteFromBasketButton.Location = new Point(219, 711);
            DeleteFromBasketButton.Margin = new Padding(3, 4, 3, 4);
            DeleteFromBasketButton.Name = "DeleteFromBasketButton";
            DeleteFromBasketButton.Size = new Size(183, 89);
            DeleteFromBasketButton.TabIndex = 1;
            DeleteFromBasketButton.Text = "Удалить из корзины";
            DeleteFromBasketButton.UseVisualStyleBackColor = true;
            DeleteFromBasketButton.Click += RemoveFromCartButton_Click;
            // 
            // PayButton
            // 
            PayButton.Location = new Point(1029, 711);
            PayButton.Margin = new Padding(3, 4, 3, 4);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(161, 89);
            PayButton.TabIndex = 2;
            PayButton.Text = "Оплатить";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // ProductList
            // 
            ProductList.FormattingEnabled = true;
            ProductList.ItemHeight = 20;
            ProductList.Location = new Point(15, 116);
            ProductList.Margin = new Padding(3, 4, 3, 4);
            ProductList.Name = "ProductList";
            ProductList.Size = new Size(387, 564);
            ProductList.TabIndex = 3;
            ProductList.SelectedIndexChanged += ProductList_SelectedIndexChanged;
            // 
            // ShoppingCartList
            // 
            ShoppingCartList.FormattingEnabled = true;
            ShoppingCartList.ItemHeight = 20;
            ShoppingCartList.Location = new Point(970, 116);
            ShoppingCartList.Margin = new Padding(3, 4, 3, 4);
            ShoppingCartList.Name = "ShoppingCartList";
            ShoppingCartList.SelectionMode = SelectionMode.None;
            ShoppingCartList.Size = new Size(246, 444);
            ShoppingCartList.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(970, 589);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 5;
            label1.Text = "ИТОГО:";
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalAmountLabel.Location = new Point(970, 648);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(171, 28);
            TotalAmountLabel.TabIndex = 6;
            TotalAmountLabel.Text = "TotalAmountLabel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(456, 16);
            label2.Name = "label2";
            label2.Size = new Size(589, 91);
            label2.TabIndex = 8;
            label2.Text = "Best Shop Ever";
            // 
            // BudgetLabel
            // 
            BudgetLabel.AutoSize = true;
            BudgetLabel.Location = new Point(11, 25);
            BudgetLabel.Name = "BudgetLabel";
            BudgetLabel.Size = new Size(50, 20);
            BudgetLabel.TabIndex = 9;
            BudgetLabel.Text = "label3";
            // 
            // button1
            // 
            button1.Location = new Point(237, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(166, 52);
            button1.TabIndex = 10;
            button1.Text = "Пополнить баланс";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 71);
            label3.Name = "label3";
            label3.Size = new Size(151, 39);
            label3.TabIndex = 11;
            label3.Text = "Products";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(970, 71);
            label4.Name = "label4";
            label4.Size = new Size(105, 36);
            label4.TabIndex = 12;
            label4.Text = "Basket";
            // 
            // WeighButton
            // 
            WeighButton.Location = new Point(427, 711);
            WeighButton.Margin = new Padding(3, 4, 3, 4);
            WeighButton.Name = "WeighButton";
            WeighButton.Size = new Size(149, 89);
            WeighButton.TabIndex = 13;
            WeighButton.Text = "Взвесить";
            WeighButton.UseVisualStyleBackColor = true;
            WeighButton.Click += WeighButton_Click;
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.Location = new Point(575, 116);
            ProductPictureBox.Margin = new Padding(3, 4, 3, 4);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(339, 432);
            ProductPictureBox.TabIndex = 14;
            ProductPictureBox.TabStop = false;
            // 
            // ProductInfoTextBox
            // 
            ProductInfoTextBox.Location = new Point(575, 587);
            ProductInfoTextBox.Margin = new Padding(3, 4, 3, 4);
            ProductInfoTextBox.Multiline = true;
            ProductInfoTextBox.Name = "ProductInfoTextBox";
            ProductInfoTextBox.Size = new Size(339, 88);
            ProductInfoTextBox.TabIndex = 7;
            // 
            // QuantityNumericUpDown
            // 
            QuantityNumericUpDown.Location = new Point(416, 148);
            QuantityNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            QuantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            QuantityNumericUpDown.Size = new Size(137, 27);
            QuantityNumericUpDown.TabIndex = 15;
            QuantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(409, 116);
            label5.Name = "label5";
            label5.Size = new Size(169, 28);
            label5.TabIndex = 16;
            label5.Text = "Количество штук";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(970, 25);
            label6.Name = "label6";
            label6.Size = new Size(168, 20);
            label6.TabIndex = 17;
            label6.Text = "Ваши бонусные баллы";
            // 
            // BonusLabel
            // 
            BonusLabel.AutoSize = true;
            BonusLabel.Location = new Point(1146, 25);
            BonusLabel.Name = "BonusLabel";
            BonusLabel.Size = new Size(50, 20);
            BonusLabel.TabIndex = 18;
            BonusLabel.Text = "label7";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 845);
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
            Controls.Add(ProductInfoTextBox);
            Controls.Add(TotalAmountLabel);
            Controls.Add(label1);
            Controls.Add(ShoppingCartList);
            Controls.Add(ProductList);
            Controls.Add(PayButton);
            Controls.Add(DeleteFromBasketButton);
            Controls.Add(AddToBasketButton);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox ProductInfoTextBox;
        private NumericUpDown QuantityNumericUpDown;
        private Label label5;
        private Label label6;
        private Label BonusLabel;
    }
}