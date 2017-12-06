using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace Portfolio.Models
{
    public class Weather
    {
        public Object getWeatherForecast()
        {
            string url =
                "http://api.wunderground.com/api/cf31b2cf1c3e985d/conditions/q/CA/Long_Beach.json";
                //synchronous client
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}