namespace CoursWork
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            addFoodButton = new Button();
            banUser = new Button();
            deleteUser = new Button();
            dataGridView1 = new DataGridView();
            addProductsButton = new Button();
            minimizeButton = new Label();
            panel2 = new Panel();
            backButton = new PictureBox();
            closeButton = new Label();
            panel1 = new Panel();
            deleteProductDishButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addFoodButton
            // 
            addFoodButton.Location = new Point(19, 44);
            addFoodButton.Name = "addFoodButton";
            addFoodButton.Size = new Size(145, 52);
            addFoodButton.TabIndex = 0;
            addFoodButton.Text = "Додати їжу";
            addFoodButton.UseVisualStyleBackColor = true;
            addFoodButton.Click += addFoodButton_Click;
            // 
            // banUser
            // 
            banUser.Location = new Point(21, 296);
            banUser.Name = "banUser";
            banUser.Size = new Size(143, 68);
            banUser.TabIndex = 6;
            banUser.Text = "Додати до чорного списоку";
            banUser.UseVisualStyleBackColor = true;
            banUser.Click += banUser_Click;
            // 
            // deleteUser
            // 
            deleteUser.Location = new Point(21, 370);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(143, 68);
            deleteUser.TabIndex = 7;
            deleteUser.Text = "Видалити користувача";
            deleteUser.UseVisualStyleBackColor = true;
            deleteUser.Click += deleteUser_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(222, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(548, 394);
            dataGridView1.TabIndex = 8;
            // 
            // addProductsButton
            // 
            addProductsButton.Location = new Point(19, 102);
            addProductsButton.Name = "addProductsButton";
            addProductsButton.Size = new Size(145, 52);
            addProductsButton.TabIndex = 9;
            addProductsButton.Text = "Додати продукт";
            addProductsButton.UseVisualStyleBackColor = true;
            addProductsButton.Click += addProductsButton_Click;
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
            panel1.Controls.Add(deleteProductDishButton);
            panel1.Controls.Add(addProductsButton);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(deleteUser);
            panel1.Controls.Add(banUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 17;
            // 
            // deleteProductDishButton
            // 
            deleteProductDishButton.Location = new Point(21, 160);
            deleteProductDishButton.Name = "deleteProductDishButton";
            deleteProductDishButton.Size = new Size(145, 52);
            deleteProductDishButton.TabIndex = 18;
            deleteProductDishButton.Text = "Видалення продутів і їжє";
            deleteProductDishButton.UseVisualStyleBackColor = true;
            deleteProductDishButton.Click += deleteProductDishButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(addFoodButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button addFoodButton;
        private Button addProductsButton;
        private Button button5;
        private Button banUser;
        private Button deleteUser;
        private DataGridView dataGridView1;
        private Button button2;
        private Label minimizeButton;
        private Panel panel2;
        private Label closeButton;
        private Panel panel1;
        private PictureBox backButton;
        private Button deleteProductDishButton;
    }
}