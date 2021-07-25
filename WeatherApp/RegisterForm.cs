using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace WeatherApp
{
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (registerLogin.Text == string.Empty)
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (registerPassword.Text == string.Empty)
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (emailLabel.Text == string.Empty)
            {
                MessageBox.Show("Введите почту");
                return;
            }

            if (registerName.Text == string.Empty)
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (IsUserExists())
                return;


            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `weatherUsers` (`Login`, `Password`, `Email`, `Name`) VALUES (@login, @password, @email, @name)", dataBase.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = registerLogin.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = registerPassword.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = registerName.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailLabel.Text;

            dataBase.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы зарегистрировались");
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();

            }
            else
                MessageBox.Show("Аккаунт не создан");
            dataBase.CloseConnection();

        }
        
        public Boolean IsUserExists()
        {
            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `weatherUsers` WHERE `Login` = @uL", dataBase.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = registerLogin.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть");
                return true;

            }
            else
            {
                return false;
            }
        }

        private void enterLabel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();

        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
