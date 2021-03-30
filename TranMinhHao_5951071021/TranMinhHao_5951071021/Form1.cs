using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranMinhHao_5951071021
{
    public partial class Form1 : Form
    {

        const string appID = "d9aa0856f23ae499110e68c7151f2b9f";
        string cityID = "1580578";

        public Form1()
        {
            InitializeComponent();

            getWhether(cityID);

            //getForecast(cityID);
        }

        void getWhether(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?id={0}&lang=fr&appid={1}&units=metric&cnt=6", city, appID);

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WhetherInfo.root>(json);

                WhetherInfo.root output = result;

                lblCity.Text = string.Format("{0}", output.name);
                lblCountry.Text = string.Format("{0}", output.sys.country);
                lblCelsius.Text = string.Format("{0} \u00B0" + "C", output.main.temp);

            }
        }

        //void getForecast(string city)
        //{
        //    int day = 2;
        //    string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?id={0}&units=metric&cnt={1}&appid={2}", city, day, appID);
        //    using (WebClient web = new WebClient())
        //    {
        //        var json = web.DownloadString(url);
        //        var Object = JsonConvert.DeserializeObject<WhetherForecast>(json);
        //        WhetherForecast whetherForecast = Object;

        //        lblCon.Text = string.Format("{0}", whetherForecast.list[1].whetherList[0].main);
        //        lblDes1.Text = string.Format("{0}", whetherForecast.list[1].whetherList[0].description);
        //        lblDes2.Text = string.Format("{0} \u00B0" + "C", whetherForecast.list[1].temp);
        //        lblSpeed.Text = string.Format("{0}", whetherForecast.list[1].speed);
        //    }
        //}
    }
}
