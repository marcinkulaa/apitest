using System;
using System.Collections.Generic;
using System.Text;


namespace testApi.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public Geo Geo { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Address address))
            {
                return false;
            }

            return Street == address.Street && Suite == address.Suite && City == address.City && Zipcode == address.Zipcode && Geo.Equals(address.Geo);
        }
    }
}
