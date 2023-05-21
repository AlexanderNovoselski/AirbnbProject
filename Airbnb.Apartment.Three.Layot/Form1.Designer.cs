namespace Airbnb.Apartment.Three.Layot
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ItemDetailsBox = new GroupBox();
            BoughtItemBox = new TextBox();
            PriceTextBox = new TextBox();
            QuantityBox = new TextBox();
            ItemBox = new TextBox();
            BoughtPlaceLabel = new Label();
            PriceLabel = new Label();
            QuantityLabel = new Label();
            ItemNameLabel = new Label();
            SubmitButton = new Button();
            SumBox = new GroupBox();
            PrintButton = new Button();
            SumTextBox = new TextBox();
            TotalSumLabel = new Label();
            ListBox = new ListBox();
            splitter1 = new Splitter();
            AvailableItemsButton = new Button();
            ItemsLabel = new Label();
            ItemListLabel = new Label();
            NeededItems = new ListBox();
            NeededItemsButton = new Button();
            NeededListItems = new Label();
            ItemDetailsBox.SuspendLayout();
            SumBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemDetailsBox
            // 
            ItemDetailsBox.Controls.Add(BoughtItemBox);
            ItemDetailsBox.Controls.Add(PriceTextBox);
            ItemDetailsBox.Controls.Add(QuantityBox);
            ItemDetailsBox.Controls.Add(ItemBox);
            ItemDetailsBox.Controls.Add(BoughtPlaceLabel);
            ItemDetailsBox.Controls.Add(PriceLabel);
            ItemDetailsBox.Controls.Add(QuantityLabel);
            ItemDetailsBox.Controls.Add(ItemNameLabel);
            ItemDetailsBox.Location = new Point(24, 36);
            ItemDetailsBox.Name = "ItemDetailsBox";
            ItemDetailsBox.Size = new Size(284, 152);
            ItemDetailsBox.TabIndex = 0;
            ItemDetailsBox.TabStop = false;
            ItemDetailsBox.Text = "Item Details";
            // 
            // BoughtItemBox
            // 
            BoughtItemBox.Location = new Point(120, 103);
            BoughtItemBox.Name = "BoughtItemBox";
            BoughtItemBox.Size = new Size(100, 23);
            BoughtItemBox.TabIndex = 7;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(120, 74);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(100, 23);
            PriceTextBox.TabIndex = 6;
            // 
            // QuantityBox
            // 
            QuantityBox.Location = new Point(120, 45);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(100, 23);
            QuantityBox.TabIndex = 5;
            // 
            // ItemBox
            // 
            ItemBox.Location = new Point(120, 17);
            ItemBox.Name = "ItemBox";
            ItemBox.Size = new Size(100, 23);
            ItemBox.TabIndex = 4;
            ItemBox.TextChanged += textBox1_TextChanged;
            // 
            // BoughtPlaceLabel
            // 
            BoughtPlaceLabel.AutoSize = true;
            BoughtPlaceLabel.Location = new Point(12, 103);
            BoughtPlaceLabel.Name = "BoughtPlaceLabel";
            BoughtPlaceLabel.Size = new Size(75, 15);
            BoughtPlaceLabel.TabIndex = 3;
            BoughtPlaceLabel.Text = "Bought from";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(12, 74);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(33, 15);
            PriceLabel.TabIndex = 2;
            PriceLabel.Text = "Price";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(12, 45);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(53, 15);
            QuantityLabel.TabIndex = 1;
            QuantityLabel.Text = "Quantity";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Location = new Point(12, 20);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(66, 15);
            ItemNameLabel.TabIndex = 0;
            ItemNameLabel.Text = "Item Name";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(24, 204);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(168, 67);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // SumBox
            // 
            SumBox.Controls.Add(PrintButton);
            SumBox.Controls.Add(SumTextBox);
            SumBox.Controls.Add(TotalSumLabel);
            SumBox.Location = new Point(734, 46);
            SumBox.Name = "SumBox";
            SumBox.Size = new Size(169, 98);
            SumBox.TabIndex = 2;
            SumBox.TabStop = false;
            SumBox.Text = "Total";
            // 
            // PrintButton
            // 
            PrintButton.Location = new Point(94, 62);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(49, 23);
            PrintButton.TabIndex = 4;
            PrintButton.Text = "Print";
            PrintButton.UseVisualStyleBackColor = true;
            PrintButton.Click += PrintButton_Click;
            // 
            // SumTextBox
            // 
            SumTextBox.Location = new Point(94, 25);
            SumTextBox.Name = "SumTextBox";
            SumTextBox.Size = new Size(49, 23);
            SumTextBox.TabIndex = 1;
            // 
            // TotalSumLabel
            // 
            TotalSumLabel.AutoSize = true;
            TotalSumLabel.Location = new Point(18, 28);
            TotalSumLabel.Name = "TotalSumLabel";
            TotalSumLabel.Size = new Size(59, 15);
            TotalSumLabel.TabIndex = 0;
            TotalSumLabel.Text = "Total Sum";
            // 
            // ListBox
            // 
            ListBox.BackColor = SystemColors.GradientActiveCaption;
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 15;
            ListBox.Location = new Point(659, 369);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(115, 139);
            ListBox.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 597);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // AvailableItemsButton
            // 
            AvailableItemsButton.Location = new Point(659, 514);
            AvailableItemsButton.Name = "AvailableItemsButton";
            AvailableItemsButton.Size = new Size(75, 23);
            AvailableItemsButton.TabIndex = 6;
            AvailableItemsButton.Text = "On";
            AvailableItemsButton.UseVisualStyleBackColor = true;
            AvailableItemsButton.Click += ItemsButton_Click;
            // 
            // ItemsLabel
            // 
            ItemsLabel.Location = new Point(0, 0);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(100, 23);
            ItemsLabel.TabIndex = 9;
            // 
            // ItemListLabel
            // 
            ItemListLabel.AutoSize = true;
            ItemListLabel.BackColor = SystemColors.ButtonFace;
            ItemListLabel.Location = new Point(656, 351);
            ItemListLabel.Name = "ItemListLabel";
            ItemListLabel.Size = new Size(78, 15);
            ItemListLabel.TabIndex = 8;
            ItemListLabel.Text = "Bought Items";
            // 
            // NeededItems
            // 
            NeededItems.BackColor = SystemColors.GradientActiveCaption;
            NeededItems.FormattingEnabled = true;
            NeededItems.ItemHeight = 15;
            NeededItems.Location = new Point(800, 369);
            NeededItems.Name = "NeededItems";
            NeededItems.Size = new Size(120, 139);
            NeededItems.TabIndex = 10;
            // 
            // NeededItemsButton
            // 
            NeededItemsButton.Location = new Point(800, 514);
            NeededItemsButton.Name = "NeededItemsButton";
            NeededItemsButton.Size = new Size(75, 23);
            NeededItemsButton.TabIndex = 11;
            NeededItemsButton.Text = "On";
            NeededItemsButton.UseVisualStyleBackColor = true;
            // 
            // NeededListItems
            // 
            NeededListItems.AutoSize = true;
            NeededListItems.BackColor = SystemColors.ButtonFace;
            NeededListItems.Location = new Point(795, 351);
            NeededListItems.Name = "NeededListItems";
            NeededListItems.Size = new Size(80, 15);
            NeededListItems.TabIndex = 12;
            NeededListItems.Text = "Needed Items";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(932, 597);
            Controls.Add(NeededListItems);
            Controls.Add(NeededItemsButton);
            Controls.Add(NeededItems);
            Controls.Add(ItemListLabel);
            Controls.Add(ItemsLabel);
            Controls.Add(AvailableItemsButton);
            Controls.Add(splitter1);
            Controls.Add(ListBox);
            Controls.Add(SumBox);
            Controls.Add(SubmitButton);
            Controls.Add(ItemDetailsBox);
            Name = "Form1";
            Text = "Airbnb Apartment";
            ItemDetailsBox.ResumeLayout(false);
            ItemDetailsBox.PerformLayout();
            SumBox.ResumeLayout(false);
            SumBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox ItemDetailsBox;
        private Label ItemNameLabel;
        private Label BoughtPlaceLabel;
        private Label PriceLabel;
        private Label QuantityLabel;
        private TextBox BoughtItemBox;
        private TextBox PriceTextBox;
        private TextBox QuantityBox;
        private TextBox ItemBox;
        private Button SubmitButton;
        private GroupBox SumBox;
        private TextBox SumTextBox;
        private Label TotalSumLabel;
        private Button PrintButton;
        private ListBox ListBox;
        private Splitter splitter1;
        private Button AvailableItemsButton;
        private Label ItemsLabel;
        private Label ItemListLabel;
        private ListBox NeededItems;
        private Button NeededItemsButton;
        private Label NeededListItems;
    }
}