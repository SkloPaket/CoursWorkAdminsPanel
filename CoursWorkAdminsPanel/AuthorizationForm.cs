using CoursWorkAdminsPanel;
using CoursWorkAdminsPanel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CoursWork.TcpClientService;

namespace CoursWork
{
    public partial class AuthorizationForm : Form
    {
        Point lastPoint;
        Form1 backForm;
        public AuthorizationForm(Form1 BackForm)
        {
            InitializeComponent();

            passwordField.AutoSize = false;
            this.passwordField.Size = new Size(this.passwordField.Size.Width, this.loginField.Size.Height);
            backForm = BackForm;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            string login = loginField.Text.Trim();
            string password = passwordField.Text.Trim();
            nameErrorLabel.Visible = false;
            passwordErrorLabel.Visible = false;

            if (login.Length < 4)
            {
                nameErrorLabel.Text = "Логін повинен містити мінімум 4 символи!";
                nameErrorLabel.Visible = true;
                return;
            }
            if (password.Length < 4)
            {
                passwordErrorLabel.Text = "Пароль повинен містити мінімум 4 символи!";
                passwordErrorLabel.Visible = true;
                return;
            }

            RequestModel request = new RequestModel
            {
                Action = "authorizationAdministrator",
                Login = loginField.Text,
                Password = passwordField.Text
            };

            string json = JsonSerializer.Serialize(request);

            string responseJson = TcpClientService.SendMessage(json);

            ResponseModel response =
                JsonSerializer.Deserialize<ResponseModel>(responseJson);

            if (response.Status == "success")
            {
                MessageBox.Show("Login success");

                CurrentUser.UserID = response.UserID;

                this.Hide();
                MainForm Form = new MainForm(this);
                Form.Show();
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            backForm.Show();
        }
    }
}
