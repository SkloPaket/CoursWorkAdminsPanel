namespace CoursWork
{
    partial class DeleteProductAndDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteProductAndDish));
            dataGridViewProduct = new DataGridView();
            minimizeButton = new Label();
            panel2 = new Panel();
            backButton = new PictureBox();
            closeButton = new Label();
            panel1 = new Panel();
            Dish = new Label();
            Product = new Label();
            dataGridViewDish = new DataGridView();
            deleteDishButton = new Button();
            nameNumProduct = new Label();
            numDish = new Label();
            productBox = new TextBox();
            numDishBox = new TextBox();
            deleteProductsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDish).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(236, 75);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.Size = new Size(233, 363);
            dataGridViewProduct.TabIndex = 8;
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
            panel1.Controls.Add(Dish);
            panel1.Controls.Add(Product);
            panel1.Controls.Add(dataGridViewDish);
            panel1.Controls.Add(deleteDishButton);
            panel1.Controls.Add(nameNumProduct);
            panel1.Controls.Add(numDish);
            panel1.Controls.Add(productBox);
            panel1.Controls.Add(numDishBox);
            panel1.Controls.Add(deleteProductsButton);
            panel1.Controls.Add(dataGridViewProduct);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 17;
            // 
            // Dish
            // 
            Dish.AutoSize = true;
            Dish.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Dish.Location = new Point(537, 53);
            Dish.Name = "Dish";
            Dish.Size = new Size(66, 21);
            Dish.TabIndex = 17;
            Dish.Text = "Страва";
            // 
            // Product
            // 
            Product.AutoSize = true;
            Product.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Product.Location = new Point(236, 53);
            Product.Name = "Product";
            Product.Size = new Size(78, 21);
            Product.TabIndex = 16;
            Product.Text = "Продукт";
            // 
            // dataGridViewDish
            // 
            dataGridViewDish.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDish.Location = new Point(537, 75);
            dataGridViewDish.Name = "dataGridViewDish";
            dataGridViewDish.Size = new Size(233, 363);
            dataGridViewDish.TabIndex = 15;
            // 
            // deleteDishButton
            // 
            deleteDishButton.Location = new Point(49, 104);
            deleteDishButton.Name = "deleteDishButton";
            deleteDishButton.Size = new Size(145, 52);
            deleteDishButton.TabIndex = 14;
            deleteDishButton.Text = "Видалити блюдо";
            deleteDishButton.UseVisualStyleBackColor = true;
            deleteDishButton.Click += deleteDishButton_Click;
            // 
            // nameNumProduct
            // 
            nameNumProduct.AutoSize = true;
            nameNumProduct.Location = new Point(27, 339);
            nameNumProduct.Name = "nameNumProduct";
            nameNumProduct.Size = new Size(98, 15);
            nameNumProduct.TabIndex = 13;
            nameNumProduct.Text = "Номер продукту";
            // 
            // numDish
            // 
            numDish.AutoSize = true;
            numDish.Location = new Point(27, 57);
            numDish.Name = "numDish";
            numDish.Size = new Size(85, 15);
            numDish.TabIndex = 12;
            numDish.Text = "Номер страви";
            // 
            // productBox
            // 
            productBox.Location = new Point(27, 357);
            productBox.Name = "productBox";
            productBox.Size = new Size(185, 23);
            productBox.TabIndex = 11;
            // 
            // numDishBox
            // 
            numDishBox.Location = new Point(27, 75);
            numDishBox.Name = "numDishBox";
            numDishBox.Size = new Size(185, 23);
            numDishBox.TabIndex = 10;
            // 
            // deleteProductsButton
            // 
            deleteProductsButton.Location = new Point(49, 386);
            deleteProductsButton.Name = "deleteProductsButton";
            deleteProductsButton.Size = new Size(145, 52);
            deleteProductsButton.TabIndex = 9;
            deleteProductsButton.Text = "Видалити продукт";
            deleteProductsButton.UseVisualStyleBackColor = true;
            deleteProductsButton.Click += deleteProductsButton_Click;
            // 
            // DeleteProductAndDish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteProductAndDish";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDish).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private DataGridView dataGridViewProduct;
        private Button button2;
        private Label minimizeButton;
        private Panel panel2;
        private Label closeButton;
        private Panel panel1;
        private PictureBox backButton;
        private Button deleteProductsButton;
        private Label nameNumProduct;
        private Label numDish;
        private TextBox productBox;
        private TextBox numDishBox;
        private Button deleteDishButton;
        private Label Dish;
        private Label Product;
        private DataGridView dataGridViewDish;
    }
}