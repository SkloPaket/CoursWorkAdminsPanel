namespace CoursWork
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            dataGridView1 = new DataGridView();
            minimizeButton = new Label();
            panel2 = new Panel();
            backButton = new PictureBox();
            closeButton = new Label();
            panel1 = new Panel();
            isLiquid = new Label();
            isLiquidComboBox = new ComboBox();
            label1 = new Label();
            isHealthBox = new ComboBox();
            nameCalories = new Label();
            nameProduct = new Label();
            caloriesBox = new TextBox();
            nameProductBox = new TextBox();
            addProductsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(236, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(507, 394);
            dataGridView1.TabIndex = 8;
            // 
            // minimizeButton
            // 
            minimizeButton.AutoSize = true;
            minimizeButton.Cursor = Cursors.Hand;
            minimizeButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            minimizeButton.Location = new Point(750, 3);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(19, 23);
            minimizeButton.TabIndex = 16;
            minimizeButton.Text = "-\r\n";
            minimizeButton.Click += minimizeButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(backButton);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(minimizeButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 30);
            panel2.TabIndex = 16;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // backButton
            // 
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.Location = new Point(-1, -1);
            backButton.Name = "backButton";
            backButton.Size = new Size(39, 29);
            backButton.SizeMode = PictureBoxSizeMode.Zoom;
            backButton.TabIndex = 18;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeButton.ForeColor = Color.Black;
            closeButton.Location = new Point(775, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(21, 23);
            closeButton.TabIndex = 1;
            closeButton.Text = "x";
            closeButton.TextAlign = ContentAlignment.MiddleCenter;
            closeButton.Click += closeButton_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(isLiquid);
            panel1.Controls.Add(isLiquidComboBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(isHealthBox);
            panel1.Controls.Add(nameCalories);
            panel1.Controls.Add(nameProduct);
            panel1.Controls.Add(caloriesBox);
            panel1.Controls.Add(nameProductBox);
            panel1.Controls.Add(addProductsButton);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 17;
            // 
            // isLiquid
            // 
            isLiquid.AutoSize = true;
            isLiquid.Location = new Point(27, 229);
            isLiquid.Name = "isLiquid";
            isLiquid.Size = new Size(48, 15);
            isLiquid.TabIndex = 17;
            isLiquid.Text = "Рідина?";
            // 
            // isLiquidComboBox
            // 
            isLiquidComboBox.ForeColor = SystemColors.WindowText;
            isLiquidComboBox.FormattingEnabled = true;
            isLiquidComboBox.Items.AddRange(new object[] { "Так", "Ні" });
            isLiquidComboBox.Location = new Point(27, 247);
            isLiquidComboBox.Name = "isLiquidComboBox";
            isLiquidComboBox.Size = new Size(185, 23);
            isLiquidComboBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 169);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 15;
            label1.Text = "Користний продукт?";
            // 
            // isHealthBox
            // 
            isHealthBox.ForeColor = SystemColors.WindowText;
            isHealthBox.FormattingEnabled = true;
            isHealthBox.Items.AddRange(new object[] { "Так", "Ні" });
            isHealthBox.Location = new Point(27, 187);
            isHealthBox.Name = "isHealthBox";
            isHealthBox.Size = new Size(185, 23);
            isHealthBox.TabIndex = 14;
            // 
            // nameCalories
            // 
            nameCalories.AutoSize = true;
            nameCalories.Location = new Point(27, 111);
            nameCalories.Name = "nameCalories";
            nameCalories.Size = new Size(144, 15);
            nameCalories.TabIndex = 13;
            nameCalories.Text = "Кількість калорій на 100г";
            // 
            // nameProduct
            // 
            nameProduct.AutoSize = true;
            nameProduct.Location = new Point(27, 57);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(92, 15);
            nameProduct.TabIndex = 12;
            nameProduct.Text = "Назва продукта";
            // 
            // caloriesBox
            // 
            caloriesBox.Location = new Point(27, 129);
            caloriesBox.Name = "caloriesBox";
            caloriesBox.Size = new Size(185, 23);
            caloriesBox.TabIndex = 11;
            // 
            // nameProductBox
            // 
            nameProductBox.Location = new Point(27, 75);
            nameProductBox.Name = "nameProductBox";
            nameProductBox.Size = new Size(185, 23);
            nameProductBox.TabIndex = 10;
            // 
            // addProductsButton
            // 
            addProductsButton.Location = new Point(43, 298);
            addProductsButton.Name = "addProductsButton";
            addProductsButton.Size = new Size(145, 52);
            addProductsButton.TabIndex = 9;
            addProductsButton.Text = "Додати продукт";
            addProductsButton.UseVisualStyleBackColor = true;
            addProductsButton.Click += addProductsButton_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private DataGridView dataGridView1;
        private Button button2;
        private Label minimizeButton;
        private Panel panel2;
        private Label closeButton;
        private Panel panel1;
        private PictureBox backButton;
        private Button addProductsButton;
        private Label nameCalories;
        private Label nameProduct;
        private TextBox caloriesBox;
        private TextBox nameProductBox;
        private Label isLiquid;
        private ComboBox isLiquidComboBox;
        private Label label1;
        private ComboBox isHealthBox;
    }
}