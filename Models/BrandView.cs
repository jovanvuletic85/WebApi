using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiVehicle.Models
{
    public class BrandView
    {
        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public string CountryOfOrigin { get; set; }
    }
}