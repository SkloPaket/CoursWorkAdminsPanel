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
    public partial class deleteUser : Form
    {
        Point lastPoint;
        private MainForm backForm;
        public void LoadUsers(DataGridView dataGridView)
        {
            RequestModel request =
                new RequestModel
                {
                    Action = "get_users"
                };

            string json =
                JsonSerializer.Serialize(request);

            string responseJson =
                TcpClientService.SendMessage(json);

            List<UserInfoModel> users =
                JsonSerializer.Deserialize<List<UserInfoModel>>
                (responseJson);

            dataGridView.DataSource = users;

            dataGridView.Columns[0].HeaderText = "ID";

            dataGridView.Columns[1].HeaderText = "Логін";

            dataGridView.Columns[2].HeaderText = "Email";

            dataGridView.Columns[3].HeaderText = "Адмін";

            dataGridView.Columns[4].HeaderText = "Бан";
        }
        public deleteUser(MainForm BackForm)
        {
            InitializeComponent();

            backForm = BackForm;
            LoadUsers(dataGridView1);
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            backForm.Show();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            string userName = nameProductBox.Text;
            string userEmail = emailBox.Text;


            UserBanDeleteInfo request = new UserBanDeleteInfo
            {
                Action = "delete_user",
                UserName = userName,
                UserEmail = userEmail

            };

            string json =
    JsonSerializer.Serialize(request);

            string response =
                TcpClientService.SendMessage(json);

            LoadUsers(dataGridView1);
            MessageBox.Show(response);
        }
    }
}
