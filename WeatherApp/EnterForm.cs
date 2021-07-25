using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class EnterForm : MaterialForm
    {
        public EnterForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1(CityLine.Text);
                this.Hide();
                form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Такого города не существует");
            }
        }

        private void Enter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
