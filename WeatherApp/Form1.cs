using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WeatherApp
{
  public partial class Form1 : MaterialForm
  {
        public Form1(string city)
    {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&cnt=15&units=metric&appid=6fa095c114c44b8983cf448560847507", city);
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            var oW = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(response);
            panel1.BackgroundImage = oW.list[0].weather[0].Icon;
            groupBox1.Text = $"{UnixTimeToDateTime(oW.list[0].dt).ToString().Substring(0, 10)}";
            label1.Text = $"Средняя температура \n{oW.list[0].temp.eve.ToString("0")} °C";
            label2.Text = $"Давление \n{(oW.list[0].pressure / 1.3332239).ToString("0")} мм.рт.ст";
            label3.Text = $"Ветер {oW.list[0].speed.ToString("0")} м/c";
            label4.Text = $"Влажность {oW.list[0].humidity.ToString()}%";

            panel2.BackgroundImage = oW.list[1].weather[0].Icon;
            groupBox2.Text = $"{UnixTimeToDateTime(oW.list[1].dt).ToString().Substring(0, 10)}";
            label8.Text = $"Средняя температура \n{oW.list[1].temp.eve.ToString("0")} °C";
            label7.Text = $"Давление \n{(oW.list[1].pressure / 1.3332239).ToString("0")} мм.рт.ст";
            label6.Text = $"Ветер {oW.list[1].speed.ToString("0")} м/c";
            label5.Text = $"Влажность {oW.list[1].humidity.ToString()}%";

            panel3.BackgroundImage = oW.list[2].weather[0].Icon;
            groupBox3.Text = $"{UnixTimeToDateTime(oW.list[2].dt).ToString().Substring(0, 10)}";
            label12.Text = $"Средняя температура \n{oW.list[2].temp.eve.ToString("0")} °C";
            label11.Text = $"Давление \n{(oW.list[2].pressure / 1.3332239).ToString("0")} мм.рт.ст";
            label10.Text = $"Ветер {oW.list[2].speed.ToString("0")} м/c";
            label9.Text = $"Влажность {oW.list[2].humidity.ToString()}%";

            panel4.BackgroundImage = oW.list[3].weather[0].Icon;
            groupBox4.Text = $"{UnixTimeToDateTime(oW.list[3].dt).ToString().Substring(0, 10)}";
            label16.Text = $"Средняя температура \n{oW.list[3].temp.eve.ToString("0")} °C";
            label15.Text = $"Давление \n{(oW.list[3].pressure / 1.3332239).ToString("0")} мм.рт.ст";
            label14.Text = $"Ветер {oW.list[3].speed.ToString("0")} м/c";
            label13.Text = $"Влажность {oW.list[3].humidity.ToString()}%";

            panel5.BackgroundImage = oW.list[4].weather[0].Icon;
            groupBox5.Text = $"{UnixTimeToDateTime(oW.list[4].dt).ToString().Substring(0, 10)}";
            label20.Text = $"Средняя температура \n{oW.list[4].temp.eve.ToString("0")} °C";
            label19.Text = $"Давление \n{(oW.list[4].pressure / 1.3332239).ToString("0")} мм.рт.ст";
            label18.Text = $"Ветер {oW.list[4].speed.ToString("0")} м/c";
            label17.Text = $"Влажность {oW.list[4].humidity.ToString()}%";

            panel6.BackgroundImage = oW.list[5].weather[0].Icon;
            groupBox6.Text = $"{UnixTimeToDateTime(oW.list[5].dt).ToString().Substring(0, 10)}";
            label24.Text = $"Средняя температура \n{oW.list[5].temp.eve.ToString("0")} °C";
            label23.Text = $"Давление \n{(oW.list[5].pressure / 1.3332239).ToString("0")} мм.рт.ст";
            label22.Text = $"Ветер {oW.list[5].speed.ToString("0")} м/c";
            label21.Text = $"Влажность {oW.list[5].humidity.ToString()}%";

            double temperature = (oW.list[0].temp.eve + oW.list[1].temp.eve + oW.list[2].temp.eve + oW.list[3].temp.eve + oW.list[4].temp.eve + oW.list[5].temp.eve) / 6;
            label25.Text = $"Средняя температура за все дни: {temperature.ToString("0")} °C";
            materialLabel1.Text = $"Город: {oW.city.name}";
            groupBox1.ForeColor = Color.FromArgb(67, 160, 71);
            groupBox2.ForeColor = Color.FromArgb(67, 160, 71);
            groupBox3.ForeColor = Color.FromArgb(67, 160, 71);
            groupBox4.ForeColor = Color.FromArgb(67, 160, 71);
            groupBox5.ForeColor = Color.FromArgb(67, 160, 71);
            groupBox6.ForeColor = Color.FromArgb(67, 160, 71);
        }

    private DateTime UnixTimeToDateTime(double UnixTime)
    {
      DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0);
      return origin.AddSeconds(UnixTime);
    }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnterForm form = new EnterForm();
            form.Show();
        }
    }
}
