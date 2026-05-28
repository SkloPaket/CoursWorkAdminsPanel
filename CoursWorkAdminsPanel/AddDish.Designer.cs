namespace CoursWork
{
    partial class AddDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDish));
            addFoodButton = new Button();
            dataGridView1 = new DataGridView();
            minimizeButton = new Label();
            panel2 = new Panel();
            backButton = new PictureBox();
            closeButton = new Label();
            panel1 = new Panel();
            flowPanel = new FlowLayoutPanel();
            label1 = new Label();
            numProduct = new TextBox();
            btnGenerate = new Button();
            nameDish = new Label();
            nameDishBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addFoodButton
            // 
            addFoodButton.Location = new Point(110, 386);
            addFoodButton.Name = "addFoodButton";
            addFoodButton.Size = new Size(145, 52);
            addFoodButton.TabIndex = 0;
            addFoodButton.Text = "Додати їжу";
            addFoodButton.UseVisualStyleBackColor = true;
            addFoodButton.Click += addFoodButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(368, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(420, 394);
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
            panel1.Controls.Add(flowPanel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numProduct);
            panel1.Controls.Add(btnGenerate);
            panel1.Controls.Add(nameDish);
            panel1.Controls.Add(nameDishBox);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(addFoodButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 17;
            // 
            // flowPanel
            // 
            flowPanel.Location = new Point(12, 214);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(350, 166);
            flowPanel.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 98);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 15;
            label1.Text = "Кількість продуктів";
            // 
            // numProduct
            // 
            numProduct.Location = new Point(94, 116);
            numProduct.Name = "numProduct";
            numProduct.Size = new Size(185, 23);
            numProduct.TabIndex = 14;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(110, 156);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(145, 52);
            btnGenerate.TabIndex = 13;
            btnGenerate.Text = "Додати продукти";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // nameDish
            // 
            nameDish.AutoSize = true;
            nameDish.Location = new Point(94, 44);
            nameDish.Name = "nameDish";
            nameDish.Size = new Size(79, 15);
            nameDish.TabIndex = 12;
            nameDish.Text = "Назва страви";
            // 
            // nameDishBox
            // 
            nameDishBox.Location = new Point(94, 62);
            nameDishBox.Name = "nameDishBox";
            nameDishBox.Size = new Size(185, 23);
            nameDishBox.TabIndex = 11;
            // 
            // AddDish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddDish";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDish";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button addFoodButton;
        private Button button5;
        private DataGridView dataGridView1;
        private Button button2;
        private Label minimizeButton;
        private Panel panel2;
        private Label closeButton;
        private Panel panel1;
        private PictureBox backButton;
        private TextBox nameDishBox;
        private Label nameDish;
        private Label label1;
        private TextBox numProduct;
        private Button btnGenerate;
        private FlowLayoutPanel flowPanel;
    }
}