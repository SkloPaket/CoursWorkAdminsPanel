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
    public partial class DeleteProductAndDish : Form
    {
        Point lastPoint;
        private MainForm backForm;
        public void LoadProduct(DataGridView dataGridView)
        {
            RequestModel request =
                new RequestModel
                {
                    Action = "get_product"
                };

            string json =
                JsonSerializer.Serialize(request);

            string responseJson =
                TcpClientService.SendMessage(json);

            List<ProductInfoModel> users =
                JsonSerializer.Deserialize<List<ProductInfoModel>>
                (responseJson);

            dataGridView.DataSource = users;

            dataGridView.Columns[0].HeaderText = "ID";

            dataGridView.Columns[1].HeaderText = "Назва";
        }

        public void LoadDish(DataGridView dataGridView)
        {
            RequestModel request =
                new RequestModel
                {
                    Action = "get_dish_compositions"
                };

            string json =
                JsonSerializer.Serialize(request);

            string responseJson =
                TcpClientService.SendMessage(json);

            List<DishCompositionInfoModel> users =
    JsonSerializer.Deserialize<List<DishCompositionInfoModel>>
    (responseJson);

            dataGridView.DataSource = users;

            dataGridView.Columns[0].HeaderText = "Назва";

            dataGridView.Columns[1].HeaderText = "DishID";
        }
        public DeleteProductAndDish(MainForm BackForm)
        {
            InitializeComponent();

            backForm = BackForm;
            LoadProduct(dataGridViewProduct);
            LoadDish(dataGridViewDish);
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

        private void deleteProductsButton_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(productBox.Text, out int productId))
            {
                MessageBox.Show("Введіть правильний ID продукту");
                return;
            }

            RequestModel request =
                new RequestModel
                {
                    Action = "delete_product",
                    ProductID = productId
                };

            string json =
                JsonSerializer.Serialize(request);

            string response =
                TcpClientService.SendMessage(json);

            MessageBox.Show(response);

            LoadProduct(dataGridViewProduct);
        }

        private void deleteDishButton_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(numDishBox.Text, out int dishId))
            {
                MessageBox.Show("Введіть правильний ID продукту");
                return;
            }

            RequestModel request =
                new RequestModel
                {
                    Action = "delete_dish",
                    DishID = dishId
                };

            string json =
                JsonSerializer.Serialize(request);

            string response =
                TcpClientService.SendMessage(json);

            MessageBox.Show(response);

            LoadDish(dataGridViewDish);
        }
    }
}
