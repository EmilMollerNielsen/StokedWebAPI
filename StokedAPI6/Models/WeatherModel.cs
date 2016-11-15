using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StokedAPI6.Models
{
    public class WeatherModel
    {
        //ID
        public int Id { get; set; }

        //Fra JSON

        public string Type { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }



        public DateTime Date { get; set; }

        //astronomy

        public DateTime Sunrise { get; set; }

        public DateTime Sunset { get; set; }

        public DateTime Moonrise { get; set; }

        public DateTime Moonset { get; set; }





    }
}