namespace CoursWork
{
    partial class deleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteUser));
            deleteUserButton = new Button();
            dataGridView1 = new DataGridView();
            minimizeButton = new Label();
            panel2 = new Panel();
            backButton = new PictureBox();
            closeButton = new Label();
            panel1 = new Panel();
            email = new Label();
            emailBox = new TextBox();
            login = new Label();
            nameProductBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location = new Point(43, 181);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(143, 68);
            deleteUserButton.TabIndex = 7;
            deleteUserButton.Text = "Видалити користувача";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_Click;
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
            panel1.Controls.Add(email);
            panel1.Controls.Add(emailBox);
            panel1.Controls.Add(login);
            panel1.Controls.Add(nameProductBox);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(deleteUserButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 17;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(23, 112);
            email.Name = "email";
            email.Size = new Size(45, 15);
            email.TabIndex = 19;
            email.Text = "Пошта";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(23, 130);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(185, 23);
            emailBox.TabIndex = 18;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Location = new Point(23, 54);
            login.Name = "login";
            login.Size = new Size(37, 15);
            login.TabIndex = 16;
            login.Text = "Логін";
            // 
            // nameProductBox
            // 
            nameProductBox.Location = new Point(23, 72);
            nameProductBox.Name = "nameProductBox";
            nameProductBox.Size = new Size(185, 23);
            nameProductBox.TabIndex = 14;
            // 
            // deleteUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "deleteUser";
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
        private Button deleteUserButton;
        private DataGridView dataGridView1;
        private Button button2;
        private Label minimizeButton;
        private Panel panel2;
        private Label closeButton;
        private Panel panel1;
        private PictureBox backButton;
        private Label email;
        private TextBox emailBox;
        private Label login;
        private TextBox nameProductBox;
    }
}