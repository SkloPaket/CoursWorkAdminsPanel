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
    public partial class AddProduct : Form
    {
        Point lastPoint;
        private MainForm backForm;
        public void LoadUsers(DataGridView dataGridView)
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

            dataGridView.Columns[2].HeaderText = "Калорії на 100г";

            dataGridView.Columns[3].HeaderText = "Користність";

            dataGridView.Columns[4].HeaderText = "Рідина";
        }
        public AddProduct(MainForm BackForm)
        {
            InitializeComponent();

            backForm = BackForm;
            LoadUsers(dataGridView1);
        }

        private void addProductsButton_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(caloriesBox.Text, out int calories))
            {
                MessageBox.Show("Неправильна калорійнисть");
                return;
            }

            if (isHealthBox.SelectedItem == null)
            {
                MessageBox.Show("Оберіть так або ні");
                return;
            }

            if (isLiquidComboBox.SelectedItem == null)
            {
                MessageBox.Show("Оберіть так або ні");
                return;
            }



            int isHealth = Convert.ToInt32(isHealthBox.SelectedValue);
            int isLiquid = Convert.ToInt32(isLiquidComboBox.SelectedValue);

            if (isHealth == 1) { isHealth = 0; }
            else if (isHealth == 2) { isHealth = 1; }

            if (isLiquid == 1) { isLiquid = 0; }
            else if (isLiquid == 2) { isLiquid = 1; }

            AddProductRequest request = new AddProductRequest
            {
                Action = "add_product",
                NameProduct = nameProductBox.Text,
                Calories = calories,
                IsHealth = isHealth,
                IsLiquid = isLiquid
            };

            string json =
    JsonSerializer.Serialize(request);

            string response =
                TcpClientService.SendMessage(json);

            MessageBox.Show(response);
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
    }
}
