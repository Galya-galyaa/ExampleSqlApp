using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSqlApp
{
    public partial class LoginForm : Form
    {
        private bool isPasswordVisible = false; //
        private string imagePath; 
        public LoginForm()
        {
            InitializeComponent();

            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;

            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;

            //passField.UseSystemPasswordChar = false; //
            imagePath = Path.Combine(Application.StartupPath, "images"); //
            try
            {
                pictureBoxEye.Image = Image.FromFile(Path.Combine(imagePath, "closed_eye.png"));
                pictureBoxEye.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxEye.Cursor = Cursors.Hand;
                pictureBoxEye.BackColor = Color.Transparent;
            }
            catch (Exception ex)  
            { 
                pictureBoxEye.Visible = false;
                System.Diagnostics.Debug.WriteLine("Ошибка загрузки картинки: " + ex.Message);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        Point lastPoint;
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин" || string.IsNullOrWhiteSpace(loginField.Text) || passField.Text == "Введите пароль" || string.IsNullOrWhiteSpace(passField.Text))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }

            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `admins` WHERE `login` = @uL AND `pass` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                //MessageBox.Show("Вы успешно вошли");
                this.Hide();
                ProductForm productForm = new ProductForm();
                productForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            { 
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
                this.passField.UseSystemPasswordChar = true;

                isPasswordVisible = false;
                try { pictureBoxEye.Image = Image.FromFile(Path.Combine(imagePath, "closed_eye.png")); } catch { }
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                this.passField.UseSystemPasswordChar = false;
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;

                try { pictureBoxEye.Image = Image.FromFile(Path.Combine(imagePath, "closed_eye.png")); } catch { }
                isPasswordVisible = false;
            }
        }

        private void pictureBoxEye_Click(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль" || string.IsNullOrEmpty(passField.Text))
                return;
            isPasswordVisible = !isPasswordVisible;
            if (isPasswordVisible )
            {
                passField.UseSystemPasswordChar = false;
                try
                {
                    pictureBoxEye.Image = Image.FromFile(Path.Combine(imagePath, "open_eye.png"));
                }
                catch { }
            }
            else
            {
                passField.UseSystemPasswordChar = true;
                try
                {
                    pictureBoxEye.Image = Image.FromFile(Path.Combine(imagePath, "closed_eye.png"));
                }
                catch { }
            }
        }
    }
} 
