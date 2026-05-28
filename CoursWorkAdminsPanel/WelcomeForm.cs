using System.Windows.Forms;

namespace CoursWork
{
    public partial class Form1 : Form
    {
        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void authorization_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm Form = new AuthorizationForm(this);
            Form.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
