
namespace CoursWork
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
            WelcomeText = new Label();
            authorization = new Button();
            closeButton = new Label();
            minimizeButton = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeText
            // 
            WelcomeText.AutoSize = true;
            WelcomeText.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WelcomeText.Location = new Point(244, 33);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(302, 55);
            WelcomeText.TabIndex = 0;
            WelcomeText.Text = "Адмін панель";
            // 
            // authorization
            // 
            authorization.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            authorization.Location = new Point(302, 210);
            authorization.Name = "authorization";
            authorization.Size = new Size(174, 56);
            authorization.TabIndex = 1;
            authorization.Text = "Авторизуватися";
            authorization.UseVisualStyleBackColor = true;
            authorization.Click += authorization_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.None;
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeButton.ForeColor = Color.Black;
            closeButton.Location = new Point(778, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(21, 23);
            closeButton.TabIndex = 14;
            closeButton.Text = "x";
            closeButton.TextAlign = ContentAlignment.MiddleCenter;
            closeButton.Click += closeButton_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.AutoSize = true;
            minimizeButton.Cursor = Cursors.Hand;
            minimizeButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            minimizeButton.Location = new Point(753, 3);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(19, 23);
            minimizeButton.TabIndex = 15;
            minimizeButton.Text = "-\r\n";
            minimizeButton.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(minimizeButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 16;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // panel2
            // 
            panel2.Controls.Add(authorization);
            panel2.Controls.Add(WelcomeText);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Label WelcomeText;
        private Button authorization;
        private Label closeButton;
        private Label minimizeButton;
        private Panel panel1;
        private Panel panel2;
    }
}
