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
    public partial class AddDish : Form
    {
        Point lastPoint;
        private MainForm backForm;
        private List<ComboBox> productCombos = new List<ComboBox>();
        private List<TextBox> weightBoxes = new List<TextBox>();

        public void LoadUsers(DataGridView dataGridView)
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

            dataGridView.Columns[2].HeaderText = "ProductID";

            dataGridView.Columns[3].HeaderText = "Вага у грамах";

        }

        public AddDish(MainForm BackForm)
        {
            InitializeComponent();

            backForm = BackForm;

            LoadUsers(dataGridView1);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            flowPanel.Controls.Clear();
            productCombos.Clear();
            weightBoxes.Clear();

            if (!int.TryParse(numProduct.Text, out int count) || count <= 0)
            {
                MessageBox.Show("Введіть кількість більше 0");
                return;
            }

            RequestModel request = new RequestModel
            {
                Action = "get_products"
            };

            string json = JsonSerializer.Serialize(request);

            string responseJson = TcpClientService.SendMessage(json);

            List<ProductModel> products =
                JsonSerializer.Deserialize<List<ProductModel>>(responseJson);

            if (products == null || products.Count == 0)
            {
                MessageBox.Show("Продукти не знайдені");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Panel row = new Panel();
                row.Width = 500;
                row.Height = 35;

                ComboBox cb = new ComboBox();
                cb.Width = 200;
                cb.Left = 0;

                cb.DataSource = new List<ProductModel>(products);
                cb.DisplayMember = "Name";
                cb.ValueMember = "ProductID";

                TextBox tb = new TextBox();
                tb.Width = 100;
                tb.Left = 220;

                row.Controls.Add(cb);
                row.Controls.Add(tb);

                flowPanel.Controls.Add(row);

                productCombos.Add(cb);
                weightBoxes.Add(tb);
            }
        }



        private void addFoodButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameDishBox.Text))
            {
                MessageBox.Show("Введи назву страви!");
                return;
            }

            List<DishProductRequest> products = new List<DishProductRequest>();

            for (int i = 0; i < productCombos.Count; i++)
            {
                if (productCombos[i].SelectedItem == null)
                {
                    MessageBox.Show($"Оберіть продукт у рядку {i + 1}");
                    return;
                }

                if (!int.TryParse(weightBoxes[i].Text, out int weight) || weight <= 0)
                {
                    MessageBox.Show($"Неправильна вага у рядку {i + 1}");
                    return;
                }

                if (productCombos[i].SelectedValue == null)
                {
                    MessageBox.Show($"Не вибрано продукт у рядку {i + 1}");
                    return;
                }

                ProductModel selectedProduct =
    (ProductModel)productCombos[i].SelectedItem;

                int productId = selectedProduct.ProductID;

                products.Add(new DishProductRequest
                {
                    ProductID = productId,
                    Weight = weight
                });
            }

            AddDishRequest request = new AddDishRequest
            {
                Action = "create_dish",
                Name = nameDishBox.Text,
                Products = products
            };

            string json = JsonSerializer.Serialize(request);

            string response = TcpClientService.SendMessage(json);

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
