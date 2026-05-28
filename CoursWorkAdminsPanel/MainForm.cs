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
    public partial class MainForm : Form
    {
        Point lastPoint;
        private AuthorizationForm backForm;

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


        public MainForm(AuthorizationForm BackForm)
        {
            InitializeComponent();

            backForm = BackForm;
            LoadUsers(dataGridView1);
        }

        private void addFoodButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDish form = new AddDish(this);
            form.Show();
        }

        private void addProductsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct form = new AddProduct(this);
            form.Show();
        }
        private void deleteUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteUser form = new deleteUser(this);
            form.Show();
        }
        private void banUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanUser form = new BanUser(this);
            form.Show();
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

        private void deleteProductDishButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteProductAndDish form = new DeleteProductAndDish(this);
            form.Show();
        }
    }
}
