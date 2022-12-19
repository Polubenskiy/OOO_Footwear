using OOO_Footwear.Classes;
using OOO_Footwear.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOO_Footwear
{
    public partial class Authorization : Form
    {
        private bool _dragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;
        
        public Authorization() => InitializeComponent();

        private void Authorization_Load(object sender, EventArgs e)
        {
            labelNameIndustry.Focus();
            labelNameIndustry.Select();

            pictureBoxCaptcha.Image = CaptchaImage
                .GenerateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);

            textBoxLogin.Text = "o@outlook.com";
            textBoxPassword.Text = "2L6KZG";
            textBoxCaptcha.Text = CaptchaImage.Text;
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Authorization_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = Location;
        }

        private void Authorization_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                Location = Point.Add(_dragFormPoint, new Size(dif));
            }
        }

        private void Authorization_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void buttonWithoutAuthorization_Click(object sender, EventArgs e)
        {
            UserData userRole = new UserData();
            userRole.Guest();

            ProductList productList = new ProductList(userRole);

            Hide();
            productList.ShowDialog();
            Show();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            UserData userRole = new UserData(textBoxLogin.Text, textBoxPassword.Text);

            if (userRole.IsEnter()) 
            {
                if (CaptchaImage.Text == textBoxCaptcha.Text)
                {
                    ProductList productList = new ProductList(userRole);
                                 
                    Hide();
                    productList.ShowDialog();
                    Show();
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Вход");
            }

            
        }
    }
}
