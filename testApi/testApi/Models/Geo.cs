using System;
using System.Collections.Generic;
using System.Text;

namespace testApi.Models
{

    public class Geo
    {
        public string Lat { get; set; }
        public string Lng { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Geo geo))
            {
                return false;
            }

            return Lat == geo.Lat && Lng == geo.Lng;
        }
    }
}
