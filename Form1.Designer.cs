namespace ThomureWeek8Task1
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
            FridgeContentsListBox = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            UpdateFridgeContentsSubmitButton = new Button();
            UpdateFridgeContentsNumeric = new NumericUpDown();
            textBox1 = new TextBox();
            groupBox4 = new GroupBox();
            label8 = new Label();
            AddNewItemsSubmitButton = new Button();
            AddNewItemsExpirationDate = new DateTimePicker();
            AddNewItemsInitialUnitsNumeric = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            AddNewItemsNameText = new TextBox();
            groupBox6 = new GroupBox();
            textBox4 = new TextBox();
            DeleteSubmitButton = new Button();
            groupBox3 = new GroupBox();
            label1 = new Label();
            label4 = new Label();
            GroceryListBox = new CheckedListBox();
            groupBox5 = new GroupBox();
            GroceryListAlarmCreatorSubmitButton = new Button();
            GroceryListAlarmCreatorNumeric = new NumericUpDown();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpdateFridgeContentsNumeric).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddNewItemsInitialUnitsNumeric).BeginInit();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GroceryListAlarmCreatorNumeric).BeginInit();
            SuspendLayout();
            // 
            // FridgeContentsListBox
            // 
            FridgeContentsListBox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FridgeContentsListBox.FormattingEnabled = true;
            FridgeContentsListBox.Location = new Point(6, 48);
            FridgeContentsListBox.Name = "FridgeContentsListBox";
            FridgeContentsListBox.Size = new Size(332, 420);
            FridgeContentsListBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Items";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 29);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "Units";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(FridgeContentsListBox);
            groupBox1.Location = new Point(31, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 505);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fridge Contents";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(157, 30);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 9;
            label7.Text = "Expiration Date";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(UpdateFridgeContentsSubmitButton);
            groupBox2.Controls.Add(UpdateFridgeContentsNumeric);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(382, 288);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 111);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Fridge Contents Units";
            // 
            // UpdateFridgeContentsSubmitButton
            // 
            UpdateFridgeContentsSubmitButton.Cursor = Cursors.Hand;
            UpdateFridgeContentsSubmitButton.Location = new Point(119, 80);
            UpdateFridgeContentsSubmitButton.Name = "UpdateFridgeContentsSubmitButton";
            UpdateFridgeContentsSubmitButton.Size = new Size(75, 23);
            UpdateFridgeContentsSubmitButton.TabIndex = 3;
            UpdateFridgeContentsSubmitButton.Text = "Submit";
            UpdateFridgeContentsSubmitButton.UseVisualStyleBackColor = true;
            UpdateFridgeContentsSubmitButton.Click += UpdateFridgeContentsSubmitButton_Click;
            // 
            // UpdateFridgeContentsNumeric
            // 
            UpdateFridgeContentsNumeric.Location = new Point(6, 80);
            UpdateFridgeContentsNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpdateFridgeContentsNumeric.Name = "UpdateFridgeContentsNumeric";
            UpdateFridgeContentsNumeric.Size = new Size(66, 23);
            UpdateFridgeContentsNumeric.TabIndex = 2;
            UpdateFridgeContentsNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(188, 52);
            textBox1.TabIndex = 1;
            textBox1.Text = "Select the contents only in Fridge Contents list, enter a number to remove that amount of units.";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(AddNewItemsSubmitButton);
            groupBox4.Controls.Add(AddNewItemsExpirationDate);
            groupBox4.Controls.Add(AddNewItemsInitialUnitsNumeric);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(AddNewItemsNameText);
            groupBox4.Location = new Point(382, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 138);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Add New Items";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 63);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 8;
            label8.Text = "Expiration Date";
            // 
            // AddNewItemsSubmitButton
            // 
            AddNewItemsSubmitButton.Cursor = Cursors.Hand;
            AddNewItemsSubmitButton.Location = new Point(119, 110);
            AddNewItemsSubmitButton.Name = "AddNewItemsSubmitButton";
            AddNewItemsSubmitButton.Size = new Size(75, 23);
            AddNewItemsSubmitButton.TabIndex = 7;
            AddNewItemsSubmitButton.Text = "Submit";
            AddNewItemsSubmitButton.UseVisualStyleBackColor = true;
            AddNewItemsSubmitButton.Click += AddNewItemsSubmitButton_Click;
            // 
            // AddNewItemsExpirationDate
            // 
            AddNewItemsExpirationDate.Location = new Point(0, 81);
            AddNewItemsExpirationDate.Name = "AddNewItemsExpirationDate";
            AddNewItemsExpirationDate.Size = new Size(200, 23);
            AddNewItemsExpirationDate.TabIndex = 5;
            // 
            // AddNewItemsInitialUnitsNumeric
            // 
            AddNewItemsInitialUnitsNumeric.Location = new Point(128, 38);
            AddNewItemsInitialUnitsNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AddNewItemsInitialUnitsNumeric.Name = "AddNewItemsInitialUnitsNumeric";
            AddNewItemsInitialUnitsNumeric.Size = new Size(66, 23);
            AddNewItemsInitialUnitsNumeric.TabIndex = 4;
            AddNewItemsInitialUnitsNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 19);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 3;
            label6.Text = "Initial Units";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 2;
            label5.Text = "Item Name";
            // 
            // AddNewItemsNameText
            // 
            AddNewItemsNameText.Location = new Point(6, 37);
            AddNewItemsNameText.MaxLength = 15;
            AddNewItemsNameText.Name = "AddNewItemsNameText";
            AddNewItemsNameText.PlaceholderText = "Enter Here";
            AddNewItemsNameText.Size = new Size(97, 23);
            AddNewItemsNameText.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.ActiveCaption;
            groupBox6.Controls.Add(textBox4);
            groupBox6.Controls.Add(DeleteSubmitButton);
            groupBox6.Location = new Point(382, 405);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(200, 112);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            groupBox6.Text = "Delete";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 22);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(188, 53);
            textBox4.TabIndex = 4;
            textBox4.Text = "Select contents on the either list, then submit to remove entirely from database.";
            // 
            // DeleteSubmitButton
            // 
            DeleteSubmitButton.Cursor = Cursors.Hand;
            DeleteSubmitButton.Location = new Point(119, 81);
            DeleteSubmitButton.Name = "DeleteSubmitButton";
            DeleteSubmitButton.Size = new Size(75, 23);
            DeleteSubmitButton.TabIndex = 8;
            DeleteSubmitButton.Text = "Submit";
            DeleteSubmitButton.UseVisualStyleBackColor = true;
            DeleteSubmitButton.Click += DeleteSubmitButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Info;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(GroceryListBox);
            groupBox3.Location = new Point(588, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(263, 505);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Grocery List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 29);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 9;
            label1.Text = "Amount Needed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 29);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 2;
            label4.Text = "Items";
            // 
            // GroceryListBox
            // 
            GroceryListBox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GroceryListBox.FormattingEnabled = true;
            GroceryListBox.Location = new Point(6, 47);
            GroceryListBox.Name = "GroceryListBox";
            GroceryListBox.Size = new Size(252, 420);
            GroceryListBox.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ActiveCaption;
            groupBox5.Controls.Add(GroceryListAlarmCreatorSubmitButton);
            groupBox5.Controls.Add(GroceryListAlarmCreatorNumeric);
            groupBox5.Controls.Add(textBox2);
            groupBox5.Location = new Point(382, 156);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 126);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Grocery List Alarm Creator";
            // 
            // GroceryListAlarmCreatorSubmitButton
            // 
            GroceryListAlarmCreatorSubmitButton.Cursor = Cursors.Hand;
            GroceryListAlarmCreatorSubmitButton.Location = new Point(119, 97);
            GroceryListAlarmCreatorSubmitButton.Name = "GroceryListAlarmCreatorSubmitButton";
            GroceryListAlarmCreatorSubmitButton.Size = new Size(75, 23);
            GroceryListAlarmCreatorSubmitButton.TabIndex = 3;
            GroceryListAlarmCreatorSubmitButton.Text = "Submit";
            GroceryListAlarmCreatorSubmitButton.UseVisualStyleBackColor = true;
            GroceryListAlarmCreatorSubmitButton.Click += GroceryListAlarmCreatorSubmitButton_Click;
            // 
            // GroceryListAlarmCreatorNumeric
            // 
            GroceryListAlarmCreatorNumeric.Location = new Point(6, 97);
            GroceryListAlarmCreatorNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            GroceryListAlarmCreatorNumeric.Name = "GroceryListAlarmCreatorNumeric";
            GroceryListAlarmCreatorNumeric.Size = new Size(66, 23);
            GroceryListAlarmCreatorNumeric.TabIndex = 2;
            GroceryListAlarmCreatorNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 22);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(188, 69);
            textBox2.TabIndex = 1;
            textBox2.Text = "Select the contents only in Fridge Contents list, enter the minimum value of the item to have before putting it on Grocery List.\r\n.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 525);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Fridge Inventory Application";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UpdateFridgeContentsNumeric).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddNewItemsInitialUnitsNumeric).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GroceryListAlarmCreatorNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox FridgeContentsListBox;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private NumericUpDown UpdateFridgeContentsNumeric;
        private Button UpdateFridgeContentsSubmitButton;
        private GroupBox groupBox4;
        private TextBox AddNewItemsNameText;
        private Label label5;
        private NumericUpDown AddNewItemsInitialUnitsNumeric;
        private Label label6;
        private Button AddNewItemsSubmitButton;
        private DateTimePicker AddNewItemsExpirationDate;
        private Label label8;
        private Label label7;
        private GroupBox groupBox6;
        private TextBox textBox4;
        private Button DeleteSubmitButton;
        private GroupBox groupBox3;
        private Label label1;
        private Label label4;
        private CheckedListBox GroceryListBox;
        private GroupBox groupBox5;
        private Button GroceryListAlarmCreatorSubmitButton;
        private NumericUpDown GroceryListAlarmCreatorNumeric;
        private TextBox textBox2;
    }
}