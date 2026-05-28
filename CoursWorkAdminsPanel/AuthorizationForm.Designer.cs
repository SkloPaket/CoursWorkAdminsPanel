namespace CoursWork
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            panel1 = new Panel();
            nameErrorLabel = new Label();
            passwordErrorLabel = new Label();
            JoinButton = new Button();
            label1 = new Label();
            passwordField = new TextBox();
            loginField = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            backButton = new PictureBox();
            minimizeButton = new Label();
            closeButton = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(nameErrorLabel);
            panel1.Controls.Add(passwordErrorLabel);
            panel1.Controls.Add(JoinButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(passwordField);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.ForeColor = Color.Red;
            nameErrorLabel.Location = new Point(222, 115);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(92, 15);
            nameErrorLabel.TabIndex = 11;
            nameErrorLabel.Text = "Помилка назви";
            nameErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            passwordErrorLabel.AutoSize = true;
            passwordErrorLabel.ForeColor = Color.Red;
            passwordErrorLabel.Location = new Point(222, 201);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(105, 15);
            passwordErrorLabel.TabIndex = 10;
            passwordErrorLabel.Text = "Помилка паролю";
            passwordErrorLabel.Visible = false;
            // 
            // JoinButton
            // 
            JoinButton.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            JoinButton.FlatAppearance.BorderSize = 3;
            JoinButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 189, 130);
            JoinButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(108, 140, 213);
            JoinButton.Font = new Font("Verdana", 24F);
            JoinButton.Location = new Point(146, 304);
            JoinButton.Name = "JoinButton";
            JoinButton.Size = new Size(441, 68);
            JoinButton.TabIndex = 5;
            JoinButton.Text = "Авторизуватися";
            JoinButton.UseVisualStyleBackColor = true;
            JoinButton.Click += JoinButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 44);
            label1.Name = "label1";
            label1.Size = new Size(218, 38);
            label1.TabIndex = 0;
            label1.Text = "Авторизація";
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Verdana", 24F);
            passwordField.Location = new Point(222, 220);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(365, 46);
            passwordField.TabIndex = 4;
            passwordField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            loginField.Font = new Font("Verdana", 24F);
            loginField.Location = new Point(222, 133);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(365, 50);
            loginField.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = CoursWorkAdminsPanel.Properties.Resources.icons8_secure_50;
            pictureBox2.Location = new Point(146, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = CoursWorkAdminsPanel.Properties.Resources.icons8_пользователь_мужчина_в_кружке_50;
            pictureBox1.Location = new Point(146, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(backButton);
            panel2.Controls.Add(minimizeButton);
            panel2.Controls.Add(closeButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 30);
            panel2.TabIndex = 0;
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
            // minimizeButton
            // 
            minimizeButton.AutoSize = true;
            minimizeButton.Cursor = Cursors.Hand;
            minimizeButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            minimizeButton.Location = new Point(751, 3);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(19, 23);
            minimizeButton.TabIndex = 16;
            minimizeButton.Text = "-\r\n";
            minimizeButton.Click += minimizeButton_Click;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeButton.ForeColor = SystemColors.ActiveCaptionText;
            closeButton.Location = new Point(776, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(21, 23);
            closeButton.TabIndex = 1;
            closeButton.Text = "x";
            closeButton.TextAlign = ContentAlignment.MiddleCenter;
            closeButton.Click += closeButton_Click;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthorizationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label closeButton;
        private TextBox loginField;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button JoinButton;
        private TextBox passwordField;
        private Label minimizeButton;
        private Label nameErrorLabel;
        private Label passwordErrorLabel;
        private PictureBox backButton;
    }
}